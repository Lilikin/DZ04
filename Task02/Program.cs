// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"Чётных чисел в массиве: {count}");
