// Напишите программу, которая создает массив из некоторого количества элеентов
// и выводит их на экран с помощью функции.Создать рандоный массив из 8 элементов.

Console.Clear();
int maxValue = 100;
int[] array = new int[8];
Random r = new Random();
for (int i = 0; i < 8; i++)
array [i] = r.Next(0, maxValue); 
Console.WriteLine($"array: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");
//Console.WriteLine(array[r.Next(0, maxValue)]); почему не работает такая формула вывода в консоль?

