using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connString = "Server=(LocalDb)\\v11.0;Integrated Security=true;database=AdventureWorksLT2012";
            DataContext context = new DataContext(connString);

            var tableProd = context.GetTable<MyProduct>();
            var products=from prod in tableProd
                         where prod.Color=="Black"
                         select prod;

            foreach (MyProduct p in products)
            {
                Console.WriteLine(p.Name);
            }

            MyProduct product = products.First();
            product.Color = "Red";
            context.SubmitChanges();

            AdventureWorksDataContext awdc = new AdventureWorksDataContext(connString);
            var categories= awdc.ProductCategories;

            foreach(ProductCategory pc in categories)
            {
                Console.WriteLine(pc.Name);
                foreach(Product pd in pc.Products)
                    Console.WriteLine("   {0}", pd.Name);
            }

            var query = from cat in categories
                        from prod in cat.Products
                        where cat.Name.Contains("Frames")
                        select prod;

            foreach(var p in query)
            {
                Console.WriteLine("{0}", p.Name);
            }

            awdc.Products.First().Color = "Dark Red";
            awdc.SubmitChanges();

            ProductCategory newCat = new ProductCategory();
            newCat.Name = "Nuova Categoria";
            newCat.ModifiedDate = DateTime.Now;
            awdc.ProductCategories.InsertOnSubmit(newCat);
            awdc.SubmitChanges();
        }
    }
}
