//Программа нахождения максимального числа

int a = new Random().Next(1,10000);
int b = new Random().Next(1,10000);
int c = new Random().Next(1,10000);
int d = new Random().Next(1,10000);
int e = new Random().Next(1,10000);
int f = new Random().Next(1,10000);
int g = new Random().Next(1,10000);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;
if (g > max) max = g;

Console.Write("max = ");
Console.WriteLine(max);