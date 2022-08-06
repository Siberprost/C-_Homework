//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void PowerForUzver()
{
Console.WriteLine("Введите числ для возведения в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень будем возводить?");
int step = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < step; i++)
{
    a = a * a;
}
Console.Write(a);
}
PowerForUzver();
