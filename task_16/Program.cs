// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число от 1 до 7");
string num = Console.ReadLine();

if (num == "6") Console.WriteLine("Выходной /суббота");

if (num == "7") Console.WriteLine("Выходной /воскресенье");

else Console.WriteLine("Рабочий день недели");
