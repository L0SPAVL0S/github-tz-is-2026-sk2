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

for (int row = 0; row < b; row++)
{
    for (int col = 0; col < a; col++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}
