using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD2C5
    {
        static Stack<string> stackBack;
        static Stack<string> stackForward;
        static string trangHienTai;
        static void TruyCap(string url)
        {
            stackBack.Push(trangHienTai);
            trangHienTai = url;
            stackForward.Clear();
            Console.WriteLine("Đã truy cập: " + trangHienTai);
        }
        static void Back()
        {
            if (stackBack.Count == 0)
                Console.WriteLine("Không thể quay lại");
            else
            {
                stackForward.Push(trangHienTai);
                trangHienTai = stackBack.Pop();
                Console.WriteLine("Quay lại: " + trangHienTai);
            }
        }
        static void Forward()
        {
            if (stackForward.Count == 0)
                Console.WriteLine("Không thể tiến lên");
            else
            {
                stackBack.Push(trangHienTai);
                trangHienTai = stackForward.Pop();
                Console.WriteLine("Tiến lên: " + trangHienTai);
            }
        }
        static void HienThi()
        {
            Console.WriteLine("Trang hiện tại: " + trangHienTai);
            Console.Write("Stack Back (đỉnh -> đáy): ");
            if (stackBack.Count == 0)
                Console.Write("(rỗng)");
            foreach (string s in stackBack)
                Console.Write(s + "  ");
            Console.WriteLine();
            Console.Write("Stack Forward (đỉnh -> đáy): ");
            if (stackForward.Count == 0)
                Console.Write("(rỗng)");
            foreach (string s in stackForward)
                Console.Write(s + "  ");
            Console.WriteLine();
        }
        public static void Run()
        {
            stackBack = new Stack<string>();
            stackForward = new Stack<string>();
            trangHienTai = "trang-chu";
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG LỊCH SỬ DUYỆT WEB");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Quay lại");
                Console.WriteLine("3. Tiến lên");
                Console.WriteLine("4. Hiển thị trang hiện tại và hai Stack");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                {
                    Console.Write("Nhập URL: ");
                    string url = Console.ReadLine();
                    if (string.IsNullOrEmpty(url))
                        Console.WriteLine("URL không được để trống");
                    else
                        TruyCap(url);
                }
                else if (chon == "2")
                    Back();
                else if (chon == "3")
                    Forward();
                else if (chon == "4")
                    HienThi();
            } while (chon != "0" && chon != null);
        }
    }
}
