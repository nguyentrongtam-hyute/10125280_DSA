using System;
namespace Buoi02_DanhSach
{
    class B18C4
    {
        class TrangThai
        {
            public string ten;
            public TrangThai prev;
            public TrangThai next;
        }
        class DonHang
        {
            public int ma;
            public string khach;
            public TrangThai trangThai;
            public DonHang tiep;
        }
        static TrangThai choXuLy, dangGiao, hoanThanh;
        static DonHang dsDon;
        static void TaoTrangThai()
        {
            choXuLy = new TrangThai();
            choXuLy.ten = "Chờ xử lý";
            dangGiao = new TrangThai();
            dangGiao.ten = "Đang giao";
            hoanThanh = new TrangThai();
            hoanThanh.ten = "Hoàn thành";
            choXuLy.next = dangGiao;
            dangGiao.prev = choXuLy;
            dangGiao.next = hoanThanh;
            hoanThanh.prev = dangGiao;
        }
        static void ThemDon(int ma, string khach)
        {
            DonHang moi = new DonHang();
            moi.ma = ma;
            moi.khach = khach;
            moi.trangThai = choXuLy;
            if (dsDon == null)
                dsDon = moi;
            else
            {
                DonHang p = dsDon;
                while (p.tiep != null)
                    p = p.tiep;
                p.tiep = moi;
            }
        }
        static DonHang TimDon(int ma)
        {
            DonHang p = dsDon;
            while (p != null && p.ma != ma)
                p = p.tiep;
            return p;
        }
        static void ChuyenTiep(DonHang d)
        {
            if (d.trangThai.next == null)
                Console.WriteLine("Đơn hàng đã hoàn thành");
            else
                d.trangThai = d.trangThai.next;
        }
        static void QuayLai(DonHang d)
        {
            if (d.trangThai.prev == null)
                Console.WriteLine("Đơn hàng đang ở trạng thái đầu");
            else
                d.trangThai = d.trangThai.prev;
        }
        static void InDon()
        {
            if (dsDon == null)
                Console.WriteLine("Chưa có đơn hàng");
            for (DonHang p = dsDon; p != null; p = p.tiep)
                Console.WriteLine("Đơn " + p.ma + " - " + p.khach + " - " + p.trangThai.ten);
        }
        public static void Run()
        {
            TaoTrangThai();
            dsDon = null;
            string chon;
            do
            {
                Console.WriteLine("\nQuản lý đơn hàng");
                InDon();
                Console.WriteLine("1. Thêm đơn hàng");
                Console.WriteLine("2. Chuyển sang trạng thái tiếp theo");
                Console.WriteLine("3. Quay lại trạng thái trước");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                {
                    Console.Write("Mã đơn: ");
                    int ma = int.Parse(Console.ReadLine());
                    Console.Write("Tên khách hàng: ");
                    ThemDon(ma, Console.ReadLine());
                }
                else if (chon == "2" || chon == "3")
                {
                    Console.Write("Mã đơn: ");
                    DonHang d = TimDon(int.Parse(Console.ReadLine()));
                    if (d == null)
                        Console.WriteLine("Không tìm thấy đơn hàng");
                    else if (chon == "2")
                        ChuyenTiep(d);
                    else
                        QuayLai(d);
                }
            } while (chon != "0");
        }
    }
}
