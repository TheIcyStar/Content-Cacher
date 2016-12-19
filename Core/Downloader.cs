using System;
using System.IO;
using System.Net;

namespace Content_Cacher.Core {
	class Downloader {
		public void StartDownload() {
			//get next item in queue
			//get the download url of item
			//send url to downloader
			//update progress in ui --todo: make a seperate event elsewhere to handle this
		}

		/// <summary>
		/// Downloads a file from a given URL
		/// </summary>
		/// <param name="url">URL of file to download</param>
		private void DownloadFile(string url ) {
			//todo: add start, progress, and end events

			string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string pathDownload = Path.Combine(UserPath, "Downloads");
			var request = (HttpWebRequest)WebRequest.Create(url);

			using (WebResponse response = request.GetResponse()) {
				using (Stream source = response.GetResponseStream()) {
					using (FileStream target = File.Open(pathDownload, FileMode.Create, FileAccess.Write)) {
						var buffer = new byte[1024];
						int bytes;
						int copiedBytes = 0;

						while ((bytes = source.Read(buffer, 0, buffer.Length)) > 0) {
							target.Write(buffer, 0, bytes);

							copiedBytes += bytes;

							//reference code for use later
							/*var eventArgs = new ProgressEventArgs((copiedBytes * 1.0 / response.ContentLength) * 100);
							if (this.DownloadProgressChanged != null) {
								this.DownloadProgressChanged(this, eventArgs);

								if (eventArgs.Cancel) {
									cancel = true;
								}
							}
							//*/
						}
					}
				}
			}

		}
	}
}
