// Program 003c – obrazec 1 (lehký): obrys obdélníku (uvnitř prázdný)
static int ReadNatural(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
        {
            return value;
        }
        Console.WriteLine("Chyba: zadejte přirozené číslo.");
    }
}

int width = ReadNatural("Šířka: ");
int height = ReadNatural("Výška: ");

for (int row = 0; row < height; row++)
{
    for (int col = 0; col < width; col++)
    {
        // hvězdička jen na okraji: první/poslední řádek nebo první/poslední sloupec
        bool border = row == 0 || row == height - 1 || col == 0 || col == width - 1;
        Console.Write(border ? '*' : ' ');
    }
    Console.WriteLine();
}
