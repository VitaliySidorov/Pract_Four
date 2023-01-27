// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
double Exponentiation(int n, int m)
{
    int level = m;
    if (level < 0)
    {
        Console.WriteLine("Показатель степени приведен к натуральному виду.");
        level = m * (-1);
    }
    double result = 1;
    for(int i=1; i<=level; i++)
    {
        result *= n;
    }
    return result;
}

Console.WriteLine("Введите два числа (А и В) для возведения числа А в натуральную степень В.");
Console.Write("Первое число ");
int numA = ReadNumber();
Console.Write("Второе число ");
int numB = ReadNumber();
Console.WriteLine();
Console.WriteLine($"{numA} в степени {Math.Abs(numB)} равно {Exponentiation(numA, numB)}.");