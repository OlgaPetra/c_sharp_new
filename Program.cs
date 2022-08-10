// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 1
// Напишите программу, которая на вход принимает число,на выходе выдает его квадрат


Console.Clear();

//Console.Write("Введите число :");
//int number = Convert.ToInt32 (Console.ReadLine());
//number *= number; 
//int sqrt = number * number;
//int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));
//Console.Write( "Число в квадрате: " + number);

//Задача 2
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Input Ferst Number:");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input Second Number:");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num1 == num2 * num2)
    Console.Write("Ferst number is a square of Second number" );
else 
    Console.Write("Ferst number is not a square of Second number");

    



