// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int numberA = new Random().Next(10, 100); // 10, 11, ... 99
Console.WriteLine("numberA = " + numberA);

int tens = numberA / 10 % 10; 
int units = numberA % 10;

int max = tens;

if (tens > max) max = tens;
if (units > max) max = units;

Console.WriteLine("max = " + max);