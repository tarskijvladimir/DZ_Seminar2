// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
if (number1 < 100)
{
Console.WriteLine ("третьей цифры нет");
}

if (number1 <= 1000) 
{
    int a1 = number1 % 10;
 Console.WriteLine($"у числа {number},третья цифра {a1}");
}

while (number1 > 1000) 
    {
        number1 = number1 / 10;
    }
        
        int a2 = number1 % 10;
        Console.WriteLine($"у числа {number},третья цифра {a2} ");
    




 


