﻿/* Задача No7. Напишите программу, которая
 принимает на вход трёхзначное число и на 
 выходе показывает последнюю цифру этого 
 числа.
456 -> 6 782 -> 2 918 -> 8*/
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
int a = N/10;
if (N<1000 & N>99){
Console.WriteLine(N % 10);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}