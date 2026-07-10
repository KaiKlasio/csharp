using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        Console.WriteLine($"Percent: {percent:P2} tip");
        Console.WriteLine($"Currency: {currency.ToString("C2", new CultureInfo("en-US"))}");
    }
}