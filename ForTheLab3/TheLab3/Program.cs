using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double x, s;
        Console.WriteLine("Введите конечное число");
        x = Convert.ToDouble(Console.ReadLine());
        s = 0;
        for (double i = 0; i <= x; i++)
        {
            s += i;
        }
        Console.WriteLine(s);

        }

    } 

