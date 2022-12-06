Console.Clear();
Console.Write("Введите пятизначное число : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100000 && n > 10000 || n > -10000 && n < -10000)
{
    if (n % 10 == n / 10000 && (n % 100 - n % 10) / 10 == n / 1000 % 10)

        Console.Write("Число является палиндромом.");

    else

        Console.Write("Число не является палиндромом.");
}

else

    Console.WriteLine("Вы ввели не пятизначное число..");
