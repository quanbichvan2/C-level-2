using Lab6.UI;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using lab6.Models;

namespace lab6
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
                        choice = Context.Menu();
                    }
                    catch (System.Exception)
                    {
                        choice = 8;
                    }
                    switch (choice)
                    {
                        case 1:
                            Handings.bai1.cn1();
                            Context.Notification();
                            break;
                        case 2:
                            Handings.bai1.cn2();
                            Context.Notification();
                            break;
                        case 3:
                            Handings.bai1.cn3();
                            Context.Notification();
                            break;
                        case 4:
                            Handings.bai1.cn4();
                            Context.Notification();
                            break;
                        case 5:
                            Handings.bai2.cn5();
                            Context.Notification();
                            break;
                        case 6:
                            Handings.bai2.cn6();
                            Context.Notification();
                            break;
                        case 7:
                            Handings.bai3.cn7();
                            Context.Notification();
                            break;
                        case 8:
                            Handings.bai3.cn8();
                            Context.Notification();
                            break;
                        case 9:
                            Handings.bai3.cn9();
                            Context.Notification();
                            break;
                        case 10:
                            Handings.bai3.cn10();
                            Context.Notification();
                            break;
                        case 0:
                            Context.EndingProgram();
                            System.Environment.Exit(0);
                            break;
                        default:
                            Context.NotificationError();
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