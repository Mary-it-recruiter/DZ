// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3


// Console.Write("Введите значение a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b : ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
// {
//     Console.WriteLine($"Max = {a}");
// }
// else

//     Console.WriteLine($"Max = {b}");



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите значение a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b : ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение c : ");
// int c = Convert.ToInt32(Console.ReadLine());

// if ((a > b) && (a > c))
// {
//     Console.WriteLine($"Max = {a}");
// }

// if ((c > b) && (c > a))
// {
//     Console.WriteLine($"Max = {c}");
// }

// if ((b > a) && (b > c))
// {
//     Console.WriteLine($"Max = {b}");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет
// 7->нет

// Console.Write("Введите значение a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int y = a % 2;

// if (y == 0)
// {
//     Console.WriteLine($"{a} - чётное число");
// }
// else

//     Console.WriteLine($"{a}  - нечётное число");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введите число: "); 56
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;

if (res == 1)

{
    res += 1;
}

while (res <= num)

{
    Console.WriteLine(res);
    res += 2;
}

//ок!)