// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numberA = new Random().Next(10, 1001); // 10, 11, ... 1000
Console.WriteLine("numberA = " + numberA);

int numberB = new Random().Next(1, 10); // 1, 2, ... 9
Console.WriteLine("numberB = " + numberB);

if (numberA % numberB == 0)
{
    Console.WriteLine("число " + numberA + " Является кратным " + numberB);
}
else
{
    Console.WriteLine("число " + numberA + " Не является кратным " + numberB);
    int result = numberA % numberB;
    Console.WriteLine("Остаток от числа numberA = " + result);
}