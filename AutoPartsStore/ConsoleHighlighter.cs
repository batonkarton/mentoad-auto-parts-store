using System.Drawing;

namespace AutoPartsStore;

public static class ConsoleHighlighter
{
    public static void Highlight<T>(List<T> items, int index, Func<T, string> formatter)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(formatter(items[index]));
        Console.ResetColor();
    }

    public static void ColorPrint(string text, ConsoleColor color)
    {
       Console.ForegroundColor = color;
       Console.WriteLine(text);
       Console.ResetColor();
    }
    public static void ColorSearch()
    {
        Console.WriteLine("");
        ColorPrint("Loading..", ConsoleColor.Magenta);
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".\n");
        Console.ForegroundColor = ConsoleColor.Green;        
        Console.ResetColor();
    }
}