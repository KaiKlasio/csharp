using System;

public class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        // Prüfen, ob der Index innerhalb der Array-Grenzen liegt
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        // Element am angegebenen Index durch n ersetzen
        array[index] = n;

        // Das aktualisierte (oder unveränderte) Array zurückgeben
        return array;
    }
}
