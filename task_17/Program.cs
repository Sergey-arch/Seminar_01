// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите Первое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите Второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num == num2 * num2 | num2 == num * num) Console.Write("Является");
else Console.Write("Не является");
