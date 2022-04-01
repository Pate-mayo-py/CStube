using Aspose.Html.DataScraping.MultimediaScraping.YouTube;

namespace YouTubeDownloader;

public static class Installer
{
	private static string strDuration;

	public static void Install()
	{
		ConsoleSettings.Info("\nPreparing to install...");
		if (Video.videoInfo is YouTubeVideoInfo)
        {
			Video.title = Video.videoInfo.Title;
			Video.duration = Video.videoInfo.Duration;
			Video.duration /= 60;
			strDuration = Video.duration.ToString();
			strDuration = strDuration.Replace(",", ":");
        }

		if (Video.youtubeVideoInfo != null)
        {
			ConsoleSettings.Info($"\nDownloading of the video ({Video.title}) duration : {strDuration}");
			Video.multimedia.Download(Video.format, Video.filePath);
			Console.WriteLine("- - -");
			ConsoleSettings.Info("Your video was downloaded as success !");
        }else { ConsoleSettings.Error("\nError : Unknow, Please reload CStube"); }
	}
}
