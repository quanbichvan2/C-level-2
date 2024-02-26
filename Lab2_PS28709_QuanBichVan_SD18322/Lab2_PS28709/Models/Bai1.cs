using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_PS28709.Models
{
    public class Bai1
    {
        // bài 1a
        public class ImplictlyVariable
        {
            static dynamic imp = 15;

            // Main method
            static public void Run()
            {
                // try to print the value of 'imp'
                Console.WriteLine(imp);
            }
        }
        public class RunDictionaryExample
        {
            public void Run()
            {
                var data = new Dictionary<string, int>();
                data.Add("cat", 2);
                data.Add("dog", 1);
                Console.WriteLine("cat - dog = {0}", data["cat"] - data["dog"]);
            }
        }

        public class RunDynamic
        {
            public void Run()
            {
                GetDetails(100);
                GetDetails("Welcome to Fpoly");
                GetDetails(true);
                GetDetails(20.50);
                //Console.ReadLine();
            }

            static void GetDetails(dynamic d)
            {
                Console.WriteLine(d);
            }
        }
        public class RunTestMethod
        {
            public void Run()
            {
                User dobj = new User();
                dobj.GetDetails(10);
            }
        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public void GetDetails(dynamic d)
            {
                Console.WriteLine(d);
            }
        }
    }
}
