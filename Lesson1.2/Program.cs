﻿/*Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/
Console.WriteLine("Введите цифру дня недели от 1 до 7");
int a = int.Parse(Console.ReadLine());

    if (a==1){
        Console.WriteLine("Понедельник");
    }
    if (a==2){
        Console.WriteLine("Вторник");
    }
    if (a==3){
        Console.WriteLine("Среда");
    }
    if (a==4){
        Console.WriteLine("Четверг");
    }
    if (a==5){
        Console.WriteLine("Пятница");
    }
    if (a==6){
        Console.WriteLine("Суббота");
    }  
    if (a==7){
        Console.WriteLine("Воскресенье");
    }
    if (a<0){
        Console.WriteLine("Такого дня недели нет");
    }
    if (a>7){
        Console.WriteLine("Такого дня недели нет");
    }