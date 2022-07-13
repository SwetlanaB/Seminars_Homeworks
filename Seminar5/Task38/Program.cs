//Task38

double[] CreateRandomArray(int size)
{
double[] newArray= new double[size];

for (int i=0; i<size; i++)
    newArray [i]=new Random().NextDouble()*100.0;
return newArray;
}
 

void ShowArray(double[]newArray)
{
    for(int i=0; i < newArray.Length;i++)
        Console.Write(newArray[i]+" ");

    Console.WriteLine();

}

double MinMax(double[]newArray)
{
    double result=0;
    double min=newArray[0];
    double max=newArray[0];
    for(int i=1; i < newArray.Length; i++)
    {
        if(min>newArray[i]) min=newArray[i];
        if(max<newArray[i]) max=newArray[i];
        
    }
    Console.Write("min-" +min);
    Console.WriteLine();
    Console.Write("max-" +max);
    result=max-min;
    return result;

}
Console.WriteLine("Введите размер массива"); 
int size=Convert.ToInt32(Console.ReadLine());


double[]array=CreateRandomArray(size);

ShowArray(array);

double r=MinMax(array);
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным значением равна=" +r); 