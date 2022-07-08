// Task27:Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе(452 -> 11)

int Summa (int x)
{
   int summ=0;

 while (x>0) 
 {
    summ = summ + x %10;
    x=x/10;
       
 }
   
   return summ; 
} 


int number=0;
Console.WriteLine("Вводим любое число:");
number= Convert.ToInt32(Console.ReadLine());

int a=Summa(number);

Console.WriteLine("Сумма равна "+ a);

 