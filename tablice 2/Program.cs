using System;

class Program
{
    static void Main()
    {
        int[] a = { -2, -1, 0, 0, 1, 4 };
        int[] b = { -3, -2, -1, 1, 2, 3 };

        Print(a, b);
    }

    public static void Print(int[] a, int[] b)
    {
        int i = 0;
        int j = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i] < b[j])
            {
                Console.Write(a[i] + " ");
                i++;
            }
            else if (a[i] > b[j])
            {
                j++;
            }
            else
            {
                // Skip duplicates
                i++;
                j++;
            }
        }

        // Print remaining elements from array 'a'
        while (i < a.Length)
        {
            Console.Write(a[i] + " ");
            i++;
        }

        // Check if no numbers were printed
        if (i == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine();
        }
    }
}
