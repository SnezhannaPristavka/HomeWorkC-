//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример решения 
/*
int numberA = 5;
Console.WriteLine(numberA);
int numberB = 7;
Console.WriteLine(numberB);
int max;
int min;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.Write("Максимальное число" + " ");
Console.WriteLine(max);
Console.Write("Минимальное число" + " ");
Console.Write(min);
*/

Console.Write ("Введите целое число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите целое число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max;
int min;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.Write("Максимальное число" + " ");
Console.WriteLine(max);
Console.Write("Минимальное число" + " ");
Console.Write(min);