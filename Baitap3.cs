using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập mảng số nguyên không dấu
        Console.Write("Nhập số phần tử của mảng số nguyên không dấu: ");
        int n = int.Parse(Console.ReadLine());
        ushort[] unsignedArr = new ushort[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} của mảng số nguyên không dấu: ");
            unsignedArr[i] = ushort.Parse(Console.ReadLine());
        }

        // Tính tổng mảng số nguyên không dấu
        ushort unsignedSum = 0;
        foreach (ushort num in unsignedArr)
        {
            unsignedSum += num;
        }
        Console.WriteLine($"Tổng các số trong mảng số nguyên không dấu là: {unsignedSum}");

        // Nhập mảng số nguyên có dấu
        Console.Write("Nhập số phần tử của mảng số nguyên có dấu: ");
        n = int.Parse(Console.ReadLine());
        short[] signedArr = new short[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} của mảng số nguyên có dấu: ");
            signedArr[i] = short.Parse(Console.ReadLine());
        }

        // Tính tổng mảng số nguyên có dấu
        short signedSum = 0;
        foreach (short num in signedArr)
        {
            signedSum += num;
        }
        Console.WriteLine($"Tổng các số trong mảng số nguyên có dấu là: {signedSum}");
    }
}