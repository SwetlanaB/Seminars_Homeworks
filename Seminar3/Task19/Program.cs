// Task19:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int number)
{
int sum = 0;


while (number >sum)
    {
        sum = number % 10+ sum;
        sum = (sum* 10);
        number = number / 10; 
       
    }
 sum= sum/100;

if (number == sum)
    {
        Console.WriteLine("Это число палиндром"+ number+" "+sum );
    }
    else
    {
    Console.WriteLine("Число не палиндром"+ number+"  "+sum);
    }
            
}

int number;
Console. WriteLine("Введите пятизначное число= " );
number=Convert.ToInt32(Console.ReadLine()); 

Palindrom(number);





 
           