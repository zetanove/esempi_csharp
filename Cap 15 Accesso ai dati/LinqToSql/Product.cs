using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table(Name="SalesLT.Product")]
    class MyProduct
    {
        [Column(IsPrimaryKey=true)]
        public int ProductID { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Color { get; set; }
    }
}
