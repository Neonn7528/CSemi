/*Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. 
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*
Print(5);
void Print (int number, int i = 1)
{
    if (i<=number)
    {
Console.Write($"{number}, ");
Print (number-1, i);
    }
}
*/

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*
int m = DataInput();
int n = DataInput();
int DataInput()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}
Console.WriteLine($"M={m}; N={n} -> {SumNumber(m-1,n)}");
int SumNumber(int m, int n)
{
    int sum = m;
    if (m == n) return 0;
    else
    {
        m++;
        sum = m + SumNumber(m, n);
        return sum;
    }
}
*/

/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = DataInput();
int n = DataInput();
Console.WriteLine($"m={m}, n={n} -> A({m},{n}) = {Ackerman(m, n)}");

int DataInput()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }

}
