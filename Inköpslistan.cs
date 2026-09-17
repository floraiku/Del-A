List<string> names = new List<string>(); // En lista som kan endast innehålla text.
List<int> prices = new List<int>(); // En lista som kan endast innehålla heltal 
while (true)
{
    int total = 0;
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}.{names[i]} - {prices[i]} kr"); total += prices[i];

    }
    Console.WriteLine($"Totalt: {total} kr");

    Console.Write("Vara eller nummer:");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int nummer))
    {
        int index = nummer - 1;
        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            prices.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Den varan finns inte.");
        }
    }
    else
    {
        Console.Write("pris: ");
        if (int.TryParse(Console.ReadLine(), out int pris))
        {
            names.Add(input ?? "");
            prices.Add(pris);
        }
        else
        {
            Console.WriteLine("Ogiltigt pris.");
        }
    }
}
