int[] a;
a = new int[] { -2, -1, 0, 1, 1, 4 };
int[] b;
b = new int[] { -3, -2, -1, 2, 3 };

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
        else if (a[i - 1] == b[j])
        {
            jest = true;
        }
    }
    if (jest == false)
    {
        Console.Write(a[i] + " ");
        pusto = false;
    }
}
if (pusto == true)
{
    Console.WriteLine("empty");
}
