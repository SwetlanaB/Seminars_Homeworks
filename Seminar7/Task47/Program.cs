﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.m = 3, n = 4.
double[,] CreateRandom2dArray(int rows, int columns)
{
    double [,] newArray= new double[rows, columns];

    for(int i=0; i < rows; i++)
    {
         for(int j=0; j < columns; j++)
            newArray[i,j]=new Random().NextDouble()*100.0;
    }
        
    return newArray;        
}

void Show2dArray(double[,]newArray)
{
    for(int i=0; i <newArray.GetLength(0); i++)
    {
        for(int j=0; j <newArray.GetLength(1); j++)
            Console.Write(newArray[i,j]+" ");
        
        Console.WriteLine();
    }
        
}
Console.WriteLine("Input number of rows=" ); 
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int n=Convert.ToInt32(Console.ReadLine());


double[,]myArray=CreateRandom2dArray(m,n);
Show2dArray(myArray);
