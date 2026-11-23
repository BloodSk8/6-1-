using System;

class Task1
{
    static void Main()
    {
        Console.Write("Введите размер массива (a): ");
        int a = int.Parse(Console.ReadLine());

        int[] array = new int[a];

        for (int i = 0; i < a; i++)
        {
            Console.Write($"Введите элемент [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВведенный массив:");
        Console.WriteLine(string.Join(" ", array));
    }
}
