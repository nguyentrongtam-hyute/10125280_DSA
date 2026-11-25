using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class AD1C5
    {
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
        static bool KiemTra(string bt, out string lyDo)
        {
            Stack<char> st = new Stack<char>();
            Stack<int> viTri = new Stack<int>();
            lyDo = "";
            for (int i = 0; i < bt.Length; i++)
            {
                char c = bt[i];
                if (LaNgoacMo(c))
                {
                    st.Push(c);
                    viTri.Push(i);
                }
                else if (LaNgoacDong(c))
                {
                    if (st.Count == 0)
                    {
                        lyDo = "dấu " + c + " ở vị trí " + i + " không có dấu mở tương ứng";
                        return false;
                    }
                    char mo = st.Pop();
                    int vt = viTri.Pop();
                    if (mo != NgoacMoTuongUng(c))
                    {
                        lyDo = "dấu " + c + " ở vị trí " + i + " không khớp với dấu " + mo + " ở vị trí " + vt;
                        return false;
                    }
                }
            }
            if (st.Count > 0)
            {
                lyDo = "dấu " + st.Peek() + " ở vị trí " + viTri.Peek() + " chưa được đóng";
                return false;
            }
            return true;
        }
        public static void Run()
        {
            Console.WriteLine("Kiểm tra ngoặc tròn ( ), vuông [ ], nhọn { } trong biểu thức");
            Console.WriteLine("Ví dụ đúng: 3 + 5 * (2 - 4)   {[1+2]*3}/4");
            Console.WriteLine("Ví dụ sai: (3 + 4   [1+2)   {(})   5 + 6)");
            string bt;
            do
            {
                Console.Write("Nhập biểu thức: ");
                bt = Console.ReadLine();
                if (!string.IsNullOrEmpty(bt))
                {
                    string lyDo;
                    if (KiemTra(bt, out lyDo))
                        Console.WriteLine("Biểu thức có cấu trúc ngoặc đúng");
                    else
                        Console.WriteLine("Biểu thức sai (" + lyDo + ")");
                }
            } while (!string.IsNullOrEmpty(bt));
        }
    }
}
