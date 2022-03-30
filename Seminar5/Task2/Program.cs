//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-100,51);
        Console.Write(collection[index] + " ");
    }
}
int Sum(int[] mas)
{
    int ind = 0;
    int sum = 0;
    while(ind < mas.Length)
    {
        if(ind % 2 == 0) ind++;
        else
        {
            sum = sum + mas[ind];
            ind++;
        }
    }
    return sum;
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine();
Console.Write("Sum of numbers in odd position " + Sum(array));