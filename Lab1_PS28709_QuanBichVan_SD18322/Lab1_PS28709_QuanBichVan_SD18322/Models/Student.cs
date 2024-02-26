using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PS28709_QuanBichVan_SD18322.Models
{
    public class Student
    {
        public string StudentName;
        public string Course;
        public void SetStudentDetails(string StuName, string Course)
        {
            this.StudentName = StuName;
            this.Course = Course;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
        }


        public static string CollegeName = "FPT PolyTechnic";
        public static string CollegeAddress = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh";


        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
    }
}
