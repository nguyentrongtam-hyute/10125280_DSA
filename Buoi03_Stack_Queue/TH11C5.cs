using System;
using System.Collections.Generic;
using System.Text;
namespace Buoi03_Stack_Queue
{
    class TH11C5
    {
        static int Pri(string op)
        {
            if (op == "*" || op == "/")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        static List<string> TachPhanTu(string bt)
        {
            List<string> ds = new List<string>();
            int i = 0;
            while (i < bt.Length)
            {
                if (char.IsWhiteSpace(bt[i]))
                    i++;
                else if (char.IsDigit(bt[i]) || bt[i] == '.')
                {
                    int bd = i;
                    while (i < bt.Length && (char.IsDigit(bt[i]) || bt[i] == '.'))
                        i++;
                    ds.Add(bt.Substring(bd, i - bd));
                }
                else
                {
                    ds.Add(bt[i].ToString());
                    i++;
                }
            }
            return ds;
        }
        static string HauTo(string E)
        {
            Stack<string> St = new Stack<string>();
            StringBuilder E1 = new StringBuilder();
            IEnumerable<string> enumer = TachPhanTu(E);
            foreach (string s in enumer)
            {
                if (s == "(")
                    St.Push(s);
                else if (s == ")")
                {
                    while (St.Count > 0 && St.Peek() != "(")
                        E1.Append(St.Pop()).Append(' ');
                    if (St.Count > 0)
                        St.Pop();
                }
                else if (TH9C5.LaToanHang(s))
                    E1.Append(s).Append(' ');
                else
                {
                    while (St.Count > 0 && Pri(St.Peek()) >= Pri(s))
                        E1.Append(St.Pop()).Append(' ');
                    St.Push(s);
                }
            }
            while (St.Count > 0)
                E1.Append(St.Pop()).Append(' ');
            return E1.ToString().Trim();
        }
        public static void Run()
        {
            Console.WriteLine("Chỉ dùng số, + - * / và ngoặc tròn ( ). Ví dụ: 3 + 5 * (2 - 4)");
            string bt;
            do
            {
                Console.Write("Nhập biểu thức trung tố: ");
                bt = Console.ReadLine();
                if (!string.IsNullOrEmpty(bt))
                {
                    string lyDo;
                    if (!TH10C5.KiemTra(bt, true, out lyDo))
                        Console.WriteLine("Biểu thức không hợp lệ (" + lyDo + ")");
                    else
                    {
                        string hauTo = HauTo(bt);
                        Console.WriteLine("Biểu thức hậu tố: " + hauTo);
                        float kq;
                        string loi;
                        if (TH9C5.Tinh(hauTo, out kq, out loi))
                            Console.WriteLine("Giá trị biểu thức: " + TH9C5.InSo(kq));
                        else
                            Console.WriteLine(loi);
                    }
                }
            } while (!string.IsNullOrEmpty(bt));
        }
    }
}
