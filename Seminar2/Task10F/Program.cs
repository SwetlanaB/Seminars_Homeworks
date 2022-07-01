// Task10F

int SecondNum (int num)
{   
    return ((num / 10) % 10);
}

int numberA;
Console.Write("Введите число А = ");
numberA = Convert.ToInt32(Console.ReadLine());


int number = SecondNum (numberA);

Console.WriteLine("Ваше число будет=" +  number);