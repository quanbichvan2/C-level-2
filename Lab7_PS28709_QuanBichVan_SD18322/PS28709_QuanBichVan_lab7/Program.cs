using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using PS28709_QuanBichVan_lab7.Models;
using PS28709_QuanBichVan_lab7.UI;

namespace PS28709_QuanBichVan_lab7
{
    class Program
    {
        public static int choice;
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                do
                {
                    try
                    {
                        choice = Contexts.Menu();
                    }
                    catch (System.Exception)
                    {
                        choice = 8;
                    }
                    switch (choice)
                    {
                        case 1:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 1a: ");
                            Handing.Bai1.cn1();
                            Contexts.Notification();
                            break;
                        case 2:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 1b: ");
                            Handing.Bai1.cn2();
                            Contexts.Notification();
                            break;
                        case 3:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 1c: ");
                            Handing.Bai1.cn3();
                            Contexts.Notification();
                            break;
                        case 4:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 2a: ");
                            Handing.bai2.cn4();
                            Contexts.Notification();
                            break;
                        case 5:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 2b: ");
                            Handing.bai2.cn5();
                            Contexts.Notification();
                            break;
                        case 6:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 2c: ");
                            Handing.bai2.cn6();
                            Contexts.Notification();
                            break;
                        case 7:
                            Contexts.CenterWrite(17);
                            Console.WriteLine("Bài 2d: ");
                            Handing.bai2.cn7();
                            Contexts.Notification();
                            break;
                        case 0:
                            Contexts.EndingProgram();
                            System.Environment.Exit(0);
                            break;
                        default:
                            Contexts.NotificationError();
                            break;

                    }
                    Console.WriteLine();
                }
                while (choice != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
