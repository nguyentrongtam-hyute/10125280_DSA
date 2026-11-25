using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class TH5C5
    {
        static bool KiemTra(string s)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    st.Push(s[i]);
                else if (s[i] == ')')
                {
                    if (st.Count == 0)
                        return false;
                    st.Pop();
                }
                else
                    return false;
            }
            return st.Count == 0;
        }
        public static void Run()
        {
            Console.WriteLine("Ví dụ xâu đúng: (()) ()() (()())");
            Console.WriteLine("Ví dụ xâu sai: (())) )( ((()");
            string s;
            do
            {
                Console.Write("Nhập xâu: ");
                s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    if (KiemTra(s))
                        Console.WriteLine("Xâu đúng");
                    else
                        Console.WriteLine("Xâu sai");
                }
            } while (!string.IsNullOrEmpty(s));
        }
    }
}
