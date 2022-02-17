// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int EndNumber(int number)
{
    int result = number % 10;
    return result;
}

Console.Write("Введите Двухзначное число: ");
int num = int.Parse(Console.ReadLine());

int numberA = EndNumber(num);
int numberB = num / 10;

if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " большее");
    Console.WriteLine("Число " + numberB + " меньшее");
}
else if (numberA < numberB)
{
    Console.WriteLine("Число " + numberB + " большее");
    Console.WriteLine("Число " + numberA + " меньшее");
}
else
{
    Console.Write("Числа равны");
}