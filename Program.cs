// Задание
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number the sum of the digits of which must be even, or 'q' to exit: ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            int number = Convert.ToInt32(input);
            int sum = 0;

            // Вычисляем сумму всех цифр числа
            while (number != 0)
            {
                sum += number % 10; // Получаем последнюю цифру числа и добавляем к сумме
                number /= 10; // Удаляем последнюю цифру числа
            }

            if (sum % 2 == 0)
            {
                Console.WriteLine("The sum of the digits is even");
                break;
            }
        }
    }
}