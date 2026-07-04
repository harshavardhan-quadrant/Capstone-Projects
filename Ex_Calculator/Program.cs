using System.Data;

Console.Title = "Expression Calculator";

while (true)
{
    Console.Clear();

    Console.WriteLine("===========================================");
    Console.WriteLine("      C# Expression Calculator");
    Console.WriteLine("===========================================");
    Console.WriteLine();
    Console.WriteLine("Examples:");
    Console.WriteLine("10+20");
    Console.WriteLine("10+20*5");
    Console.WriteLine("(10+20)*5");
    Console.WriteLine("100/5+25");
    Console.WriteLine();

    Console.Write("Enter Expression (or type 'exit'): ");

    static void Pause()
    {
        Console.WriteLine();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }

    string? expression = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(expression))
    {
        Console.WriteLine("\nExpression cannot be empty.");
        Pause();
        continue;
    }

    if (expression.Trim().ToLower() == "exit")
        break;

    try
    {
        var result = new DataTable().Compute(expression, null);

        Console.WriteLine();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Expression : {expression}");
        Console.WriteLine($"Result     : {result}");
        Console.WriteLine("-------------------------------------------");
    }
    catch
    {
        Console.WriteLine();
        Console.WriteLine("Invalid Expression.");
    }

    Pause();
}

