// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите неотрицательные число m: ");
double numberM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательные число n: ");
double numberN = Convert.ToDouble(Console.ReadLine());

double Akkerman(double m, double n)
{
    if (m == 0) return n + 1;

    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);

    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;

}

Console.WriteLine(Akkerman(numberM, numberN));