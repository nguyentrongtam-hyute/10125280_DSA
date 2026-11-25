using System;
using System.Collections.Generic;
using System.Globalization;
namespace Buoi03_Stack_Queue
{
    class TH9C5
    {
        public static bool LaToanHang(string s)
        {
            int bd = 0;
            if (s.Length > 1 && s[0] == '-')
                bd = 1;
            int soChuSo = 0, soCham = 0;
            for (int i = bd; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    soChuSo++;
                else if (s[i] == '.')
                    soCham++;
                else
                    return false;
            }
            return soChuSo > 0 && soCham <= 1;
        }
        public static string InSo(float f)
        {
            return f.ToString(CultureInfo.InvariantCulture);
        }
        public static bool Tinh(string hauTo, out float ketQua, out string loi)
        {
            Stack<float> stack = new Stack<float>();
            IEnumerable<string> enumer = hauTo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ketQua = 0;
            loi = "";
            foreach (string s in enumer)
            {
                if (LaToanHang(s))
                    stack.Push(float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture));
                else if (s == "+" || s == "-" || s == "*" || s == "/")
                {
                    if (stack.Count < 2)
                    {
                        loi = "Thiếu toán hạng cho toán tử " + s;
                        return false;
                    }
                    float b = stack.Pop();
                    float a = stack.Pop();
                    float r = 0;
                    if (s == "+")
                        r = a + b;
                    else if (s == "-")
                        r = a - b;
                    else if (s == "*")
                        r = a * b;
                    else
                    {
                        if (b == 0)
                        {
                            loi = "Chia cho 0";
                            return false;
                        }
                        r = a / b;
                    }
                    stack.Push(r);
                }
                else
                {
                    loi = "Phần tử " + s + " không hợp lệ";
                    return false;
                }
            }
            if (stack.Count != 1)
            {
                loi = "Biểu thức hậu tố không hợp lệ";
                return false;
            }
            ketQua = stack.Pop();
            return true;
        }
        public static void Run()
        {
            Console.WriteLine("Các phần tử cách nhau bởi dấu cách. Ví dụ: 3 4 2 * +");
            string bt;
            do
            {
                Console.Write("Nhập biểu thức hậu tố: ");
                bt = Console.ReadLine();
                if (!string.IsNullOrEmpty(bt))
                {
                    float kq;
                    string loi;
                    if (Tinh(bt, out kq, out loi))
                        Console.WriteLine("Giá trị biểu thức: " + InSo(kq));
                    else
                        Console.WriteLine(loi);
                }
            } while (!string.IsNullOrEmpty(bt));
        }
    }
}
