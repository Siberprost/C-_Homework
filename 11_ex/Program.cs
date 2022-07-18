//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


    Console.WriteLine("Введите число для вычисления");
        int n = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите степень для вычисления");
        int lot = Convert.ToInt32(Console.ReadLine());
   

    int strt = 1;
    while (strt <= n)
    {
        Console.Write (Math.Pow(strt, lot) + "|  |");
        strt++;
    }
    