using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using TMP_TAExporter.Properties;

namespace TMP_TAExporter
{
    public static class IntegrityExport
    {
        private static bool _bRunning;
        public static event EventHandler OnProgressHandler;

        public static void OnProgress(int progress)
        {
            try
            {
                var handler = OnProgressHandler;
                if (handler == null) return;
                var args = new ProgressEventArgs(progress);
                handler(null, args);
            }
            catch (Exception)
            {
                //ignored
            }
        }

        public static string ExportIntegrity(DateTime from, DateTime to, bool applyTargetHoursCalc,
            bool filterEnabled = false, string costCentreFrom = "", string costCentreTo = "")
        {
            if (_bRunning)
                return @"Export already running";

            _bRunning = true;
            var iCounter = 0;

            var fileName = Settings.Default.IntegrityExportLocation;

            try
            {
                // Set the ServerType to 1 for connect to the embedded server
                var connectionString =
                    "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + Settings.Default.TmpDbLocation + ";" +
                    "DataSource=" + Settings.Default.NetworkLocation + ";" +
                    "Port=3050;" +
                    "Dialect=3;" +
                    "Charset=NONE;" +
                    "Role=;" +
                    "Connection lifetime=15;" +
                    "Pooling=true;" +
                    "Packet Size=8192;" +
                    "ServerType=0";

                var myConnection = new FbConnection(connectionString);
                myConnection.Open();

                var myTransaction = myConnection.BeginTransaction();
                var myCommand = new FbCommand
                {
                    Connection = myConnection,
                    Transaction = myTransaction,
                    CommandText = "SELECT COUNT(*) FROM CLOCKD " +
                                  "WHERE DATETIME >= @START_DATE AND DATETIME <= @END_DATE AND a.CALC0 <> null"
                };
                if (filterEnabled)
                {
                    myCommand.CommandText = "SELECT COUNT(*) FROM CLOCKD a " +
                                            "INNER JOIN EMP b ON a.EMPNO = b.EMP_NO " +
                                             "WHERE" +
                                            "   a.DATETIME >= @START_DATE AND a.DATETIME <= @END_DATE AND" +
                                            "   b.DEPARTMENT >= @CCFROM AND b.DEPARTMENT <= @CCTO AND a.CALC0 IS NOT NULL";

                    myCommand.Parameters.Add("@CCFROM", FbDbType.VarChar).Value = costCentreFrom;
                    myCommand.Parameters.Add("@CCTO", FbDbType.VarChar).Value = costCentreTo;
                }

                myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);
                

                //Get amount of records
                var iCount = (int) myCommand.ExecuteScalar();

                myCommand.CommandText = "SELECT * FROM CLOCKD " +
                                        "WHERE DATETIME >= @START_DATE AND DATETIME <= @END_DATE AND a.CALC0 IS NOT NULL " +
                                        "ORDER BY EMPNO, DATETIME";
                if (filterEnabled)
                {
                    myCommand.CommandText = "SELECT * FROM CLOCKD a " +
                                            "INNER JOIN EMP b ON a.EMPNO = b.EMP_NO " +
                                            "WHERE a.DATETIME >= @START_DATE AND a.DATETIME <= @END_DATE AND " +
                                            "b.COST_CENTRE >= @CCFROM AND b.COST_CENTRE <= @CCTO AND a.CALC0 IS NOT NULL AND a.TARGET0 IS NOT NULL " +
                                            "ORDER BY a.EMPNO, a.DATETIME";
                }
                //myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                //myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);
                var myReader = myCommand.ExecuteReader();

                var normalTime = 0.0;
                var overTime = 0.0;
                var doubleTime = 0.0;
                var calc3 = 0.0;
                var calc4 = 0.0;
                var targetHours0 = 0.0;
                var lastEmployee = "";
                var internalCounter = 0;
                var shifts = 0;

                while (myReader.Read())
                {                   
                    //increment toolbar                    
                    OnProgress((int) Math.Round((double) (100*iCounter++)/iCount));

                    //Last employee
                    var emp = myReader["EMPNO"].ToString();
                    if (emp == "11643")
                        emp = "11643";

                    if (emp != lastEmployee && lastEmployee != "" || internalCounter == iCount)
                    {
                        //If it is the last record, add the last hours
                        if (internalCounter == iCount)
                        {
                            targetHours0 += Convert.ToDouble(myReader["TARGET0"]);
                            normalTime += Convert.ToDouble(myReader["CALC0"]);
                            overTime += Convert.ToDouble(myReader["CALC1"]);
                            doubleTime += Convert.ToDouble(myReader["CALC2"]);
                            calc3 += Convert.ToDouble(myReader["CALC3"]);
                            calc4 += Convert.ToDouble(myReader["CALC4"]);
                            shifts += Convert.ToInt32(myReader["SHIFTS"]);
                        }

                        if (applyTargetHoursCalc)
                        {
                            //Calculate hours vs target hours
                            if (Math.Abs(targetHours0) > 0)
                            {
                                if (targetHours0 > normalTime)
                                {
                                    var difference = targetHours0 - normalTime;
                                    //Check if there are enough hours available in overtime
                                    if (overTime > 0)
                                    {
                                        if (overTime >= difference)
                                        {
                                            overTime -= difference;
                                            normalTime += difference;
                                        }
                                        else
                                        {
                                            overTime = 0.0;
                                            normalTime += overTime;
                                        }
                                    }
                                }
                            }
                        }

                        var line =
                            $"{lastEmployee.PadRight(7, ' ')}" +
                            $"{Math.Round(normalTime/60,2).ToString("#.00", CultureInfo.InvariantCulture).Replace(".","").PadLeft(5, '0')}" +
                            $"{Math.Round(overTime/60,2).ToString("#.00", CultureInfo.InvariantCulture).Replace(".", "").PadLeft(5, '0')}" +
                            $"{Math.Round(doubleTime/60,2).ToString("#.00", CultureInfo.InvariantCulture).Replace(".", "").PadLeft(5, '0')}" +
                            $"{Math.Round(calc3/60,2).ToString("#.00", CultureInfo.InvariantCulture).Replace(".", "").PadLeft(5, '0')}" +
                            //$"{Math.Round(calc4/60,2).ToString("#.00", CultureInfo.InvariantCulture).Replace(".", "").PadLeft(5, '0')}" +
                            $"{shifts.ToString().PadRight(3, '0')}" +
                            $"{Environment.NewLine}";

                        using (var sw = new StreamWriter(fileName, true))
                        {
                            sw.Write(line);
                        }

                        //Add hours of the current employee
                        targetHours0 = Convert.ToDouble(myReader["TARGET0"]);
                        normalTime = Convert.ToDouble(myReader["CALC0"]);
                        overTime = Convert.ToDouble(myReader["CALC1"]);
                        doubleTime = Convert.ToDouble(myReader["CALC2"]);
                        calc3 = Convert.ToDouble(myReader["CALC3"]);
                        calc4 = Convert.ToDouble(myReader["CALC4"]);
                        shifts = Convert.ToInt32(myReader["SHIFTS"]);
                    }
                    else
                    {
                        targetHours0 += Convert.ToDouble(myReader["TARGET0"]);
                        normalTime += Convert.ToDouble(myReader["CALC0"]);
                        overTime += Convert.ToDouble(myReader["CALC1"]);
                        doubleTime += Convert.ToDouble(myReader["CALC2"]);
                        calc3 += Convert.ToDouble(myReader["CALC3"]);
                        calc4 += Convert.ToDouble(myReader["CALC4"]);
                        shifts += Convert.ToInt32(myReader["SHIFTS"]);
                    }

                    lastEmployee = emp;

                    Application.DoEvents();
                    internalCounter++;
                }

                OnProgress(100);

                myConnection.Close();
                myCommand.Dispose();
                myConnection.Close();
                _bRunning = false;

                return $"{iCount} record(s) processed";
            }
            catch (Exception ex)
            {
                _bRunning = false;
                return ex.Message + @" Row: " + iCounter;
            }
        }

        public class ProgressEventArgs : EventArgs
        {
            public ProgressEventArgs(int progress)
            {
                Progress = progress;
            }

            public int Progress { get; set; }
        }
    }
}