namespace AutoPartsStore;

public static class ConsoleHighlighter
{
    public static void Highlight<T>(List<T> items, int index, Func<T, string> formatter)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(formatter(items[index]));
        Console.ResetColor();
    }
}