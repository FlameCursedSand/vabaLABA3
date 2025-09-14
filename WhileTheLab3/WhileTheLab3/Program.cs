using System;
using System.Diagnostics.Eventing.Reader;

internal class Program
{
    private static void Main(string[] args)
    {
        double x, s;
        Console.WriteLine("Введите конечное число");
        x = Convert.ToDouble(Console.ReadLine());
        s = 0;
        double i = 0;
        while (i <= x)
        {
            s += i;
            i++;
        }
        Console.WriteLine(s);
    }   
}