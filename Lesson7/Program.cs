//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
//m = 3, n = 4. 
// 1  4  8  19
// 5  -2 33 -2
// 77 3  8  1
/*
int[,] array = Generate2DArray(3,4);
PrintArray(array);
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
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
            //Console.WriteLine($"{i}, {j}");
            array[i, j] = random.Next(1, 15);
        }
    }

    return array;
}*/


/*Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4
Новый массив будет выглядеть вот так:
1 47 2
5 81 9
8 42 4*/
/*
int[,] array = Generate2DArray(4, 4);
PrintArray(array);
Console.WriteLine();
SquareNotEven(array);
PrintArray(array);

int[,] Generate2DArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void SquareNotEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2  != 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j%2 != 0)

                    array[i, j] = (int)Math.Pow(array[i, j], 2);
                }

        }
    }
}*/

/*Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.*/

int[,] array = Generate2DArray(3, 5);
PrintArray(array);
int summOfDiagonal = SumOfDiagonals(array);
Console.WriteLine($"Сумма диагонали от первого числа равна: {summOfDiagonal}");

int[,] Generate2DArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int SumOfDiagonals(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
            sum += array[i, j];
            }
        }
    }
    return sum;
}