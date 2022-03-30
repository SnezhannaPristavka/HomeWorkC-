// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Method(int num1, int num2)
{
    int result = num1;
    if (num2 == 0) result = 1;
    if (num2 < 0) num2 = num2 * (-1);
    for (int count = 1; count < num2; count++)
    {
        result = result * num1;
    }
    return result;
}
Console.Write("Enter an integer A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an integer B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The number A to the power of B is " + Method(A,B));