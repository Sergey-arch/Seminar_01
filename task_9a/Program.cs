﻿// 

Console.Write("Введите число = ");

int num = int.Parse(Console.ReadLine()); // Перевели строчное значение в цифровое

int result = num % 10;
Console.WriteLine("последняя цифра трёхзначного числа = " + result);
