using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;

namespace YouTubeDownloader;

public static class Video
{
	public static MultimediaScraper scraper = new MultimediaScraper();
	public static Multimedia multimedia = scraper.GetMultimedia(GetInfo.url);
	public static VideoInfo videoInfo = multimedia.CollectVideoInfo();
	public static VideoInfo youtubeVideoInfo = videoInfo as YouTubeVideoInfo;
	public static string ext = GetInfo.format;
	public static VideoFormatInfo format = youtubeVideoInfo.Formats.OrderBy(f => f.Bitrate).First(f => f.AudioCodec != null && f.VideoCodec != null);
	public static string filePath = Path.Combine("C:/Users/Administrateur/Music/", Video.videoInfo.Title + "." + ext);

	public static string title = "";
	public static float duration = 0;
}
