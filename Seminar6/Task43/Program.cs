// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


void FindPoint(double k1, double k2,double b1, double b2)
{

double x=0; 
double y=0;
 
if((k1/k2)==(b1/b2)) Console.WriteLine("Прямые совпадают, точек пересечения множество");
    if (k1==k2) Console.WriteLine("Прямые параллельны, точки пересечения нет. Введите другое значение k"); 
    else 
{
    x=(b2-b1)/(k1-k2);
    y=(k2*x+b2);
}
        
Console.WriteLine(" Координаты точки пересечения x=" +x);
Console.WriteLine(" Координаты точки пересечения y=" +y); 
 
}  

double k1 =0 ;
Console.WriteLine(" Пользователь вводит значение k1 = ");
k1 = Convert.ToDouble(Console.ReadLine());
double k2 =0 ;
Console.WriteLine(" Пользователь вводит значение k2 = ");
k2 = Convert.ToDouble(Console.ReadLine());
double b1=0;
Console.WriteLine("Пользователь вводит значение b1 = ");
b1 = Convert.ToDouble(Console.ReadLine());
double b2=0;
Console.WriteLine("Пользователь вводит значение b2 = ");
b2 = Convert.ToDouble(Console.ReadLine());          


FindPoint(k1,k2,b1,b2);

    





    