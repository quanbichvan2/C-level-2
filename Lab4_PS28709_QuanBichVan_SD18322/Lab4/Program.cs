using System.Runtime.Intrinsics.X86;
using System.Text;
using Lab4.UI;
using Lab4.Models;
using System.Linq.Expressions;
using static Lab4.Models.Bai1;
using static Lab4.Models.Bai2;
using static Lab4.Models.Bai3;
using static Lab4.Models.Bai4;

namespace Lab4
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
                        choice = 5;
                    }
                    switch (choice)
                    {
                        case 1:
                            LambdaExpressions example1 = new LambdaExpressions();
                            example1.Lambda();
                            Context.Notification();
                            break;
                        case 2:
                            Bai2 example2= new Bai2();
                            example2.XuatThongTin();
                            example2.Sort();
                            Context.Notification();
                            break;
                        case 3:
                            Bai3 example3 = new Bai3();
                            example3.InThongTin();
                            example3.XuatThongTinLINQ();
                            Context.Notification();
                            break;
                        case 4:
                            Bai4 example4 = new Bai4();
                            example4.LINQMixSyntax();
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