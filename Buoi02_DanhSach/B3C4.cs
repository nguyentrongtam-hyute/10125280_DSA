using System;
namespace Buoi02_DanhSach
{
    class B3C4
    {
        static int TongTatCa(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    t += a[i, j];
            return t;
        }
        static int DuongNhoNhat(int[,] a, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] < min && a[i, j] > 0)
                        min = a[i, j];
            return min;
        }
        static int TongCheoPhu(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                int j = (n - 1) - i;
                t += a[i, j];
            }
            return t;
        }
        static bool CheoChinhTangDan(int[,] a, int n)
        {
            int[] tg = new int[n];
            for (int i = 0; i < n; i++)
                tg[i] = a[i, i];
            for (int i = 0; i <= n - 2; i++)
                for (int j = i + 1; j <= n - 1; j++)
                    if (!(tg[i] < tg[j]))
                        return false;
            return true;
        }
        public static void Run()
        {
            Console.Write("Nhập cấp ma trận n (0 <= n < 100): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n >= 100)
            {
                Console.WriteLine("n không hợp lệ");
                return;
            }
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "," + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("a. Tổng tất cả phần tử: " + TongTatCa(a, n));
            int m = DuongNhoNhat(a, n);
            if (m == int.MaxValue)
                Console.WriteLine("b. Không có giá trị dương");
            else
                Console.WriteLine("b. Giá trị dương nhỏ nhất: " + m);
            Console.WriteLine("c. Tổng đường chéo phụ: " + TongCheoPhu(a, n));
            if (CheoChinhTangDan(a, n))
                Console.WriteLine("d. Đường chéo chính tăng dần");
            else
                Console.WriteLine("d. Đường chéo chính không tăng dần");
        }
    }
}
