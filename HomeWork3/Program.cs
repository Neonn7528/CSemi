/*Задача 19
Напишите программу, которая принимает на вход
 пятизначное число и проверяет, является ли оно
  палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length == 5)
{
    Metod(number);
}
else Console.WriteLine($"Число не пятизначное.");
void Metod(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром.");
    }
    else Console.WriteLine($"{number} - не палиндром.");
}

/*Задача 21
Напишите программу, которая принимает на вход
 координаты двух точек и находит расстояние между
  ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*Console.Write("Введите X1:");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1:");
int Z1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2:");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2:");
int Y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2:");
int Z2 = int.Parse(Console.ReadLine());
double result = GetDistance(X1, Y1, Z1, X2, Y2, Z2);
if (result == 0)
{
    Console.Write("Переменные введены не правильно");
    return;
}
Console.Write("Расстояние между точками: ");
Console.Write(result);
double GetDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    if (X1 == 0 & Y1 == 0 & Z1 == 0 & X2 == 0 & Y2 == 0 & Z2 == 0)
    {
        return 0;
    }
    double L;
    L = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    return L;
}*/
/*Напишите программу, которая принимает на вход число (N) и выдаёт
 таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
/*Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine());
Metod(N);
void Metod (int N){
    for (int i = 1; i <=N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}*/