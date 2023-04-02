/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120
*/
/*
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

int result = GetComposition(n);

Console.WriteLine(result);

int GetComposition(int number)
{
    int result = 1;
    
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
    
}
*/


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Random random = new Random();

int [] array = new int [8];

for (int i = 0; i < 8; i++)
{
    int randomValue = random.Next(0, 2);
    array[i] = randomValue;
}

PrintArray(array);

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}