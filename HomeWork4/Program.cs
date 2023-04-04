/*Задача 25: Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B. БЕЗ Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа:");
int b = int.Parse(Console.ReadLine());
int Degree(int a, int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        a=a*c;
    }
    return a;
}
Console.WriteLine(Degree(a, b));*/


/* Напишите программу, которая принимает на вход
 число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

int ArreyLength(int number)//
{
    int i=0;
    while (number != 0)
    {
      number = number / 10;
      i++;
    }
    return i;
}
int[] CreatingAnArray(int number)
{
    int length = ArreyLength(number);
    int[] arrey = new int[length];
    for (int i = 0; i < length; i++) 
   {
        arrey[i] = number % 10;
        number = number /10;
    }
    return arrey;
}
int SummOfNumders(int number)
{
    int[] arrey = CreatingAnArray (number);
    int sum = 0;
    for (int i = 0; i <arrey.Length; i++)
    {
        sum = sum + arrey[i];
    }
    return sum;
}
Console.Write(SummOfNumders(number));*/


/*Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int [] array = new int [8];
void PrintArray (int[] array)// Метод вывода в консоль массива
{
    if (array.Length != 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length == 1)
            {
                Console.Write($"[{array[i]}]");
            }

            else if (i == 0)
            {
                Console.Write($"[{array[i]},");
            }

            else if (i == array.Length -1)
            {
                Console.Write($" {array[i]}]");
            }
            
            else
            {
                Console.Write($" {array[i]},");
            }
        }
    }
}
void FillArray(int[] collection) //void - метод не возрашает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}
FillArray(array);
PrintArray(array);
