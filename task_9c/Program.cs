﻿// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число = ");
int a = Convert.ToInt32(Console.ReadLine()); // Перевели строчное выражение в числовое
Console.WriteLine("последняя цифра трёхзначного числа = " + a % 10);