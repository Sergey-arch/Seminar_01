// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите 5-ти значное число: ");
int a = int.Parse(Console.ReadLine());

if (a > 100000 || a < 10000) Console.WriteLine("Число не соответствует 5-ти значному");
else 
{
    int num1 = a % 10;
    int num2 = a / 10000;
    int num3 = a / 10 % 10;
    int num4 = a / 1000 % 10;

    if (num1 == num2 || num3 == num4) Console.WriteLine("Число соответсвует палиндрому " + a);
    else Console.WriteLine("Число Не соответсвует палиндрому: " + a);
}