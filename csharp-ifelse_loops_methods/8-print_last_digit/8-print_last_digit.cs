using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        // Math.Abs stellt sicher, dass wir bei -1024 als letzte Ziffer 4 erhalten
        int lastDigit = Math.Abs(number % 10);
        Console.Write(lastDigit);
        return lastDigit;
    }
}