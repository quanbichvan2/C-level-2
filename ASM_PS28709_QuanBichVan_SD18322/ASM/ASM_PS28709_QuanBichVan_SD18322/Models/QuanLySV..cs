using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Security.Claims;
using System.Data;
using System.Data.SqlClient;
using ASM_PS28709_QuanBichVan_SD18322.UI;
using Microsoft.EntityFrameworkCore;

namespace ASM_PS28709_QuanBichVan_SD18322.Models
{
	public class QuanLySV
	{
        private static bool IsValidEmail(string emailcheck)
        {
            try
            {
                var mail = new MailAddress(emailcheck);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private static double diemMin, diemMax;

        public static void Ct1() // chức năng 1
        {
            /*
             Scaffold - DbContext "Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;Persist Security Info=True;User ID=sa;Password=123;MultipleActiveResultSets=True" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Entities - ContextDir Context - Context DemoContext - f;
             */

            /*
            Asingment_C2Context context = new Asingment_C2Context();
            context.Classes.Add();
            context.SaveChanges();
*/
            using var context = new Asingment_C2Context();
            do
            {
                var lophoc = new Class();
                Console.Write("Nhập Tên Lớp: ");
                lophoc.NameClass = Console.ReadLine();
                if (!string.IsNullOrEmpty(lophoc.NameClass))  // nếu mảng string không rỗng
                {
                    context.Classes.Add(lophoc);
                    context.SaveChanges();
                    break;
                }
            } while (true);

            //var connectionString = "Data Source = Yun\\SQLEXPRESS; Initial Catalog = Asingment_C#2;User ID=sa;Password=***********;Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();   //Mở kết nối
            //{
            //    do
            //    {
            //        Class lophoc = new Class();
            //        Console.Write("Nhập Tên Lớp: ");
            //        lophoc.NameClass = Console.ReadLine();
            //        if (string.IsNullOrEmpty(lophoc.NameClass) == false)
            //        {
            //            db.Classes.InsertOnSubmit(lophoc);
            //            db.SubmitChanges();
            //            break;
            //        }
            //    } while (true);
            //}
        }

        public static void Ct2() // chức năng 1
        {
            using var context = new Asingment_C2Context();
            var st = new Student();

            do
            {
                Console.Write("1. Nhập Tên Sinh Viên: ");
                st.Name = Console.ReadLine();
            } while (string.IsNullOrEmpty(st.Name));

            do
            {
                Console.Write("2. Nhập Điểm: ");
                if (!double.TryParse(Console.ReadLine(), out double mark) || mark < 0 || mark > 10)
                {
                    continue;
                }
                st.Mark = mark;
                break;
            } while (true);

            do
            {
                Console.Write("3. Nhập Email: ");
                string email = Console.ReadLine();
                if (IsValidEmail(email))
                {
                    st.Email = email;
                    break;
                }
            } while (true);

            Console.Write("4. Nhập IDCLASS: ");
            if (int.TryParse(Console.ReadLine(), out int idClass))
            {
                st.IdClass = idClass;
            }

            context.Students.Add(st);
            context.SaveChanges();
            Console.ReadLine();
            //using (var db = new YinGHDataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //Student st = new Student();
            //do
            //{
            //    Console.Write("1. Nhập Tên Sinh Viên: ");
            //    st.Name = Console.ReadLine();
            //    if (string.IsNullOrEmpty(st.Name) == false)
            //    {
            //        break;
            //    }
            //} while (true);
            //do
            //{
            //    Console.Write("2. Nhập Điểm: ");
            //    st.Mark = Convert.ToDouble(Console.ReadLine());
            //    if (st.Mark >= 0 && st.Mark <= 10)
            //    {
            //        break;
            //    }
            //} while (true);
            //do
            //{
            //    string emailcheck;
            //    Console.Write("3. Nhập Email: ");
            //    st.Email = emailcheck = Console.ReadLine();
            //    if (IsValidEmail(emailcheck))
            //    {
            //        break;
            //    }
            //} while (true);
            //Console.Write("4. Nhập IDCLASS: ");
            //st.idClass = Convert.ToInt32(Console.ReadLine());
            //db.Students.InsertOnSubmit(st);
            //db.SubmitChanges();
            // }
        }

        public static void Ct3() // chức năng 2
        {
            using var context = new Asingment_C2Context();
            var students = context.Students.ToList();

            foreach (var student in students)
            {
                string hocLuc;
                if (student.Mark < 3)
                {
                    hocLuc = "Kém";
                }
                else if (student.Mark < 5)
                {
                    hocLuc = "Yếu";
                }
                else if (student.Mark < 6.5)
                {
                    hocLuc = "Trung bình";
                }
                else if (student.Mark < 7.5)
                {
                    hocLuc = "Khá";
                }
                else if (student.Mark < 9)
                {
                    hocLuc = "Giỏi";
                }
                else
                {
                    hocLuc = "Xuất sắc";
                }

                Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                Console.WriteLine($"Mã Số Sinh Viên: {student.StId} | Tên Sinh Viên: {student.Name} | Email: {student.Email} | Điểm: {student.Mark} | Học lực: {hocLuc} ");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
               
            }
            Console.ReadLine();

            // Name, Mark, Email và IdClass
            //using (var db = new YinGHDataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //var lq = from x in db.Students
            //         select x;
            //foreach (var n in lq)
            //{
            //    string hocLuc;
            //    if (n.Mark < 3)
            //    {
            //        hocLuc = "Kém";
            //    }
            //    else if (n.Mark < 5)
            //    {
            //        hocLuc = "Yếu";
            //    }
            //    else if (n.Mark < 6.5)
            //    {
            //        hocLuc = "Trung bình";
            //    }
            //    else if (n.Mark < 7.5)
            //    {
            //        hocLuc = "Khá";
            //    }
            //    else if (n.Mark < 9)
            //    {
            //        hocLuc = "Giỏi";
            //    }
            //    else
            //    {
            //        hocLuc = "Xuất sắc";
            //    }
            //    Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
            //    Console.WriteLine($"Mã Số Sinh Viên: {n.StID} | Tên Sinh Viên: {n.Name} | Email: {n.Email} | Điểm: {n.Mark} | Học lực: {hocLuc} ");
            //    Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //}
            //}
        }

        public static void Ct4() // chức năng 3
        {
            using var context = new Asingment_C2Context();
            Console.Write("Nhập điểm Min: ");
            diemMin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập điểm Max: ");
            diemMax = Convert.ToDouble(Console.ReadLine());

            var students = context.Students.Where(s => diemMin <= s.Mark && s.Mark <= diemMax).ToList();

            foreach (var student in students)
            {
                Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                Console.WriteLine($"Mã Số Sinh Viên: {student.StId} | Tên Sinh Viên: {student.Name} | Email: {student.Email} | Điểm: {student.Mark} ");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.ReadLine();

            }
            //using (var db = new YinGHDataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //Console.Write("Nhập điểm Min: ");
            //diemMin = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhập điểm Max: ");
            //diemMax = Convert.ToDouble(Console.ReadLine());
            //var lq = from y in db.Students
            //         select y;
            //foreach (var h in lq)
            //{
            //    if (diemMin <= h.Mark && h.Mark <= diemMax)
            //    {
            //        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
            //        Console.WriteLine($"Mã Số Sinh Viên: {h.StID} | Tên Sinh Viên: {h.Name} | Email: {h.Email} | Điểm: {h.Mark} ");
            //        Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //    }

            //}
            //}

        }

        public static void Ct5() // chức năng 4
        {
            using var db = new Asingment_C2Context();
            var st = new Student();

            Console.Write("Nhập Mã Sinh Viên: ");
            bool success = int.TryParse(Console.ReadLine(), out int id);

            // nếu ép kiểu thành công, trả về cho tôi giá trị đúng và tạo 1 biến sau khi ép kiểu
            // nếu ép kiểu thất bại, trả về giá trị sai
            if (success)
            {
                var obj = db.Students
                    .Where(x => x.StId == id)
                    .FirstOrDefault();
                if (obj != null)
                {
                    Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                    Console.WriteLine($"Mã Số Sinh Viên: {obj.StId} | Tên Sinh Viên: {obj.Name} | Email: {obj.Email} | Điểm: {obj.Mark} ");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    Console.Write("Cập nhập mã sinh viên: ");
                    st.StId = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.Write("1. Nhập Tên Sinh Viên: ");
                        st.Name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(st.Name))
                        {
                            break;
                        }
                    } while (true);

                    do
                    {
                        string emailcheck;
                        Console.Write("3. Nhập Email: ");
                        st.Email = emailcheck = Console.ReadLine();
                        if (IsValidEmail(emailcheck))
                        {
                            break;
                        }
                    } while (true);

                    do
                    {
                        Console.Write("2. Nhập Điểm: ");
                        st.Mark = Convert.ToDouble(Console.ReadLine());
                        if (st.Mark >= 0 && st.Mark <= 10)
                        {
                            break;
                        }
                    } while (true);

                    var c = db.Students
                        .FirstOrDefault(x => x.StId == st.StId);
                    if (c != null)
                    {
                        c.Name = st.Name;
                        c.Email = st.Email;
                        c.Mark = st.Mark;
                        db.SaveChanges();
                    }
                }
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sv này");
                Console.ReadLine();

            }
            //using (var db = new YinGHDataContext(@"Data Source=Y\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //Student st = new Student();
            //Console.Write("Nhập Mã Sinh Viên: ");
            //st.StID = Convert.ToInt32(Console.ReadLine());
            //var obj = from x in db.Students
            //          where x.StID == st.StID
            //          select x;
            //foreach (var item in obj)
            //{
            //    Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
            //    Console.WriteLine($"Mã Số Sinh Viên: {item.StID} | Tên Sinh Viên: {item.Name} | Email: {item.Email} | Điểm: {item.Mark} ");
            //    Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //}


            //Console.Write("Cập nhập mã sinh viên: ");
            //st.StID = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.Write("1. Nhập Tên Sinh Viên: ");
            //    st.Name = Console.ReadLine();
            //    if (string.IsNullOrEmpty(st.Name) == false)
            //    {
            //        break;
            //    }
            //} while (true);
            //do
            //{
            //    string emailcheck;
            //    Console.Write("3. Nhập Email: ");
            //    st.Email = emailcheck = Console.ReadLine();
            //    if (IsValidEmail(emailcheck))
            //    {
            //        break;
            //    }
            //} while (true);
            //do
            //{
            //    Console.Write("2. Nhập Điểm: ");
            //    st.Mark = Convert.ToDouble(Console.ReadLine());
            //    if (st.Mark >= 0 && st.Mark <= 10)
            //    {
            //        break;
            //    }
            //} while (true);
            //Console.Write("Cập nhật IDCLASS: ");
            //st.idClass = Convert.ToInt32(Console.ReadLine());
            //var c = db.Students
            //        .Where(x => x.StID == st.StID)
            //        .FirstOrDefault();
            //c.Name = st.Name;
            //c.Email = st.Email;
            //c.Mark = st.Mark;
            //c.idClass = st.idClass;
            //db.SubmitChanges();
            //}
        }

        public static void Ct6() // chức năng 5
        {
            using var db = new Asingment_C2Context();
            var obj = db.Students.OrderByDescending(x => x.Mark).ToList();

            foreach (var h in obj)
            {
                Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                Console.WriteLine($"Mã Số Sinh Viên: {h.StId} | Tên Sinh Viên: {h.Name} | Email: {h.Email} | Điểm: {h.Mark} ");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

            }
            Console.ReadLine();

            //using (var db = new YinGHDataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //    var obj = db.Students.OrderByDescending(x => x.Mark);
            //    foreach (var h in obj)
            //    {
            //        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
            //        Console.WriteLine($"Mã Số Sinh Viên: {h.StID} | Tên Sinh Viên: {h.Name} | Email: {h.Email} | Điểm: {h.Mark} ");
            //        Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //    }
            //}
        }

        public static void Ct7() // chức năng 6
        {
            using var db = new Asingment_C2Context();
            var y06 = db.Students.OrderByDescending(x => x.Mark).Take(5).ToList();

            foreach (var x in y06)
            {
                Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                Console.WriteLine($"Mã Số Sinh Viên: {x.StId} | Tên Sinh Viên: {x.Name} | Email: {x.Email} | Điểm: {x.Mark} ");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
            }
            Console.ReadLine();

            //using (var db = new YinGHDataContext(@"Data Source=Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //    var y06 = db.Students.OrderByDescending(x => x.Mark).Take(5);
            //    foreach (var x in y06)
            //    {
            //        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
            //        Console.WriteLine($"Mã Số Sinh Viên: {x.StID} | Tên Sinh Viên: {x.Name} | Email: {x.Email} | Điểm: {x.Mark} ");
            //        Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //    }
            //}
        }

        public static void Ct8() // chức năng 7
        {
            using var db = new Asingment_C2Context();
            var obj = db.Classes.Include(p => p.Students).ToList();

            var dtbThread = new Thread(() =>
            {
                using var writer = new StreamWriter(@"E:\FPT\C#2\BT\ASM_Fix\ASM\ASM_PS28709_QuanBichVan_SD18322\Asm_C#2.txt");
                foreach (var item in obj)
                {
                    string line = $"{item.NameClass} | {item.Students.Average(x => x.Mark)}";
                    writer.WriteLine(line);
                }
            })
            {
                Name = "DTB"
            };
            dtbThread.Start();
            Context.CenterWrite(17);
            Console.WriteLine("In Thành Công");
            Console.ReadLine();


            //using (var db = new YinGHDataContext(@"Data Source=-Yun\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            //Integrated Security=True"))
            //{
            //    var obj = from c in db.Classes
            //              join s in db.Students
            //              on c.idClass equals s.idClass
            //              select new
            //              {
            //                  Studentname = c.NameClass,
            //                  diem = s.Mark
            //              };
            //    var obj2 = from jhin in obj
            //               group jhin by jhin.Studentname;

            //    foreach (var item in obj2)
            //    {
            //        Console.WriteLine($"{item.Key} | {item.Average(x => x.diem)}");
            //    }
            //}
        }
    }
}

