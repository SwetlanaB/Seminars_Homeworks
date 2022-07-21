// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindElement(int[,]array,int m,int n,int x,int y)
{
 x=0;
 y=0;
 m=0;
 n=0;
 
    for(int i=0; i <m; i++)
    {
        for(int j=0; j <n; j++)
        {
         while (x<m && y<n)
            if ( array[i,j]==array[x,y])
            i=x;
            j=y;
                
        }   
    }    
    Console.Write("Число существует= " + array[x,y]); 
}


Console.WriteLine("Input number of rows=" );
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of array=" );
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of array=" );
int max=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x of array element=" );
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y of array element=" );
int y=Convert.ToInt32(Console.ReadLine());

int [,]myArray=CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);

FindElement(myArray,m,n,x,y);
