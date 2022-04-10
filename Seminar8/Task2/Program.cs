// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 15);
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

void FindMinSumRow(int[,] masive)
{
    int sum = 0;
    int minSum=int.MaxValue;
    int count = 0;
    for (int i = 0; i < masive.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < masive.GetLength(1); j++)
        {
            sum = sum + masive[i,j];
        }
        if(sum < minSum) 
        {
            minSum = sum;
            count = i + 1;
        }
    }
    Console.WriteLine("The smallest amount is " + minSum + " in line number " + count);
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
Print(matrix);
FindMinSumRow(matrix);