/* Напишите прогу, которая на выход принемает
два числа и выдает какое больше, а какое меньше.
int max = 0;
int min = 0;
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if( a > b ) { 
    max = a; min = b;
}
else { max = b; min = a;
 } 
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);*/


/*Напишите прогу, которая на вход принемает
три числа и выдает максимальное из них.
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if( a >= max ) { 
    max = a;
}
if( b > max ) { 
    max = b;
}
if( c > max ) { 
    max = c;
}
Console.Write("max = ");
Console.WriteLine(max);*/



/*Напишите прогу, которая на вход принемает
число и выдает является ли число четным.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int res = a % 2;
if ( res == 0 )
{
  Console.WriteLine("Четное");  
}
else
{
    Console.Write("Не четное");
}*/


/*Напишите прогу, которая на вход принемает
число N, а на выходе показывает все четные числа от 1 до N.*/
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()); 
for (int a = 1; a <= N; a++)
    if ( a % 2 == 0 )
        Console.WriteLine(a);