// Task34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray( int size,int minValue,int maxValue)
{
int[] newArray= new int[size];


for (int i=0; i<size; i++)
    newArray [i]=new Random().Next(100,999);

return newArray;
}
 
void ShowArray(int[]array)
{
    for(int i=0; i < array.Length;i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();

}

int FindQuantity(int []array)
{
    int quant=0;

    for (int i=0; i<array.Length; i++)
    
    if(array[i]%2 == 0 ) quant=quant+1;
        
 return quant;

}


Console.WriteLine("Задайте размер массива ");
int size=Convert.ToInt32(Console.ReadLine());


int[]array=CreateRandomArray(size,100,999);

ShowArray(array);

int quantOfArray=FindQuantity(array);
Console.WriteLine("Количество четных случайных значений массива равно " +quantOfArray);