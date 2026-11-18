using System;
namespace Buoi02_DanhSach
{
    class B13C4
    {
        class Node
        {
            public int data;
            public Node next;
        }
        static Node head;
        static void TaoDS()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            Node tail = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
                Node moi = new Node();
                moi.data = int.Parse(Console.ReadLine());
                if (head == null)
                    head = moi;
                else
                    tail.next = moi;
                tail = moi;
            }
        }
        static void InDS()
        {
            for (Node p = head; p != null; p = p.next)
                Console.Write(p.data + " ");
            Console.WriteLine();
        }
        static void DaoNguoc()
        {
            Node previous = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }
        public static void Run()
        {
            head = null;
            TaoDS();
            Console.WriteLine("Danh sách ban đầu:");
            InDS();
            DaoNguoc();
            Console.WriteLine("Danh sách sau khi đảo ngược:");
            InDS();
        }
    }
}
