// Программа, которая принимаает на вход 3 числа и выдаёт максимальное 
// из этих чисел.

Console.WriteLine("Введите три чесла ");
int N = Convert.ToInt32(Console.ReadLine());
int H = Convert.ToInt32(Console.ReadLine());
int T = Convert.ToInt32(Console.ReadLine());

if (N>H && N>T)
{
    Console.Write($"max {N} ");
}
if (H>N && H>T)
{
   Console.Write($"max {H} "); 
}
if (T>N && T>H)
{
     Console.Write($"max {T} "); 
}