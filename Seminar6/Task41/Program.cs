// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int []CreateArray(int size)

{
    int[]newArray=new int[size];
    
    for( int i=0;i<size; i++)
    {
    Console.WriteLine($"Введите первое число{i+1}");
    newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    
Console.WriteLine();
return newArray;
}

void ShowArray(int[]array)
{
    for(int i=0; i < array.Length;i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}
int Count(int[]newArray)
{
 int count=0;
    
for(int i=0; i<newArray.Length;i++)
 
  if(0 <newArray[i]) count++;
    
return count;
}

Console.WriteLine("Введите размер массива");
int size=Convert.ToInt32(Console.ReadLine());

int[]array=CreateArray(size);

ShowArray(array);

int count=Count(array);
Console.WriteLine("Количество положительных введенных чисел массива равно: "+count);
