using System;
class Program
{
    static void Main(string[]args)
    {
        // Создает 100 рандомных чисел от -1000 до 1000
        Random random = new Random();
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-1000, 1000);
        }

        // Распечатывает получившиеся числа
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Считает сколько из этих чисел положительных
        int positiveNumber = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                positiveNumber++;
            }
        }
        Console.WriteLine("(всего "+ positiveNumber +" положительных чисел");

        // Считает сколько из этих чисел отрицательных
        int unpositiveNumber = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                unpositiveNumber++;
            }
        }
        Console.WriteLine("и "+ unpositiveNumber +" отрицательных чисел чисел)");


    }
}