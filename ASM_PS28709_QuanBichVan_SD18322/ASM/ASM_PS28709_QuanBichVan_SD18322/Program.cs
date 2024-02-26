using ASM_PS28709_QuanBichVan_SD18322.UI;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Data.SqlClient;
using ASM_PS28709_QuanBichVan_SD18322.Models;
namespace ASM_PS28709_QuanBichVan_SD18322
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
                            QuanLySV.Ct1();
                            Console.WriteLine("Nhập danh sách ");
                            QuanLySV.Ct2();
                            Context.Notification();
                            break;
                        case 2:
                            QuanLySV.Ct3();
                            Context.Notification();
                            break;
                        case 3:
                            QuanLySV.Ct4();
                            Context.Notification();
                            break;
                        case 4:
                            
                            QuanLySV.Ct5();
                            Context.Notification();
                            break;
                        case 5:
                          
                            QuanLySV.Ct6();
                            Context.Notification();
                            break;
                        case 6:
                        
                            QuanLySV.Ct7();
                            Context.Notification();
                            break;
                        case 7:
                          
                            QuanLySV.Ct8();
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