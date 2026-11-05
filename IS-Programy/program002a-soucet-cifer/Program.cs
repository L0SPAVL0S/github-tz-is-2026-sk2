// Program 002a – součet a součin cifer celého čísla (čistě matematicky)
Console.Write("Zadejte celé číslo: ");
// long, aby se vešlo i int.MinValue po odstranění znaménka
if (!long.TryParse(Console.ReadLine(), out long number))
{
    Console.WriteLine("Chyba: zadejte celé číslo.");
    return;
}

// znaménko nemá vliv na cifry
long rest = Math.Abs(number);

long sum = 0;
long product = 1;

// Číslo 0 má jednu cifru (0), ale cyklus by se neprovedl ani jednou
if (rest == 0)
{
    product = 0;
}

while (rest > 0)
{
    long digit = rest % 10; // poslední cifra
    sum += digit;
    product *= digit;
    rest /= 10;             // odříznutí poslední cifry
}

Console.WriteLine($"Součet cifer: {sum}");
Console.WriteLine($"Součin cifer: {product}");
