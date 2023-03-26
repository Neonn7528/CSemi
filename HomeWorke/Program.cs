/* Напишите прогу, которая на выход принемает
два числа и выдает какое больше, а какое меньше.*/
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
Console.WriteLine(min);
