// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

Console.WriteLine("Введите 2 числа");
int a, b;
Console.WriteLine("Введите 1 число: ");
a = Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите 2 число: ");
b = Convert.ToInt32(Console.WriteLine());

bool Chto0 = a > b;
bool Chto1 = a == b;
bool Chto2 = a < b;

if (Chto0)
{
Console.WriteLine($"Число {a} больше чем {b}");
}
else if (Chto1)
{
Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
Console.WriteLine($"Число {b} больше чем {a}");
}

