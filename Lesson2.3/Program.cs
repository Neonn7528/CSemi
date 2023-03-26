/*Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да*/


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num % 7;
int b = num % 23;
if ( a == 0 & b == 0)
{
    Console.WriteLine("Кратноe");
    }
else 
    Console.WriteLine("Не кратное");