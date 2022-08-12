// Пользоваель вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввёл пользователь

void Zadacha41()
{
    Console.WriteLine ("Сколько числе хотите ввести");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) count++;
    }
    Console.WriteLine($"Чисел меньше нуля: {count}");
}
//Zadacha41();


/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void Zadacha43()
{
    Console.WriteLine ("B1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ("K1 = ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ("B2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ("K2 = ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    if (k1 == k2 || b1 == b2)
    {
        Console.WriteLine("При паралелльных прямых пересечений нет. Решение уехало в отпуск на майорку.");
    }
    else
    {
        //A(x,y)
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x)} , {Math.Round(y)})");
        Console.WriteLine($"Координаты точки пересечения A ({Math.Round(x)} , {Math.Round(y2)})");
    }
}
Zadacha43();