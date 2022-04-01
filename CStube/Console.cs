namespace YouTubeDownloader;

public static class ConsoleSettings
{
    private static ConsoleColor cyan = ConsoleColor.Cyan;
    private static ConsoleColor magenta = ConsoleColor.Magenta;
    private static ConsoleColor yellow = ConsoleColor.Yellow;
    private static ConsoleColor red = ConsoleColor.Red;
    private static ConsoleColor white = ConsoleColor.White;

    public static void Title(string _text)
    {
        Console.ForegroundColor = magenta;
        Console.WriteLine(_text);
        Console.ResetColor();
    }

    public static void Subtitle(string _text)
    {
        Console.ForegroundColor = cyan;
        Console.WriteLine(_text);
        Console.ResetColor();
    }

    public static void Question(string _text)
    {
        Console.ForegroundColor = yellow;
        Console.WriteLine(_text);
        Console.ResetColor();
    }

    public static void Info(string _text)
    {
        Console.ForegroundColor = yellow;
        Console.WriteLine(_text);
        Console.ResetColor();
    }

    public static void Error(string _text)
    {
        Console.ForegroundColor = red;
        Console.WriteLine(_text);
        Console.ResetColor();
    }

    public static void UserInput(string _text)
    {
        Console.ForegroundColor = white;
        Console.WriteLine(_text);
        Console.ResetColor();
    }
}
