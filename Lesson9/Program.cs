/*Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке
 от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/
/*Print(7);
void Print (int number, int i = 1)
{
    if (i<=number)
    {
Console.Write($"{i}, ");
Print (number, i+1);
    }
}*/

/*Задача 65: Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"*/
/*
int m = DataInput();
int n = DataInput();
int DataInput()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}
Print(n,m);
void Print (int number, int i)
{
    if (i<=number)
    {
Console.Write($"{i} ");
Print (number, i+1);
    }
}*/

/*Задача 67: Напишите программу, которая будет принимать
 на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9*/
/*
int number = DataInput();
int DataInput()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int sum = Sumnumber(number);
Console.WriteLine($"{number} => {sum}");
int Sumnumber(int number)
{
    if (number > 0)
    {
        int sum = number % 10;
        number = number / 10;
        return Sumnumber(number) + sum;
    }
    return 0;
}
*/

/*Задача 69: Напишите программу, которая на вход
 принимает два числа A и B, и возводит число А в
  целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8*/

int A = DataInput();
int B = DataInput();
Console.WriteLine($"A={A}; B={B} => {DegreeNumber(A,B)}");
int DataInput()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int DegreeNumber(int A, int B)
{
    if (B>0)
    {
        --B;
        return DegreeNumber(A,B)*A;
    }
    return 1;
}
