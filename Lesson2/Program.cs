
/*int a = 5;
int b = 6;
int c = 2;
int d = 3;

int result1 = Calculate(a, b);
Show (a,b);
int result2 = Calculate(c, d);
Show (c,d);
Console.WriteLine(result1);
Console.WriteLine(result2);
int Calculate(int a, int b)
{
    return a * (a * b) - 5;
}
void Show(int a, int b)
{
Console.WriteLine($"{a} , {b}");
}*/


/*Выводит случайное число из отрезка {10, 99}
показывает наибольшее цифру в числе*/
Random nomber = new Random();
int nomberValue = nomber.Next(10, 99);
int lastDigit = nomberValue % 10;
int firstDigit = nomberValue / 10;
Console.WriteLine(nomberValue);
if (lastDigit > firstDigit){
    Console.WriteLine(lastDigit);
}
else{
    Console.WriteLine(firstDigit);
}