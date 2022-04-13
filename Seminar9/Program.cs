// Доработать и выслать релиазацию программы по выводу треугольника Паскаля.
void ShowTriangle(int number)
{
    for (int i = 0; i < number; i++)
    {
        for (int j = number; j > i + 1; j--)
        {
            Console.Write(" ");
        }

        int val = 1;

        for (int j = 0; j <= i; j++)
        {
            Console.Write(val + " ");
            val = (val * (i - j)) / (j + 1);
        }

        Console.WriteLine();
    }
}
Console.WriteLine("Введите порядок степени для треугольника");
int num = Convert.ToInt32(Console.ReadLine());
ShowTriangle(num);