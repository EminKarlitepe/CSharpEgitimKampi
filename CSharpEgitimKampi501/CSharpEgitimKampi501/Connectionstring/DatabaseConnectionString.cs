using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Connectionstring
{
    public class DatabaseConnectionString
    {
        public static void SQLDatabaseConnectString()
        {
            SqlConnection connection = new SqlConnection("Server=KARLITEPE\\\\MSSQLSERVER79;" +
                "initial Catalog=EgitimKampi501Db;integrated security=true");
        }
    }
}
