// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число = ");
string a = Console.ReadLine();
if (a.Length < 3) Console.WriteLine("Третья цифра в числе numberA = " + a + " Отсутствует");
else Console.WriteLine("Третья цифра в числе numberA = " + a[2]);
