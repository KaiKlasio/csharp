using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            // Leerzeichen hinzufügen: für Zeile 0 -> 0 Leerzeichen, Zeile 1 -> 1 Leerzeichen...
            for (int space = 0; space < i; space++)
            {
                Console.Write(" ");
            }
            // Backslash drucken und Zeile beenden
            Console.WriteLine("\\");
        }
        
        // Immer einen Zeilenumbruch am Ende, auch wenn length <= 0
        if (length <= 0)
        {
            Console.WriteLine();
        }
    }
}