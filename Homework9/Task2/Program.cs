// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int stop)
{
    if (start != stop + 1) return start + Sum(start + 1, stop);
    else return 0;
}
Console.WriteLine("Cумма натуральных элементов в промежутке от M до N");
Console.WriteLine(Sum(numberM, numberN));