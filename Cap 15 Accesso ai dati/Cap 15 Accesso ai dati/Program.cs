using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cap_15_Accesso_ai_dati
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine("  File type: {0}", driveInfo.DriveType);

                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  File system:         {0}", driveInfo.DriveFormat);
                    Console.WriteLine("  Spazio disponibile:  {0,10} KBytes", (driveInfo.AvailableFreeSpace>>10));
                    Console.WriteLine("  Spazio totale:       {0,10} KBytes", driveInfo.TotalFreeSpace>>10);
                    Console.WriteLine("  Total size of drive: {0,10} KBytes", driveInfo.TotalSize>>10);
                }
            }

            string pathDir=Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            DirectoryInfo tempDir = new DirectoryInfo("c:\\temp\\tempdir");
            if(tempDir.Exists)
                tempDir.Delete(true);

            if (Directory.Exists("c:\\temp\\tempdir"))
                Directory.Delete("c:\\temp\\tempdir", true);

            
        }
    }
}
