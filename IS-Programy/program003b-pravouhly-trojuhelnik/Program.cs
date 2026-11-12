// Program 003b – vykreslení pravoúhlého trojúhelníku
// Vstup: délka odvěsny n (obě odvěsny mají stejnou délku, pravý úhel je vlevo dole).
Console.Write("Délka odvěsny n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Chyba: zadejte přirozené číslo.");
    return;
}

// Řádek r (1..n) obsahuje r hvězdiček
for (int row = 1; row <= n; row++)
{
    Console.WriteLine(new string('*', row));
}
