/* Задача 1: Задайте значения M и N. Напишите программу, которая
выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int Even(int mTemp)
{
    if (mTemp % 2 == 0) return mTemp;
    return Even(mTemp + 1);
}

Console.WriteLine("Программа нахождения четных чисел в промежутке от M до N");
Console.Write("Введите M: ");
string sm = Console.ReadLine();
int m = int.Parse(sm);
Console.Write("Введите N: ");
string sn = Console.ReadLine();
int n = int.Parse(sn);

while (m <= n)
{
    Console.Write($"{Even(m)}\t");
    m = m + 2;
}