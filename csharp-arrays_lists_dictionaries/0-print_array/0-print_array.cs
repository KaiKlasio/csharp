using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }

        int[] myArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            myArray[i] = i;
            // Drucke die Zahl
            Console.Write(i);
            
            // Drucke Leerzeichen NUR, wenn es NICHT das letzte Element ist
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        // Erst nach der Schleife kommt der Zeilenumbruch
        Console.WriteLine();

        return myArray;
    }
}