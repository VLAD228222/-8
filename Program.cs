using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Автор: Дейко Влад");

        // Створення та заповнення масиву
        int[] array = new int[100];
        Random rand = new Random();

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
            Console.Write($"{array[i],4}");
            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }

        // Перевірка введеного граничного значення
        int limit;
        do
        {
            Console.WriteLine("\nВведіть граничне значення (від 1 до 100):");
            while (!int.TryParse(Console.ReadLine(), out limit) || limit < 1 || limit > 100)
            {
                Console.WriteLine("Помилка! Введіть ціле число від 1 до 100:");
            }
        } while (limit < 1 || limit > 100);

        // Підрахунок кількості елементів 
        int count = 0;
        foreach (int num in array)
        {
            if (num < limit)
                count++;
        }

        // Створення другого масиву
        int[] secondArray = new int[count];
        int index = 0;
        foreach (int num in array)
        {
            if (num < limit)
            {
                secondArray[index] = num;
                index++;
            }
        }

        // Виведення другого масиву
        Console.WriteLine($"\nДругий масив (елементи менші за {limit}):");
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write($"{secondArray[i],4}");
            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }

        // Обчислення добутку
        long product = 1;

        if (secondArray.Length == 0)
        {
            Console.WriteLine("\n\nНемає елементів менших за задане значення.");
        }
        else
        {
            foreach (int num in secondArray)
            {
                product *= num;
            }

            Console.WriteLine($"\n\nКількість елементів у другому масиві: {secondArray.Length}");
            Console.WriteLine($"Добуток елементів другого масиву: {product}");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
