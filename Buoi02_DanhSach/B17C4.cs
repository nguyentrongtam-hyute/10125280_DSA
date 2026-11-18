using System;
namespace Buoi02_DanhSach
{
    class B17C4
    {
        class BaiHat
        {
            public string ten;
            public BaiHat prev;
            public BaiHat next;
        }
        static BaiHat head, tail, current;
        static void ThemBaiHat(string ten)
        {
            BaiHat moi = new BaiHat();
            moi.ten = ten;
            if (head == null)
            {
                head = moi;
                current = moi;
            }
            else
            {
                tail.next = moi;
                moi.prev = tail;
            }
            tail = moi;
        }
        static void XoaBaiHat(string ten)
        {
            BaiHat p = head;
            while (p != null && p.ten != ten)
                p = p.next;
            if (p == null)
            {
                Console.WriteLine("Không tìm thấy bài hát");
                return;
            }
            if (p == current)
                current = p.next != null ? p.next : p.prev;
            if (p.prev != null)
                p.prev.next = p.next;
            else
                head = p.next;
            if (p.next != null)
                p.next.prev = p.prev;
            else
                tail = p.prev;
        }
        static void Next()
        {
            if (current == null || current.next == null)
                Console.WriteLine("Không có bài tiếp theo");
            else
                current = current.next;
        }
        static void Previous()
        {
            if (current == null || current.prev == null)
                Console.WriteLine("Không có bài trước đó");
            else
                current = current.prev;
        }
        static void InPlaylist()
        {
            if (head == null)
            {
                Console.WriteLine("Playlist trống");
                return;
            }
            int stt = 1;
            for (BaiHat p = head; p != null; p = p.next)
            {
                Console.WriteLine((p == current ? "> " : "  ") + stt + ". " + p.ten);
                stt++;
            }
        }
        public static void Run()
        {
            head = tail = current = null;
            string chon;
            do
            {
                Console.WriteLine("\n--- Playlist ---");
                InPlaylist();
                Console.WriteLine("1. Thêm bài hát");
                Console.WriteLine("2. Xóa bài hát");
                Console.WriteLine("3. Next");
                Console.WriteLine("4. Previous");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = Console.ReadLine();
                if (chon == "1")
                {
                    Console.Write("Tên bài hát: ");
                    ThemBaiHat(Console.ReadLine());
                }
                else if (chon == "2")
                {
                    Console.Write("Tên bài hát cần xóa: ");
                    XoaBaiHat(Console.ReadLine());
                }
                else if (chon == "3")
                    Next();
                else if (chon == "4")
                    Previous();
            } while (chon != "0");
        }
    }
}
