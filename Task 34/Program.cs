Console.Clear();
int[] arr = new int[4];
int j = 0, sum = 0;
Random rnd = new Random();

for (int i = 0; i < 4; i++)
{
    arr[i] = rnd.Next(100, 1000);
}

foreach (int count in arr)
{
    Console.Write("{0} ", count);
    if (count % 2 == 0)
    {
        j++;
        sum += count;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}", j, sum);

