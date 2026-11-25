using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH6C5
    {
        static Queue<string> hangDoi;
        static void ThemYeuCau()
        {
            Console.Write("Nhập tên tài liệu: ");
            string ten = Console.ReadLine();
            if (string.IsNullOrEmpty(ten))
                Console.WriteLine("Tên tài liệu không được để trống");
            else
            {
                hangDoi.Enqueue(ten);
                Console.WriteLine("Đã thêm vào hàng đợi: " + ten);
            }
        }
        static void XuLyYeuCau()
        {
            if (hangDoi.Count > 0)
                Console.WriteLine("Đang in: " + hangDoi.Dequeue());
            else
                Console.WriteLine("Không có yêu cầu in nào!");
        }
        static void HienThi()
        {
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Hàng đợi rỗng");
                return;
            }
            Console.WriteLine("Danh sách hàng đợi:");
            int stt = 1;
            foreach (string t in hangDoi)
            {
                Console.WriteLine(stt + ". " + t);
                stt++;
            }
        }
        public static void Run()
        {
            hangDoi = new Queue<string>();
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG HỆ THỐNG IN");
                Console.WriteLine("1. Thêm yêu cầu in");
                Console.WriteLine("2. Xử lý yêu cầu in");
                Console.WriteLine("3. Hiển thị danh sách hàng đợi");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                    ThemYeuCau();
                else if (chon == "2")
                    XuLyYeuCau();
                else if (chon == "3")
                    HienThi();
            } while (chon != "0" && chon != null);
        }
    }
}
