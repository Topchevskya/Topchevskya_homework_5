﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = { 3, 7, 22, 78 };
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine("Разница между максимальным и минимальным элементом массива = {0}", max - min);