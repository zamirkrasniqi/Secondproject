Console.WriteLine("Enter product names.");
Console.WriteLine("Type 'exit' to finish.");
Console.WriteLine();

List<string> products = new List<string>();
string input = string.Empty;

while (input.ToLower().Trim() != "exit")
{
    Console.Write("Product: ");
    input = Console.ReadLine();

    if (input.ToLower().Trim() != "exit")
    {
        products.Add(input);
    }
}

products.Sort();
Console.WriteLine();
Console.WriteLine("Sorted product list: ");
Console.WriteLine();

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine("- " + products[i]);
}

