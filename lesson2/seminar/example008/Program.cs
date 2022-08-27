//принимает число

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a*a==b) Console.WriteLine ("да");
else if (b*b==a) Console.WriteLine ("да");
else Console.WriteLine ("нет");
    
