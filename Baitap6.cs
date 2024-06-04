using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Yêu cầu a: Tính trung bình cộng của các số trong mảng số thực 8 byte
        Console.Write("Nhập số phần tử của mảng số thực 8 byte: ");
        int n = int.Parse(Console.ReadLine());
        double[] doubleArr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} của mảng: ");
            doubleArr[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0d;
        for (int i = 0; i < n; i++)
        {
            sum += doubleArr[i];
        }
        double average = sum / n;

        Console.WriteLine($"Trung bình cộng của các số trong mảng: {average}");

        // Yêu cầu b: Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực 8 byte
        double maxValue = doubleArr[0];
        double minValue = doubleArr[0];

        for (int i = 1; i < n; i++)
        {
            if (doubleArr[i] > maxValue)
            {
                maxValue = doubleArr[i];
            }
            if (doubleArr[i] < minValue)
            {
                minValue = doubleArr[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng: {maxValue}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {minValue}");
    }
}