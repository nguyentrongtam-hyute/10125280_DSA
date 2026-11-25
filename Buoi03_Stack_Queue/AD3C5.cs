using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD3C5
    {
        class KhungHam
        {
            public string ten;
            public string thamSo;
            public string diaChiTraVe;
        }
        static Stack<KhungHam> callStack;
        static int soLanGoi;
        static KhungHam TaoKhung(string ten, string thamSo)
        {
            KhungHam f = new KhungHam();
            f.ten = ten;
            f.thamSo = thamSo;
            if (callStack.Count == 0)
                f.diaChiTraVe = "hệ điều hành";
            else
            {
                soLanGoi++;
                f.diaChiTraVe = callStack.Peek().ten + " (lệnh gọi thứ " + soLanGoi + ")";
            }
            return f;
        }
        static void HienThi()
        {
            Console.WriteLine("Call Stack (đỉnh -> đáy):");
            foreach (KhungHam f in callStack)
                Console.WriteLine("  " + f.ten + "(" + f.thamSo + ") -> trả về: " + f.diaChiTraVe);
        }
        static long GiaiThua(int n)
        {
            callStack.Push(TaoKhung("GiaiThua", "n=" + n));
            Console.WriteLine("Gọi GiaiThua(" + n + ")");
            HienThi();
            long kq;
            if (n <= 1)
                kq = 1;
            else
                kq = n * GiaiThua(n - 1);
            Console.WriteLine("GiaiThua(" + n + ") trả về " + kq);
            callStack.Pop();
            HienThi();
            return kq;
        }
        public static void Run()
        {
            callStack = new Stack<KhungHam>();
            soLanGoi = 0;
            callStack.Push(TaoKhung("Main", ""));
            string chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG FUNCTION CALL STACK");
                Console.WriteLine("1. Gọi hàm mới");
                Console.WriteLine("2. Kết thúc hàm hiện tại");
                Console.WriteLine("3. Hiển thị Call Stack");
                Console.WriteLine("4. Chạy thử đệ quy tính n!");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                {
                    Console.Write("Tên hàm: ");
                    string ten = Console.ReadLine();
                    Console.Write("Tham số: ");
                    string ts = Console.ReadLine();
                    if (string.IsNullOrEmpty(ten))
                        Console.WriteLine("Tên hàm không được để trống");
                    else
                    {
                        callStack.Push(TaoKhung(ten, ts));
                        HienThi();
                    }
                }
                else if (chon == "2")
                {
                    if (callStack.Count <= 1)
                        Console.WriteLine("Đang ở Main, không còn hàm nào để kết thúc");
                    else
                    {
                        KhungHam f = callStack.Pop();
                        Console.WriteLine("Hàm " + f.ten + " kết thúc, quay về " + callStack.Peek().ten);
                        HienThi();
                    }
                }
                else if (chon == "3")
                    HienThi();
                else if (chon == "4")
                {
                    Console.Write("Nhập n (0..12): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0 || n > 12)
                        Console.WriteLine("n không hợp lệ");
                    else
                        Console.WriteLine(n + "! = " + GiaiThua(n));
                }
            } while (chon != "0" && chon != null);
        }
    }
}
