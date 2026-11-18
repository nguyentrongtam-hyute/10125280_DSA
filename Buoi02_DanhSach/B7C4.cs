using System;
using System.Globalization;
namespace Buoi02_DanhSach
{
    class B7C4
    {
        static double DocSo()
        {
            string s = Console.ReadLine().Replace(',', '.');
            return double.Parse(s, CultureInfo.InvariantCulture);
        }
        public static void Run()
        {
            Console.Write("Nhập số ngày n: ");
            int n = int.Parse(Console.ReadLine());
            double[] nhietDo = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhiệt độ ngày " + (i + 1) + ": ");
                nhietDo[i] = DocSo();
            }
            int ngayMax = 0, ngayMin = 0;
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (nhietDo[i] > nhietDo[ngayMax])
                    ngayMax = i;
                if (nhietDo[i] < nhietDo[ngayMin])
                    ngayMin = i;
                tong += nhietDo[i];
            }
            Console.WriteLine("Ngày nóng nhất: ngày " + (ngayMax + 1) + " (" + nhietDo[ngayMax] + ")");
            Console.WriteLine("Ngày lạnh nhất: ngày " + (ngayMin + 1) + " (" + nhietDo[ngayMin] + ")");
            Console.WriteLine("Nhiệt độ trung bình: " + Math.Round(tong / n, 2));
        }
    }
}
