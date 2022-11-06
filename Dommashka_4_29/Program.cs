// Напишите программу, которая создает массив из некоторого количества элеентов
// и выводит их на экран с помощью функции.Создать рандоный массив из 8 элементов.

Console.Clear();
Console.WriteLine("Введите колиество элементов массива: ");
int х = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное число элемента массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное число элемента массива: ");
int maxValue = int.Parse(Console.ReadLine()!);


int[] array = new int [х];
Random r = new Random();
for (int i = 0; i <= maxValue; i++)
{
   array [i] = r.Next(minValue, maxValue + 1); 
   Console.Write($"{array[i]}, ");
}


