// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите целое неотрицательное число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите целое неотрицательное число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int result = AckermanFunction(m, n);
Console.WriteLine($"A(m,n) = {result}");

//.........................МЕТОД................................

int AckermanFunction(int num, int arg)
{
    if (num == 0)
    {
        return (arg + 1);
    }
    else if ((num > 0) && (arg == 0))
    {
        return AckermanFunction(num - 1, 1);
    }
    else return AckermanFunction(num - 1, AckermanFunction(num, arg - 1));
}