// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            matrix[i, j] = rand.Next(-100,101) * rand.NextDouble(); //0.0 до 1.0
            Console.Write($"{Math.Round(matrix[i, j], 2)} ");
        }
    Console.WriteLine();
    }
}
int row = 3;
int column = 4;

FillArray(row, column);