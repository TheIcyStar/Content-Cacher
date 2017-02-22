using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Content_Cacher { //video to test with: https://www.youtube.com/watch?v=zmr2I8caF0c
	static class Program {
		// I am sorry to anyone who has to read my newbie c# code

		public static Core.DownloadQueue AppDownloadQueue;
		public static UIController AppUIController;

		[STAThread]
		static void Main() {
			AppDownloadQueue = new Core.DownloadQueue();
			AppUIController = new UIController();

			AppDownloadQueue.QueueChange += AppUIController.OnQueueChange;
			AppDownloadQueue.AddedToQueue += AppUIController.OnQueueAdded;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainFrame());
		}
	}

	//manages display of the UI
	public class UIController {
		//Queue content changes
		public void OnQueueAdded(object source, EventArgs e) {
			//Console.WriteLine("UIController: An object was added to the queue");
		}
		public void OnQueueChange(object source, EventArgs e) {
			//Console.WriteLine("UIController: Queue changed");
		}
	}
}
