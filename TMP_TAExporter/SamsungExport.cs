using System;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using TMP_TAExporter.Properties;

namespace TMP_TAExporter
{
    internal static class SamsungExport
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

        public static string ExportSamsung(DateTime from, DateTime to, bool checkNotExported = false)
        {
            if (_bRunning)
                return @"Export already running";

            _bRunning = true;
            var iCounter = 0;

            var fileName = $"{Settings.Default.SamsungExportLocation}/{DateTime.Now.ToString("yyyyMMdd")}.txt";

            try
            {
                //Check if exported column is created
                if (checkNotExported)
                    CheckColumnCreated();

                // Set the ServerType to 1 for connect to the embedded server
                var connectionString =
                    "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + Settings.Default.TmpDbLocation + ";" +
                    "DataSource="+Settings.Default.NetworkLocation+";" +
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
                    Transaction = myTransaction
                };

                string query;
                if (checkNotExported)
                {
                    query = "SELECT COUNT(*) FROM CLOCKING " +
                            "WHERE EXPORTED = 0";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM CLOCKING " +
                            "WHERE CLKDATE >= @START_DATE AND CLKDATE <= @END_DATE";

                    myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                    myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);
                }

                //Assign Query to command
                myCommand.CommandText = query;


                //Get amount of records
                var iCount = (int) myCommand.ExecuteScalar();

                if (checkNotExported)
                {
                    myCommand.CommandText = "SELECT * FROM CLOCKING " +
                                            "WHERE EXPORTED = 0";
                }
                else
                {
                    myCommand.CommandText = "SELECT * FROM CLOCKING " +
                                            "WHERE CLKDATE >= @START_DATE AND CLKDATE <= @END_DATE";

                    myCommand.Parameters.Add("@START_DATE", FbDbType.TimeStamp).Value = Helpers.GetLowestDt(from);
                    myCommand.Parameters.Add("@END_DATE", FbDbType.TimeStamp).Value = Helpers.GetHighestDt(to);
                }

                var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    //increment toolbar                    
                    OnProgress((int) Math.Round((double) (100*iCounter++)/iCount));

                    //standard data                    
                    var employeeNo = myReader["CODE"].ToString().PadLeft(8, ' ');

                    //Build Date
                    var tDate = ((DateTime) myReader["CLKTIME"]).ToString("yyyyMMddHHmmss");

                    //Direction
                    var direction = myReader["IO"].ToString();
                    switch (direction.TrimEnd(' '))
                    {
                        case "I":
                            direction = "In";
                            break;
                        case "O":
                            direction = "Out";
                            break;
                        default:
                            direction = "In";
                            break;
                    }

                    var line = $"{employeeNo},{tDate},{direction},{Environment.NewLine}";
                    using (var sw = new StreamWriter(fileName, true))
                    {
                        sw.Write(line);
                    }

                    Application.DoEvents();
                }
                OnProgress(100);

                myConnection.Close();
                myCommand.Dispose();
                myConnection.Close();
                _bRunning = false;

                //Update exported fields
                if (checkNotExported)
                    UpdateExported();

                return $"{iCount} record(s) processed";
            }
            catch (Exception ex)
            {
                _bRunning = false;
                return ex.Message + @" Row: " + iCounter;
            }
        }

        private static void CheckColumnCreated()
        {
            // Set the ServerType to 1 for connect to the embedded server
            var connectionString =
                "User=SYSDBA;" +
                "Password=masterkey;" +
                "Database=" + Settings.Default.TmpDbLocation + ";" +
                "DataSource="+Settings.Default.NetworkLocation+";" +
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
                CommandText = "EXECUTE BLOCK AS BEGIN " +
                              "IF(NOT EXISTS(" +
                              "     SELECT 1 FROM RDB$RELATION_FIELDS rf WHERE rf.RDB$RELATION_NAME = 'CLOCKING' and rf.RDB$FIELD_NAME = 'EXPORTED')) " +
                              "THEN " +
                              "     EXECUTE STATEMENT 'ALTER TABLE CLOCKING ADD EXPORTED char(1) DEFAULT 0 NOT NULL'; " +
                              "END "
            };

            //Execute command
            myCommand.ExecuteNonQuery();
            myTransaction.Commit();

            //Close open connections
            myConnection.Close();
            myCommand.Dispose();
            myConnection.Close();
        }

        private static void UpdateExported()
        {
            // Set the ServerType to 1 for connect to the embedded server
            var connectionString =
                "User=SYSDBA;" +
                "Password=masterkey;" +
                "Database=" + Settings.Default.TmpDbLocation + ";" +
                "DataSource=" + Settings.Default.NetworkLocation+";" +
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
                CommandText = "UPDATE CLOCKING SET EXPORTED = 1"
            };

            //Execute command
            myCommand.ExecuteNonQuery();
            myTransaction.Commit();

            //Close open connections
            myConnection.Close();
            myCommand.Dispose();
            myConnection.Close();
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