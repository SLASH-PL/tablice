int[] a;
a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
int[] b;
b = new int[] { 0, 1, 2, 3, 3 };
int[] c = new int[9];


int i = 0, j = 0;
bool isEmpty = true;

while (i < a.Length && j < b.Length)
{
    if (a[i] < b[j])
    {
        if (i == 0 || a[i] != a[i - 1])
        {
            Console.Write(a[i] + " ");
            isEmpty = false;
        }
        i++;
    }
    else if (a[i] > b[j])
    {
        if (j == 0 || b[j] != b[j - 1])
        {
            Console.Write(b[j] + " ");
            isEmpty = false;
        }
        j++;
    }
    else
    {
        i++;
        j++;
    }
}

while (i < a.Length)
{
    if (i == 0 || a[i] != a[i - 1])
    {
        Console.Write(a[i] + " ");
        isEmpty = false;
    }
    i++;
}

while (j < b.Length)
{
    if (j == 0 || b[j] != b[j - 1])
    {
        Console.Write(b[j] + " ");
        isEmpty = false;
    }
    j++;
}

if (isEmpty)
{
    Console.Write("empty");
}