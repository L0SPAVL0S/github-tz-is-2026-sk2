// Program 001 – výpis řady čísel
Console.Write("first = ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("last = ");
int last = int.Parse(Console.ReadLine()!);

Console.Write("step = ");
int step = int.Parse(Console.ReadLine()!);

for (int i = first; i <= last; i += step)
{
    Console.WriteLine(i);
}
