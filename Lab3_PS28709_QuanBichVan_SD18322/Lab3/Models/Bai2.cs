using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lab3.Models
{
    public class Bai2
    {
            public static void CreateDirectory()
            {
                DirectoryInfo dir = new DirectoryInfo("E:\\FPT\\C#2\\BT\\Lab3_PS28709_QuanBichVan_SD18322\\Lab3");
                try
                {
                    if (dir.Exists)
                    {
                        Console.WriteLine("Directory Already Exists");
                        Console.WriteLine("Directory Name: " + dir.Name);
                        Console.WriteLine("Path: " + dir.FullName);
                        Console.WriteLine("Directory is created on: " + dir.CreationTime);
                        Console.WriteLine("Directory is Last Accessed on: " + dir.LastAccessTime);
                    }
                    else
                    {
                        dir.Create();
                        Console.WriteLine("Directory Created Successfully. Information of Directory");
                        Console.WriteLine("Directory Name: " + dir.Name);
                        Console.WriteLine("Path: " + dir.FullName);
                        Console.WriteLine("Directory is created on: " + dir.CreationTime);
                        Console.WriteLine("Directory is Last Accessed on: " + dir.LastAccessTime);
                    }
                    Console.WriteLine("Bạn đã tạo Directory thành công!");
                    Console.ReadLine();
                }
                catch (DirectoryNotFoundException d)
                {
                    Console.WriteLine(d.Message.ToString());
                }
            }
            public static void CreateFile()
            {
                FileInfo file = new FileInfo("E:\\FPT\\C#2\\BT\\Lab3_PS28709_QuanBichVan_SD18322\\Lab3\\text.txt");
                using (StreamWriter sw = file.CreateText())
                {
                    sw.WriteLine("Hello File Handing");
                    sw.WriteLine("Quan Bích Vân");
                    sw.WriteLine("PS28709");
                }
                Console.WriteLine("\n\n******Display File Info******");
                Console.WriteLine("File Create on: " + file.CreationTime);
                Console.WriteLine("Directory Name: " + file.DirectoryName);
                Console.WriteLine("Full Name of File: " + file.FullName);
                Console.WriteLine("File is Last Accessed on: " + file.LastAccessTime);
                Console.WriteLine("Bạn đã tạo File thành công!");
                Console.ReadLine();
            }
    }
}
