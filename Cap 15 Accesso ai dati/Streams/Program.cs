using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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


            //FileStream
            string path="c:\\temp\\filestream.txt";
            using(FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.WriteByte(1);
            }

            using (FileStream fs = File.OpenRead(path))
            {
                int i=fs.ReadByte();
            }

            //async
            AsyncWriteOp();


            using (MemoryStream ms = new MemoryStream())
            {
                using (FileStream file = new FileStream("c:\\temp\\test.jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] filebuffer = new byte[file.Length];
                    file.Read(filebuffer, 0, (int)file.Length);
                    ms.Write(filebuffer, 0, (int)file.Length);

                    //processo i byte
                    //...

                    file.Position = 0;
                    file.Write(filebuffer, 0, filebuffer.Length);
                }
            }

            using (StreamReader reader = new StreamReader(path, Encoding.ASCII))
            {
                reader.ReadLine();
            }

            using(StreamReader sr1= File.OpenText(path))
            {
                string line;
                while( (line=sr1.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }

            using (StreamReader sr2 = File.OpenText(path))
            {
                int ch;
                while ((ch = sr2.Read()) != -1)
                {
                    Console.WriteLine((char)ch);
                }
            }

            using(StreamWriter writer=new StreamWriter(path, true, Encoding.UTF8))
            {
                writer.WriteLine(1);
                writer.WriteLine(true);
                writer.WriteLine("hello");
            }

            FileInfo fi = new FileInfo(path);
            using(StreamWriter writer=fi.AppendText())
            {
                writer.WriteLine(1);
                writer.WriteLine(true);
                writer.WriteLine("hello");
            }
            string str="abcdefgh";
            StringReader strReader = new StringReader("abcdefgh");
            
            string xmlString="<node></node>";
            var xmlReader= XmlReader.Create(new StringReader(xmlString));
            xmlReader.Read();

            FileStream binFs=File.OpenWrite("c:\\temp\\file.dat");
            BinaryWriter bw = new BinaryWriter(binFs);
            
            bool booleano=true;
            int intero=234;
            string stringa="hello";
            bw.Write(booleano);
            bw.Write(intero);
            bw.Write(stringa);

            bw.Close();

            using(BinaryReader br=new BinaryReader(File.OpenRead("c:\\temp\\file.dat")))
            {
                booleano = br.ReadBoolean();
                intero = br.ReadInt32();
                stringa = br.ReadString();
            }

            Stream streamb=File.OpenRead("c:\\temp\\file.dat");
            using (BinaryReader br = new BinaryReader(streamb))
            {
                byte[] allBytes=br.ReadBytes((int)streamb.Length);
            }
        }


        private static async void AsyncWriteOp()
        {
            byte[] buffer = new byte[100000];
            Random rnd=new Random();
            rnd.NextBytes(buffer);

            string path="c:\\temp\\asyncfile.txt";
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                await fs.WriteAsync(buffer, 0, 1000);
                fs.Seek(0, SeekOrigin.Begin);

                byte[] readbuffer = new byte[100];
                int readBytes= await fs.ReadAsync(readbuffer, 0, 100);
            }
        }
    }
}
