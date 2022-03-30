// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write("Enter " + index + " element of the array ");
        collection[index] = Convert.ToDouble(Console.ReadLine());
    }
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write(collection[index] + " ");
    }
}
void Diff(double[] number)
{
    double max = Double.MinValue;
    double min = Double.MaxValue;
    int ind = 0;
    while (ind < number.Length)
    {
        if (number[ind] > max) max = number[ind];
        if (number[ind] < min) min = number[ind];
        ind++;
    }
    double diff = max - min;
    Console.WriteLine();
    Console.Write("Difference between max and min: " + diff);
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
Diff(array);