/* Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

int Sum(int mTemp, int nTemp, int sTemp)
{

    if (mTemp > nTemp) return sTemp;
    return Sum(mTemp + 1, nTemp, sTemp = sTemp + mTemp);
}

Console.WriteLine("Программа нахождения суммы натуральных чисел в промежутке от M до N");
Console.Write("Введите M: ");
string sm = Console.ReadLine();
int m = int.Parse(sm);
Console.Write("Введите N: ");
string sn = Console.ReadLine();
int n = int.Parse(sn);

/* int sum = 0;
while (m <= n)
{
    sum = sum + m;
    m++;
} */
int sum = 0;
Console.Write(Sum(m, n, sum));