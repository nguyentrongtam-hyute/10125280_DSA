using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH7C5
    {
        class GoiTin
        {
            public int stt;
            public string noiDung;
        }
        static Queue<GoiTin> duongTruyen;
        static int dem;
        static void GuiDuLieu()
        {
            Console.Write("Nhập gói dữ liệu: ");
            string nd = Console.ReadLine();
            if (string.IsNullOrEmpty(nd))
                Console.WriteLine("Gói dữ liệu không được để trống");
            else
            {
                dem++;
                GoiTin g = new GoiTin();
                g.stt = dem;
                g.noiDung = nd;
                duongTruyen.Enqueue(g);
                Console.WriteLine("Đã gửi gói #" + g.stt + ": " + g.noiDung);
            }
        }
        static void NhanDuLieu()
        {
            if (duongTruyen.Count > 0)
            {
                GoiTin g = duongTruyen.Dequeue();
                Console.WriteLine("Đã nhận gói #" + g.stt + ": " + g.noiDung);
            }
            else
                Console.WriteLine("Không có dữ liệu để nhận!");
        }
        static void HienThi()
        {
            if (duongTruyen.Count == 0)
            {
                Console.WriteLine("Hàng đợi rỗng");
                return;
            }
            Console.WriteLine("Các gói dữ liệu trong hàng đợi:");
            foreach (GoiTin g in duongTruyen)
                Console.WriteLine("Gói #" + g.stt + ": " + g.noiDung);
        }
        public static void Run()
        {
            duongTruyen = new Queue<GoiTin>();
            dem = 0;
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU");
                Console.WriteLine("1. Gửi dữ liệu");
                Console.WriteLine("2. Nhận dữ liệu");
                Console.WriteLine("3. Hiển thị dữ liệu trong hàng đợi");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                    GuiDuLieu();
                else if (chon == "2")
                    NhanDuLieu();
                else if (chon == "3")
                    HienThi();
            } while (chon != "0" && chon != null);
        }
    }
}
