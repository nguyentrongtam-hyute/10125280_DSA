using System;
namespace Buoi02_DanhSach
{
    class B4C4
    {
        class Nut
        {
            public int info;
            public Nut link;
        }
        static Nut pHead;
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
                if (pHead == null)
                    pHead = moi;
                else
                    cuoi.link = moi;
                cuoi = moi;
            }
        }
        static void InDS()
        {
            Nut p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        static int DemX(int x)
        {
            int d = 0;
            Nut p = pHead;
            while (p != null)
            {
                if (p.info == x)
                    d = d + 1;
                p = p.link;
            }
            return d;
        }
        static int DuongNhoNhat()
        {
            int minduong = int.MaxValue;
            Nut p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minduong)
                    minduong = p.info;
                p = p.link;
            }
            return minduong;
        }
        static void XoaX(int x)
        {
            Nut p = pHead;
            Nut t = null;
            while (p != null && p.info != x)
            {
                t = p;
                p = p.link;
            }
            if (p == null)
                Console.WriteLine("Không tìm thấy " + x);
            else if (p == pHead)
                pHead = p.link;
            else
                t.link = p.link;
        }
        public static void Run()
        {
            pHead = null;
            TaoDS();
            InDS();
            Console.Write("Nhập x để đếm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("a. Số phần tử bằng " + x + ": " + DemX(x));
            int m = DuongNhoNhat();
            if (m == int.MaxValue)
                Console.WriteLine("b. Không có phần tử dương");
            else
                Console.WriteLine("b. Phần tử dương nhỏ nhất: " + m);
            Console.Write("Nhập x cần xóa: ");
            x = int.Parse(Console.ReadLine());
            XoaX(x);
            Console.WriteLine("c. Danh sách sau khi xóa:");
            InDS();
        }
    }
}
