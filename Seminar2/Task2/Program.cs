// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdNum(int numeric)
{
    if (numeric >= 100 && numeric < 1000)
    {
        numeric = numeric % 100 % 10;
    }
    if(numeric >= 1000)
    {
        while(numeric >= 1000)
        {
            numeric = numeric / 10;
        }
        numeric = numeric % 100 % 10;
    }
    
    return numeric;
}

Console.Write("Enter any integer: ");
int Num = Convert.ToInt32(Console.ReadLine());

if(Num < 100) Console.Write("No third digit");
else Console.Write(ThirdNum(Num));