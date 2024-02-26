using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Bai1
    {
        public class CreateStreamFile
        {
            public void StreamFile()
            {
                try
                {
                    string file = @"E:\FPT\C#2\BT\Lab3_PS28709_QuanBichVan_SD18322\example1a.txt";
                    //Creating File
                    FileStream fs = new FileStream(file, FileMode.Create);
                    //Adding current date and time in file
                    byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                    fs.Write(bdata, 0, bdata.Length);
                    Console.WriteLine("Data Added");
                    fs.Close();
                    //Reading File
                    string data;
                    FileStream fsRead = new FileStream(file, FileMode.Open, FileAccess.Read);
                    using (StreamReader sr = new StreamReader(fsRead))
                    {
                        data = sr.ReadToEnd();
                    }
                    Console.WriteLine(data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
                Console.ReadKey();
            }
        }
        public class StreamWriteAndReader
        {
            public void StreamFile()
            {
                string file = @"E:\FPT\C#2\BT\Lab3_PS28709_QuanBichVan_SD18322\example1b.txt";
                // creating and writting 
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.Write(DateTime.Now.ToString());
                    Console.WriteLine("Successfully Added Current Date and Time");
                }
                //Reading File
                using (StreamReader reader= new StreamReader(file))
                {
                    Console.WriteLine("Reading Current Time: ");
                    Console.WriteLine(reader.ReadToEnd());
                }
                Console.ReadKey();
            }

        }
        public class TextWriterAndTextReader
        {
            public void TextFile()
            {
                string file = @"E:\FPT\C#2\BT\Lab3_PS28709_QuanBichVan_SD18322\example1c.txt";
                //Writing File
                using (TextWriter writer = File.CreateText(file))
                {
                    writer.Write(DateTime.Now.ToString());
                    Console.WriteLine("Successfully Added Current Date and Time");
                }
                //Reading File
                using (TextReader reader = File.OpenText(file))
                {
                    Console.WriteLine("Reading Current Time: ");
                    Console.WriteLine(reader.ReadToEnd());
                }
                Console.ReadKey();
            }
        }
    }
}
