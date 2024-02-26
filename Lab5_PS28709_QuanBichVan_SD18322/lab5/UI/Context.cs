using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.UI
{
    public class Context
    {
        public static int width = 55;
        //Đây là hàm làm UI cho cái Menu
        public static int Menu()
        {
            //Xóa màn hình, nó giống  system("cls") trong C . Tìm hiểu thêm ở MS-DOS command for clear the screen
            Console.Clear();
            //Console.ForegroundColor là một thuộc tính của lớp Console được sử dụng để đặt màu chữ hiển thị trên màn hình console.
            // Tổng có 16 màu khác nhau để lựa chọn, bao gồm: Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, và White.
            Console.ForegroundColor = ConsoleColor.Green;
            //cách xử lý chuỗi định dạng (verbatim string), hiểu đơn giản là mọi dấu xuống dòng và các ký tự đặc biệt khác được giữ nguyên trong chuỗi
            string menu = @"
                    [[==================================================]]
                    ||   _   .-')       ('-.       .-') _               ||    
                    ||  ( '.( OO )_   _(  OO)     ( OO ) )              ||
                    ||   ,--.   ,--.)(,------.,--./ ,--,' ,--. ,--.     ||
                    ||   |   `.'   |  |  .---'|   \ |  |\ |  | |  |     ||
                    ||   |         |  |  |    |    \|  | )|  | | .-')   ||
                    ||   |  |'.'|  | (|  '--. |  .     |/ |  |_|( OO )  ||
                    ||   |  |   |  |  |  .--' |  |\    |  |  | | `-' /  ||
                    ||   |  |   |  |  |  `---.|  | \   | ('  '-'(_.-'   ||
                    ||   `--'   `--'  `------'`--'  `--'   `-----'      ||
                    ||--------------------------------------------------||
                    ||  1. Xuất ra ds người có Address là “Ha Noi”      ||
                    ||  2. Tìm người có Age lớn nhất                    ||
                    ||  3. check ds contacts có bao nhiêu người?        ||
                    ||  4. Sort ds contacts theo đô tuổi tăng dần       ||
                    ||  5. Sort ds contacts theo đô tuổi và Họ giảm dần ||
                    ||  6. In ds người có họ băt đầu bằng ký tự “B”     ||
                    ||  7. Dùng LINQ ToLookup() Operator chuyển ds      ||
                    ||     List<Contact> về định dạng kiểu key/ value và||
                    ||     xuất toàn bộ thông tin ra màn hình           ||
                    ||__________________________________________________||
                    ||        0. Thoát chương trình                     ||
                    [[==================================================]]";
            Console.WriteLine(menu);
            //Nếu muốn đặt lại về màu mặc định hoặc thay đổi sang bảng màu khác dùng : Console.ResetColor();
            Console.ResetColor();
            CenterWrite(17);
            Console.Write("Nhập: ");
            int choices = Convert.ToInt32(Console.ReadLine());
            return choices;
        }
        public static void EndingProgram()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;//Đổi màu
            string text = @"    
                    [[==================================================]]
                    ||     (     (                                      ||
                    ||     )\ )  )\ )  *   )                 (          ||
                    ||    (()/( (()/(` )  /(                 )\ (       ||
                    ||     /(_)) /(_))( )(_))___ `  )    (  ((_))\ )    ||
                    ||    (_))_|(_)) (_(_())|___|/(/(    )\  _ (()/(    ||
                    ||    | |_  | _ \|_   _|    ((_)_\  ((_)| | )(_))   ||
                    ||    | __| |  _/  | |      | '_ \)/ _ \| || || |   ||
                    ||    |_|   |_|    |_|      | .__/ \___/|_| \_, |   ||
                    ||                          |_|             |__/    ||
                    [[==================================================]]";
            Console.WriteLine(text);
            Console.ResetColor();
            Notification();
        }
        public static void Notification()
        {
            Console.SetCursorPosition((width + 10) / 2, Console.CursorTop); //32 là độ dài chuỗi "Nhấn bất kì phím nào để tiếp tục"
            //đoạn CursorTop là: di chuyển tọa độ của con trỏ đến vị trí chính xác bằng việc thiêt lập thuộc tính cursorTop
            Console.Write("Nhấn bất kì phím nào để tiếp tục");
            Console.ReadKey();
        }
        public static void NotificationError()
        {
            Console.SetCursorPosition((width - 13) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Lỗi nhập liệu");
            Notification();
        }
        public static void CenterWrite(int x)
        {
            Console.SetCursorPosition((width - x) / 2, Console.CursorTop);//Di chuyển vị trí con trỏ chuột

        }
    }
}
