using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedStorageSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "isofile.txt";
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            string[] fileNames = isoStore.GetFileNames(filename);

            Console.WriteLine("quota: {0}GB", isoStore.Quota >> 30);
            Console.WriteLine("used size: {0}MB", isoStore.UsedSize >> 20);

            foreach (string file in fileNames)
            {
                if (file == filename)
                {
                    Console.WriteLine("The file already exists!");
                }
            }

            using (IsolatedStorageFileStream oStream = new IsolatedStorageFileStream(filename, FileMode.Create, isoStore))
            {
                StreamWriter writer = new StreamWriter(oStream);
                writer.WriteLine("Prima linea nel file isolated storage.");
                writer.WriteLine("seconda linea");
                writer.Close();
            }

            using (IsolatedStorageFileStream iStream = new IsolatedStorageFileStream(filename, FileMode.Open, isoStore))
            {
                StreamReader reader = new StreamReader(iStream);
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
