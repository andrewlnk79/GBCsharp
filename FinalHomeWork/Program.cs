﻿using FinalHomeWork;

Main();

void Main()
{
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("введите число1-начало");
    try
    {
        num1 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("нужно вводить число");
    }

    try
    {
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("нужно вводить число");
    }

    new Task1().RecursionPrint(num1, num2);
}