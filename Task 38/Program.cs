
Random rnd = new Random();
int[] arr = new int[5];
int max = 0;
int min = 100;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($" + {arr[i]}");
}
Console.WriteLine();
Console.WriteLine($"Максимальное число:{max}");
Console.WriteLine($"Минимальное число:{min}");
Console.WriteLine($"Разница максимального и минимального: {max - min}");