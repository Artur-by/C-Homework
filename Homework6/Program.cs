// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int EnterNumber()
{
    int count = 0;
    Console.Write("Введите число или 0 чтобы закончить ввод: ");
    int enter = Convert.ToInt32(Console.ReadLine());
    while (enter != 0)
    {
        if (enter > 0) count += 1;
        Console.Write("Введите число или 0 чтобы закончить ввод: ");
        enter = Convert.ToInt32(Console.ReadLine());
    }
    return count;
}

int result = EnterNumber();
Console.WriteLine($"Количество чисел больше нуля:  {result}");
