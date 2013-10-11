using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            string filename=Path.Combine( Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "myfile.xml");
            doc.Load(filename);

            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>
<veicoli>
  <veicolo targa="AB123CD">
    <marca>Alfa Romeo</marca>
    <modello>GT</modello>
  </veicolo>
</veicoli>
";
            doc.LoadXml(xml);
        }
    }
}
