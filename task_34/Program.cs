// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[10];
Random rnumber = new Random();
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnumber.Next(100, 1000);
    Console.Write($"{array[i]} ");
    {
        if (array[i] % 2 == 0) result++;
    }
}
Console.WriteLine($" -> количество чётных чисел {result}");