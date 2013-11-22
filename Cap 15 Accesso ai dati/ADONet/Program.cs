using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

                //ExecuteNonQuery
                string sqlUpdate = "UPDATE SalesLT.Customer  SET CompanyName = 'ACME', Phone = '0001234' WHERE CustomerId=1";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, connection);
                int affected=cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("{0} record aggiornati", affected);

                cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = connection;
                cmdUpdate.CommandType = System.Data.CommandType.Text;
                cmdUpdate.CommandText = "UPDATE SalesLT.Customer  SET CompanyName = @NAME WHERE CustomerId=@CustomerId";
                cmdUpdate.Parameters.AddWithValue("@CustomerId", 2);
                cmdUpdate.Parameters.AddWithValue("@NAME", "L'ape maia");
                affected= cmdUpdate.ExecuteNonQuery();

                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM SalesLT.Product WHERE Color='Black'", connection);
                int numero = (int)cmdCount.ExecuteScalar();

                string sql = "SELECT * FROM SalesLT.Customer WHERE CustomerId=123123123123123";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader= cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader["FirstName"] as string;
                        string lastname = reader["LastName"] as string;
                        Console.WriteLine("{0} {1} {2}", id, name, lastname);
                    }
                }
                reader.Close();

                SqlCommand cmdSchema = new SqlCommand("SELECT * FROM SalesLT.Product", connection);
                
                using (var readerSchema = cmdSchema.ExecuteReader(CommandBehavior.SchemaOnly))
                {
                    var tableSchema = readerSchema.GetSchemaTable();
                    foreach (DataRow row in tableSchema.Rows)
                    {
                        Console.WriteLine(row["ColumnName"] + " - " + row["DataTypeName"]);
                    }
                }

                

                SqlCommand cmdXml = new SqlCommand("SELECT TOP 5 ProductID, Name, Color FROM SalesLT.Product FOR XML AUTO, XMLDATA", connection);
                XmlReader xmlReader = cmdXml.ExecuteXmlReader();
                while(xmlReader.Read())
                    Console.WriteLine("{0}", xmlReader.ReadOuterXml());

                xmlReader.Close();
                
            }

            Console.ReadLine();
        }
    }
}
