// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
if(number < 0) number = number * (-1);
while (count != number)
{
    sum = sum + (number % 10);
    number = number / 10;
}
Console.Write("The sum of the numbers is " + sum);