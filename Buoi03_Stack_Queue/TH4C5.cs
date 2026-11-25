using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH4C5
    {
        static Stack<string> backStack;
        static Stack<string> forwardStack;
        static string currentPage;
        static void Visit(string url)
        {
            if (currentPage != null)
                backStack.Push(currentPage);
            currentPage = url;
            forwardStack.Clear();
            Console.WriteLine("Đang truy cập: " + currentPage);
        }
        static void Back()
        {
            if (backStack.Count == 0)
                Console.WriteLine("Không thể quay lại");
            else
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
                Console.WriteLine("Quay lại: " + currentPage);
            }
        }
        static void Forward()
        {
            if (forwardStack.Count == 0)
                Console.WriteLine("Không thể tiến lên");
            else
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                Console.WriteLine("Tiến lên: " + currentPage);
            }
        }
        static void ShowCurrentPage()
        {
            if (currentPage == null)
                Console.WriteLine("Chưa truy cập trang nào");
            else
                Console.WriteLine("Trang hiện tại: " + currentPage);
        }
        public static void Run()
        {
            backStack = new Stack<string>();
            forwardStack = new Stack<string>();
            currentPage = null;
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Quay lại");
                Console.WriteLine("3. Tiến lên");
                Console.WriteLine("4. Hiển thị trang hiện tại");
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
                        Visit(url);
                }
                else if (chon == "2")
                    Back();
                else if (chon == "3")
                    Forward();
                else if (chon == "4")
                    ShowCurrentPage();
            } while (chon != "0" && chon != null);
        }
    }
}
