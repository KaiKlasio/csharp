using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                // Drucke i Leerzeichen
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                // Drucke den Backslash
                Console.WriteLine("\\");
            }
        }
        else
        {
            // Bei length <= 0 nur eine leere Zeile
            Console.WriteLine();
        }
    }
}