﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
int  num;

Console.Write("Введите трёхзначное число: ");
num = Convert.ToInt32(Console.ReadLine());

for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
    {
    Console.WriteLine("Число отличное трёхзначного, попробуйте ещё раз: ");
    num = Convert.ToInt32(Console.ReadLine());
    }

num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");