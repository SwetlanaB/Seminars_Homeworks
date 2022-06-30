// Task8
int num , current;

Console.Write("Введите число N = ");
num = Convert.ToInt32(Console.ReadLine());

current=1;

while(current< num)
{
    current =(current+1);
    if (current % 2 != 0)
        Console.Write(current + " ");
}

