﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число дня недели: ");
 int date = Convert.ToInt32(Console.ReadLine());

 if (date >= 1 && date <= 5 ) Console.WriteLine ("Ещё будний день, работайте, солнце ещё высоко");
 else if (date == 6 || date == 7 ) Console.WriteLine ("Выходной день, постарайся успеть отдохнуть");
 else Console.WriteLine ("Вы так устали, что уже путаете цифры. Попробуйте ещё раз");
