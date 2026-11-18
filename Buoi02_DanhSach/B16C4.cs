using System;
namespace Buoi02_DanhSach
{
    class B16C4
    {
        class Node
        {
            public string url;
            public Node prev;
            public Node next;
        }
        static Node current;
        static void TruyCap(string url)
        {
            Node moi = new Node();
            moi.url = url;
            if (current != null)
            {
                current.next = moi;
                moi.prev = current;
            }
            current = moi;
        }
        static void Back()
        {
            if (current.prev == null)
                Console.WriteLine("Không thể quay lại");
            else
                current = current.prev;
        }
        static void Forward()
        {
            if (current.next == null)
                Console.WriteLine("Không thể tiến tới");
            else
                current = current.next;
        }
        public static void Run()
        {
            current = null;
            TruyCap("trang-chu");
            string chon;
            do
            {
                Console.WriteLine("\nTrang hiện tại: " + current.url);
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                {
                    Console.Write("Nhập địa chỉ trang: ");
                    TruyCap(Console.ReadLine());
                }
                else if (chon == "2")
                    Back();
                else if (chon == "3")
                    Forward();
            } while (chon != "0");
        }
    }
}
