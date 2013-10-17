using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XComment("contiene dati sui veicoli"),
                new XElement("veicoli",
                    new XElement("veicolo", new XAttribute("targa", "AB123CD"),
                        new XElement("marca", "Alfa Romeo"),
                        new XElement("modello", "GT")
                        )
                    )
                );

            xdoc.Save("xfile.xml");
            //Debug.WriteLine(xdoc);
            Console.WriteLine(xdoc);
        }
    }
}
