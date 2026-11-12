// Program 003e – obrazec 3 (těžší): plný kosočtverec (diamant)
// Vstup: n = počet řádků horní poloviny včetně prostředního (celková výška je 2n-1).
Console.Write("Velikost n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Chyba: zadejte přirozené číslo.");
    return;
}

// horní polovina i prostřední řádek: rostoucí šířka
for (int row = 1; row <= n; row++)
{
    Console.WriteLine(new string(' ', n - row) + new string('*', 2 * row - 1));
}
// dolní polovina: klesající šířka (zrcadlově)
for (int row = n - 1; row >= 1; row--)
{
    Console.WriteLine(new string(' ', n - row) + new string('*', 2 * row - 1));
}
