// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите целое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine(PrintNaturalNumbers(n, 1));

//.........................МЕТОД................................

string PrintNaturalNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }

    return (start + ", " + PrintNaturalNumbers(start - 1, end));
}