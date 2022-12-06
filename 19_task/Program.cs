Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Math.Abs(n);

if (m < 100000 && m > 9999)
{
    if (m % 10 == m / 10000 && (m % 100 - m % 10) / 10 == m / 1000 % 10)

        Console.Write("Число является палиндромом.");
    else

        Console.Write("Число не является палиндромом.");
}

else

    Console.WriteLine("Вы ввели не пятизначное число!");

