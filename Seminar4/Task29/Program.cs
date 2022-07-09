// Task29:Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray( int size,int minValue, int maxValue)
{
int[] newArray= new int[size];

for (int i=0; i<size; i++)
    newArray [i]=new Random().Next(minValue,maxValue+1);

return newArray;
}
 
void ShowArray(int[]array)
{
    for(int i=0; i < array.Length;i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();

}


Console.WriteLine("Введите размер массива m");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max=Convert.ToInt32(Console.ReadLine());

int[]array=CreateRandomArray(size,min,max);


ShowArray(array);
