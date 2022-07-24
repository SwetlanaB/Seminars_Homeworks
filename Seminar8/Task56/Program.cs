// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray(int m, int n)
{
    int [,] newArray= new int[m, n];
    
    for(int i=0; i < m; i++)
    {
         for(int j=0; j < n; j++)
         {
            Console.WriteLine("Введите число");
            newArray[i,j]=Convert.ToInt32(Console.ReadLine()); ;
         }
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

int RangeSum(int[,]array,int m,int n)
{
   int sum=0;
    for(int i=0; i <m; i++)
    {  
        sum=0;
            for(int j=0; j <n; j++)
            {
               sum=sum+array[i,j];
            }
            Console.WriteLine(sum);
    }
    return sum;           
}

int[]CreateArray(int size)
{
    int[]newArray=new int[size];
    
    for( int i=0;i<size; i++)
    {
    Console.WriteLine($"Введите число{i+1}");
    newArray[i]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(); 
    }
    return newArray;
}    

void MinSum( int[]newArray,int m)
{
int min=newArray[0];

    for(int i=0;i<m; i++)
    {
    if(min>newArray[i]) min=newArray[i]; 
    
    }
    Console.WriteLine("минимальная сумма="+min);
} 

Console.WriteLine("Input number of rows=" );
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int n=Convert.ToInt32(Console.ReadLine());


int [,]myArray=Create2dArray(m,n);
Show2dArray(myArray);
int a=RangeSum(myArray,m,n);
int []newArray=CreateArray(m);
MinSum(newArray,m);