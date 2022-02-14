// Выяснить является ли число чётным

int numberA = new Random().Next(1, 999); // 1, 2, ... 998
Console.WriteLine("numberA = " + numberA);

if (numberA % 2 == 0)
{
    Console.WriteLine("число " + numberA + " Является четным");
}
else
{
    Console.WriteLine("число " + numberA + " Не является четным");
}