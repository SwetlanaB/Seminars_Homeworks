// Task2
int numberA;
Console.Write("Введите число А = ");
numberA = Convert.ToInt32(Console.ReadLine());

int numberB;
Console.Write("Введите число В = ");
numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberA;

if(numberB >= max) max = numberB;
Console.WriteLine("Максимальное значение = " + max);
if (numberB<= min) min = numberB;
Console.Write("Минимальное значение= " + min);