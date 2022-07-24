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
   
   int minSum=0;
   int iMin=0;

    for(int i=0; i <1; i++)
    {  
         for(int j=0; j <n; j++)
        {
            minSum=minSum+array[i,j];//Console.WriteLine("минимальная сумма"+minSum);
        }
    }      
     
    for(int i=1; i <m; i++)
    {  
        int sum=0;
         for(int j=0; j <n; j++)       
        {    
          sum=sum+array[i,j];// Console.WriteLine("Сумма строки" +sum); 
        }     
            if  (sum <= minSum)
            {
                minSum = sum;
                iMin=i+1;
            } 
    }          
                
         
Console.WriteLine("Минимальная сумма =" +minSum);
Console.WriteLine("искомая строка="+iMin);  
  
return minSum; 
}        


Console.WriteLine("Input number of rows=" );
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int n=Convert.ToInt32(Console.ReadLine());


int [,]myArray=Create2dArray(m,n);
Show2dArray(myArray);
 
int  minSum=RangeSum(myArray,m,n);
 