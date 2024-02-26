using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Them.Models
{
    public class TextWriterAndTextReader
    {
        public void TextFile()
        {
            string file = @"E:\FPT\C#2\BT\Lab3_Them\example.txt";
            //Writing File
            using (TextWriter writer = File.CreateText(file))
            {
                writer.Write(DateTime.Now.ToString());
                Console.WriteLine("");
            }
            //Reading File
            using (TextReader reader = File.OpenText(file))
            {
                Console.WriteLine("Thông tin sinh viên ");
                Console.WriteLine("Tên: Quan Bích Vân ");
                Console.WriteLine("ID: PS28709 ");
                Console.WriteLine("Lớp SD18322 ");
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
