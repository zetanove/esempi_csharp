using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes=new byte[] {1,2,3,4};
            Stream s = new FileStream("c:\\temp\\file.txt", FileMode.OpenOrCreate);
            s.Write(bytes, 0, bytes.Length);
            s.WriteByte(123);
            s.Close();

            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }

            byte[] buffer = new byte[1000];
            Random rnd=new Random();
            rnd.NextBytes(buffer);
            
            byte[] dest=new byte[50000];
            using(MemoryStream ms = new MemoryStream(buffer))
            {
                int read=0;
                int total = 0;
                while( (read = ms.Read(dest, 0, 100)) >0)
                {
                    total += read;
                }
                Console.WriteLine(total);

                int b = ms.ReadByte(); // -1

                if (ms.CanSeek)
                {
                    long pos = ms.Position;
                    ms.Seek(100, SeekOrigin.Begin);
                    pos= ms.Position;
                    int b2 = ms.ReadByte();
                }

 
            }

            using (FileStream fs = new FileStream("c:\\temp\\filestream.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.WriteByte(1);
            }

            using (FileStream fsRead = new FileStream("c:\\temp\\filestream.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    fsRead.WriteByte(1);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }


        }
    }
}
