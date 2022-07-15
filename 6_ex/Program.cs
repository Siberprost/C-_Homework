//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


// я не понял, нужно ли делать рандомный ввод или чтобы вводил юзер и сделал оба варианта. Только вот проверку на кол-во введённых пользователем символов не сделал т.к. не очень понял как.

Console.Write("Для ввода числа нажмите 1, для рандомного числа нажмите 2");
int choise = Convert.ToInt32(Console.ReadLine());;
if (choise == 1)
{
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());;
    Console.WriteLine ("Ваше число " + num);

    int ones = num % 10; 
    int tens = num / 10; 
    int hundr = num / 100;

    int result = tens % 10;
    Console.WriteLine ("Вторая цифра в числе " + result);
}
if (choise == 2)
{
    Random rand = new Random();
    int num = rand.Next(100,1000);
    Console.WriteLine ("случайное число " + num);

    int ones = num % 10; // 84 % 10 = 4
    int tens = num / 10; // 84/10=8 (целочисленное деление)
    int hundr = num / 100;

    int result = tens % 10;
    Console.WriteLine ("Вторая цифра в числе " + result);
}
