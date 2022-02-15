// Показать числа от -N до N

int numberA = new Random().Next(1, 10); // 1, 2, ... 9
Console.WriteLine("numberA = " + numberA);

int i = numberA * -1;
Console.WriteLine("i = " + i);

while(i != numberA + 1)
{
    Console.WriteLine("n = " + i);
    i++;
}