using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD4C5
    {
        class YeuCauIn
        {
            public int stt;
            public string tenTaiLieu;
            public int soTrang;
        }
        static Queue<YeuCauIn> hangDoi;
        static int dem;
        static void ThemYeuCau()
        {
            Console.Write("Nhập tên tài liệu: ");
            string ten = Console.ReadLine();
            if (string.IsNullOrEmpty(ten))
            {
                Console.WriteLine("Tên tài liệu không được để trống");
                return;
            }
            Console.Write("Nhập số trang: ");
            int soTrang = int.Parse(Console.ReadLine());
            if (soTrang <= 0)
            {
                Console.WriteLine("Số trang phải lớn hơn 0");
                return;
            }
            dem++;
            YeuCauIn y = new YeuCauIn();
            y.stt = dem;
            y.tenTaiLieu = ten;
            y.soTrang = soTrang;
            hangDoi.Enqueue(y);
            Console.WriteLine("Đã thêm yêu cầu in #" + y.stt + ": " + y.tenTaiLieu + " (" + y.soTrang + " trang)");
        }
        static void XuLyYeuCau()
        {
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Không có yêu cầu in nào!");
                return;
            }
            YeuCauIn y = hangDoi.Dequeue();
            Console.WriteLine("Đang in yêu cầu #" + y.stt + ": " + y.tenTaiLieu + " (" + y.soTrang + " trang)");
            Console.WriteLine("Còn lại " + hangDoi.Count + " yêu cầu trong hàng đợi");
        }
        static void HienThi()
        {
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Hàng đợi rỗng");
                return;
            }
            Console.WriteLine("Danh sách yêu cầu in đang chờ (theo thứ tự FIFO):");
            int tong = 0;
            foreach (YeuCauIn y in hangDoi)
            {
                Console.WriteLine("#" + y.stt + ". " + y.tenTaiLieu + " - " + y.soTrang + " trang");
                tong += y.soTrang;
            }
            Console.WriteLine("Tổng cộng: " + hangDoi.Count + " yêu cầu, " + tong + " trang");
        }
        public static void Run()
        {
            hangDoi = new Queue<YeuCauIn>();
            dem = 0;
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG HỆ THỐNG IN ẤN (FIFO)");
                Console.WriteLine("1. Thêm yêu cầu in (Enqueue)");
                Console.WriteLine("2. Xử lý yêu cầu in (Dequeue)");
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
