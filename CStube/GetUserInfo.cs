namespace YouTubeDownloader;

public class GetInfo
{
	public static string url = "";
	public static string format = "";
	public static bool wantDownload;
	private static string rep ="";
	private static bool isGoodFormat;
	private static bool isGoodRep;
	
	private static void AskLink()
    {
		ConsoleSettings.Info("\nPaste your YouTube url here :");
		Console.ForegroundColor = ConsoleColor.White;
		url = Console.ReadLine().ToString();
		Console.ResetColor();
	}

	public static void GetLink()
	{
		AskLink();

		if (url == null || url == "" || !url.Contains("https://youtu.be/"))
        {
			while (url == null || url == "" || !url.Contains("https://youtu.be/"))
			{
				ConsoleSettings.Error("\nError : You must enter a valid YouTube url.\n");
				AskLink();
			}
        }
	}

	private static void AskFormat()
    {
		ConsoleSettings.Info("\nChoose your format (MP3 : write (a), MP4 : write (b)) :");
		Console.ForegroundColor = ConsoleColor.White;
		format = Console.ReadLine().ToString();
		Console.ResetColor();
		if (format != "a")
		{
			if (format != "b") { isGoodFormat = false; }

			else { isGoodFormat = true; }
		}
		else { isGoodFormat = true; }
	}

	public static void GetFormat()
    {
		AskFormat();

		if (isGoodFormat == false)
		{
			while (isGoodFormat == false)
			{
				ConsoleSettings.Error("\nError : You must enter a valid format (write only (a) or (b)).\n");
				AskFormat();
			}
		}
		else if (format == "a") { format = "mp3"; }
		else { format = "mp4"; }
	}

	public static void AskDownload()
    {
		ConsoleSettings.Info($"\nThis YouTube video will be download in {format} format. Are you sure about that ? " +
			$"Write (y) to yes, (n) to no and to quit");
		Console.ForegroundColor = ConsoleColor.White;
		rep = Console.ReadLine().ToString();
		Console.ResetColor();
	}

	public static void WantDownload()
    {
		AskDownload();

		if (rep != "y")
		{
			if (rep != "n") { isGoodRep = false; }
			else { isGoodRep = true; }
		}
		else { isGoodRep = true; }

		if (isGoodRep == false)
		{
			while (isGoodRep == false)
			{
				ConsoleSettings.Error("\nError : You must enter a valid response (write only (y) or (n)).\n");
				AskDownload();
			}
		}

		if (rep == "y") { wantDownload = true; }
		else { wantDownload = false; }
	}
}
