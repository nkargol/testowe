using System;
using System.Security.Authentication.ExtendedProtection;

class Zadania1
{
    static void Main(string[] args)
    {
        //Zadanie1();
        //Zadanie2();
        //Zadanie3();
        //Zadanie4();
        //Zadanie5();
        Zadanie6();
    }


    static void Zadanie1()
    {
        Console.WriteLine("Radius: ");
        double r = Double.Parse(Console.ReadLine());
        if (r < 0)
        {
            Console.WriteLine("Incorrect data");
        }
        else
        {
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Perimeter: {0:0.##}", perimeter);
        }
    }

    static void Zadanie2()
    {
        Console.WriteLine("First side length: ");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Second side length: ");
        double b = Double.Parse(Console.ReadLine());
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Incorrect data");
        }
        else
        {
            double pole = a * b;
            Console.Write("The surface area is {0:0.##} ", pole);
        }
        if (a == b)
        {
            Console.WriteLine("and it is a square.");
        }
        else
        {
            Console.WriteLine("and it is not a square.");
        }
    }

    static void Zadanie3()
    {
        Console.WriteLine("Integer: ");
        int a = Int32.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is not even.");
        }
    }

    static void Zadanie4()
    {
        Console.WriteLine("First number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Third number: ");
        double c = double.Parse(Console.ReadLine());
        double max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        Console.WriteLine("Max: {0:0.##}", max);
    }

    static void Zadanie5()
    {
        Console.WriteLine("First coefficient of the quadratic equation: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Second coefficient of the quadratic equation: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Third coefficient of the quadratic equation: ");
        double c = double.Parse(Console.ReadLine());
        double delta = b * b - (4 * a * c);
        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Zeros of the function: x1 = {0:0.##}; x2 = {1:0.##}", x1, x2);
        }
        else if (delta == 0)
        {
            double x0 = (-b) / (2 * a);
            Console.WriteLine("Zeros of the function: x0 = {0:0.##}", x0);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine("Zeros of the function: x1 = {0:0.##} + {1:0.##}i, x2 = {0:0.##} - {1:0.##}i", realPart, imaginaryPart);
        }
    }

    static void Zadanie6()
    {
        decimal dec = 4.33M; //dollar's exchange rate
        decimal eec = 4.59M; //euro's exchange rate
        Console.WriteLine("Amount in PLN: ");
        decimal amountzl = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Currency options:");
        Console.WriteLine("1. American dollar (USD)");
        Console.WriteLine("2. Euro (EUR)");
        Console.Write("Choose the currency (number): ");
        int currency = Int32.Parse(Console.ReadLine());
        decimal amount = 0M;
        string currencyName = "";
        switch (currency)
        {
            case 1:
                amount = amountzl / dec;
                currencyName = "American dollar (USD)";
                break;
            case 2:
                amount = amountzl / eec;
                currencyName = "Euro (EUR)";
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        Console.WriteLine("{0}zl is {1:0.##} {2}", amountzl, amount, currencyName);
    }
}