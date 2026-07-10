using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            // Leerzeichen vor dem Backslash drucken
            for (int space = 0; space < i; space++)
            {
                Console.Write(" ");
            }
            // Backslash und Zeilenumbruch drucken
            Console.WriteLine("\\");
        }
        // Zusätzlicher Zeilenumbruch, falls length <= 0 oder nach der Linie
        if (length <= 0)
        {
            Console.WriteLine();
        }
    }
}