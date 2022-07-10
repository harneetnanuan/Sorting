


//using System;

public class Example
{
    public static void Main()
    {
        int[] array = { 2, 7, 5, 9, 3, 1 };
        for (int k = 0; k < array.Length; k++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;

                }
            }
        }
       
            System.Console.WriteLine(string.Join(",", array));

        System.Console.WriteLine("Time complexity is O(n square)");
        
    }
}