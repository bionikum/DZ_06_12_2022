Console.Clear();
Console.Write("Введите количество кустов черники : ");
int a = int.Parse(Console.ReadLine());

int[] N = new int[a];

for (int i = 0; i < N.Length; i++)
{
    Console.Write($"Введите количество ягод на {i} кусте: ");
    N[i] = int.Parse(Console.ReadLine());
}
int max = 0;

for (int i = 0; i < a - 2; i++)
{
    if (N[i] + N[i + 1] + N[i + 2] > max)
    {
        max = N[i] + N[i + 1] + N[i + 2];
    }
    if (N[0] + N[1] + N[i + 2] > max)
    {
        max = N[0] + N[1] + N[i + 2];
    }
    if (N[0] + N[i + 1] + N[i + 2] > max)
    {
        max = N[0] + N[i + 1] + N[i + 2];
    }
}
Console.WriteLine(max);

