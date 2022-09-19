// Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите начальное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

// Вариант №1
int Print(int startnumber, int stopnumber)
{
    if (startnumber <= stopnumber)
    {
        Console.Write($"{startnumber} | ");
        return Print(startnumber + 1, stopnumber);
    }
    else return 0;
}


// Вариант №2
string List(int startnumber, int stopnumber)
{
    if (startnumber <= stopnumber) return $" {startnumber} |" + List(startnumber + 1, stopnumber);
    else return String.Empty;
}

Console.WriteLine("Все натуральные числа в промежутке от M до N: ");
Console.WriteLine("Вариант №1");
Print(numberM, numberN);
Console.WriteLine();
Console.WriteLine("Вариант №2");
Console.WriteLine(List(numberM, numberN));