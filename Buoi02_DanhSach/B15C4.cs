using System;
namespace Buoi02_DanhSach
{
    class B15C4
    {
        class Node
        {
            public int data;
            public Node next;
        }
        static bool CoChuTrinh(Node head)
        {
            Node rua = head;
            Node tho = head;
            while (tho != null && tho.next != null)
            {
                rua = rua.next;
                tho = tho.next.next;
                if (rua == tho)
                    return true;
            }
            return false;
        }
        public static void Run()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            Node head = null, tail = null;
            Node[] cacNut = new Node[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
                Node moi = new Node();
                moi.data = int.Parse(Console.ReadLine());
                cacNut[i] = moi;
                if (head == null)
                    head = moi;
                else
                    tail.next = moi;
                tail = moi;
            }
            Console.Write("Nút cuối nối về nút có chỉ số (0.." + (n - 1) + ", nhập -1 nếu không tạo chu trình): ");
            int vt = int.Parse(Console.ReadLine());
            if (n > 0 && vt >= 0 && vt < n)
                tail.next = cacNut[vt];
            if (CoChuTrinh(head))
                Console.WriteLine("Danh sách có chu trình");
            else
                Console.WriteLine("Danh sách không có chu trình");
        }
    }
}
