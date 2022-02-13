// По двум заданным числам проверять является ли первое квадратом второго

int numberA = new Random().Next(1, 101); // 1 2 3 4 ... 100
Console.WriteLine("numberA  " + numberA);

int numberB = new Random().Next(1, 11); // 1 2 3 4 ... 10
Console.WriteLine("numberB  " + numberB);

if (numberA == numberB * numberB)
{
    Console.WriteLine("numberA   Является квадратом numberB");
}
else
{
    Console.WriteLine("numberA   Не является квадратом numberB");
}