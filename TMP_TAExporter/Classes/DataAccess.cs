using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using FirebirdSql.Data.FirebirdClient;

namespace TMP_TAExporter.Classes
{
    public class DataAccess
    {
        private string DatabaseLocation { get; set; }

        public DataAccess(string databaseLocation)
        {
            DatabaseLocation = databaseLocation;
        }


        private string GetConnectionString()
        {
            return "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + DatabaseLocation + ";" +
                    "DataSource=localhost;" +
                    "Port=3050;" +
                    "Dialect=3;" +
                    "Charset=NONE;" +
                    "Role=;" +
                    "Connection lifetime=15;" +
                    "Pooling=true;" +
                    "Packet Size=8192;" +
                    "ServerType=0";
        }

        public List<CostCentre> GetCostCentres()
        {
            var myConnection = new FbConnection(GetConnectionString());
            myConnection.Open();

            var myTransaction = myConnection.BeginTransaction();
            var myCommand = new FbCommand
            {
                Connection = myConnection,
                Transaction = myTransaction,
                CommandText = "SELECT * FROM CCENTRES ORDER BY CODE"
            };

            var myReader = myCommand.ExecuteReader();

            var costCentres = new List<CostCentre>();
            while (myReader.Read())
            {
                var cc = new CostCentre
                {
                    Code = myReader["CODE"].ToString(),
                    Description = myReader["DESCRIPTION"].ToString()
                };
                costCentres.Add(cc);
            }

            return costCentres;
        }
    }
}
