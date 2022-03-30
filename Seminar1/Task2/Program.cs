//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA;
int numberB;
int numberC;
int max;
Console.Write("Введите первое целое число" + " ");
numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе целое число" + " ");
numberB = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третье целое число" + " ");
numberC = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(numberA + ", " + numberB + ", " + numberC);

if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

if (max > numberC)
{
    Console.Write("Максимальное число" + " ");
    Console.Write(max);
}
else
{
    max = numberC;
    Console.Write("Максимальное число" + " ");
    Console.Write(max);
}