using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH8C5
    {
        class KhachHang
        {
            public int stt;
            public string ten;
            public string dichVu;
            public DateTime denLuc;
        }
        static Queue<KhachHang> hangDoi;
        static int dem;
        static string[] dsDichVu = { "Gửi/Rút tiền", "Mở tài khoản", "Tư vấn" };
        static int GiayCho(KhachHang k)
        {
            return (int)(DateTime.Now - k.denLuc).TotalSeconds;
        }
        static void ThemKhach()
        {
            Console.Write("Nhập tên (hoặc số thứ tự) khách hàng: ");
            string ten = Console.ReadLine();
            if (string.IsNullOrEmpty(ten))
            {
                Console.WriteLine("Tên khách hàng không được để trống");
                return;
            }
            Console.WriteLine("Dịch vụ: 1. " + dsDichVu[0] + "  2. " + dsDichVu[1] + "  3. " + dsDichVu[2]);
            Console.Write("Chọn dịch vụ (1-3): ");
            int dv = int.Parse(Console.ReadLine());
            if (dv < 1 || dv > 3)
            {
                Console.WriteLine("Dịch vụ không hợp lệ");
                return;
            }
            dem++;
            KhachHang k = new KhachHang();
            k.stt = dem;
            k.ten = ten;
            k.dichVu = dsDichVu[dv - 1];
            k.denLuc = DateTime.Now;
            hangDoi.Enqueue(k);
            Console.WriteLine("Đã thêm khách hàng " + k.ten + " (số " + k.stt + "), phía trước còn " + (hangDoi.Count - 1) + " người");
        }
        static void PhucVu()
        {
            if (hangDoi.Count > 0)
            {
                KhachHang k = hangDoi.Dequeue();
                Console.WriteLine("Đang phục vụ khách hàng: " + k.ten + " (số " + k.stt + ") - " + k.dichVu + " - đã chờ " + GiayCho(k) + " giây");
            }
            else
                Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
        }
        static void HienThi()
        {
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Hàng đợi rỗng");
                return;
            }
            Console.WriteLine("Khách hàng đang chờ (" + hangDoi.Count + " người):");
            int vt = 1;
            foreach (KhachHang k in hangDoi)
            {
                Console.WriteLine(vt + ". " + k.ten + " (số " + k.stt + ") - " + k.dichVu + " - chờ " + GiayCho(k) + " giây");
                vt++;
            }
        }
        public static void Run()
        {
            hangDoi = new Queue<KhachHang>();
            dem = 0;
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG DỊCH VỤ KHÁCH HÀNG");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                    ThemKhach();
                else if (chon == "2")
                    PhucVu();
                else if (chon == "3")
                    HienThi();
            } while (chon != "0" && chon != null);
        }
    }
}
