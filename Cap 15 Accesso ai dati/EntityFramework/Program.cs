using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorksLT2012Entities db = new AdventureWorksLT2012Entities())
            {
                var query = from prod in db.Product
                            select prod;

                foreach (Product p in query)
                {
                    Console.WriteLine("{0} {1}", p.ProductID, p.Name);
                }

                var q2 = from cat in db.ProductCategory
                         join prod in db.Product on cat.ProductCategoryID equals prod.ProductCategoryID
                         where cat.Name.ToLower().Contains("bike")
                         select prod;

                foreach(var p in q2)
                {
                    Console.WriteLine("{0} {1}", p.ProductCategory.Name, p.Name);
                }

                ProductCategory cat1 = new ProductCategory();
                cat1.Name = "nuova cat";
                cat1.ModifiedDate = DateTime.Now;
                cat1.rowguid = Guid.NewGuid();
                using (AdventureWorksLT2012Entities dba = new AdventureWorksLT2012Entities())
                {
                    dba.Database.ExecuteSqlCommand("DELETE from SalesLT.ProductCategory WHERE Name='nuova cat'");
                    dba.ProductCategory.Add(cat1);
                    dba.SaveChanges();
                }

                using(AdventureWorksLT2012Entities dbquery = new AdventureWorksLT2012Entities())
                {
                    var product1 = dbquery.Product.Find(1);

                    var products = dbquery.Product.SqlQuery("select * from SalesLT.Product").ToList();

                    var productColorsQuery = dbquery.Database.SqlQuery<string>("select distinct Color from SalesLT.product");
                    List<string> names= productColorsQuery.ToList();


                    int affected=dbquery.Database.ExecuteSqlCommand("UPDATE SalesLT.Customer SET CompanyName='ACME' WHERE CustomerID=1234");
                }

                //loading
                using (AdventureWorksLT2012Entities dbload = new AdventureWorksLT2012Entities())
                {
                    var productOrdered= dbload.Customer.Where(c => c.SalesOrderHeader.Any()).First().SalesOrderHeader.First().SalesOrderDetail.First().Product;
                }
            }
        }
    }
}
