Console.Clear();
Console.Write("Введите пятизначное число: ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            
            if (name == reverse)
            {
                Console.WriteLine($"{name} является палиндромом");
            }
            else
            {
                Console.WriteLine($"{name} не является палиндромом");
            }