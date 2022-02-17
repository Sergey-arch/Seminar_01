// Найти третью цифру числа или сообщить, что её нет


int numberA = new Random().Next(1000, 10000);
Console.WriteLine("numberA = " + numberA);
string s1 = numberA.ToString();
if (s1.Length < 3) Console.WriteLine("Третья цифра в числе numberA = " + s1 + " Отсутствует");
else Console.WriteLine("Третья цифра в числе numberA = " + s1[2]);
