using System;
using System.Collections.Generic;

namespace Content_Cacher {
	/// <summary>
	/// The youtube video info class. Holds all of a youtube video's metadata
	/// </summary>
	class YoutubeVideoInfo {

		public string URL;
		public string Title;
		public string Description;

		public int Duration; //in seconds


		//int itag, string url
		public Dictionary<int, string> AvailibleDownloads = new Dictionary<int, string>();
		
		public int itag;
		public string downloadURL;
		public int Expire; //unix in seconds on when the download url becomes stale and new ones need to be fetched
		//todo: move the parsing of download urls to right before downloading, since the urls become stale over time OR over different Ip addresses

		/*to-be-added metadata
		int Views;
		int Likes;
		int Dislikes;
		string thumbnailURL;
		//*/
	}
}
