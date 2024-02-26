using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PS28709_QuanBichVan_SD18322.Models
{
    public class Separate
    {
        //Bài 3
        public partial class Bai3
        {
            public float Add(float a, float b) 
            {
                return a + b;
            }
            public float Sub(float a, float b)
            {
                return a - b;
            }
        }
        public partial class Bai3
        {
            public float Mul(float a, float b)
            {
                return a * b;
            }
            public float Div(float a, float b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0.");
                    return 0;
                }
                else
                {
                    return a / b;
                }
            }
        }
    }
}
