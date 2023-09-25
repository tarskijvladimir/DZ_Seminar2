

Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

 int a1 = a % 100;
 int a2 = a1 / 10;
 

Console.WriteLine($"Трехзначное число {a} ,без первой цифры и третьей будет {a2}");
