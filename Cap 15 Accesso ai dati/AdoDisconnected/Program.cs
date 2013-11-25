using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AdoDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=(LocalDb)\\v11.0;Integrated Security=true;database=AdventureWorksLT2012";

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SalesLT.Product", conn);
                adapter.Fill(ds, "Products");
            }

            DataTable dt=ds.Tables[0];
            Console.WriteLine("{0} record", dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(string.Format("Name: {0} , ProductNumber: {1}",
                                              row["Name"], row["ProductNumber"]));
            }

            //DELETE command
            try
            {
                SqlConnection cn = new SqlConnection(connString);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SalesLT.Product", cn);

                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = cn;
                cmdDelete.CommandType = CommandType.Text;
                cmdDelete.CommandText = "DELETE FROM SalesLT.Product WHERE ProductID=@ID";
                SqlParameter paramId = new SqlParameter("@ID", SqlDbType.Int, 0, "ProductID");
                cmdDelete.Parameters.Add(paramId);


                da.DeleteCommand = cmdDelete;
                da.Fill(ds);


                DataTable table = ds.Tables[0];
                int count = table.Rows.Count;
                Console.WriteLine("before delete: {0} rows", count);
                DataRow dr = table.Rows[count - 1];
                dr.Delete();
                //da.Update(table);
                ds.AcceptChanges();

                ds = new DataSet();
                da.Fill(ds);
                count = table.Rows.Count;
                Console.WriteLine("before delete: {0} rows", count);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //command builder
            SqlConnection cn2 = new SqlConnection(connString);
            cn2.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM SalesLT.Customer", cn2);
            SqlCommandBuilder builder = new SqlCommandBuilder(da2);
            da2.UpdateCommand = builder.GetUpdateCommand();
            da2.InsertCommand = builder.GetInsertCommand();
            Console.WriteLine("UpdateCommand: {0}",da2.UpdateCommand.CommandText);
            Console.WriteLine("InsertCommand: {0}", da2.InsertCommand.CommandText);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            DataTable table2 = ds2.Tables[0];
            DataRow rowNew= table2.NewRow();
            rowNew["NameStyle"] = false;
            rowNew["FirstName"] = "Antonio";
            rowNew["LastName"] = "Pelleriti";
            rowNew["PasswordHash"] = "";
            rowNew["PasswordSalt"] = "password";

            da2.Update(table2);
        }
    }
}
