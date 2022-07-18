// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки 1");
    Console.WriteLine("x:");
    int xA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    int yA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z:");
    int zA = Convert.ToInt32(Console.ReadLine());     
Console.WriteLine("Введите координаты точки 2");
    Console.WriteLine("x:");
    int xB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    int yB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z:");
    int zB = Convert.ToInt32(Console.ReadLine());   

//расстояние можно вычислить по формуле треугольника (через катеты)
//(НУЖНАЯ)гипотенуза равна корень квадратный из суммы квадратов катетов 
//(КЛАССИЧЕСКАЯ)гипотенуза равна сумме квадратов катетов
//расстояние между точками в 2D = сумма квадратов разности
// соответствующих координат

//возведение в корень Math.Pow(num, 2)
//извлечение корня MathSqrt(num, 2)

double yy = Math.Pow(yA - yB , 2);
double xx = Math.Pow(xA - xB , 2);
double zz = Math.Pow(zA - zB , 2);

double S = Math.Sqrt (yy + xx + zz);

S = Math.Round(S, 2); //функция для округления S переменная? 2 - до скольки знаков после запятой.

Console.WriteLine ("Расстояние между точками в трёхмерном пространстве " + S);