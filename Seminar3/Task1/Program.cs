// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Number(int Num)
{
    int firstNum = Num / 10000;
    int secondNum = Num % 10000 / 1000; 
    int fourthNum = Num % 100 / 10;
    int fifthNum = Num % 10;
    
    if (firstNum == fifthNum && secondNum == fourthNum)
    {
        Console.Write("The number " + Num + " is palindromic");
    }
    else
    {
        Console.Write("The number " + Num + " is not palindromic");
    }
}

Console.Write("Enter a five-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

Number(number);

// оптимально лучше исользовать цикл с брейком, найти самое старшее и самое младшее сравнить. Через цикл будет программа универсальной для любого числа 