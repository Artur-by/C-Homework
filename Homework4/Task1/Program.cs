// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
double num_a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B: ");
double num_b = Convert.ToDouble(Console.ReadLine());

double Result(double num_a, double num_b)
{
    double res = Math.Pow(num_a, num_b);
    return res;
}

Console.WriteLine($"{num_a} в степени {num_b} = {Result(num_a, num_b)}");
