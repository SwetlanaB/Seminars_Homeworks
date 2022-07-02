// Task15F:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Weekend( int a)
{
   if(a>=1 && a<=7)
   {
    if(a ==1) Console.WriteLine("1 = > нет");
        if(a ==2) Console.WriteLine("2 = > нет");
        if(a ==3) Console.WriteLine("3 = > нет");
        if(a ==4) Console.WriteLine("4 = > нет");
        if(a ==5) Console.WriteLine("5 = > нет");
        if(a ==6) Console.WriteLine("6 => ДА, выходной!");
        if(a ==7) Console.WriteLine("7 = > ДА, выходной!");
   }
    else
        Console.WriteLine("Неверный ввод цифры");
}
 
Console.WriteLine("Введите цифру, обозначающую день недели-");
int day = Convert.ToInt32(Console.ReadLine());

Weekend(day);
