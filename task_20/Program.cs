// Задать номер четверти, показать диапазоны для возможных координат
/*
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");   
else if (x == 0 || y == 0) Console.WriteLine("Лежит на оси");
*/

/*
Console.Write("Введите четверть: ");
double num = Convert.ToDouble(Console.ReadLine());

double x = 1;
double n = 10;
if (num == 1) Console.WriteLine("I четверть");
{
    while (x <= n) Console.Write(" х " + x, x++);
    double y = 1;
    double n1 = 10;
    Console.WriteLine();
    while (y <= n1) Console.Write(" y " + y, y++);
}
Console.WriteLine();

double x2 = 1;
double n2 = 10;

if (num == 2) Console.WriteLine("II четверть");
{
    while (x2 <= n2 * (-1)) Console.Write(" х " + x2 * (-1), x2--);
    double y2 = 1;
    double n3 = 10;
    Console.WriteLine();
    while (y2 <= n3) Console.Write(" y " + y2, y2++);
}
Console.WriteLine();
*/




int Num(int x, int y)
{
    int i = 1;
    int n = 10;

    while (i <= n) Console.Write(" х " + i, i++);
    int i = 1;
    int n = 10; 
    return x;

}

Console.Write("Введите четверть от 1 до 4: ");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num > 4) Console.Write("Не верно ввели четверть ");
else if (num == 1) Console.WriteLine("I четверть ");


int x = Num(num);



//int x = Num(num);



