// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
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
}
int FindElement(int[,] arr, int i, int j)
{
    if (i < arr.GetLength(0) && j < arr.GetLength(1)) return arr[i, j];
    else return 0;
}

int row = 5;
int column = 5;
int[,] matrix = new int[row, column];
FillArray(matrix);
Print(FillArray(matrix));

Console.Write("Enter the number of the first position: ");
int firstPos = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of the second position: ");
int secondPos = Convert.ToInt32(Console.ReadLine());

if (FindElement(matrix, firstPos, secondPos) == 0) Console.WriteLine("This element does not exist.");
else Console.Write("Element " + FindElement(matrix, firstPos, secondPos) + " belongs to given position");