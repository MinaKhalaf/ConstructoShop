using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;

namespace ConstructionEquipmentsSol
{
    public class SqlConnect
    {
        private string DataSource = "constructionequipmentsqlserver.database.windows.net";
        private string UserID = "Mina";
        private string Password = "P@ssw0rd";
        private string InitialCatalog = "ConstructionEquipmentSol";

        public SqlConnection fn_SqlConnect ()
        {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = DataSource;
                builder.UserID = UserID;
                builder.Password = Password;
                builder.InitialCatalog = InitialCatalog;

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
            try
            {
                {
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return connection;
        }
    }
}