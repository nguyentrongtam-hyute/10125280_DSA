using System;
namespace Buoi02_DanhSach
{
    class B1C4
    {
        static int[] a;
        static void Nhap()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void HienThi()
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static void Chen(int x, int k)
        {
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i <= k - 1; i++)
                tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i <= a.Length - 1; i++)
                tmp[i + 1] = a[i];
            a = tmp;
        }
        public static void Run()
        {
            Nhap();
            Console.WriteLine("Dãy vừa nhập:");
            HienThi();
            Console.Write("Nhập x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k (0.." + a.Length + "): ");
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ");
                return;
            }
            Chen(x, k);
            Console.WriteLine("Dãy sau khi chèn:");
            HienThi();
        }
    }
}
