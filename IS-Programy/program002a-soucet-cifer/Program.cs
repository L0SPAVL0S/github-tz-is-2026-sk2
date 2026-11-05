// Program 002a – součet a součin cifer celého čísla (čistě matematicky)
Console.Write("Zadejte celé číslo: ");
if (!long.TryParse(Console.ReadLine(), out long number))
{
    Console.WriteLine("Chyba: zadejte celé číslo.");
    return;
}

long rest = Math.Abs(number);

long sum = 0;
long product = 1;

if (rest == 0)
{
    product = 0;
}

while (rest > 0)
{
    long digit = rest % 10;
    sum += digit;
    product *= digit;
    rest /= 10;             
}

Console.WriteLine(new string('=', 40));
Console.WriteLine($"Ciferný součet čísla {number} je {sum}");
Console.WriteLine(new string('=', 40));
Console.WriteLine($"Součin cifer: {product}");
