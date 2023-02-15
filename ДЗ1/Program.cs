// Программа, которая на вход принимает 2 числа и выдаёт,
// какое число больше, а какое меньше.
// Пример:  a=5 b=7 -> max=7

Console.WriteLine("Введите первое число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int H = Convert.ToInt32(Console.ReadLine());

if (N>H)
{
    Console.Write($"{N}>{H} ");
}
else
{
    Console.Write($"{N}<{H} ");
}