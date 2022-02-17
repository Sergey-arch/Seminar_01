// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

if (num > 7) Console.WriteLine("Такой день недели не существует");

else if (num == 6 || num == 7) Console.WriteLine("Выходной день недели");

else Console.WriteLine("Рабочий день недели");
