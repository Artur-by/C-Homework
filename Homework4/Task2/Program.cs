// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целочисленное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int count = 0;
    while (number != 0)
    {
        count = count + number % 10;
        number = number / 10;
    }
    return count;
}

Console.WriteLine($"Сумма цифр в числе {numb} = {Sum(numb)}");