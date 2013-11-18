using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=(LocalDb)\\v11.0;Integrated Security=true;database=AdventureWorksLT2012";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            conn.Close();

            using(SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine(connection.ServerVersion);

                string sql = "SELECT * FROM SalesLT.Customer";
                SqlCommand cmd = new SqlCommand(sql, connection);
               
            }
        }
    }
}
