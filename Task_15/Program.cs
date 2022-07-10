// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("введите цифру дня недели и определите является ли он выходным");
Console.Write("введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
int day = 0;
if (num >= 1 && num <= 7)
{
    day = num;
    if (day == 6 || day == 7) Console.WriteLine($"{num} -> ДА");
    else Console.WriteLine($"{num} -> НЕТ");
}
else Console.WriteLine("Введена не корректная цифра");
