// Program 003a – vykreslení plného obdélníku (případně čtverce)
static int ReadNatural(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
        {
            return value;
        }
        Console.WriteLine("Chyba: zadejte přirozené číslo (1, 2, 3, ...).");
    }
}

int a = ReadNatural("Šířka a: ");
int b = ReadNatural("Výška b: ");

ConsoleColor[] colors =
{
    ConsoleColor.Red,
    ConsoleColor.Yellow,
    ConsoleColor.Green,
    ConsoleColor.Cyan,
    ConsoleColor.Blue,
    ConsoleColor.Magenta,
};

for (int row = 0; row < b; row++)
{
    Console.ForegroundColor = colors[row % colors.Length];
    for (int col = 0; col < a; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

Console.ResetColor();
