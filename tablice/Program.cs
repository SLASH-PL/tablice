﻿int[] a;
a = new int[] { -2, -1, 0, 0, 1, 4 };
int[] b;
b = new int[] { -3, -2, -1, 1, 2, 3 };

bool pusto = true;
for (int i = 0; i < a.Length; i++) 
{
    bool jest = false;
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            jest = true;
            break;
        }
    }
    if (!jest)
    {
        bool duplicate = false;
        for (int k = 0; k < i; k++)
        {
            if (a[i] == a[k])
            {
                duplicate = true;
                break;
            }
        }
        if (!duplicate)
        {
            Console.Write(a[i] + " ");
            pusto = false;
        }
    }
}
if (pusto == true)
{
    Console.WriteLine("empty");
}