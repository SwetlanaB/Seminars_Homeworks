//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int [,]SmallToBig(int[,]array)
{
    for(int k=0; k< array.GetLength(0);k++)
    {
        for(int i=0; i <array.GetLength(0); i++)
        {
            for(int j=array.GetLength(1)-1; j >i; j--)
            {
             
                if (array[k,j-1]>array[k,j])
                {
                int temp=array[k,j-1];
                array[k,j-1]=array[k,j];
                array[k,j]=temp;
                }
            }     
        }
    }
    Console.WriteLine();
    return array;            
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
Show2dArray(SmallToBig(myArray));