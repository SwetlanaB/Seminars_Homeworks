// Заполните спирально массив 4 на 4.

int [,]SpiraleArray(int rows,int columns)
{
    int[,] array=new int[4,4];
    int num=1;
    int d=1;

for(d=0; d<=1;d++)
{
for(int i=0+d; i<1+d;i++)
    {
        for (int j=0+d;j<4-d;j++)
        {
           array[i,j]=num; 
           
           Console.WriteLine(num);
          num++ ;
        }
    }
      
    for(int j=3-d;j<4-d;j++)
    {
        for (int i=1+d; i<4-d;i++)
        {
           array[i,j]=num;
           Console.WriteLine(num);
           num++ ;
        }
    }    
    
    for(int i=3-d; i<4-d;i++)
    {
        for (int j=2-d;j>=0+d;j--)
        {
           array[i,j]=num;
           Console.WriteLine(num);
           num++ ;
        }
    }
    for(int j=0;j>=0;j--)
    {
        for (int i=2-d; i>0+d;i--)
        {
          array[i,j]=num;
           Console.WriteLine(num);
           num++ ;
        }
    }
}
    
return array;
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

Console.WriteLine("Input number of rows=" );
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns=" );
int columns=Convert.ToInt32(Console.ReadLine());


int [,]myArray=SpiraleArray(rows,columns);
Show2dArray(myArray);