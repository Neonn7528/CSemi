/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
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
}