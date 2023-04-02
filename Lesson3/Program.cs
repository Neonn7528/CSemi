/*Console.Write("Введите х:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите у:");
int y = int.Parse(Console.ReadLine());
int result = GetNumberOfQarter(x, y);
//if (result == 0)
    if (x == 0 || y == 0)
    {
        Console.WriteLine("х или у равны нулю.");
        return;
    }
Console.WriteLine(result);

int GetNumberOfQarter(int x, int y)
{
    {
        if (x > 0 && y > 0)
            return 1;
    }
    {
        if (x < 0 && y > 0)
            return 2;
    }
    {
        if (x < 0 && y < 0)
            return 3;
    }
    {
        if (x > 0 && y < 0)
            return 4;
    }
    return 0;
}*/

/*Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).*/

/*Console.WriteLine("Введите номер четверти:");
int quarter = int.Parse(Console.ReadLine());
string result = GetXY(quarter);
if (result == "0")
{
    Console.Write("Номер четверти введен не правильно");
    return;
}
Console.Write("В четверть попадаюат: ");
Console.Write(result);
string GetXY(int quarter)
{
    if (quarter == 1)
    {
        return "X > 0 и Y > 0";
    }
    if (quarter == 2)
    {
        return "X < 0 и Y > 0";
    }
    if (quarter == 3)
    {
        return "X < 0 и Y < 0";
    }
    if (quarter == 4)
    {
        return "X > 0 и Y < 0";
    }
    return "0";
}*/


/*Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21*/

/*Console.Write("Введите X1:");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2:");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2:");
int Y2 = int.Parse(Console.ReadLine());
double result = GetDistance(X1, X2, Y1, Y2);
if (result == 0)
{
    Console.Write("Переменные введены не правильно");
    return;
}
Console.Write("Расстояние между точками: ");
Console.Write(result);
double GetDistance(int X1, int X2, int Y1, int Y2)
{
    if (X1 == 0 & Y1 == 0 & X2 == 0 & Y2 == 0)
    {
        return 0;
    }
    double L;
    L = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    return L;
}

/*Напишите программу, которая принимает на вход число
 (N) и выдаёт таблицу квадратов чисел
от 1 до N. (без метода).
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/
/*Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i * i);
}
/*Напишите программу, которая принимает на вход число
 (N) и выдаёт таблицу квадратов чисел
от 1 до N. (С МЕТОДОМ).
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/
Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine());
Metod(N);
void Metod (int N){
    for (int i = 1; i <=N; i++)
    {
        Console.WriteLine(i * i);
    }
}


