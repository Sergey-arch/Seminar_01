// Показать последнюю цифру трёхзначного числа
/*
Console.Write("Введите число = ");

int num = int.Parse(Console.ReadLine()); // Перевели строчное значение в цифровое

int result = num % 10;
Console.WriteLine("последняя цифра трёхзначного числа = " + result);
*/

int EndNumber(int number)
{
    int result = number % 10;
    return result;
}
Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine()); // Перевели строчное значение в цифровое
Console.WriteLine("последняя цифра трёхзначного числа = " + EndNumber(num));
