int count = 0;
int distance = 10000;
int FriendSpeed1 = 1;
int FriendSpeed2 = 2;
int DogSpeed = 5;
int time;
int friend = 2;
int meeting = 10;

Console.Clear();
while(distance > meeting)
{
    if(friend == 1)
    {
       time = distance / (FriendSpeed1 + DogSpeed);
       friend = 2;
    }
    else
    {
        time = distance / (FriendSpeed2 + DogSpeed);
        friend = 1;
    }
    distance = distance - (FriendSpeed1 + FriendSpeed2) * time;
    count++;
    Console.WriteLine("Оставшаяся дистанция" + " " + distance + ", ");
}

Console.WriteLine("Количество раз, которое пробежала Собака: " + count);