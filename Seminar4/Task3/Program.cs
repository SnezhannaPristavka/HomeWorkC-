// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*void FillArray (int[] collection)         //заполняет массив случайными числами из 8 элементов
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 100);
        Console.Write(collection[index] + " ");
        index++;
    }
    
}

int [] array = new int[8];
FillArray(array);*/


void FillArray (int[] collection)         //Функция, которая заполняет массив, запрашивая данные у пользователя
{
    for (int index = 0; index < collection.Length; index++)
    {   
        Console.Write("Enter " + index + " element of the array ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray (int[] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write(col[position] + " ");
    }
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
FillArray(array);
Console.WriteLine("Array");
PrintArray(array);