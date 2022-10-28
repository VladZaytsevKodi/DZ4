// Напишите функцию (цикл), который принимает на вход 2 числа (А и В) и возводит число А
// в натуральную степень В.

Console.Clear();

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine()!);

if(b>=0)
{
Console.WriteLine($"A^B= {Math.Pow(a, b)}");
}

if(b<0)
{
int bi = b * -1; 
Console.WriteLine($"A^B= {Math.Pow(a, bi)}");
}
