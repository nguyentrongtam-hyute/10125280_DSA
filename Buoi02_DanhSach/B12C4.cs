using System;
namespace Buoi02_DanhSach
{
    class B12C4
    {
        public static void Run()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số mìn: ");
            int soMin = int.Parse(Console.ReadLine());
            if (soMin < 0 || soMin > m * n)
            {
                Console.WriteLine("Số mìn không hợp lệ");
                return;
            }
            bool[,] coMin = new bool[m, n];
            Random rd = new Random();
            int daDat = 0;
            while (daDat < soMin)
            {
                int x = rd.Next(m);
                int y = rd.Next(n);
                if (!coMin[x, y])
                {
                    coMin[x, y] = true;
                    daDat++;
                }
            }
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[,] soMinQuanh = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (coMin[i, j])
                        continue;
                    for (int k = 0; k < 8; k++)
                    {
                        int u = i + dx[k];
                        int v = j + dy[k];
                        if (u >= 0 && u < m && v >= 0 && v < n && coMin[u, v])
                            soMinQuanh[i, j]++;
                    }
                }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (coMin[i, j])
                        Console.Write("* ");
                    else
                        Console.Write(soMinQuanh[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
