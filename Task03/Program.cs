// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int size = 10;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
}
Console.WriteLine($"Массив до изменения: [{string.Join("; ", array)}]");
Array.Reverse(array);
Console.WriteLine($"Массив после изменения: [{string.Join("; ", array)}]");