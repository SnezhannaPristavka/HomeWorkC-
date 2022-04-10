// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
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

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxPositionJ = j;
            for (int x = j + 1; x < array.GetLength(1); x++)
                if (array[i, x] > array[i, maxPositionJ])
                {
                    maxPositionJ = x;
                }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPositionJ];
            array[i, maxPositionJ] = temporary;
        }
    }

}

int[,] matrix = new int[3, 4];
FillArray(matrix);
Print(matrix);
SelectionSort(matrix);
Print(matrix);