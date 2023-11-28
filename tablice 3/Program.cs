int[] a;
a = new int[] { -2, -1, 0, 1, 4 };
int[] b;
b = new int[] { -3, -2, -1, 1, 2, 3 };
int[] c = new int[9];


bool empty = true;

// Iterate over elements of array a
for (int i = 0; i < a.Length; i++)
{
    bool existsInB = false;

    // Check if current element of a exists in array b
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            existsInB = true;
            break;
        }
    }

    // If current element of a does not exist in b, print it
    if (!existsInB)
    {
        // Check if current element is a duplicate
        bool duplicate = false;
        for (int k = 0; k < i; k++)
        {
            if (a[i] == a[k])
            {
                duplicate = true;
                break;
            }
        }

        // If current element is not a duplicate, print it
        if (!duplicate)
        {
            Console.Write(a[i] + " ");
            empty = false;
        }
    }
}

// Iterate over elements of array b
for (int i = 0; i < b.Length; i++)
{
    bool existsInA = false;

    // Check if current element of b exists in array a
    for (int j = 0; j < a.Length; j++)
    {
        if (b[i] == a[j])
        {
            existsInA = true;
            break;
        }
    }

    // If current element of b does not exist in a, print it
    if (!existsInA)
    {
        // Check if current element is a duplicate
        bool duplicate = false;
        for (int k = 0; k < i; k++)
        {
            if (b[i] == b[k])
            {
                duplicate = true;
                break;
            }
        }

        // If current element is not a duplicate, print it
        if (!duplicate)
        {
            Console.Write(b[i] + " ");
            empty = false;
        }
    }
}

// If there are no numbers to print, print "empty"
if (empty)
{
    Console.WriteLine("empty");
}