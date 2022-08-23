// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
Random rnumber = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnumber.Next(0,50);
    Console.Write($"{array[i]} ");
}

int result = 0;
for (int i = 0; i < array.Length; i += 2)
{
    result = result + array[i];
}

Console.WriteLine($"-> {result}");