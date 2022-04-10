// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void Print(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           for (int j = 0; j < matrix.GetLength(2); j++)
           {
               Console.Write($"{matrix[k,i, j]} {(k,i,j)} ");
           }
           Console.WriteLine();
        }  
    }
    Console.WriteLine();
}

int[,,] array3 = new int[,,]
{
    {
        {12,22},
        {75,31}
    },

    {
        {45,53},
        {32,23}
    }
};
Print(array3);