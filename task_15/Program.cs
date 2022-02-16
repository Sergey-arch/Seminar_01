// Дано число. Проверить кратно ли оно 7 и 23

int numberA = new Random().Next(160, 163); // 10, 11, ... 1000
Console.WriteLine("numberA = " + numberA);

if (numberA % 7 == 0) 
{
    if (numberA % 23 == 0)
    {
        Console.WriteLine("число " + numberA + " Является кратным 7 и 23");
    }
}
else
{
    Console.WriteLine("число " + numberA + " Не является кратным 7 и 23");
}

