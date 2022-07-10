// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("выведение третьей цифры задданого числа");
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.Write($"{num} -> {result}");
}
else Console.Write($"{num} -> третьей цифры нет");
