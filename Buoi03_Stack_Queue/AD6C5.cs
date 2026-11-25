using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD6C5
    {
        class KhachHang
        {
            public int stt;
            public string ten;
            public string dichVu;
            public DateTime denLuc;
        }
        static Queue<KhachHang> hangDoi;
        static KhachHang dangPhucVu;
        static int dem;
        static string[] dsDichVu = { "Gửi/Rút tiền", "Mở tài khoản", "Tư vấn" };
        static int GiayCho(KhachHang k)
        {
            return (int)(DateTime.Now - k.denLuc).TotalSeconds;
        }
        static void KhachDen()
        {
            Console.Write("Nhập tên khách hàng: ");
            string ten = Console.ReadLine();
            if (string.IsNullOrEmpty(ten))
            {
                Console.WriteLine("Tên khách hàng không được để trống");
                return;
            }
            Console.WriteLine("Loại dịch vụ: 1. " + dsDichVu[0] + "  2. " + dsDichVu[1] + "  3. " + dsDichVu[2]);
            Console.Write("Chọn loại dịch vụ (1-3): ");
            int dv = int.Parse(Console.ReadLine());
            if (dv < 1 || dv > 3)
            {
                Console.WriteLine("Loại dịch vụ không hợp lệ");
                return;
            }
            dem++;
            KhachHang k = new KhachHang();
            k.stt = dem;
            k.ten = ten;
            k.dichVu = dsDichVu[dv - 1];
            k.denLuc = DateTime.Now;
            hangDoi.Enqueue(k);
            Console.WriteLine("Khách hàng " + k.ten + " (số " + k.stt + ") đến lúc " + k.denLuc.ToString("HH:mm:ss") + ", được thêm vào cuối hàng đợi (phía trước còn " + (hangDoi.Count - 1) + " người)");
        }
        static void NhanVienRanh()
        {
            if (dangPhucVu != null)
            {
                Console.WriteLine("Đã phục vụ xong khách hàng " + dangPhucVu.ten + " (số " + dangPhucVu.stt + ")");
                dangPhucVu = null;
            }
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Nhân viên rảnh rỗi, không có khách hàng nào trong hàng đợi!");
                return;
            }
            dangPhucVu = hangDoi.Dequeue();
            Console.WriteLine("Nhân viên bắt đầu phục vụ: " + dangPhucVu.ten + " (số " + dangPhucVu.stt + ") - " + dangPhucVu.dichVu + " - đã chờ " + GiayCho(dangPhucVu) + " giây");
        }
        static void HienThi()
        {
            if (dangPhucVu != null)
                Console.WriteLine("Đang phục vụ: " + dangPhucVu.ten + " (số " + dangPhucVu.stt + ") - " + dangPhucVu.dichVu);
            else
                Console.WriteLine("Nhân viên đang rảnh");
            if (hangDoi.Count == 0)
            {
                Console.WriteLine("Hàng đợi rỗng");
                return;
            }
            Console.WriteLine("Khách hàng đang chờ (" + hangDoi.Count + " người):");
            int vt = 1;
            foreach (KhachHang k in hangDoi)
            {
                Console.WriteLine(vt + ". " + k.ten + " (số " + k.stt + ") - " + k.dichVu + " - đến lúc " + k.denLuc.ToString("HH:mm:ss") + " - chờ " + GiayCho(k) + " giây");
                vt++;
            }
        }
        public static void Run()
        {
            hangDoi = new Queue<KhachHang>();
            dangPhucVu = null;
            dem = 0;
            string chon;
            do
            {
                Console.WriteLine("\nQUẢN LÝ HÀNG ĐỢI TRUNG TÂM DỊCH VỤ KHÁCH HÀNG");
                Console.WriteLine("1. Khách hàng mới đến (Enqueue)");
                Console.WriteLine("2. Nhân viên rảnh - phục vụ khách tiếp theo (Dequeue)");
                Console.WriteLine("3. Hiển thị trạng thái hàng đợi");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                    KhachDen();
                else if (chon == "2")
                    NhanVienRanh();
                else if (chon == "3")
                    HienThi();
            } while (chon != "0" && chon != null);
        }
    }
}
