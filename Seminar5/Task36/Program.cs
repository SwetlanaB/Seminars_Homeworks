// Task36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int Summa(int []array)
{
    int summa=0;

    for (int i=0; i<array.Length; i++)
    
    if(array[i]%2 == 1 ) summa=summa+array[i];
        
 return summa;

}


Console.WriteLine("Задайте размер массива ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное значение массива");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение массива");
int max=Convert.ToInt32(Console.ReadLine());



int[]array=CreateRandomArray(size,min,max);

ShowArray(array);

int sumOfArray=Summa(array);
Console.WriteLine("Сумма нечетных случайных значений массива равна " +sumOfArray);