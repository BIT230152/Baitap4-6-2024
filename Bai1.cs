using System;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // a. Tính toán các phép tính cơ bản với 2 số nguyên
            int a, b;

            // Nhập 2 số nguyên từ bàn phím, sử dụng điều khiển exception
            while (true)
            {
                try
                {
                    Console.Write("Nhập số a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số b: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ.");
                }
            }

            // Tính toán và in kết quả
            Console.WriteLine("Kết quả:");
            Console.WriteLine($"Tổng: {a + b}");
            Console.WriteLine($"Hiệu: {a - b}");
            Console.WriteLine($"Tích: {a * b}");
            Console.WriteLine($"Thương (số nguyên): {a / b}");
            Console.WriteLine($"Thương (số thực): {(double)a / b}");

            // b. Tính tổng các số trong mảng
            int[] numbers;
            int n, sum = 0;

            // Nhập kích thước mảng và các phần tử
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            // In kết quả
            Console.WriteLine($"Tổng các số trong mảng: {sum}");

            // c. Đảo ngược các chữ số của một số nguyên không dấu
            uint number;
            uint reversedNumber = 0;

            // Nhập số nguyên không dấu từ bàn phím
            Console.Write("Nhập số nguyên không dấu: ");
            while (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên không dấu hợp lệ.");
                Console.Write("Nhập số nguyên không dấu: ");
            }

            // Đảo ngược các chữ số
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + (number % 10);
                number /= 10;
            }

            // In kết quả
            Console.WriteLine($"Số đảo ngược: {reversedNumber}");
        }
    }
}