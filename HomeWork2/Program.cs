/*Напишите программу, которая принимает
 на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*Random namber = new Random();
int nomberValue = namber.Next(100, 1000);
int last = nomberValue / 10;
int result = last % 10;
Console.WriteLine(nomberValue);
Console.WriteLine(result);*/


/*Напишите программу, которая выводит третью цифру заданного
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string abc = Convert.ToString(num);
    if (abc.Length > 2)
{
  Console.WriteLine($"{num} -> {abc[2]}");
}
    else 
{
  Console.WriteLine($"{num} -> третьей цифры нет");
}*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
 день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());
    if (num < 6 & num > 0)
{
        Console.WriteLine($"{num} -> не выходной");
}
    if (num == 6 | num == 7)
{
         Console.WriteLine($"{num} -> выходной");
}
    if (num < 0 | num > 7)
{
         Console.WriteLine($"{num} -> Нет такого дня недели");
}