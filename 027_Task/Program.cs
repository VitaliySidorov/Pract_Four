// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
int SumNumbers (int number)
{
    if (number < 0) // Проверка на отрицательное число
    {
        number *= -1;
    }
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number/10;
    }
    return result;
}

Console.Write("Введите число для определения суммы цифр в нём: ");
int num = ReadNumber();

Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {num} равна {SumNumbers(num)}.");
