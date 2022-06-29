// Task4
int numberA;
Console.Write("Введите число А = ");
numberA = Convert.ToInt32(Console.ReadLine());

int numberB;
Console.Write("Введите число B = ");
numberB = Convert.ToInt32(Console.ReadLine());

int numberC;
Console.Write("Введите число C = ");
numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(numberB >= max) max = numberB;
if(numberC >= max) max = numberC;
Console.WriteLine("Максимальное значение = " + max);