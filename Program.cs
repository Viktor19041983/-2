﻿// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine("Введите два число: ");
 int num_A = Convert.ToInt32(Console.ReadLine());
 int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
   Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
   }
else
   {
    Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
    }
