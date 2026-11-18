using System;
using System.Collections.Generic;
using System.Text;
namespace Buoi02_DanhSach
{
    class B8C4
    {
        static string ChuanHoa(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s.ToLower())
            {
                if (char.IsLetterOrDigit(c) || c == ' ')
                    sb.Append(c);
                else
                    sb.Append(' ');
            }
            return sb.ToString();
        }
        public static void Run()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();
            string[] tu = ChuanHoa(s).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> tanSuat = new Dictionary<string, int>();
            foreach (string t in tu)
            {
                if (tanSuat.ContainsKey(t))
                    tanSuat[t]++;
                else
                    tanSuat.Add(t, 1);
            }
            List<KeyValuePair<string, int>> kq = new List<KeyValuePair<string, int>>(tanSuat);
            kq.Sort((x, y) =>
            {
                if (x.Value != y.Value)
                    return y.Value.CompareTo(x.Value);
                return string.Compare(x.Key, y.Key);
            });
            foreach (KeyValuePair<string, int> cap in kq)
                Console.WriteLine(cap.Key + ": " + cap.Value);
        }
    }
}
