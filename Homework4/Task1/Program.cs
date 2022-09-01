// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int Result(int num_a, int num_b)
{
    int res = num_a;
    for (int i = 1; i < num_b; i++)
    {
        res = res * num_a;
    }
    return res;
}

Console.WriteLine($"{num_a} в степени {num_b} = {Result(num_a, num_b)}");
