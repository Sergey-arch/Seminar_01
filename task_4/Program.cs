// Найти максимальное из трех чисел

int numberA = new Random().Next(1, 21); // 1 2 3 4 ... 20
Console.WriteLine("numberA  " + numberA);

int numberB = new Random().Next(1, 21); // 1 2 3 4 ... 20
Console.WriteLine("numberB  " + numberB);

int numberC = new Random().Next(1, 21); // 1 2 3 4 ... 20
Console.WriteLine("numberC  " + numberC);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);