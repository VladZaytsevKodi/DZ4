// Напишите функцию (цикл), который принимает на вход 2 числа (А и В) и возводит число А
// в натуральную степень В.


Console.Clear();

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine()!);
{
    int result = 1;

    if(b < 0) 
    {
        b *= -1;
        for(int i = 0; i < b; i++) 
        {
            result *= a;
        }

        Console.WriteLine($"A^B= {result}");
    }
    else 
    {
        for (int i = 0; i < b; i++) 
        {
            result *= a;
        }

        Console.WriteLine($"A^B= {result}");
    }
}

