// Найти третью цифру числа или сообщить, что её нет

int EndNumber(int number)
{
    int result = number % 10;
    
    return result;
}
Console.Write("Введите Трехзначное число = ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("последняя цифра трёхзначного числа = " + EndNumber(num));