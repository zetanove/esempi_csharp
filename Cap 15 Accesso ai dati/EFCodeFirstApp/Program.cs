using EFCodeFirstLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarContext db = new CarContext())
            {
                Console.WriteLine("connected on {0}", db.Database.Connection.ConnectionString);
                Car c = new Car();
                c.Targa = "abc";
                c.Modello = "Alfa Romeo GT";

                Person p = new Person();
                p.FirstName = "Antonio";
                p.LastName = "Pelleriti";
                c.Person = p;

                db.Cars.Add(c);
                db.People.Add(p);

                db.SaveChanges();
            }
        }
    }
}
