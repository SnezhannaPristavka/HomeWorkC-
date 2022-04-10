void Print(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}	
}
int[,] SnailArray(int n)
{
   int[,] matrix = new int[n,n];
   int start = 1, rows = n, columns = n, x = 0, y = 0;
   while(x < rows)
   {
       for(int j = x; j < rows; j++)
       {
           matrix[y, j] = start;
           start++;
       }
       rows = rows - 1;
       for( int i = (y + 1); i < columns; i++)
       {
           matrix[i, columns-1] = start;
           start++;
       }
       columns = columns - 1;
       for(int j = (rows-1); j >= x; j=j-1)
       {
           matrix[rows, j] = start;
           start++;
       }
       for(int i = (columns-1); i > y; i = i-1)
       {
           matrix[i, x] = start;
           start++;
       }
       x++; y++;
   }
   return matrix;
}
Console.WriteLine("Введите размер квадратного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Print(SnailArray(n));