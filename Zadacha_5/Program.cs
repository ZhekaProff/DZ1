﻿// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
Console.Write("Вторая цифра 3-х значного числа = ");
Console.WriteLine((a / 10) % 10);
}
else
{
    Console.WriteLine("Число не 3-х значное!");
}