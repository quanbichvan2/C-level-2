using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_PS28709.Models
{
    public class Bai2
    {
        public class UserInfoExample
        {
            public void Run()
            {
                var UserInfor = new
                {
                    Id = 1,
                    Name = "QuanBichVan",
                    IsActive = true
                };
                Console.WriteLine("Id: " + UserInfor.Id);
                Console.WriteLine("Name: " + UserInfor.Name);
                Console.WriteLine("IsActive: " + UserInfor.IsActive);
                //Console.ReadLine();
            }
        }
        public class UserInfoExampleVer2
        {
            public void Run()
            {
                // Create Nested anonymous type object
                var user = new
                {
                    Id = 1,
                    Name = "VanQuan",
                    IsActive = true,
                    jobInfo = new { Designation = "Lead", Location = "Hyderabad" }
                };

                // Access anonymous type object properties
                Console.WriteLine("Id: " + user.Id);
                Console.WriteLine("Name: " + user.Name);
                Console.WriteLine("IsActive: " + user.IsActive);
                Console.WriteLine("Designation: {0}, Location: {1}", user.jobInfo.Designation, user.jobInfo.Location);
                //Console.ReadLine();
            }
        }
        public class MathDelegateExample
        {
            public delegate void MathOps(int a);
            public void MathOperationsExample()
            {
                int y = 10;
                //instantiate the delegate using an anonymous method
                MathOps ops = (int x) =>
                {
                    Console.WriteLine("Add result: {0}", x + y);
                    Console.WriteLine("Subtract result: {0}", x - y);
                };
                ops(90);
                //Console.ReadLine();
            }
        }
    }
}
