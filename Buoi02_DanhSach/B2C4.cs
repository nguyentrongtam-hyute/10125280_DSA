using System;
namespace Buoi02_DanhSach
{
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }
    class B2C4
    {
        static NhanVien[] DS;
        static void Nhap()
        {
            Console.Write("Số nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            DS = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhân viên thứ " + (i + 1));
                Console.Write("Mã NV: ");
                DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ tên: ");
                DS[i].Hoten = Console.ReadLine();
                Console.Write("Năm sinh: ");
                DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: ");
                DS[i].Phongban = Console.ReadLine();
                Console.Write("Lương cơ bản: ");
                DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: ");
                DS[i].Thuong = int.Parse(Console.ReadLine());
            }
        }
        static int thuclinh(int x)
        {
            return DS[x].LuongCB + DS[x].Thuong;
        }
        static void InNV(NhanVien v)
        {
            Console.WriteLine("{0,-8}{1,-22}{2,-10}{3,-14}{4,-12}{5,-10}{6,-12}", v.MaNV, v.Hoten, v.Namsinh, v.Phongban, v.LuongCB, v.Thuong, v.LuongCB + v.Thuong);
        }
        static void InDS(NhanVien[] ds)
        {
            Console.WriteLine("{0,-8}{1,-22}{2,-10}{3,-14}{4,-12}{5,-10}{6,-12}", "Mã NV", "Họ tên", "Năm sinh", "Phòng ban", "Lương CB", "Thưởng", "Thực lĩnh");
            for (int i = 0; i < ds.Length; i++)
                InNV(ds[i]);
        }
        static long TongThucLinh()
        {
            long tong = 0;
            for (int i = 0; i < DS.Length; i++)
                tong += thuclinh(i);
            return tong;
        }
        static void LuongThapNhat()
        {
            int min = int.MaxValue;
            for (int i = 0; i < DS.Length; i++)
                if (min > DS[i].LuongCB)
                    min = DS[i].LuongCB;
            for (int i = 0; i < DS.Length; i++)
                if (DS[i].LuongCB == min)
                    InNV(DS[i]);
        }
        static int DemThuong()
        {
            int dem = 0;
            for (int i = 0; i < DS.Length; i++)
                if (DS[i].Thuong >= 1200000)
                    dem++;
            return dem;
        }
        static bool PhaiDoiCho(NhanVien x, NhanVien y)
        {
            int c = string.Compare(x.Phongban, y.Phongban);
            if (c != 0)
                return c > 0;
            return string.Compare(x.MaNV, y.MaNV) < 0;
        }
        static void SapXep()
        {
            NhanVien[] b = (NhanVien[])DS.Clone();
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = i + 1; j < b.Length; j++)
                    if (PhaiDoiCho(b[i], b[j]))
                    {
                        NhanVien t = b[i];
                        b[i] = b[j];
                        b[j] = t;
                    }
            InDS(b);
        }
        static void TangLuong()
        {
            for (int i = 0; i < DS.Length; i++)
                DS[i].LuongCB = (int)(DS[i].LuongCB * 105L / 100);
        }
        public static void Run()
        {
            Nhap();
            string chon;
            do
            {
                Console.WriteLine("\nBài tập 2");
                Console.WriteLine("1. Tổng thực lĩnh tháng của công ty");
                Console.WriteLine("2. In nhân viên có lương cơ bản thấp nhất");
                Console.WriteLine("3. Đếm nhân viên có thưởng >= 1200000");
                Console.WriteLine("4. In danh sách sắp xếp theo phòng ban, mã NV");
                Console.WriteLine("5. Tăng lương 5% cho tất cả nhân viên");
                Console.WriteLine("6. In toàn bộ danh sách");
                Console.WriteLine("0. Quay lại");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Tổng thực lĩnh: " + TongThucLinh());
                        break;
                    case "2":
                        LuongThapNhat();
                        break;
                    case "3":
                        Console.WriteLine("Số nhân viên: " + DemThuong());
                        break;
                    case "4":
                        SapXep();
                        break;
                    case "5":
                        TangLuong();
                        InDS(DS);
                        break;
                    case "6":
                        InDS(DS);
                        break;
                }
            } while (chon != "0");
        }
    }
}
