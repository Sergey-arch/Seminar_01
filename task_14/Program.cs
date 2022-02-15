// Найти третью цифру числа или сообщить, что её нет

int numberA = new Random().Next(10, 999); // 10, 11, ... 998
Console.WriteLine("numberA = " + numberA);

if (numberA /100 % 10 == 0)
{
    Console.WriteLine("Третья цифра в числе numberA = " + numberA + " Отсутствует");
}
else
{
    int result = numberA % 10;
    Console.WriteLine("Третья цифра от числа numberA = " + result);
}
