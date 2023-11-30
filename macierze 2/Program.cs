class Program
{
    static void Main()
    {
        // Wczytaj wymiary macierzy A
        string[] dimensionsA = Console.ReadLine().Split(' ');
        int n1 = int.Parse(dimensionsA[0]);
        int m1 = int.Parse(dimensionsA[1]);

        // Wczytaj macierz A
        int[,] matrixA = new int[n1, m1];
        string[] valuesA = Console.ReadLine().Split(' ');
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                matrixA[i, j] = int.Parse(valuesA[i * m1 + j]);
            }
        }

        // Wczytaj wymiary macierzy B
        string[] dimensionsB = Console.ReadLine().Split(' ');
        int n2 = int.Parse(dimensionsB[0]);
        int m2 = int.Parse(dimensionsB[1]);

        // Wczytaj macierz B
        int[,] matrixB = new int[n2, m2];
        string[] valuesB = Console.ReadLine().Split(' ');
        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                matrixB[i, j] = int.Parse(valuesB[i * m2 + j]);
            }
        }
        Console.Clear();
        // Sprawdź czy operacja mnożenia jest możliwa
        if (m1 != n2)
        {
            Console.WriteLine("impossible");
            return;
        }

        // Oblicz iloczyn macierzy A x B
        int[,] result = new int[n1, m2];
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                for (int k = 0; k < m1; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        // Wypisz wynik
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}