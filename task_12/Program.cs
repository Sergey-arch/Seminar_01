// Удалить вторую цифру трёхзначного числа

int numberA = new Random().Next(100, 999); // 100, 101, ... 998
Console.WriteLine("numberA = " + numberA);

int n1 = numberA /100 % 10;
int n2 = numberA /10 % 10;
int n3 = numberA % 10;

int numberB = n1* 10 + n3;

Console.WriteLine("Удалить вторую цифру трёхзначного числа numberA = " + numberB);
