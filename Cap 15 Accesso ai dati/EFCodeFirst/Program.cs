using EFCodeFirstLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection ="data source=(localdb)\v11.0;initial catalog=AdventureWorksLT2012;integrated security=True;";
            using(CarContext db=new CarContext(connection))
            {
                Person p = db.Person.Create();
                p.FirstName = "Antonio";
                p.LastName = "Pelleriti";
                db.Person.Add(p);

                Car c = db.Cars.Create();
                c.Targa = "AB123CD";
                c.Modello = "Alfa Romeo GT";
                c.Person = p;
                db.Cars.Add(c);

                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
