using System;
namespace Buoi02_DanhSach
{
    class B14C4
    {
        class Node
        {
            public int data;
            public Node next;
        }
        class DanhSach
        {
            public Node head;
            public Node tail;
            public void ThemCuoi(int x)
            {
                Node moi = new Node();
                moi.data = x;
                if (head == null)
                    head = moi;
                else
                    tail.next = moi;
                tail = moi;
            }
            public void In()
            {
                for (Node p = head; p != null; p = p.next)
                    Console.Write(p.data + " ");
                Console.WriteLine();
            }
        }
        static DanhSach NhapDS(string ten)
        {
            DanhSach ds = new DanhSach();
            Console.Write("Số phần tử của " + ten + ": ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập các phần tử theo thứ tự tăng dần");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
                ds.ThemCuoi(int.Parse(Console.ReadLine()));
            }
            return ds;
        }
        static DanhSach Gop(DanhSach a, DanhSach b)
        {
            DanhSach kq = new DanhSach();
            Node p = a.head;
            Node q = b.head;
            while (p != null && q != null)
            {
                if (p.data <= q.data)
                {
                    kq.ThemCuoi(p.data);
                    p = p.next;
                }
                else
                {
                    kq.ThemCuoi(q.data);
                    q = q.next;
                }
            }
            while (p != null)
            {
                kq.ThemCuoi(p.data);
                p = p.next;
            }
            while (q != null)
            {
                kq.ThemCuoi(q.data);
                q = q.next;
            }
            return kq;
        }
        public static void Run()
        {
            DanhSach l1 = NhapDS("danh sách 1");
            DanhSach l2 = NhapDS("danh sách 2");
            Console.WriteLine("Danh sách sau khi gộp:");
            Gop(l1, l2).In();
        }
    }
}
