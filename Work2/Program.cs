﻿// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

//Math.Pow(number,n) - возведение числа number в степень n

Console.Write("Введите квадрат любого числа: ");
int sqr = int.Parse(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());

if (sqr == number*number)
    Console.Write("Число " + number + " является квадратом числа " + sqr);
else
   Console.Write("Число " + number + " не является квадратом числа " + sqr); 