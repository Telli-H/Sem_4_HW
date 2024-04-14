// Задание
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Enter a number the sum of the digits of which must be even, or 'q' to exit: ");
//             string input = Console.ReadLine();

//             if (input == "q")
//             {
//                 break;
//             }

//             int number = Convert.ToInt32(input);
//             int sum = 0;

//             // Вычисляем сумму всех цифр числа
//             while (number != 0)
//             {
//                 sum += number % 10; // Получаем последнюю цифру числа и добавляем к сумме
//                 number /= 10; // Удаляем последнюю цифру числа
//             }

//             if (sum % 2 == 0)
//             {
//                 Console.WriteLine("The sum of the digits is even");
//                 break;
//             }
//         }
//     }
// }


//Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// using System;

// class Program
// {
//     static int[] CreateArrayRndInt(int size, int min, int max)
//     {
//         int[] array = new int[size];
//         Random rnd = new Random();

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = rnd.Next(min, max);
//         }
//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int num in array)
//         {
//             Console.Write($"{num} ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int count = 0;
//         foreach (int num in array)
//         {
//             if (num % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

//     static void Main(string[] args)
//     {
//         int minimum = 100;
//         int maximum = 1000;

//         Console.WriteLine("Enter the size of the array: ");
//         int count = Convert.ToInt32(Console.ReadLine());

//         int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
//         Console.WriteLine("Generated Array:");
//         PrintArray(arrayMain);

//         int evenCount = CountEvenNumbers(arrayMain);
//         Console.WriteLine($"Number of even numbers in the array: {evenCount}");
//     }
// }




// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// int ArrayToInteger(int[] array)
// {
//     int number = 0;
//     for (int i = array.Length-1; i >= 0; i--)
//     {
//         number = number * 10 + array[i];
//     }

//     return number;

// }

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)


// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int minimum = 0;
// int maximum = 10;

// Console.WriteLine("input size of the array: ");
// int count = Convert.ToInt32(Console.ReadLine());

// int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
// PrintArray(arrayMain);

// Console.WriteLine();
// Console.WriteLine(ArrayToInteger(arrayMain));


