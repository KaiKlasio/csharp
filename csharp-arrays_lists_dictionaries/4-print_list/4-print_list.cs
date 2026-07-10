using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        // Prüfen, ob die Größe negativ ist
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> myList = new List<int>();

        // Liste befüllen und Elemente drucken
        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
            Console.Write(i + (i == size - 1 ? "" : " "));
        }
        
        // Zeilenumbruch nach der Ausgabe
        Console.WriteLine();

        return myList;
    }
}