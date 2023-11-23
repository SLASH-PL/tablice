namespace macierze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            var (n, m) = ( temp[0], temp[1] );
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                var wiersz = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = wiersz[j];
                }
            }
            //wypisywanie tablicy kolumnami
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}