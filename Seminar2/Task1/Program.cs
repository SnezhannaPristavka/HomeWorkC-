//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondNum(int numeric)
{   
    if(numeric > 0)
    {
        numeric = numeric % 100 / 10;
    }
    else
    {
        numeric = (numeric % 100 / 10) * (-1);
    }
    
    return numeric;
}

Console.Write("Enter a three-digit number: ");
int Num = Convert.ToInt32(Console.ReadLine());

Console.Write("The second number is " + SecondNum(Num));

/*Вопрос задала в комментарии
int SecondNum(int numeric)
{
    int SecondN;
    
    if(numeric > 0)
    {
        SecondN = numeric % 100 / 10;
    }
    else
    {
        SecondN = (numeric % 100 / 10) * (-1);
    }
    
    return SecondN;
}*/