// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");

// тичерский способ:
//string num = (Console.ReadLine());
//Console.WriteLine($"Третья цифра введенного числа: {num[2]}");


// математический способ
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int len = number;
    int count = 0;
    while (len != 0)
    {
        len = len / 10;
        count++;
    }
    int new_count = count - 3;
    while (new_count != 0)
    {
        number = number / 10;
        new_count--;
    }
    Console.WriteLine($"Третья цифра введенного числа: {number % 10}");
}
