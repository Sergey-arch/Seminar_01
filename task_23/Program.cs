// Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите n: ");
double n = Convert.ToDouble(Console.ReadLine());
double i = 1;
while (i <= n) Console.Write("\t" + i, i++);
Console.WriteLine();
double j = 1;
while (j <= n) Console.Write("\t" + j * j, j++);
