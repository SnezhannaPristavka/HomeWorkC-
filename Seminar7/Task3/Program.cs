// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 31);
        }
    }
}
void Print(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Average(int[,] block)
{
    float sum = 0;
    float averageNum = 0;
    for (int j = 0; j < block.GetLength(1); j++)
    {
        for (int i = 0; i < block.GetLength(0); i++)
        {
            sum = sum + block[i, j];
        }
        averageNum = sum / block.GetLength(0);
        Console.Write(Math.Round(averageNum, 2) + " ");
        sum = 0;
        averageNum = 0;
    }

}
Console.Write("Set row length: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Set column length: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];

FillArray(matrix);
Print(matrix);
Average(matrix);