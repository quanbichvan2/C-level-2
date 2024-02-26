using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6.UI;
namespace lab6.Models
{
    public class Handings
    {
        public class bai1
        {
            private static IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87, 401, 1000 };
            private static IList<string> strList = new List<string>() { /*null,*/ "Two", "Three", "Four", "Five" };

            public static void cn1()
            {
                Context.CenterWrite(17);
                Console.WriteLine("Số chẵn đầu tiên trong intList: {0}", intList.First(i => i % 2 == 0));
                Console.ReadLine();
            }

            public static void cn2()
            {
                Context.CenterWrite(17);
                Console.WriteLine("Phần tử cuối cùng trong intList có giá trị > 200: {0}", intList.Last(x => x > 200));
                Console.ReadLine();
            }

            public static void cn3()
            {
                Context.CenterWrite(17);
                Console.WriteLine("Phần tử đầu tiên trong strList có giá trị bắt đầu bằng ký tự “T”: {0}", strList.FirstOrDefault(s => s.StartsWith("T")));
                Console.ReadLine();
            }

            public static void cn4()
            {
                int sum = 0;
                foreach (int i in intList.Where((x, index) => index % 2 != 0))
                {
                    sum += i;
                }
                Context.CenterWrite(17);
                Console.WriteLine("Tổng các trị tại vị trí index lẻ trong intList: {0}", sum);
                Console.ReadLine();
            }
        }
        public class bai2
        {
            private static IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", StandardID = 1 },
                new Student() { StudentId = 2, StudentName = "Moin", StandardID = 1 },
                new Student() { StudentId = 3, StudentName = "Bill", StandardID = 2 },
                new Student() { StudentId = 4, StudentName = "Ram" , StandardID = 2 },
                new Student() { StudentId = 5, StudentName = "Ron" }
            };

                    private static IList<Standard> standardList = new List<Standard>()
            {
                new Standard() { StandardID = 1, StandardName = "Tiêu chuẩn 1" },
                new Standard() { StandardID = 2, StandardName = "Tiêu chuẩn 2" },
                new Standard() { StandardID = 3, StandardName = "Tiêu chuẩn 3" },
            };

            public static void cn5()
            {
                var innerJoin = from d in studentList
                                join e in standardList
                                on d.StandardID equals e.StandardID
                                select new
                                {
                                    StudentsName = d.StudentName,
                                    StandardsName = e.StandardName,
                                };

                foreach (var inner in innerJoin)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(inner.StudentsName + " \t | \t" + inner.StandardsName);
                }

                Console.ReadLine();
            }

            public static void cn6()
            {
                var innerJoin = from d in studentList
                                join e in standardList
                                on d.StandardID equals e.StandardID
                                select new
                                {
                                    StudentsName = d.StudentName,
                                    StandardsName = e.StandardName,
                                };

                var result = from d in standardList
                             join e in studentList on d.StandardID equals e.StandardID into Hihi
                             select new
                             {
                                 Standards = d.StandardName,
                                 Students = from s in Hihi
                                            orderby s.StudentName
                                            select s
                             };

                int totalItems = 0;
                foreach (var Group in result)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(Group.Standards);
                    foreach (var item in Group.Students)
                    {
                        totalItems++;
                        Context.CenterWrite(17);
                        Console.WriteLine("    {0}", item.StudentName);
                        Context.CenterWrite(17);
                    }
                }

                Console.ReadLine();
            }
        }
        public class bai3
        {
            private List<int> little = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            private List<int> big = new List<int>() { 5, 6, 7, 8, 9, 10 };

            public static void cn7()
            {
                bai3 instance = new bai3();

                var MS = instance.little.Union(instance.big).ToList();

                var QS = (from num in instance.little
                          select num).Union(instance.big).ToList();

                foreach (var item in MS)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

            public static void cn8()
            {
                bai3 instance = new bai3();

                var MS2 = instance.little.Intersect(instance.big).ToList();

                var QS2 = (from num in instance.little
                           select num).Intersect(instance.big).ToList();

                foreach (var item in MS2)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

            public static void cn9()
            {
                bai3 instance = new bai3();

                var MS3 = instance.little.Concat(instance.big).ToList();

                var QS3 = (from num in instance.little
                           select num).Concat(instance.big).ToList();

                foreach (var item in MS3)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

            public static void cn10()
            {
                bai3 instance = new bai3();

                var MS4 = instance.little.Except(instance.big).ToList();

                var QS4 = (from num in instance.little
                           select num).Except(instance.big).ToList();

                foreach (var item in MS4)
                {
                    Context.CenterWrite(17);
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }


    }
}
