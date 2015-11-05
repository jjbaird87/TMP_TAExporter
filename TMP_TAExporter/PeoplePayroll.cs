using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using TMP_TAExporter.Properties;

namespace TMP_TAExporter
{
    public static class PeoplePayroll
    {
        private static bool _bRunning;

        private static int _normalShift;
        private static int _twoShift;
        private static int _threeShift;
        private static int _twelveShift;
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

        public static string Export(DateTime from, DateTime to)
        {
            if (_bRunning)
                return @"Export already running";

            _bRunning = true;
            var iCounter = 0;

            var fileName = Settings.Default.PeopleExportLocation;
            var shiftsFileName = Settings.Default.PeopleShiftsExportLocation;

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

                var lastEmployee = "";
                var internalCounter = 0;
                var ds = new DataSet("NewDataSet");
                var dt = new DataTable("NewDataTable");

                //Set the locale for each -> Hours
                ds.Locale = Thread.CurrentThread.CurrentCulture;
                dt.Locale = Thread.CurrentThread.CurrentCulture;

                dt.Columns.Add("Employee Code");
                dt.Columns.Add("OT 1.5 Hours Worked", typeof (double));
                dt.Columns.Add("OT2.0 Hours Worked", typeof (double));
                dt.Columns.Add("Lost Time Hours", typeof (double));

                //Set locale for each -> Shift Template
                var shiftDs = new DataSet("ShiftDataSet");
                var shiftDt = new DataTable("ShiftDt");
                shiftDs.Locale = Thread.CurrentThread.CurrentCulture;
                shiftDs.Locale = Thread.CurrentThread.CurrentCulture;
                shiftDt.Columns.Add("Employee Code");
                shiftDt.Columns.Add("12Shift Days Worked");
                shiftDt.Columns.Add("2 Shift Days Worked");
                shiftDt.Columns.Add("3 Shift Days Worked");
                shiftDt.Columns.Add("Normal Shift Worked");

                var overTime = 0.0;
                var doubleTime = 0.0;
                var lostTime = 0.0;

                while (myReader.Read())
                {
                    //increment toolbar                    
                    OnProgress((int) Math.Round((double) (100*iCounter++)/iCount));

                    //Last employee
                    var emp = myReader["EMPNO"].ToString().PadLeft(8, '0');
                    var shiftCode = myReader["WORKPAT"].ToString();
                    
                    if (emp != lastEmployee && lastEmployee != "" || internalCounter == iCount)
                    {
                        //If it is the last record, add the last hours
                        if (internalCounter == iCount)
                        {
                            lostTime += Convert.ToDouble(myReader["LOST"]);
                            overTime += Convert.ToDouble(myReader["CALC1"]);
                            doubleTime += Convert.ToDouble(myReader["CALC2"]);
                            AddShift(shiftCode);
                        }
                        //Check if all values are zero - if yes do not show on report
                        if ((lostTime + overTime + doubleTime) > 0)
                        {
                            //Convert values to decimal values
                            overTime = overTime/60.0;
                            doubleTime = doubleTime / 60.0;
                            lostTime = lostTime / 60.0;
                            dt.Rows.Add(lastEmployee, overTime, doubleTime, lostTime);
                        }
                        shiftDt.Rows.Add(lastEmployee, _twelveShift, _twoShift, _threeShift, _normalShift);

                        overTime = 0;
                        doubleTime = 0;
                        lostTime = 0;

                        _normalShift = 0;
                        _twoShift = 0;
                        _threeShift = 0;
                        _twelveShift = 0;
                    }
                    else
                    {
                        lostTime += Convert.ToDouble(myReader["LOST"]);
                        overTime += Convert.ToDouble(myReader["CALC1"]);
                        doubleTime += Convert.ToDouble(myReader["CALC2"]);
                        AddShift(shiftCode);
                    }
                    lastEmployee = emp;

                    Application.DoEvents();
                    internalCounter++;
                }
                ds.Tables.Add(dt);
                shiftDs.Tables.Add(shiftDt);
                CreateExcelFile.CreateExcelDocument(ds, fileName);
                CreateExcelFile.CreateExcelDocument(shiftDs, shiftsFileName);

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

        private static void AddShift(string code)
        {
            switch (code)
            {
                case "01":
                    _normalShift++;
                    break;
                case "02":
                    _twoShift++;
                    break;
                case "03":
                    _threeShift++;
                    break;
                case "04":
                    _twelveShift++;
                    break;
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