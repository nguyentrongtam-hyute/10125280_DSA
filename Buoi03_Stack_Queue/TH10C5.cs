using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH10C5
    {
        static bool LaToanTu(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
        static bool LaNgoacMo(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }
        static bool LaNgoacDong(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
        static char NgoacMoTuongUng(char c)
        {
            if (c == ')')
                return '(';
            if (c == ']')
                return '[';
            return '{';
        }
        static bool KiemTraNgoac(string bt)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < bt.Length; i++)
            {
                if (LaNgoacMo(bt[i]))
                    st.Push(bt[i]);
                else if (LaNgoacDong(bt[i]))
                {
                    if (st.Count == 0 || st.Pop() != NgoacMoTuongUng(bt[i]))
                        return false;
                }
            }
            return st.Count == 0;
        }
        public static bool KiemTra(string bt, bool chiNgoacTron, out string lyDo)
        {
            Stack<char> st = new Stack<char>();
            bool chuToanHang = true;
            int truoc = 0;
            int i = 0;
            lyDo = "";
            while (i < bt.Length)
            {
                char c = bt[i];
                if (char.IsWhiteSpace(c))
                {
                    i++;
                    continue;
                }
                if (char.IsDigit(c) || c == '.')
                {
                    int bd = i, soChuSo = 0, soCham = 0;
                    while (i < bt.Length && (char.IsDigit(bt[i]) || bt[i] == '.'))
                    {
                        if (bt[i] == '.')
                            soCham++;
                        else
                            soChuSo++;
                        i++;
                    }
                    string so = bt.Substring(bd, i - bd);
                    if (soChuSo == 0 || soCham > 1)
                    {
                        lyDo = "số không hợp lệ " + so;
                        return false;
                    }
                    if (!chuToanHang)
                    {
                        lyDo = "thiếu toán tử trước số " + so;
                        return false;
                    }
                    chuToanHang = false;
                    truoc = 1;
                    continue;
                }
                if (LaToanTu(c))
                {
                    if (chuToanHang)
                    {
                        if (truoc == 0)
                            lyDo = "biểu thức bắt đầu bằng toán tử " + c;
                        else if (truoc == 2)
                            lyDo = "hai toán tử liên tiếp";
                        else
                            lyDo = "toán tử " + c + " đứng ngay sau dấu mở ngoặc";
                        return false;
                    }
                    chuToanHang = true;
                    truoc = 2;
                    i++;
                    continue;
                }
                if (LaNgoacMo(c))
                {
                    if (chiNgoacTron && c != '(')
                    {
                        lyDo = "chỉ cho phép ngoặc tròn, gặp " + c;
                        return false;
                    }
                    if (!chuToanHang)
                    {
                        lyDo = "thiếu toán tử trước dấu " + c;
                        return false;
                    }
                    st.Push(c);
                    truoc = 3;
                    i++;
                    continue;
                }
                if (LaNgoacDong(c))
                {
                    if (chiNgoacTron && c != ')')
                    {
                        lyDo = "chỉ cho phép ngoặc tròn, gặp " + c;
                        return false;
                    }
                    if (chuToanHang)
                    {
                        if (truoc == 2)
                            lyDo = "toán tử đứng ngay trước dấu " + c;
                        else if (truoc == 3)
                            lyDo = "cặp ngoặc rỗng";
                        else
                            lyDo = "dấu " + c + " ở đầu biểu thức";
                        return false;
                    }
                    if (st.Count == 0)
                    {
                        lyDo = "dấu " + c + " không có dấu mở tương ứng";
                        return false;
                    }
                    if (st.Pop() != NgoacMoTuongUng(c))
                    {
                        lyDo = "dấu " + c + " không khớp với dấu mở";
                        return false;
                    }
                    chuToanHang = false;
                    truoc = 4;
                    i++;
                    continue;
                }
                lyDo = "ký tự " + c + " không hợp lệ";
                return false;
            }
            if (truoc == 0)
            {
                lyDo = "biểu thức rỗng";
                return false;
            }
            if (chuToanHang)
            {
                lyDo = "biểu thức kết thúc bằng toán tử";
                return false;
            }
            if (st.Count > 0)
            {
                lyDo = "còn dấu ngoặc mở chưa được đóng";
                return false;
            }
            return true;
        }
        public static void Run()
        {
            Console.WriteLine("Cho phép số, + - * /, ngoặc tròn ( ), vuông [ ], nhọn { }");
            Console.WriteLine("Ví dụ hợp lệ: 3 + 5 * (2 - 4)   {[1+2]*3}/4");
            Console.WriteLine("Ví dụ sai: 3 + * 5   (3 + 4   [1+2)   + 3 - 1   5 + 6 -");
            string bt;
            do
            {
                Console.Write("Nhập biểu thức: ");
                bt = Console.ReadLine();
                if (!string.IsNullOrEmpty(bt))
                {
                    string lyDo;
                    if (KiemTraNgoac(bt))
                        Console.WriteLine("Dấu ngoặc: mở và đóng đúng cách");
                    else
                        Console.WriteLine("Dấu ngoặc: sai");
                    if (KiemTra(bt, false, out lyDo))
                        Console.WriteLine("Biểu thức hợp lệ");
                    else
                        Console.WriteLine("Biểu thức không hợp lệ (" + lyDo + ")");
                }
            } while (!string.IsNullOrEmpty(bt));
        }
    }
}
