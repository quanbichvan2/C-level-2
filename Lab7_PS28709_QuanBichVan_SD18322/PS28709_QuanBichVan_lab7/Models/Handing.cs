using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using PS28709_QuanBichVan_lab7.UI;

namespace PS28709_QuanBichVan_lab7.Models
{
    public class Handing
    {
        public class Bai1
        {
            static IEnumerable<string> WordFilt(string mystr)
            {
                var upWord = mystr.Split(' ')
                    .Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));
                /*
                 Khi sử dụng StringComparison.Ordinal, việc so sánh chuỗi được thực hiện bằng cách so sánh từng ký tự
                 trong chuỗi theo thứ tự từ điển, mà không quan tâm đến các quy tắc so sánh ngôn ngữ hoặc cấu hình địa
                 phương. 
                */
                return upWord;
            }
            public static void cn1()
            {
                //Bài 1: Viết chương trình xuất bình phương các số chẵn > 4.

                int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var test = (from obj in n1
                            where obj % 2 == 0 && obj > 4
                            select Math.Pow(obj, 2)).ToList();
                foreach (var item in test)
                {
                    Contexts.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
            public static void cn2()
            {
                //Bài 1B: Viết chương trình nhận vào một chuỗi ký tự, xuất ra màn hình số lần xuất hiện của từng ký tự trong chuỗi:
                string fpt = "Fpoly";
                var result = from obj in fpt.ToLowerInvariant().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                             select obj;
                foreach (var item in result)
                {
                    Contexts.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Contexts.CenterWrite(17);
                Console.Write("Nhập vào chuỗi: ");
                string message = Console.ReadLine();
                //Xóa khoảng trắng khỏi chuỗi
                message = message.Replace(" ", string.Empty);
                //sử dụng vòng lặp while và for để lặp và đếm số lần xuất hiện của ký tự
                while (message.Length > 0)
                {
                    Console.Write(message[0] + " : ");
                    int count = 0;
                    for (int j = 0; j < message.Length; j++)
                    {
                        if (message[0] == message[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                    message = message.Replace(message[0].ToString(), string.Empty);
                    // dòng mã trên loại bỏ tất cả các ký tự giống với ký tự đầu tiên của message khỏi message
                }
                Console.ReadLine();
            }
            public static void cn3()
            {
                //Bài 1C: Viết chương trình nhận vào một chuỗi ký tự có các chuỗi con có viết hoa, xuất ra màn hình các chuỗi con được viết hoa.
                string strNew;
                Console.Write("Mời nhập chuỗi ký tự: ");
                strNew = Console.ReadLine();

                var ucWord = WordFilt(strNew);
                int count = 0; // Biến đếm số từ viết hoa
                Console.Write("Đây là chuỗi in hoa: ");
                foreach (var item in ucWord)
                {
                    Console.Write(item + " ");
                    count++;
                }
                Console.ReadLine();
            }
        }
        public class bai2
        {
            public static void cn4()
            {
                // Xuất ra màn hình các thông tin ContactName trong table Customers và ShipName trong bảng Orders
                using (var db = new DataClasses1DataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=northwind;
                Integrated Security=True"))
                {
                    var result = from c in db.Customers
                                 join o in db.Orders on c.CustomerID equals o.CustomerID
                                 select new
                                 {
                                     conName = c.ContactName,
                                     shipName = o.ShipName
                                 };
                    foreach (var x in result)
                    {
                        Contexts.CenterWrite(17);
                        Console.WriteLine(x);
                    }
                    Console.ReadLine();
                }
            }
            public static void cn5()
            {
                //Thêm một dòng dữ liệu vào bảng Customers với dữ liệu CustomerID=”Fpoly” và CompanyName = “FPT”

                using (var db = new DataClasses1DataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=northwind;
                Integrated Security=True"))
                {
                    var customer = new Customer()
                    {
                        CustomerID = "Fpoly",
                        CompanyName = "FPT"
                    };
                    db.Customers.InsertOnSubmit(customer);
                    Console.WriteLine("Đã thêm thành công");
                    db.SubmitChanges();
                }
            }
            public static void cn6()
            {
                // Cập nhật CompanyName = “FE” tại CustomerID=”Fpoly”
                using (var db = new DataClasses1DataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=northwind;
                Integrated Security=True"))
                {
                    var c = db.Customers
                            .Where(x => x.CustomerID == "Fpoly")
                            .FirstOrDefault();
                    c.CompanyName = "FE";
                    db.SubmitChanges();
                }
            }
            public static void cn7()
            {
                //Xóa dòng có CustumerID= ”ALFKI"
                using (var db = new DataClasses1DataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=northwind;
                Integrated Security=True"))
                {
                    var e = db.Customers
                        .Where(x => x.CustomerID == "ALFKI")
                        .FirstOrDefault();
                    db.Customers.DeleteOnSubmit(e);
                    db.SubmitChanges();
                }
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}
