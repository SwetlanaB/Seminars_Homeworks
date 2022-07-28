/*//  Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

N = 4532 -> 4*/

int AccountFingers(int n)
{
    if (n>9)
    {
        return 1 + AccountFingers(n=n/10);
    }  
    else return 1;

}
Console.WriteLine(AccountFingers(542981279));



