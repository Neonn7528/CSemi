/*Задача31. Задайте массиы из 12 
элементов и найдите сумму положительных
и сумму отрицательных.*/
int[] array = GenerateArray(12);
PrintArray(array);

int sum = CalculatePositiveSum(array);
int sumNegativeNumbers = CalculateNegativeSum(array);
Console.WriteLine($"Сумма положительных равна {sum}");
Console.WriteLine($"Сумма отрицательных равна{sumNegativeNumbers}");


int[] GenerateArray(int length)//генерация массива
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


int CalculateNegativeSum(int[] array)
{
    int sumNegative = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] < 0){
            sumNegative+=array[i];
        }
    }
    return sumNegative;
}
    int CalculatePositiveSum(int[] array)
{
    int sumPositive = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            sumPositive+=array[i];
        }
    }

    return sumPositive;
}
