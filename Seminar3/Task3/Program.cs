//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int Number)
{
    int NumInitial = 1;
    while(NumInitial <= Number)
    {   
        int CubeNum = Convert.ToInt32(Math.Pow(NumInitial,3));
        Console.WriteLine(CubeNum);
        NumInitial++;
    }
}

Console.Write("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine());

Cube(N);