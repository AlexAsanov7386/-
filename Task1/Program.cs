﻿// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void ShowNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        return;
    }

    Console.Write(m + " ");
    ShowNumbers(m + 1, n);

}
ShowNumbers(1, 5);
