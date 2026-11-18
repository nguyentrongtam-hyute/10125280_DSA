using System;
namespace Buoi02_DanhSach
{
    class B5C4
    {
        class Nut
        {
            public int info;
            public Nut link;
        }
        static Nut l;
        static void TaoDS()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            Nut cuoi = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
                Nut moi = new Nut();
                moi.info = int.Parse(Console.ReadLine());
                moi.link = null;
                if (l == null)
                    l = moi;
                else
                    cuoi.link = moi;
                cuoi = moi;
            }
        }
        static int Max()
        {
            int max = int.MinValue;
            for (Nut p = l; p != null; p = p.link)
                if (p.info > max)
                    max = p.info;
            return max;
        }
        static int Tong()
        {
            int t = 0;
            for (Nut p = l; p != null; p = p.link)
                t += p.info;
            return t;
        }
        static bool KTNT(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static int DemNguyenTo()
        {
            int dem = 0;
            for (Nut p = l; p != null; p = p.link)
                if (KTNT(p.info))
                    dem++;
            return dem;
        }
        static void DemAmDuongKhong(out int am, out int duong, out int khong)
        {
            am = 0;
            duong = 0;
            khong = 0;
            for (Nut p = l; p != null; p = p.link)
            {
                if (p.info < 0)
                    am++;
                else if (p.info > 0)
                    duong++;
                else
                    khong++;
            }
        }
        static int DemX(int x)
        {
            int dem = 0;
            for (Nut p = l; p != null; p = p.link)
                if (p.info == x)
                    dem++;
            return dem;
        }
        static int DuongNhoNhat()
        {
            int minduong = int.MaxValue;
            for (Nut p = l; p != null; p = p.link)
                if (p.info > 0 && p.info < minduong)
                    minduong = p.info;
            return minduong;
        }
        public static void Run()
        {
            l = null;
            TaoDS();
            if (l == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Console.WriteLine("a. Phần tử lớn nhất: " + Max());
            Console.WriteLine("b. Tổng các phần tử: " + Tong());
            Console.WriteLine("c. Số lượng số nguyên tố: " + DemNguyenTo());
            int am, duong, khong;
            DemAmDuongKhong(out am, out duong, out khong);
            Console.WriteLine("d. Số âm: " + am + ", số dương: " + duong + ", số 0: " + khong);
            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("e. Số phần tử bằng " + x + ": " + DemX(x));
            int m = DuongNhoNhat();
            if (m == int.MaxValue)
                Console.WriteLine("f. Không có phần tử dương");
            else
                Console.WriteLine("f. Phần tử dương nhỏ nhất: " + m);
        }
    }
}
