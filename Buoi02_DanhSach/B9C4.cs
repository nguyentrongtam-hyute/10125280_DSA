using System;
using System.Collections.Generic;
namespace Buoi02_DanhSach
{
    class B9C4
    {
        static bool LaNguyenTo(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static bool LaHoanHao(int x)
        {
            if (x < 2)
                return false;
            int tong = 0;
            for (int i = 1; i <= x / 2; i++)
                if (x % i == 0)
                    tong += i;
            return tong == x;
        }
        static void In(string ten, List<int> ds)
        {
            Console.Write(ten + " (" + ds.Count + "): ");
            foreach (int x in ds)
                Console.Write(x + " ");
            Console.WriteLine();
        }
        public static void Run()
        {
            Console.Write("Nhập số lượng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            List<int> nguyenTo = new List<int>();
            List<int> chan = new List<int>();
            List<int> hoanHao = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (LaNguyenTo(a[i]))
                    nguyenTo.Add(a[i]);
                if (a[i] % 2 == 0)
                    chan.Add(a[i]);
                if (LaHoanHao(a[i]))
                    hoanHao.Add(a[i]);
            }
            In("Số nguyên tố", nguyenTo);
            In("Số chẵn", chan);
            In("Số hoàn hảo", hoanHao);
        }
    }
}
