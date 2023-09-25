// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите цифру:   ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1) 
{
    Console.WriteLine("Сегодня понедельник, этот день не выходной");
}
else if(number == 2)  //доп условие, чтоб при нахождении числа – программа завершилась. При обычном if программа идет дальше – иногда это надо, чтоб вывести несколько чисел
{
    Console.WriteLine("Сегодня вторник, этот день не выходной");
}
else if(number == 3)
{
    Console.WriteLine("Сегодня среда, этот день не выходной");
}
else if(number == 4)
{
    Console.WriteLine("Сегодня четверг, этот день не выходной");
}
else if(number == 5)
{
    Console.WriteLine("Сегодня пятница, этот день не выходной");
}
else if(number == 6)
{
    Console.WriteLine("Сегодня суббота, выходной");
}
else if(number == 7)
{
    Console.WriteLine("Сегодня воскресенье, выходной");
}
else
{
    Console.WriteLine("вы ошиблись");
}
