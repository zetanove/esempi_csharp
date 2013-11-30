using System;
using System.Data.Entity;

namespace EFCodeFirstLibrary
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars {get;set;}
        public DbSet<Person> People { get; set; }
    }
}
