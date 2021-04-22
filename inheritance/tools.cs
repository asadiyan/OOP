public static class Tools
{
    public static void ColorFullWriteLine(string text, System.ConsoleColor color)
    {
        System.Console.ForegroundColor = color;
        System.Console.WriteLine(text);
        System.Console.ResetColor();
    }
}

