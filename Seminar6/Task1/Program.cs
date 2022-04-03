// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Вариант1 не смогла довести до ума, как выйти из цикла. Не придумала ничего лучшего, чем выйти через число 0
//но понимаю, что это не корректно.
/*void InputNumber(int counter)
{
    try
    {
        Console.WriteLine("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        while (num != 0)
        {
            if(num > 0) counter++;
            Console.WriteLine("Введите число: ");
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Положительных чисел " + counter);
    }
    catch (Exception e)
    {
        Console.WriteLine("Ввод некорректен: " + e.Message);
        InputNumber(counter);
    }
}
int count = 0;
InputNumber(count);*/

//Вариант2 рабочий

string x = "0";
int count = 0;
while(x.ToLower()!="stop")// подсвечивает, не знаю почему. Если убрать ToLower() светить не будет.
{
    double y = Convert.ToDouble(x);
    if(y > 0) count++;
    Console.WriteLine("Введите число или слово stop для завершения программы: ");
    x = Console.ReadLine(); // подсвечивает, не знаю почему.). На самой первой лекции в примере у лектора не светилось
}
Console.WriteLine("Положительных чисел " + count);