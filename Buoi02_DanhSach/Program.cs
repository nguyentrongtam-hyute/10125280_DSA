using System;
using System.Text;
namespace Buoi02_DanhSach
{
    class Program
    {
        static void HienMenu()
        {
            Console.WriteLine(" 1. Bài 1 Chương 4:");
            Console.WriteLine(" 2. Bài 2 Chương 4:");
            Console.WriteLine(" 3. Bài 3 Chương 4:");
            Console.WriteLine(" 4. Bài 4 Chương 4:");
            Console.WriteLine(" 5. Bài 5 Chương 4:");
            Console.WriteLine(" 6. Bài 7 Chương 4:");
            Console.WriteLine(" 7. Bài 8 Chương 4:");
            Console.WriteLine(" 8. Bài 9 Chương 4:");
            Console.WriteLine(" 9. Bài 10 Chương 4:");
            Console.WriteLine("10. Bài 11 Chương 4:");
            Console.WriteLine("11. Bài 12 Chương 4:");
            Console.WriteLine("12. Bài 13 Chương 4:");
            Console.WriteLine("13. Bài 14 Chương 4:");
            Console.WriteLine("14. Bài 15 Chương 4:");
            Console.WriteLine("15. Bài 16 Chương 4:");
            Console.WriteLine("16. Bài 17 Chương 4:");
            Console.WriteLine("17. Bài 18 Chương 4:");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn: ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string chon;
            do
            {
                HienMenu();
                chon = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    switch (chon)
                    {
                        case "1": B1C4.Run(); break;
                        case "2": B2C4.Run(); break;
                        case "3": B3C4.Run(); break;
                        case "4": B4C4.Run(); break;
                        case "5": B5C4.Run(); break;
                        case "6": B7C4.Run(); break;
                        case "7": B8C4.Run(); break;
                        case "8": B9C4.Run(); break;
                        case "9": B10C4.Run(); break;
                        case "10": B11C4.Run(); break;
                        case "11": B12C4.Run(); break;
                        case "12": B13C4.Run(); break;
                        case "13": B14C4.Run(); break;
                        case "14": B15C4.Run(); break;
                        case "15": B16C4.Run(); break;
                        case "16": B17C4.Run(); break;
                        case "17": B18C4.Run(); break;
                        case "0": break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dữ liệu nhập không đúng định dạng");
                }
                if (chon != "0")
                {
                    Console.Write("\nNhấn phím bất kì để tiếp tục...");
                    Console.ReadLine();
                }
            } while (chon != "0");
        }
    }
}
