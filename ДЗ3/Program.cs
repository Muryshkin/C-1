// Программа, которая на вход принимает число и выдаёт,
// является ли число чётным

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int lastnumber = N / 2;

if(lastnumber = N%50)
{
    Console.WriteLine($"{lastnumber} - да ");
}
else
{
    Console.WriteLine($"{lastnumber} - нет ");
}