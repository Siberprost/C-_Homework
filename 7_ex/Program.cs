//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//326791 -> 6

// я не понял, нужно ли делать рандомный ввод или чтобы вводил юзер и сделал оба варианта. Только вот проверку на кол-во введённых пользователем символов не сделал т.к. не очень понял как.

Console.Write("Для ввода числа нажмите 1, для рандомного числа нажмите 2");
int choise = Convert.ToInt32(Console.ReadLine());
if (choise == 1)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Ваше число " + num);
    if (num < 100)
    {
    Console.WriteLine ("Числа после двух попали под санкции и более недоступны в Вашем регионе");
    }
    else
    {
        while (num > 999)
        num = num / 10;

        int ones = num % 10; 
        int tens = num / 10; 
        int hundr = num / 100;
        int result = ones;
        Console.WriteLine ("Вторая цифра в числе " + result);
    }

    
}

if (choise == 2)
{
    Random rand = new Random();
    int num = rand.Next(100,1000);
    Console.WriteLine ("случайное число " + num);
 if (num < 100)
    {
    Console.WriteLine ("Числа после двух попали под санкции и более недоступны в Вашем регионе");
    }
    else
    {
        while (num > 999)
        num = num / 10;

        int ones = num % 10; 
        int tens = num / 10; 
        int hundr = num / 100;
        int result = ones;
        Console.WriteLine ("Вторая цифра в числе " + result);
}
}