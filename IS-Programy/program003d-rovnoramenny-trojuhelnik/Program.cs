// Program 003d – obrazec 2 (střední): rovnoramenný trojúhelník (jehlan) vycentrovaný
Console.Write("Výška n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Chyba: zadejte přirozené číslo.");
    return;
}

for (int row = 1; row <= n; row++)
{
    // vlevo n-row mezer, pak 2*row-1 hvězdiček -> řádky jsou symetrické kolem středu
    Console.WriteLine(new string(' ', n - row) + new string('*', 2 * row - 1));
}
