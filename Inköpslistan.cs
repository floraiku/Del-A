List<string> names = new List<string>(); // En lista som kan endast innehålla text.
List<int> prices = new List<int>(); // En lista som kan endast innehålla heltal 
while (true)

    int total = 0;
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}.{names[i]} - { [prices]} kr"); total += prices[i];

}
Console.WriteLine($"Totalt: {totalt} kr");

Console.Write("Vara eller nummer:");
string? input = Console.ReadLine();
