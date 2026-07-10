using System;
using System.Collections.Generic;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
        // Prüfen, ob die Liste null oder leer ist
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        // Das erste Element als vorläufiges Maximum setzen
        int max = myList[0];

        // Durch die Liste iterieren und vergleichen
        for (int i = 1; i < myList.Count; i++)
        {
            if (myList[i] > max)
            {
                max = myList[i];
            }
        }

        return max;
    }
}