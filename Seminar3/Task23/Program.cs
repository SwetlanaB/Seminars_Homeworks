// Task23:Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Ncube(int num)
{
      int current=1;
   
    while (current<=num)
    {
     int cube =current*current*current;
      current++;
      Console.Write(cube + " ");
    }
    return current;
    
  
}        
int number ; 
 Console.WriteLine(" Введите число:");
 number = Convert.ToInt32(Console.ReadLine());


 int x=Ncube(number);


