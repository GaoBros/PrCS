using System;
string opr;
double n1, n2, answ;
while (true)
{
     Console.WriteLine("Добро пожаловать в мой калькулятор!");
     Console.WriteLine("1. Сложение;");
     Console.WriteLine("2. Вычитание;");
     Console.WriteLine("3. Умножение;");
     Console.WriteLine("4. Деление;");
     Console.WriteLine("5. Возведение числа в степень;");
     Console.WriteLine("6. Квадратный корень числа;");
     Console.WriteLine("7. 1% процент от числа;");
     Console.WriteLine("8. Найти факториал;");
     Console.WriteLine("9. Выйти из программы;");

     Console.Write("Введите номер операции: ");
     opr = Console.ReadLine();
    if (opr == "1" | opr == "2" | opr == "3" | opr == "4")
    {



        Console.Write("Введите первое число: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        n2 = Convert.ToDouble(Console.ReadLine());


        if (opr == "1")
        {
            answ = n1 + n2;
            Console.WriteLine("Результат: " + answ);
        }
        else if (opr == "2")
        {
            answ = n1 - n2;
            Console.WriteLine("Результат: " + answ);
        }
        else if (opr == "3")
        {
            answ = n1 * n2;
            Console.WriteLine("Результат: " + answ);
        }
        else if (opr == "4")
        {
            answ = n1 / n2;
            Console.WriteLine("Результат: " + answ);

        }
    }
     if (opr == "5")
     {
        Console.Write("Введите число: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите показатель степени: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        answ = Math.Pow(n1, n2);
         Console.WriteLine("Результат: " + answ);
     }
    if (opr == "6")
    {
        Console.Write("Введите число: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if (n1 < 1)
        {
            Console.WriteLine("Ошибка, корень не берёт отрицательные числа");
        }
        else
        {
            answ = Math.Sqrt(n1);
            Console.WriteLine("Результат: " + answ);
        }
    }
    if (opr == "7")
    {
        Console.Write("Введите число: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        answ = n1 / 100;
        Console.WriteLine("1 процент от числа равен: " + answ);
    }
           
    if (opr == "8")
    {
        Console.Write("Введите число: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if (n1 < 1)
        {
            Console.WriteLine("Ошибка, факториал не берёт отрицательные числа");
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= n1; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Результат: " + factorial);
        }

    }
    if (opr == "9")
    {
        Environment.Exit(0);
    }
} 












