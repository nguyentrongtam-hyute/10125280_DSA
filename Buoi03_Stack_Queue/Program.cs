using System;
using System.Text;
namespace Buoi03_Stack_Queue
{
    class Program
    {
        static void HienMenu()
        {
            Console.WriteLine("--- Bài tập áp dụng ---");
            Console.WriteLine("1. Bài 1 Chương 5 (áp dụng)");
            Console.WriteLine("2. Bài 2 Chương 5 (áp dụng)");
            Console.WriteLine("3. Bài 3 Chương 5 (áp dụng)");
            Console.WriteLine("4. Bài 4 Chương 5 (áp dụng)");
            Console.WriteLine("5. Bài 5 Chương 5 (áp dụng)");
            Console.WriteLine("6. Bài 6 Chương 5 (áp dụng)");
            Console.WriteLine("--- Bài tập tự thực hành ---");
            Console.WriteLine("7. Bài 4 Chương 5 (tự thực hành)");
            Console.WriteLine("8. Bài 5 Chương 5 (tự thực hành)");
            Console.WriteLine("9. Bài 6 Chương 5 (tự thực hành)");
            Console.WriteLine("10. Bài 7 Chương 5 (tự thực hành)");
            Console.WriteLine("11. Bài 8 Chương 5 (tự thực hành)");
            Console.WriteLine("12. Bài 9 Chương 5 (tự thực hành)");
            Console.WriteLine("13. Bài 10 Chương 5 (tự thực hành)");
            Console.WriteLine("14. Bài 11 Chương 5 (tự thực hành)");
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
                        case "1": AD1C5.Run(); break;
                        case "2": AD2C5.Run(); break;
                        case "3": AD3C5.Run(); break;
                        case "4": AD4C5.Run(); break;
                        case "5": AD5C5.Run(); break;
                        case "6": AD6C5.Run(); break;
                        case "7": TH4C5.Run(); break;
                        case "8": TH5C5.Run(); break;
                        case "9": TH6C5.Run(); break;
                        case "10": TH7C5.Run(); break;
                        case "11": TH8C5.Run(); break;
                        case "12": TH9C5.Run(); break;
                        case "13": TH10C5.Run(); break;
                        case "14": TH11C5.Run(); break;
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
                if (chon != "0" && chon != null)
                {
                    Console.Write("\nNhấn phím bất kì để tiếp tục...");
                    Console.ReadLine();
                }
            } while (chon != "0" && chon != null);
        }
    }
}
