// Task13F


void ThirdNumber()
{
int a = new Random().Next(1, 2147483647);
Console.WriteLine("Вывести на печать случайное число=" + a);

int result=0;

while (a > 1000) a = a / 10;
{
   if (a>100) 
   {
      result = a % 10;
  
      Console.Write("ТРЕТЬЯ ЦИФРА  =" + result);
   }
    
   else 
   {
      Console.Write("Число не содержит третью цифру");
   }
   
}
}   

ThirdNumber();  