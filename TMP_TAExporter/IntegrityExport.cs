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

        public static string ExportIntegrity(DateTime from, DateTime to, bool applyTargetHoursCalc)
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
                    "DataSource=localhost;" +
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
                                  "WHERE DATETIME >= @START_DATE AND DATETIME <= @END_DATE"
                };

                myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);

                //Get amount of records
                var iCount = (int) myCommand.ExecuteScalar();

                myCommand.CommandText = "SELECT * FROM CLOCKD " +
                                        "WHERE DATETIME >= @START_DATE AND DATETIME <= @END_DATE " +
                                        "ORDER BY EMPNO, DATETIME";

                myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);
                var myReader = myCommand.ExecuteReader();

                var normalTime = 0.0;
                var overTime = 0.0;
                var doubleTime = 0.0;
                var targetHours0 = 0.0;
                var lastEmployee = "";
                var internalCounter = 0;
                while (myReader.Read())
                {
                    //increment toolbar                    
                    OnProgress((int) Math.Round((double) (100*iCounter++)/iCount));

                    //Last employee
                    var emp = myReader["EMPNO"].ToString();
                    if (emp != lastEmployee && lastEmployee != "" || internalCounter == iCount)
                    {
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
                            $"{emp.PadRight(6, ' ')} " +
                            $"{normalTime.ToString(CultureInfo.InvariantCulture).PadLeft(3, '0')}" +
                            $"{overTime.ToString(CultureInfo.InvariantCulture).PadLeft(3, '0')}" +
                            $"{doubleTime.ToString(CultureInfo.InvariantCulture).PadLeft(3, '0')}000000" +
                            $"{Environment.NewLine}";

                        using (var sw = new StreamWriter(fileName, true))
                        {
                            sw.Write(line);
                        }

                        targetHours0 = 0;
                        normalTime = 0;
                        overTime = 0;
                        doubleTime = 0;
                    }
                    else
                    {
                        targetHours0 += Convert.ToDouble(myReader["TARGET0"]);
                        normalTime += Convert.ToDouble(myReader["CALC0"]);
                        overTime += Convert.ToDouble(myReader["CALC1"]);
                        doubleTime += Convert.ToDouble(myReader["CALC2"]);
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