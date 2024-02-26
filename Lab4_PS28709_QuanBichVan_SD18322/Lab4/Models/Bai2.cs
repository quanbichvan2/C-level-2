using Lab4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Bai2
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        List<Dog> dogs = new List<Dog>()
        {
            new Dog{Name = "Rex", Age = 4},
            new Dog{Name ="Sean",Age = 0},
            new Dog{Name ="Stacy",Age = 3 }
        };
        public void XuatThongTin()
        {
             // Xuất thông tin Name và Age của danh sách dogs (dùng phương thức Select)
            var dogInfors = dogs.Select(dog => new { dog.Name, dog.Age });
            /*
            khởi tạo biến dogInfors kiểu dữ liệu var , sử dụng phương thức Select gọi biến dogs của list <Dog> và dùng biểu thức lambda
            để chọn ra thông tin tên (name) và tuổi (age) trong ds Dogs
            Kết quả là một IEnumerable (duyệt từng phần tử thôi) của các đối tượng với các thuộc tính Name và Age. 
             */
            
            foreach (var dogInfor in dogInfors) 
            {
                Context.CenterWrite(-32);
                Console.WriteLine($"Name: {dogInfor.Name},Age: {dogInfor.Age}");
                //Sau đó, chúng ta duyệt qua danh sách mới này và xuất thông tin.
            }
        }
        // Sắp xếp lại danh sách dogs theo thứ tự giảm dần Age (dùng phương thức OrderByDescending)
        public void Sort()
        {
            var sortDogs = dogs.OrderByDescending(dog => dog.Age);
            Context.CenterWrite(-32);
            Console.WriteLine("Sắp xếp tuổi chó giảm dần");
            foreach (var dog in sortDogs)
            {
                Context.CenterWrite(-32);
                Console.WriteLine($"Name: {dog.Name},Age: {dog.Age}");
            }
        }
    }
}
