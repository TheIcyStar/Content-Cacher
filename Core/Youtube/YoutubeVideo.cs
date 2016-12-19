using System;
using System.Web;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Content_Cacher {
	/// <summary>
	/// Provides functionality for youtube videos. (not to be confused with YoutubeVideoInfo)
	//I just realized how stupid it is to have (what essentially is) a constructor for a different class in this class
	//oh well, functianality now, stupidity-removal later
	//todo?: move this constructor to its propper home
	//second thought: any possible benefits of having the (later archived) info class be as small as possible?
	//third thought: I don't think so
	//fourth thought: stop having conversations with yourself
	/// </summary>
	class YoutubeVideo {

		/// <summary>
		/// Creates a new YoutubeVideoInfo from a URL
		/// </summary>
		/// <param name="URL">String youtube URL</param>
		/// <returns></returns>
		public static YoutubeVideoInfo New(string url) {
			YoutubeVideoInfo newInfo = new YoutubeVideoInfo();

			newInfo.URL = url;
			//check if url is ok

			//get html
			string html;
			using (System.Net.WebClient client = new System.Net.WebClient()) {
				html = client.DownloadString(url); //todo: add exception handling
			}

			//get ytplayer's config
			var dataRegex = new Regex(@"ytplayer\.config\s*=\s*(\{.+?\});", RegexOptions.Multiline);

			string extractedJson = dataRegex.Match(html).Result("$1");

			JObject ytConfig = JObject.Parse(extractedJson);

			//Get title
			newInfo.Title = extractVideoTitle(html);

			//parse description (todo: find out how to have the description save special unicode chars like emojis)
			newInfo.Description = extractVideoDescription(html);

			//Get download urls
			string[] streamMap = GetDownloadUrls(ytConfig).Split(',');
			int count = 0;
			foreach (string s in streamMap) {
				int itag = int.Parse(Regex.Match(s, @"(?<=itag=)(\d+)").Value);//gets itag from the url
				string FormattedUrl = "";

				FormattedUrl = System.Net.WebUtility.HtmlDecode(FormattedUrl);
				FormattedUrl = System.Net.WebUtility.HtmlDecode(FormattedUrl);

				Console.WriteLine(s);
				count++;
			}


			return newInfo;
		}
		
		private static string extractVideoTitle(string html) {
			return Regex.Match(html, @"(?<=og:title\x22 content=\x22)(.*)(?=\x22)").Value;
		}

		private static string extractVideoDescription(string html) {
			string description = Regex.Match(html, @"(?<=eow-description\x22 class=\x22\x22 >)(.*)(?=</p>)").Value;
			//todo: find out how to add a statement to regex to not include things between <>
			//cleaning description from html tags
			bool ignore = false;
			string filteredDesc = "";
			foreach (char c in description) {
				if(c == '<') { //start ignore
					ignore = true;
				} else if (!ignore) { //add char if not ignored
					filteredDesc += c;
				} else if (c == '>') { //set ignore to false, but dont add the >
					ignore = false;
				}
			}
			return filteredDesc;
		}

		/// <summary>
		/// Returns the list of availible download urls
		/// </summary>
		/// <param name="html">raw HTML of a youtube video</param>
		private static string GetDownloadUrls(JObject ytplayerConfig) {
			JToken streamMap = ytplayerConfig["args"]["url_encoded_fmt_stream_map"];

			string streamMapString = streamMap == null ? null : streamMap.ToString();
			if (streamMapString == null || streamMapString.Contains("been+removed")) {
				//Handle "video does not exist"
			}
			//todo: append the adaptive stream maps onto this list
			return streamMapString;
		}
	}
}
