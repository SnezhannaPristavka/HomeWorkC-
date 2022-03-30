Console.Write("Введите натуральное число" + " ");
int N = Convert.ToInt32(Console.ReadLine());
int NFirst = 1;

while(NFirst <= N)
{
    if(NFirst % 2 ==0)
    {
        Console.Write(NFirst + ", ");
        NFirst++;
    }
    else
    {
        NFirst++;
    }
}