using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

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
			JObject ytConfig = JObject.Parse(Regex.Match(html, @"ytplayer\.config\s*=\s*(\{.+?\}").Value);

			//Get title
			newInfo.Title = extractVideoTitle(html);

			//parse description (todo: find out how to have the description save special unicode chars like emojis)
			newInfo.Description = extractVideoDescription(html);

			//parse availible itags

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
		/// Returns the availible download urls (todo: figure out in what data type, array of a videotype class?)
		/// </summary>
		/// <param name="html">raw HTML of a youtube video</param>
		private void GetDownloadUrls(string html) {

			string stream_map = Regex.Match(html, @"(?<=encoded_fmt_stream_map)(.*)(?=)").Value; //fix regex
        }
	}
}
