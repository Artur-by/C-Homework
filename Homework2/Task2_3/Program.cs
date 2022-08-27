//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру, обозначающую день недели: ");
int day_number = int.Parse(Console.ReadLine());

if (day_number == 6 || day_number == 7)
{
    Console.WriteLine("Да, день выходной");
}
else
{
    if (day_number < 6 && day_number > 0)
    {
        Console.WriteLine("Нет, день будний");
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
    }
}
