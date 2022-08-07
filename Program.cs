// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/
    {
        Console.WriteLine("Введите 2 числа");
        int a, b;
        Console.WriteLine("Введите 1ое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2ое число: ");
        b = Convert.ToInt32(Console.ReadLine());

        bool var0 = a > b;
        bool var1 = a == b;
        bool var2 = a < b;

        if (var0)
        {
        Console.WriteLine($"Число {a} больше чем {b}");
        }
        else if (var1)
        {
        Console.WriteLine($"Числа {a} и {b} равны");
        }
        else
        {
        Console.WriteLine($"Число {b} больше чем {a}");
        }
    }