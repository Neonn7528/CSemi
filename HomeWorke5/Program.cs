/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*
int[] array = GenerateArray(4);
PrintArray(array);
Console.WriteLine($"=>{NumberOfEven(array)}");

int NumberOfEven (int[] array)
{ 
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] % 2 == 0 )
         {
            num++;
         }
    }
    return num;
}

 int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}*/



/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*
int[] array = GenerateArray(4);
PrintArray(array);
Console.WriteLine($"=> {NumberOfOddNumbers(array)}");
int NumberOfOddNumbers (int[] array)
{
    int noteven = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        noteven += array[i];
    }
    return noteven;
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-20, 20);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}*/


/*
Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] array = GenerateArray(5);
PrintArray(array);
Console.WriteLine($"Максимальное число: {Maximum(array)}");
Console.WriteLine($"Минимальное число: {Minimum(array)}");

double NumberDifference = Maximum(array) - Minimum(array);
Console.WriteLine($"Разница чисел: {NumberDifference}");

int Minimum(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
int Maximum(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}


int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(" ", array)}]");
}