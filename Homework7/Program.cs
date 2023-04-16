/*Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*
Console.Write("Введите количество строк в двумерном массиве:");
int numberOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве:");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[numberOfLines, numberOfColumns];
Generate2DArray(numbers);
PrintArray(numbers);

void Generate2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-30, 30))/10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/



/*Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/
/*
Console.WriteLine("Вам даны следующие цифры: ");
int[,] array = Generate2DArray(3,4);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10, 50);
        }
    }

    return array;
}

Console.Write("Введите номер строки выбранной вами цифры: ");
int numberOfLines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца выбранной вами цифры: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

    if (numberOfLines > array.GetLength(0))
    {
        Console.WriteLine("Нет такой строки.");
        return;
    }
    if ( numberOfColumns > array.GetLength(1))
    {
        Console.WriteLine("Нет такого столбца.");
    }
    else
    {
        Console.WriteLine($"Вы искали:{array[numberOfLines-1, numberOfColumns-1]}");
    }
/*



/*Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] array = Generate2DArray(3, 4);
PrintArray(array);


void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage += array[i, j];
    }
    avarage =Math.Round(avarage / array.GetLength(0), 1);
    Console.Write($"{avarage}; ");
}
