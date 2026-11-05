// Program 002b – součet a součin cifer celého čísla (jiný způsob: práce s textem)
Console.Write("Zadejte celé číslo: ");
string? input = Console.ReadLine()?.Trim();

if (!long.TryParse(input, out long number))
{
    Console.WriteLine("Chyba: zadejte celé číslo.");
    return;
}

// Číslo přepíšeme na text bez znaménka a projdeme znak po znaku
string digits = number.ToString().TrimStart('-');

long sum = 0;
long product = 1;

foreach (char c in digits)
{
    int digit = c - '0'; // znak '0'..'9' -> číslo 0..9
    sum += digit;
    product *= digit;
}

Console.WriteLine(new string('=', 40));
Console.WriteLine($"Ciferný součet čísla {number} je {sum}");
Console.WriteLine(new string('=', 40));
Console.WriteLine($"Součin cifer: {product}");
