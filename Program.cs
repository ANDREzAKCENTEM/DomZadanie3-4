// Знакомство с языками программирования (семинары)
// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// double a = numberA, b = numberB;
// double result = Math.Pow(a, b);
// Console.WriteLine($"{numberA}, {numberB} -> {result} ");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sumNumbers = SumNumbers(number);

// int SumNumbers(int num)
// {
//     int sum = 0;
//     if (num <= 0) num *= -1;
//     for (int i = 1; i != num; i++)
//     {
//         sum += num % 10;
//         num = num / 10;

//     }
//     return sum;
// }

// Console.WriteLine($"Сумма цифр в числе {number}-> {sumNumbers}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GenerateArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//         for (int i = 0; i <= array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//     }
// }

// int[] arr = GenerateArray(9, 1, 100);
// PrintArray(arr);
// System.Console.Write(" -> [");
// PrintArray(arr);
// System.Console.WriteLine("]");