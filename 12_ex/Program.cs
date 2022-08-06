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
//PowerForUzver()

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
void CalculationNumbers()
{
    Console.WriteLine("Введите число для сложения каждой цифры в нём");
    int number = Convert.ToInt32(Console.ReadLine());
    void SumOfMasNum(int num)
    {
        int summary = 0;
        while (num > 0)
        {
            summary += num%10;
            num /= 10;
        }
        Console.Write($"сумма цифр в числе {number} равна { summary} ");
    }
     SumOfMasNum(number);

   
}
//CalculationNumbers();

/* Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33] */

void SortMassive()
{ 
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());

    int[]arr = new int[size];


    void MassiveFiller()
        {    
        int x;
        Console.Write("неотсортированный рандомный массив:  ");
        for (int i = 0; i < size; i++)
        {
            Random rand = new Random ();
            x = rand.Next(-10,10);
           arr[i] = x;
           Console.Write($"{arr[i]} ");
        }
    Console.WriteLine();
    }
    void SelectionSort (int[] array)
{
    for(int i = 0; i < array.Length - 1; i++) 
    {
        int minPosition = i; 
        for(int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }


        int temp = array[i]; 
        array[i] = array[minPosition]; 
        array[minPosition] = temp;
    }
}
    void PrintArray (int[] array)
{
    int count = array.Length; 
    Console.Write("Отсортированный массив:  ");
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine(); 
}
    MassiveFiller();
    SelectionSort(arr);
    PrintArray(arr);
}
//SortMassive();