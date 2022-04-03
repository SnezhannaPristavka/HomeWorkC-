//Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
//Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1
void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix [i, 0] = 1;
        matrix [i, matrix.GetLength(1)-1] = 1;
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [0, j] = 1;
        matrix [matrix.GetLength(0)-1, j] = 1;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите количество строк в массиве ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов в массиве ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, column];
PrintArray (matrix);