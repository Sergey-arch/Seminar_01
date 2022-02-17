// Показать вторую цифру трёхзначного числа

Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра трёхзначного числа = " + num / 10 % 10);