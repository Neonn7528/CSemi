/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] array = Generate2DArray(3, 4);
PrintArray(array);
Console.WriteLine();
SelectionSort(array);
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
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temporary = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }
}




/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/
/*
int[,] array = Generate2DArray(3, 4);
PrintArray(array);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SummOfNumdersLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SummOfNumdersLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой элементов ");
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

int SummOfNumdersLine(int[,] array, int i)
    {
        int sumOfLine = array[i,0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                sumOfLine += array[i,j];
            }
        }
        return sumOfLine;
    }
*/



/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
int[,] array = Generate2DArray(2, 2);
PrintArray(array);
Console.WriteLine();

int[,] array2 = Generate2DArray(2, 3);
PrintArray(array2);
Console.WriteLine();

int[,] C = Multiplication(array, array2);
PrintArray(C);

static int[,] Multiplication(int[,] array, int[,] array2)
{
    int[,] r = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                r[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return r;
}
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
*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/
/*
int[,,] array = Generate3DArray(2, 2, 2);
PrintArray3D(array);

void PrintArray3D(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] Generate3DArray(int m, int n, int t)
{
    int[,,] array = new int[m, n, t];
    Random random = new Random();
    bool[] usedNums = new bool[90];
    int num;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < t; k++)
            {
                do
                {
                    num = random.Next(10, 100);
                }
                while (usedNums[num - 10]);
                 usedNums[num - 10] = true;
                array[i, j, k] = num;
            }

        }
    }

    return array;
}
*/


 /*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
/*
int[,] array = new int[4, 4];
int number = 1;
int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        array[rowStart, i] = number;
        number++;
    }
    rowStart++;

    for (int i = rowStart; i <= rowEnd; i++)
    {
        array[i, colEnd] = number;
        number++;
    }
    colEnd--;

    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = number;
            number++;
        }
        rowEnd--;
    }

    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = number;
            number++;
        }
        colStart++;
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
         Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}
*/