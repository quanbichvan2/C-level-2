using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.UI
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
                    ||  1. Tìm số chẵn đầu tiên trong intList           ||
                    ||  2. Tìm p/tử cuối trong intList có giá trị > 200 ||
                    ||  3. Tìm p/tử đầu trong strList có ký tự đầu: “T” ||
                    ||  4. Tính tổng gtri tại vị trí lẻ trong intList   ||
                    ||  5. Sử dụng Join Query viết chương trình         ||
                    ||  6. Sử dụng GroupJoin viết chương trình          ||
                    ||  7. Sử dụng Union để xuất ra: 012345678910       ||
                    ||  8. Sử dụng Intersect để xuất ra: 56             ||
                    ||  9. Sử dụng Concat để xuất ra: 01234565678910    ||
                    ||  10. Sử dụng Except để xuất ra: 01234            ||
                    ||__________________________________________________||
                    ||        0. Thoát chương trình                     ||
                    [[==================================================]]"
            ;
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
