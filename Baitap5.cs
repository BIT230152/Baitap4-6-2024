using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Yêu cầu a: Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực 4 byte
        Console.Write("Nhập số phần tử của mảng số thực 4 byte: ");
        int n = int.Parse(Console.ReadLine());
        float[] floatArr = new float[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} của mảng: ");
            floatArr[i] = float.Parse(Console.ReadLine());
        }

        float maxValue = floatArr[0];
        float minValue = floatArr[0];

        for (int i = 1; i < n; i++)
        {
            if (floatArr[i] > maxValue)
            {
                maxValue = floatArr[i];
            }
            if (floatArr[i] < minValue)
            {
                minValue = floatArr[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng: {maxValue}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {minValue}");

        // Yêu cầu b: Tính tổng của các số trong mảng số thực 4 byte
        float sum = 0f;
        for (int i = 0; i < n; i++)
        {
            sum += floatArr[i];
        }
        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }
}