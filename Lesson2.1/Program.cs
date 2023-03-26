/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98*/
Random nomber = new Random();
int nomberValue = nomber.Next(100, 1000);
int last = nomberValue / 100;
int result = last * 10;
int firstDigit = nomberValue % 10;
int result1 = result + firstDigit; 
Console.WriteLine(nomberValue);
Console.WriteLine(result1);
