using System;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double so1, so2, Tong, Hieu, Tich, Thuong;
        Console.Write("nhập số thứ nhất:");
        so1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhập số thứ hai:");
        so2 = Convert.ToDouble(Console.ReadLine());

        Tong = so1 + so2;
        Hieu = so1 - so2;
        Tich = so2 * so1;
        Console.WriteLine("{0} + {1} = {2} ", so1, so2, Tong);

        Console.WriteLine("{0} - {1} = {2} ", so1, so2, Hieu);
        Console.WriteLine("{0} * {1} = {2} ", so1, so2, Tich);

        if (so2 == 0)
        {
            Console.WriteLine("không thể chia cho 0");
        }
        else
        {
            Thuong = so1 / so2;
            Console.WriteLine("{0} / {1} = {2}", so1, so2, Thuong);
        }
    }
}