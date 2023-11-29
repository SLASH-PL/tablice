
static double Srednia(int[,] tab)
{
    if (tab == null || tab.Length == 0)
    {
        return 0.00;
    }

    int sum = 0;
    int count = 0;

    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            int value = tab[i, j];
            if (value > 0)
            {
                sum += value;
                count++;
            }
        }
    }

    if (count == 0)
    {
        return 0.00;
    }

    double average = (double)sum / count;
    return Math.Round(average, 2);
}