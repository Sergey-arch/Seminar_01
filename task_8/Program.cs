// Показать четные числа от 1 до N

int numberA = new Random().Next(10, 100); // 10, 11, ... 99
Console.WriteLine("numberA = " + numberA);

for (int i = 1; i <= numberA; i++)
{
    if ((i % 2 == 0) && !(i == 1))
    {
        Console.WriteLine(i);
    }
}
