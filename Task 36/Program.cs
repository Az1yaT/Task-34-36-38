int[] arr = new int[4];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 1000);
    Console.Write($"|{arr[i]}|"); 

    if (arr[i] % 2 == 0)
    {
        count += 1;
    }
    
    else
    {
        
    }
}
Console.WriteLine($"=> {count}");