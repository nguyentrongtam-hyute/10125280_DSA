using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD5C5
    {
        class GoiTin
        {
            public int stt;
            public string noiDung;
            public int doTre;
            public bool loi;
        }
        static Queue<GoiTin> duongTruyen;
        static int dem, soNhan, soMat, tongTre;
        static void GuiGoi()
        {
            Console.Write("Nhập nội dung gói tin: ");
            string nd = Console.ReadLine();
            if (string.IsNullOrEmpty(nd))
            {
                Console.WriteLine("Nội dung gói tin không được để trống");
                return;
            }
            Console.Write("Nhập độ trễ đường truyền (ms): ");
            int tre = int.Parse(Console.ReadLine());
            if (tre < 0)
            {
                Console.WriteLine("Độ trễ không được âm");
                return;
            }
            Console.Write("Gói tin bị lỗi đường truyền? (c/k): ");
            string l = Console.ReadLine();
            dem++;
            GoiTin g = new GoiTin();
            g.stt = dem;
            g.noiDung = nd;
            g.doTre = tre;
            g.loi = (l == "c" || l == "C");
            duongTruyen.Enqueue(g);
            Console.WriteLine("Đã gửi gói tin #" + g.stt + ": " + g.noiDung);
        }
        static void NhanGoi()
        {
            if (duongTruyen.Count == 0)
            {
                Console.WriteLine("Không có gói tin nào để xử lý!");
                return;
            }
            GoiTin g = duongTruyen.Dequeue();
            if (g.loi)
            {
                soMat++;
                Console.WriteLine("Gói tin #" + g.stt + " (" + g.noiDung + ") bị lỗi đường truyền, bị loại bỏ");
            }
            else
            {
                soNhan++;
                tongTre += g.doTre;
                Console.WriteLine("Đã nhận gói tin #" + g.stt + ": " + g.noiDung + " (độ trễ " + g.doTre + " ms)");
            }
        }
        static void HienThi()
        {
            if (duongTruyen.Count == 0)
            {
                Console.WriteLine("Đường truyền trống");
                return;
            }
            Console.WriteLine("Các gói tin đang chờ trên đường truyền:");
            foreach (GoiTin g in duongTruyen)
                Console.WriteLine("Gói #" + g.stt + ": " + g.noiDung + " - trễ " + g.doTre + " ms" + (g.loi ? " - có lỗi" : ""));
        }
        static void ThongKe()
        {
            Console.WriteLine("Đã gửi: " + dem + " gói, đã nhận: " + soNhan + " gói, bị mất: " + soMat + " gói, đang chờ: " + duongTruyen.Count + " gói");
            if (soNhan > 0)
                Console.WriteLine("Độ trễ trung bình của các gói đã nhận: " + (tongTre / (double)soNhan).ToString(System.Globalization.CultureInfo.InvariantCulture) + " ms");
        }
        public static void Run()
        {
            duongTruyen = new Queue<GoiTin>();
            dem = soNhan = soMat = tongTre = 0;
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU");
                Console.WriteLine("1. Gửi gói tin (Enqueue)");
                Console.WriteLine("2. Xử lý gói tin ở đầu hàng đợi (Dequeue)");
                Console.WriteLine("3. Hiển thị các gói tin đang chờ");
                Console.WriteLine("4. Thống kê đường truyền");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                    GuiGoi();
                else if (chon == "2")
                    NhanGoi();
                else if (chon == "3")
                    HienThi();
                else if (chon == "4")
                    ThongKe();
            } while (chon != "0" && chon != null);
        }
    }
}
