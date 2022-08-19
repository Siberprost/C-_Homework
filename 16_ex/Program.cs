//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
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
    Console.WriteLine($"\n Отсортированный массив: ");
    OrderArrayLines(array);
    PrintArray(array);
}

//Zadacha54();

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    Console.WriteLine("введите значения длины и ширины квадратного массива");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = m;

    Console.WriteLine("введите минимум");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите максимум");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    FillArray(array, min, max);
    PrintArray(array);
    Console.WriteLine();
    int minSumLine = 0;
    int summLine = SummOfLine(array, 0);
    int SummOfLine(int[,] array, int i)
    {
        int summLine = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            summLine += array[i,j];
        }
        return summLine;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SummOfLine(array, i);
        if (summLine > tempSumLine)
            {
            summLine = tempSumLine;
            minSumLine = i;
            }
    }
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({summLine}) элементов ");

    int InputNumbers(string input)
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }
}

//Zadacha56();

//Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
//  1  2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7
void Zadacha58() 
{
    int n = 4;
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
    }

    PrintArray(sqareMatrix);
}
//Zadacha58();






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
void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

