// Удалить вторую цифру трёхзначного числа
/*
int numberA = new Random().Next(100, 999); // 100, 101, ... 998
Console.WriteLine("numberA = " + numberA);

int n1 = numberA /100 % 10;
int n2 = numberA /10 % 10;
int n3 = numberA % 10;

int numberB = n1* 10 + n3;

Console.WriteLine("Удалить вторую цифру трёхзначного числа numberA = " + numberB);
*/

int EndNumber(int number)
{
    int n1 = number /100 % 10;
    int n2 = number /10 % 10;
    int n3 = number % 10;
    int result = n1* 10 + n3;
    return result;
}
Console.Write("Введите Трехзначное число = ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("последняя цифра трёхзначного числа = " + EndNumber(num));