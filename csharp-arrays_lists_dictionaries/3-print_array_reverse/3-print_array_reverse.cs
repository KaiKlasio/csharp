using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // Wenn das Array null ist, soll die Methode einfach beendet werden
        if (array == null)
        {
            Console.WriteLine();
            return;
        }

        // Schleife vom letzten Element bis zum ersten
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            
            // Leerzeichen drucken, außer beim letzten Element (das hier das erste ist)
            if (i > 0)
            {
                Console.Write(" ");
            }
        }
        // Am Ende jeder Ausgabe muss ein Zeilenumbruch erfolgen
        Console.WriteLine();
    }
}