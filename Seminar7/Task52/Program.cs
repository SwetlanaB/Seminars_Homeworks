// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{
    int [,] newArray= new int[rows, columns];

    for(int i=0; i < rows; i++)
    {
         for(int j=0; j < columns; j++)
            newArray[i,j]=new Random() .Next(minValue, maxValue+1);
    }
        
    return newArray;        
}

void Show2dArray(int[,]array)
{
    for(int i=0; i <array.GetLength(0); i++)
    {
        
        for(int j=0; j <array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
        
}

void Avarage(int[,]array,int rows,int columns)
{
    
    int m= rows;
    int n=columns;

    for (int j=0; j <n; j++)
    {
        double avarage=0;
        Console.Write("Столбец " +(j+1)+" ");
         for (int i=0; i<rows;i++)
        {
           avarage=avarage+array[i,j];
        }
         Console.WriteLine("cреднее арифметическое столбца=" +avarage/m);
            
    }
   
}


Console.WriteLine("Input number of rows=" );
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of array=" );
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of array=" );
int max=Convert.ToInt32(Console.ReadLine());

int [,]myArray=CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Avarage(myArray, m,n);