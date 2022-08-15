/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void Zadacha47() // универсаьный шаблон для думерного массива
{
    Console.WriteLine("введите значения длины");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значения ширины");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимум");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите максимум");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    FillArrayDouble(array, min, max);
    PrintArrayDouble(array);

    Console.WriteLine();

}
//Zadacha47();

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void Zadacha50()
{
    Console.WriteLine("введите значения длины");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значения ширины");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимум");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите максимум");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    FillArray(array, min, max);
    PrintArray(array);

    Console.WriteLine();

    Console.WriteLine("Какой элемент массива будем вызывать?");
    Console.WriteLine("строка m");
       int findM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("столбец n");
        int findN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"О великие духи програмного кода, призываю Вас! Внемлите мне! Я вызываю тебя- число из {findM} {findN}! Покажись!");
    Console.WriteLine();

    if (findM > m && findN > n)
    Console.WriteLine("Духов постигла ошибка 404, боюсь сеанс будет прерван. Попробуйте еще раз, но уже с другими данными.");
    else
    {
    object c = array.GetValue(findM - 1 ,findN - 1);
    Console.WriteLine($"Духи програмного кода сегодня благосклонны и дают нам ответ! То, что ты искал равняется {c}, теперь одной загадкой в твоей жизни стало меньше");
    }

}
// Zadacha50();


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void Zadacha52()
{
    Console.WriteLine("введите значения длины");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значения ширины");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимум");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите максимум");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    FillArray(array, min, max);
    PrintArray(array);

    Console.WriteLine();


    for (int i = 0; i < n; i++) 
    {
        int srAr = 0;
        for (int j = 0; j < m; j++)
        {
            srAr += array[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / m}");
    }

}
//Zadacha52();




void FillArray(int[,] array, int startNumber = 0, int finishNumber = 9)  // заполняет двумерный массив рандомно, параметры выставляет пользователь
{
    Random random = new Random();
    finishNumber++;
    int rows = array.GetLength(0); // A(i,j,k) 0- первый символ (i), 1 - j и тд
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)// перебор по строке
    {
        for (int j = 0; j < columns; j++)//перебор по столбцу
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }

}
void PrintArray(int[,] array) // печатает массив

{
   int rows = array.GetLength(0); // A(i,j,k) 0- первый символ (i), 1 - j и тд
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)// перебор по строке
        {
            for (int j = 0; j < columns; j++)//перебор по столбцу
            {
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
    
}


void FillArrayDouble(double[,] array, int startNumber = 0, int finishNumber = 9)  // заполняет двумерный массив рандомно, параметры выставляет пользователь
{
    Random random = new Random();
    finishNumber++;
    int rows = array.GetLength(0); // A(i,j,k) 0- первый символ (i), 1 - j и тд
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)// перебор по строке
    {
        for (int j = 0; j < columns; j++)//перебор по столбцу
        {
            array[i, j] = Math.Round(random.NextDouble()*startNumber*32/16 + (finishNumber), 1);
        }
    }

}
void PrintArrayDouble(double[,] array) // печатает массив

{
   int rows = array.GetLength(0); // A(i,j,k) 0- первый символ (i), 1 - j и тд
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)// перебор по строке
        {
            for (int j = 0; j < columns; j++)//перебор по столбцу
            {
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
    
}
