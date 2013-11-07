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


            //Path

            string dirname = @"C:\temp";
            string filename = "file.txt";
            string fullpath = Path.Combine(dirname, filename);
            Console.WriteLine(fullpath);

            string xml=Path.ChangeExtension(filename, "xml");// file.xml
            string dir=Path.GetDirectoryName(fullpath); // c:\temp
            string ext = Path.GetExtension(fullpath); // .txt
            string file=Path.GetFileName(fullpath); // file.txt
            string filewithoutext= Path.GetFileNameWithoutExtension(fullpath); // file

            Directory.SetCurrentDirectory("c:\\windows"); //imposta la directory di lavoro corrente
            string full=Path.GetFullPath(filename); // c:\windows\file.txt

            string root=Path.GetPathRoot(fullpath); // C:
            string randomFile = Path.GetRandomFileName(); // v3ybhjqf.0xd
            string tempFile = Path.GetTempFileName(); // C:\Users\UserName\AppData\Local\Temp\tmp210E.tmp
            string tempPath = Path.GetTempPath(); // C:\Users\UserName\AppData\Local\Temp
            bool hasExt= Path.HasExtension("file.txt"); // true
            bool pathRooted = Path.IsPathRooted("c:\\file.txt"); //true


            string system=Environment.SystemDirectory;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //informazioni su file e directory
            string file1="C:\\temp\\file1.txt";
            var ftext= File.CreateText(file1);
            ftext.WriteLine("hello");
            ftext.Close();

            bool exists = File.Exists(file1);

            FileInfo fi1 = new FileInfo(file1);
            exists=fi1.Exists;
            Console.WriteLine(fi1.Extension);
            Console.WriteLine(fi1.Directory.FullName);


            File.Copy(@"c:\temp\file1.txt", @"C:\temp\file2.txt", true);

            FileInfo fi = new FileInfo(@"c:\temp\file1.txt");
            fi.CopyTo(@"C:\temp\file2.txt", true);


            File.Move(@"c:\temp\file2.txt", @"C:\temp\file3.txt");

            fi = new FileInfo(@"c:\temp\file3.txt");
            File.Delete(@"C:\temp\file4.txt");
            fi.MoveTo(@"C:\temp\file4.txt");


            fi1.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
            File.SetAttributes(file1, FileAttributes.Hidden | FileAttributes.ReadOnly);

            bool isReadOnly = (fi1.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;

            File.SetAttributes(file1, File.GetAttributes(file1) & ~FileAttributes.ReadOnly);
            isReadOnly = (File.GetAttributes(file1) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;

            string filepath = @"c:\temp\filetesto.txt";
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("riga 1");
            sb.AppendLine("riga 2");
            sb.AppendLine("riga 3");
            File.WriteAllText(filepath, sb.ToString());
            

            string[] righe=new string[]{"riga 1", "riga 2", "riga 3"};
            File.WriteAllLines(filepath, righe);
            File.AppendAllLines(filepath, righe);

            File.WriteAllBytes(filepath, Encoding.ASCII.GetBytes("contenuto"));

            var righeLette = File.ReadLines(filepath);
            righeLette.ToList().ForEach(Console.WriteLine);

            string[] fileList=  Directory.GetFiles("C:\\temp", "*.txt", SearchOption.AllDirectories);
            string[] directoryList= Directory.GetDirectories("C:\\temp");
            
            DirectoryInfo diTemp = new DirectoryInfo("C:\\temp\\");
            var entries= diTemp.EnumerateFileSystemInfos();
            foreach (FileSystemInfo fsi in entries)
            {
                Console.WriteLine(fsi.FullName);
            }
            var files = diTemp.EnumerateFiles();
            foreach (FileInfo finfo in files)
            {
                Console.WriteLine("{0, -30} - {1}KB", finfo.Name, finfo.Length>>10);
            }

            //LINQ
            var elenco= new DirectoryInfo("C:\\temp\\").EnumerateFiles("*", SearchOption.AllDirectories);
            var query = from f in elenco
                        where f.Length > (1 << 20) && f.Extension != "txt"
                        select new { f.FullName, f.Length };

            int fileCount=query.Count();
            query.ToList().ForEach(Console.WriteLine);

        }
    }
}
