//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummaNum(int m,int n)
{
  if(m==n) return m; 
  else 
  {
   return n +SummaNum(m,n-1);
  }
}   
Console.Write("Сумма элементов промежутка от m до n = "  +SummaNum(5,9));
       

