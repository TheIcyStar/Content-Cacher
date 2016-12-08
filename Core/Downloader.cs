using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Cacher.Core {
	class Downloader {
		public void StartDownload() {
			//get next item in queue
			//get the download url of item
			//send url to downloader
			//update progress in ui
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="url">URL of file to download</param>
		private void DownloadFile(string url, string savePath ) {
			string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string pathDownload = Path.Combine(UserPath, "Downloads");
		}
	}
}
