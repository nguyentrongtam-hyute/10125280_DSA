using System;
namespace Buoi02_DanhSach
{
    class B11C4
    {
        static bool LaDonVi(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] != 1)
                        return false;
                    if (i != j && matrix[i, j] != 0)
                        return false;
                }
            return true;
        }
        static bool LaDoiXung(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            return true;
        }
        public static void Run()
        {
            Console.Write("Nhập cấp ma trận vuông n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[" + i + "," + j + "] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            if (LaDonVi(matrix, n))
                Console.WriteLine("Là ma trận đơn vị");
            else
                Console.WriteLine("Không phải ma trận đơn vị");
            if (LaDoiXung(matrix, n))
                Console.WriteLine("Là ma trận đối xứng");
            else
                Console.WriteLine("Không phải ma trận đối xứng");
        }
    }
}
