using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        // Prüfen, ob der Index innerhalb der Array-Grenzen liegt
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        // Rückgabe des Elements an der angegebenen Stelle
        return array[index];
    }
}