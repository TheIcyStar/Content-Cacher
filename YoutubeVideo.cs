using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Cacher {
	class YoutubeVideo {

		public YoutubeVideo(string URL) {
			this.URL = URL;
		}

		private string URL, YoutubeID;
		
		/// <summary>
		/// Gets the video's youtube ID
		/// </summary>
		/// <returns>String VideoID</returns>
		public string GetVideoID() {
			return this.YoutubeID;
		}	
	}
}
