﻿Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
if (number1 > 100)
{
    while (number1 > 1000) 
    {
        number1 = number1 / 10;
    }
        int a2 = number1 % 10;
        Console.WriteLine($"у числа {number},третья цифра {a2} ");
}
else if (number1 < - 100)
{
    number1 = number1 * -1;
    while (number1 >= 1000)
    {
        number1 = number1 / 10;
    }
    number1 = number1 % 10; 
     Console.WriteLine($" у числа {number}, третья цифра  {number1} ");
}
else
{
Console.WriteLine ("третьей цифры нет");
}







