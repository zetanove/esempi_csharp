using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMonitor
{
    class Program
    {
        static string source = @"C:\temp\source";
        static string target = @"C:\temp\target";

        static void Main(string[] args)        {
            
            if(!Directory.Exists(source))
                Directory.CreateDirectory(source);

            if(!Directory.Exists(target))
                Directory.CreateDirectory(target);

            FileSystemWatcher watcher = new FileSystemWatcher(source, "*.txt");
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.Size;
            watcher.Created += watcher_Event;
            watcher.Changed += watcher_Event;
            watcher.Renamed += watcher_Event;
            watcher.Error += watcher_Error;

            //inizia il monitoraggio
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Premi \'q\' per uscire.");
            while (Console.Read() != 'q') ;

        }

        static void watcher_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("si è verificato un errore");
        }

        static void watcher_Event(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                Console.WriteLine("copia di {0}", e.Name);
                FileInfo fs = new FileInfo(e.FullPath);
                fs.CopyTo(Path.Combine(target, Path.GetFileName(e.FullPath)), true);
            }
        }
    }
}
