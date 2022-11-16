// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите целое число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите целое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write($"Сумма натуральных элементов в промежутке от M до N равна {GetSumNaturalNumbers(m, n)}");

//.........................МЕТОД................................

int GetSumNaturalNumbers(int start, int end)
{
    int sum = 0;
    sum = sum + start + 1;
    if (start == end)
    {
        return sum;
    }

    return (sum = sum + GetSumNaturalNumbers(start + 1, end - 1));
}
