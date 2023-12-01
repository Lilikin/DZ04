// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые 
// числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.WriteLine("Введите число (для выхода сумма чисел должан быть чётная, либо наберите 'q'): ");
    string str = Console.ReadLine();
    if (str == "q")
    {
        break;
    }
    if (int.TryParse(str, out int number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine($"Вы ввели число {str}, у которого сумма чисел {sum} - чётная");
            break;
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число.");
    }
}
