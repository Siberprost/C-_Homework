/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

void Zadacha64()   // доработать!!! считает только в обратную сторону// после доработок перестал считать вовсе// гугление завело в тупик// 
//нашёл похожие задачи с решением, аналогичный метод решения не помог, всё равно ошибка памяти//что-то с постановкой if else, через else не даёт выставить, ругается синтаксис. 
//В чётм проблема не смог найти
{
Console.Write("Введи N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={n}, M={m}");
PrintNumber(n, m);

void PrintNumber(int n, int m)
{
    if (m > n) return;
    {
        PrintNumber(n, m + 1);
        Console.Write($"{m}, ");
    }
    if (n > m) return;
    {
        PrintNumber(n - 1 , m);
        Console.Write($"{n}, ");
    }
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

}
Zadacha64();


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void Zadacha66()
{
    Console.WriteLine("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp = m;

    if (m > n) 
    {
    m = n; 
    n = temp;
    }

    PrintSumm(m, n, temp=0);

    void PrintSumm(int m, int n, int summ)
    {
        summ = summ + n;
        if (n <= m)
        {
            Console.Write($"Сумма элементов= {summ} ");
            return;
        }
        PrintSumm(m, n - 1, summ);
    }

    int InputNumbers(string input) 
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }

}
//Zadacha66();



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9  */

void Zadacha68()
{
    Console.WriteLine("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());

    int functionAkkerman = Ack(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int Ack(int m, int n)
    {
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
    }

    int InputNumbers(string input) 
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }
}
//Zadacha68();