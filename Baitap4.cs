using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Yêu cầu a: Kiểm tra số Palindrome
        Console.Write("Nhập một số nguyên không dấu 8 byte: ");
        ulong number = ulong.Parse(Console.ReadLine());
        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số Palindrome.");
        }

        // Yêu cầu b: Tính tổng mảng số nguyên có dấu
        Console.Write("Nhập số phần tử của mảng số nguyên có dấu 8 byte: ");
        int n = int.Parse(Console.ReadLine());
        long[] signedArr = new long[n];
        long signedSum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} của mảng số nguyên có dấu: ");
            signedArr[i] = long.Parse(Console.ReadLine());
            signedSum += signedArr[i];
        }
        Console.WriteLine($"Tổng các số trong mảng số nguyên có dấu là: {signedSum}");
    }

    static bool IsPalindrome(ulong number)
    {
        ulong originalNumber = number;
        ulong reversedNumber = 0;

        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + (number % 10);
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
}