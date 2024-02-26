using Lab4.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Bai3
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }
        IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentId = 1, StudentName = "John", Age = 13 },
            new Student() { StudentId = 2, StudentName = "Moin", Age = 21 },
            new Student() { StudentId = 3, StudentName = "Bill", Age = 18 },
            new Student() { StudentId = 4, StudentName = "Ram", Age = 20 },
            new Student() { StudentId = 5, StudentName = "Ron", Age = 15 }
        };
        // Xuất ra màn hình các student có Age > 12 và Age<20 bằng cách dùng LINQ Query Syntax và LINQ Method Syntax
        public void InThongTin()
        {
            var queryResult = from Student in studentList
                              where Student.Age > 12 && Student.Age < 20
                              select Student;
            Context.CenterWrite(-5);
            Console.WriteLine("Các học viên có tuổi từ 12 ~> 20 (dùng Query):");
            foreach(var student in queryResult)
            {
                Context.CenterWrite(12);
                Console.WriteLine($"Student ID: {student.StudentId} ,Student Name: {student.StudentName} ,Student Age: {student.Age}");
            }
        }
        // Xuất ra màn hình các student có Age > 12 và Age <20 bằng cách dùng LINQ Method Syntax
        public void XuatThongTinLINQ()
        {
            var methodResult = studentList.Where(student => student.Age >12 && student.Age < 20);
            Context.CenterWrite(-5);
            Console.WriteLine("Các học viên có tuổi từ 12 ~> 20 (dùng LINQ): ");
            foreach(var student in methodResult)
            {
                Context.CenterWrite(12);
                Console.WriteLine($"Student ID: {student.StudentId} ,Student Name: {student.StudentName} ,Student Age: {student.Age}");
            }
        }
    }
}
