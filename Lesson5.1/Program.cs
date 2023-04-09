/*Задача 33: Задайте массив. Напишите программу,
 которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3;
 массив [6, 7, 19, 345, 3] -> да*/

/*int[] array = GenerateArray(4);
PrintArray(array);
ChangeSignOfNumbers(array);
PrintArray(array);

 int[] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
void ChangeSignOfNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}*/


/*Задача 33: Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
 3; массив [6, 7, 19, 345, 3] -> да*/
/*int[] array = GenerateArray(5);
PrintArray(array);
int num = 3;
Console.WriteLine(NumberInArray(array, 3));
Console.WriteLine(num);
bool NumberInArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return fals;
 }

 int[] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат
 в отрезке [10,99].
Пример для массива из 5, а не 123 элементов.
 В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
/*int[] array = GenerateArray(123);
PrintArray(array);
 int[] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-20, 120);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int QuantityInBetween(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>min & array[i]<max)
        {
            count++;
        }
    }
}*/
/*Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и
  предпоследний
и т.д. Результат запишите в новом массиве.
 [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
int[] array = GenerateArray(9);
PrintArray(array);
int[] array2 = Multiplpkation(array);
PrintArray(array2);
int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 11);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
int[] Multiplpkation(int[] arr)
{
    int[] array = new int[arr.Length/2+arr.Length%2];
    for (int i = 0; i < arr.Length/2+arr.Length%2; i++)
    {
        if (i == (arr.Length -1 -i))
        {
            array[i] = arr[i];
            return array;
        }
            else
            {
                array[i] = arr[i] * arr[arr.Length -1 -i];
            }
    }
    return array;
}