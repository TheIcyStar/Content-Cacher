using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Cacher {
	/// <summary>
	/// The youtube video info class. Holds all of a youtube video's metadata
	/// </summary>
	class YoutubeVideoInfo {

		public string URL;
		public string Title;
		public string Description;

		//int itag, string url
		public Dictionary<int, string> AvailibleDownloads = new Dictionary<int, string>();
		
		public int itag;
		public string downloadURL;

		/*to-be-added metadata
		int Views;
		int Likes;
		int Dislikes;
		string thumbnailURL;
		//*/
		
		

	}
}
