Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int res = a%b;
if (res == 0)
{
    Console.WriteLine ("кратно");
}
else
{
     Console.WriteLine ("не кратно, остаток " +res);
   }
