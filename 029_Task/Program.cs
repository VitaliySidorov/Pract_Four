// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.Clear();
int num = ReadNumber();
PrintArray(num);

int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        Console.Write("Введите количество элементов массива: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
int[] FillArray(int n) // Метод заполнения массива случайными числами
{
    int[] array = new int[n];
    Random number = new Random();
    for(int i=0; i<array.Length; i++)
    {
        array[i] = number.Next(-20, 21); // [-20, 21)
    }
    return array;
}
void PrintArray(int m) // Метод вывода массива в консоль
{
    Console.WriteLine($"[{String.Join(", ", FillArray(m))}]");
}