// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Week(int Day)
{
    if(Day <= 7 && Day >= 1)
    {
        if(Day == 1) Console.WriteLine("Понедельник. Будний день!");
        if(Day == 2) Console.WriteLine("Вторник.Будний день!");
        if(Day == 3) Console.WriteLine("Среда.Будний день!");
        if(Day == 4) Console.WriteLine("Четверг.Будний день!");
        if(Day == 5) Console.WriteLine("Пятница.Уже почти, но будний день!");
        if(Day == 6) Console.WriteLine("Суббота.Ура!Выходной!");
        if(Day == 7) Console.WriteLine("Воскресенье.Ура!Выходной!");
    }
    else Console.WriteLine("Не существует");

}

Console.Write("Enter a number representing the day of the week ");
int number = Convert.ToInt32(Console.ReadLine());

Week(number);