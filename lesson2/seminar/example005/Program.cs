int num = new Random().Next(100,1000);
int a1 = num/100;
int a2 = num%10;
int res = a1*10+a2;
Console.WriteLine (num);
Console.WriteLine (res);
