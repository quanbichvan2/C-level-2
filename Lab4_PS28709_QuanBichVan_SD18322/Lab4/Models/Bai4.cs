using Lab4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Bai4
    {
        public void LINQMixSyntax()
        {
            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            //Linq query using Mix Syntax
            var MethodSyntax = (from obj in integerList where obj > 5 select obj).Sum();
            //Execution
            Context.CenterWrite(-32);
            Console.WriteLine("Sum is: "+ MethodSyntax);
            Console.ReadKey();
        }
    }
}
