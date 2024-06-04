using System;
using System.Text;

class Program
{
    static void FindMaxMin(sbyte[] numbers)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Số lớn nhất: {numbers.Max()}");
        Console.WriteLine($"Số nhỏ nhất: {numbers.Min()}");
    }

    static void SumEvenNumbers(sbyte[] numbers)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int evenSum = 0;
        foreach (var num in numbers)
        {
            if (num % 2 == 0)
                evenSum += num;
        }
        Console.WriteLine($"Tổng các số chẵn: {evenSum}");
    }

    static void SumFromOneTo(byte n)
    {
        Console.OutputEncoding = Encoding.UTF8;
        uint total = (uint)(n * (n + 1) / 2);
        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {total}");
    }

    static void SumDigits(byte num)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int digitSum = 0;
        while (num > 0)
        {
            digitSum += (int)(num % 10);
            num /= 10;
        }
        Console.WriteLine($"Tổng các chữ số trong {num} là: {digitSum}");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài tập 2a: Tìm số lớn nhất và nhỏ nhất trong dãy số");
        sbyte[] numbers = new sbyte[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nhập số thứ {i + 1} (1 byte): ");
            numbers[i] = sbyte.Parse(Console.ReadLine());
        }
        FindMaxMin(numbers);

        Console.WriteLine("\nBài tập 2b: Tính tổng các số chẵn trong dãy số");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nhập số thứ {i + 1} (1 byte): ");
            numbers[i] = sbyte.Parse(Console.ReadLine());
        }
        SumEvenNumbers(numbers);

        Console.WriteLine("\nBài tập 2c: Tính tổng các số từ 1 đến n");
        Console.Write("Nhập số nguyên không dấu (1 byte): ");
        byte n = byte.Parse(Console.ReadLine());
        SumFromOneTo(n);

        Console.WriteLine("\nBài tập 2d: Tính tổng các chữ số trong số nguyên");
        Console.Write("Nhập số nguyên không dấu (1 byte): ");
        byte num = byte.Parse(Console.ReadLine());
        SumDigits(num);
    }
}