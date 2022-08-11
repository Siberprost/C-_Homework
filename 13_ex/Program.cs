//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void zadacha34()
{
    Console.WriteLine("какой длинны массив хотите?");
        int size = Convert.ToInt32(Console.ReadLine());

        int[]array = new int[size];

    Console.WriteLine("Уважаемый пользователь, я всего-лишь ленивая программа, я устала, заполните нужный Вам промежуток сами.");

    Console.WriteLine("минимальное значение числа в массиве?");
        int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
        int finishNum = Convert.ToInt32(Console.ReadLine());
    MassiveFillerFix(array, startNum, finishNum);
    PrintArray2(array);

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine(" ");
    Console.Write("Количество чётных числе в заданном массиве равно " + count + " . Всё, я дальше в режим сна. Не буди меня по таким пустякам.");
}
//zadacha34();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void zadacha36()
{
    Console.WriteLine("какой длинны массив хотите?");
        int size = Convert.ToInt32(Console.ReadLine());

        int[]array = new int[size];

    Console.WriteLine("Уважаемый пользователь, я всего-лишь ленивая программа, я устала, заполните нужный Вам промежуток сами.");

    Console.WriteLine("минимальное значение числа в массиве?");
        int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
        int finishNum = Convert.ToInt32(Console.ReadLine());
    MassiveFillerFix(array, startNum, finishNum);
    PrintArray2(array);

    int summ = 0;
    
    for (int i = 1; i < array.Length; i += 2)
    {
        summ = array[i] + summ;
    }
    Console.WriteLine(" ");
    Console.Write("Сумма элементов в нечётных позициях равна " + summ + ".");
}
//zadacha36();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 75,53
void zadacha38()
{
    Console.WriteLine("какой длинны массив хотите?");
        int size = Convert.ToInt32(Console.ReadLine());
        double[]array = new double[size];


    Console.WriteLine("минимальное значение числа в массиве?");
        int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
        int finishNum = Convert.ToInt32(Console.ReadLine());
    
    MassiveFillerFixDouble(array, -100, 100);
    PrintArray2Double(array);

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i += 2)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min)  min = array[i];
    }
    Console.WriteLine(" ");
    Console.Write($"Разница между минимальным ({min}) и максимальным ({max}) элементом массива равна {max - min} ." );


}
zadacha38();



void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами, которые выбрал пользователь
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
void PrintArray2(int[] array)  //выводит на экран массив, простой, но работающий метод
    {
        Console.WriteLine("Вот Ваш массив, получите, распишитесь: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }


static void MassiveFillerFixDouble(double[] array, int startNum, int finishNum)
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(random.NextDouble()*finishNum*3/2 + (startNum/2), 2);
        }
  
    }
    // буду очень признателен, если в дальнейшем расскажите, как реализовать в данной ситуации ввод минимального и максимального значения самим пользователем.
        //очень долго думал, искал, но работающих вариантов не отыскал.
void PrintArray2Double(double[] array) 
    {
        Console.WriteLine("Вот Ваш массив, получите, распишитесь: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }




