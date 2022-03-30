// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
        Console.Write(collection[index] + " ");
    }
}

void Parity(int[] even)
{
    int count = 0;
    int position = 0;
    while (position < even.Length)
    {
        if (even[position] % 2 == 0)
        {
            count++;
            position++;
        }
        else
        {
            position++;
        }
    }
    Console.WriteLine();
    Console.Write("Number of even elements: " + count);
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Parity(array);