// Показать вторую цифру трёхзначного числа
/*
int numberA = new Random().Next(100, 999); // 100, 101, ... 998
Console.WriteLine("numberA = " + numberA);

int result = numberA /10 % 10;
Console.WriteLine("Вторая цифра трёхзначного числа numberA = " + result);
*/

int EndNumber(int number)
{
    int result = number / 10 % 10;
    return result;
}
Console.Write("Введите Трехзначное число = ");
int num = int.Parse(Console.ReadLine()); // Перевели строчное значение в цифровое
Console.WriteLine("Вторая цифра трёхзначного числа = " + EndNumber(num));