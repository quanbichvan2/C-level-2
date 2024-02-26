using System.Diagnostics;
using System.Text;
using Lab1_PS28709_QuanBichVan_SD18322.Models;
using Lab1_PS28709_QuanBichVan_SD18322.UI;

namespace Lab1_PS28709_QuanBichVan_SD18322
{
    class Program
    {
        public static void Main()
        {

            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                int choice;
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
                            Console.WriteLine("Bạn đã chọn Bài 1: MyCollege.");
                            Console.WriteLine(MyCollege.CollegeName);
                            Console.WriteLine(MyCollege.Address);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Bạn đã chọn Bài 2: Student.");
                            Student.DisplayCollegeDetails();
                            Console.WriteLine();
                            Student s1 = new Student();
                            Student s2 = new Student();
                            s1.SetStudentDetails("Thepv", "Phd");
                            s2.SetStudentDetails("Nghiemn", "MBA");
                            s1.DisplayStudentDetails();
                            s2.DisplayStudentDetails();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Bạn đã chọn Bài 3: Separate (áp dụng Partial)");
                            Separate.Bai3 bai3 = new Separate.Bai3();
                            Console.WriteLine("Cộng = {0}", bai3.Add(3, 2));
                            Console.WriteLine("Trừ = {0}", bai3.Sub(4, 3));
                            Console.WriteLine("Nhân = {0}", bai3.Mul(9, 9));
                            Console.WriteLine("Chia = {0}", bai3.Div(21, 7));
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Bạn đã chọn Bài 4: so sánh HashSet và List");
                            int times = 10000000;
                            for (int listSize = 1; listSize < 10; listSize++)
                            {
                                List<string> list = new List<string>();
                                HashSet<string> hashset = new HashSet<string>();
                                for (int i = 0; i < listSize; i++)
                                {
                                    list.Add("string" + i.ToString());
                                    hashset.Add("string" + i.ToString());
                                }

                                Stopwatch timer = new Stopwatch();
                                timer.Start();
                                for (int i = 0; i < times; i++)
                                {
                                    list.Remove("string0");
                                    list.Add("string0");
                                }

                                timer.Stop();
                                Console.WriteLine(listSize.ToString() + " item LIST strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                                timer = new Stopwatch();
                                timer.Start();
                                for (int i = 0; i < times; i++)
                                {
                                    hashset.Remove("string0");
                                    hashset.Add("string0");
                                }

                                timer.Stop();
                                Console.WriteLine(listSize.ToString() + " item HASHSET strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                                Console.WriteLine();
                            }

                            for (int listSize = 1; listSize < 10; listSize += 3)
                            {
                                List<object> list = new List<object>();
                                HashSet<object> hashset = new HashSet<object>();
                                for (int i = 0; i < listSize; i++)
                                {
                                    list.Add(new object());
                                    hashset.Add(new object());
                                }
                                object objToAddRem = list[0];
                                Stopwatch timer = new Stopwatch();
                                timer.Start();
                                for (int i = 0; i < times; i++)
                                {
                                    list.Remove(objToAddRem);
                                    list.Add(objToAddRem);
                                }
                                timer.Stop();
                                Console.WriteLine(listSize.ToString() + " item LIST objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                                timer = new Stopwatch();
                                timer.Start();
                                for (int i = 0; i < times; i++)
                                {
                                    hashset.Remove(objToAddRem);
                                    hashset.Add(objToAddRem);
                                }
                                timer.Stop();
                                Console.WriteLine(listSize.ToString() + " item HASHSET objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            Console.Clear();
                            break;
                    }
                    Console.WriteLine();
                    //HashSet nhanh hơn List vì List chạy từ đầu chuỗi tới cuối chuỗi, còn HashSet dựa vào Key.
                    //Đặt key từ đâu thì chạy từ đoạn đấy trở xuống tới cuối chuỗi.
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





