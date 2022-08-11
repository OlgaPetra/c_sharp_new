//Console.WriteLine("Hello, World!");

//Задача 1
// Напишите программу, которая на вход принимает число,на выходе выдает его квадрат


    Console.Clear();


    //Console.Write("Введите число :");
    //int number = Convert.ToInt32 (Console.ReadLine());
    //number *= number; 
//number *= number; 
    //number *= number; 
    //int sqrt = number * number;
    //int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));
    //Console.Write( "Число в квадрате: " + number);

    //Задача 2
    //Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
    //Console.Write("Input Ferst Number:");
    //int num1 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input Second Number:");
    //int num2 = Convert.ToInt32(Console.ReadLine());

    //if (num1 == num2 * num2)
    //Console.Write("Ferst number is a square of Second number");

    //else
    //Console.Write("Ferst number is not a square of Second number");

    //Задача 3
    //Напишите программу, которая будет выдавать название дня недели по заданному номеру.

    //Console.Write("Input number of the day: ");

    //int day = Convert.ToInt32(Console.ReadLine());

    //if (day < 1 || day > 7)
    //{
    //Console.Write("Incorrect number");
    //}
    //else
    //{ }
    //if (day == 1)
    //{
     // Console.Write("Понедельник");
    //}
    //if (day == 2)
    //{
    //   Console.Write("Вторник");
    //}
    //if (day == 3)
    //{
    //  Console.Write("Среда");
    //}
    //if (day == 4)
    //{
    //  Console.Write("Четверг");
    //}
    //if (day == 5)
    //{
    //   Console.Write("Пятница");
    //}
    //if (day == 6)
    //{
    //    Console.Write("Суббота");
    //}
    //if (day == 7)
    //{
    //    Console.Write("Воскресенье");
    //}


    //   ДОМАШНЕЕ ЗАДАНИЕ 
    //   Знакомство с языками программирования (семинары)
    //   Урок 1. Знакомство с языком программирования С#   
    // Задача 2: Напишите программу, которая на вход принимает два числа 
    // и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
    int a, b;
            Console.WriteLine("Введи первое число - ");
    a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число - ");
    b = Convert.ToInt32(Console.ReadLine());
 
            bool Chto0 = a > b;
            bool Chto1 = a == b;
            bool Chto2 = a < b;
 
            if (Chto0)
            {
                Console.WriteLine($"Число {a} больше чем {b} ");
            }
            else if (Chto1)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }
