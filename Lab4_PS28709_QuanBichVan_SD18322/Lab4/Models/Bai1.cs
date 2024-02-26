using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab4.UI;
namespace Lab4.Models
{
    public class Bai1
    {
        //cách 1
        public class LambdaExpressions
        {
            public void Lambda()
            {
                
                //Sử dụng Lambda Expressions viết chương trình xuất ra màn hình các số chẵn trong một danh sách các số nguyên cho sẵn.
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
                List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                Context.CenterWrite(-32);
                foreach (int x in evenNumbers)
                {
                    Console.Write("{0} \t", x);
                }
                Console.WriteLine();
                
            }
            //cách 2
            public void Lambda2()
            {
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
                List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                Context.CenterWrite(-32);
                foreach (int x in evenNumbers)
                {
                    Console.Write("{0} \t", x);
                }
                Console.WriteLine();
            }
        }
    }
}
