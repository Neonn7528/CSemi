﻿/*Задача No12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому.
 Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно*/

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int result = number1 % number2;
if (result ==0)
{
  Console.WriteLine("Кратно");  
}
else
{
    Console.Write("Не кратно - остаток:");
   Console.WriteLine(result);
}
