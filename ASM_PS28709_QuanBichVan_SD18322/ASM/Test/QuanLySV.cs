using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ASMPS28709
{
        public class QuanLySV
        {
            private static bool IsValidEmail(string emailcheck)
            {
                try
                {
                    MailAddress mail = new MailAddress(emailcheck);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public double diemMin, diemMax;

            public void Ct1() // chức năng 1
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    do
                    {
                        Class lophoc = new Class();
                        Console.Write("Nhập Tên Lớp: ");
                        lophoc.NameClass = Console.ReadLine();
                        if (string.IsNullOrEmpty(lophoc.NameClass) == false)
                        {
                            db.Classes.InsertOnSubmit(lophoc);
                            db.SubmitChanges();
                            break;
                        }
                    } while (true);
                }
            }

            public void Ct2() // chức năng 1
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    Student st = new Student();
                    do
                    {
                        Console.Write("1. Nhập Tên Sinh Viên: ");
                        st.Name = Console.ReadLine();
                        if (string.IsNullOrEmpty(st.Name) == false)
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
                    Console.Write("4. Nhập IDCLASS: ");
                    st.idClass = Convert.ToInt32(Console.ReadLine());
                    db.Students.InsertOnSubmit(st);
                    db.SubmitChanges();
                }
            }

            public void Ct3() // chức năng 2
            {
                // Name, Mark, Email và IdClass
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    var lq = from x in db.Students
                             select x;
                    foreach (var n in lq)
                    {
                        string hocLuc;
                        if (n.Mark < 3)
                        {
                            hocLuc = "Kém";
                        }
                        else if (n.Mark < 5)
                        {
                            hocLuc = "Yếu";
                        }
                        else if (n.Mark < 6.5)
                        {
                            hocLuc = "Trung bình";
                        }
                        else if (n.Mark < 7.5)
                        {
                            hocLuc = "Khá";
                        }
                        else if (n.Mark < 9)
                        {
                            hocLuc = "Giỏi";
                        }
                        else
                        {
                            hocLuc = "Xuất sắc";
                        }
                        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                        Console.WriteLine($"Mã Số Sinh Viên: {n.StID} | Tên Sinh Viên: {n.Name} | Email: {n.Email} | Điểm: {n.Mark} | Học lực: {hocLuc} ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    }
                }
            }

            public void Ct4() // chức năng 3
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    Console.Write("Nhập điểm Min: ");
                    diemMin = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhập điểm Max: ");
                    diemMax = Convert.ToDouble(Console.ReadLine());
                    var lq = from y in db.Students
                             select y;
                    foreach (var h in lq)
                    {
                        if (diemMin <= h.Mark && h.Mark <= diemMax)
                        {
                            Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                            Console.WriteLine($"Mã Số Sinh Viên: {h.StID} | Tên Sinh Viên: {h.Name} | Email: {h.Email} | Điểm: {h.Mark} ");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                        }

                    }
                }

            }

            public void Ct5() // chức năng 4
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    Student st = new Student();
                    Console.Write("Nhập Mã Sinh Viên: ");
                    st.StID = Convert.ToInt32(Console.ReadLine());
                    var obj = from x in db.Students
                              where x.StID == st.StID
                              select x;
                    foreach (var item in obj)
                    {
                        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                        Console.WriteLine($"Mã Số Sinh Viên: {item.StID} | Tên Sinh Viên: {item.Name} | Email: {item.Email} | Điểm: {item.Mark} ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    }


                    Console.Write("Cập nhập mã sinh viên: ");
                    st.StID = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.Write("1. Nhập Tên Sinh Viên: ");
                        st.Name = Console.ReadLine();
                        if (string.IsNullOrEmpty(st.Name) == false)
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
                    Console.Write("Cập nhật IDCLASS: ");
                    st.idClass = Convert.ToInt32(Console.ReadLine());
                    var c = db.Students
                            .Where(x => x.StID == st.StID)
                            .FirstOrDefault();
                    c.Name = st.Name;
                    c.Email = st.Email;
                    c.Mark = st.Mark;
                    c.idClass = st.idClass;
                    db.SubmitChanges();
                }
            }

            public void Ct6() // chức năng 5
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    var obj = db.Students.OrderByDescending(x => x.Mark);
                    foreach (var h in obj)
                    {
                        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                        Console.WriteLine($"Mã Số Sinh Viên: {h.StID} | Tên Sinh Viên: {h.Name} | Email: {h.Email} | Điểm: {h.Mark} ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    }
                }
            }

            public void Ct7() // chức năng 6
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    var y06 = db.Students.OrderByDescending(x => x.Mark).Take(5);
                    foreach (var x in y06)
                    {
                        Console.WriteLine("\n-------------------------------------->>Thông tin sinh viên<<---------------------------------------");
                        Console.WriteLine($"Mã Số Sinh Viên: {x.StID} | Tên Sinh Viên: {x.Name} | Email: {x.Email} | Điểm: {x.Mark} ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    }
                }
            }

            public void Ct8() // chức năng 7
            {
                using (var db = new YinGHDataContext(@"Data Source=LAPTOP-8E61KIMO\SQLEXPRESS;Initial Catalog=Asingment_C#2;
            Integrated Security=True"))
                {
                    var obj = from c in db.Classes
                              join s in db.Students
                              on c.idClass equals s.idClass
                              select new
                              {
                                  Studentname = c.NameClass,
                                  diem = s.Mark
                              };
                    var obj2 = from jhin in obj
                               group jhin by jhin.Studentname;

                    foreach (var item in obj2)
                    {
                        Console.WriteLine($"{item.Key} | {item.Average(x => x.diem)}");
                    }
                }
            
        }
    }
}
