using System;
using System.Windows.Forms;

namespace Content_Cacher {
	public partial class MainFrame : Form {
		public MainFrame() {
			InitializeComponent();
		}

		private void btnAddUrl_Click(object sender, EventArgs e) {
			YoutubeVideoInfo newVid = YoutubeVideo.New(txtUrlBox.Text);
			//todo: add bad url handling
			labelVideoName.Text = newVid.Title;
			labelVideoDesc.Text = newVid.Description;


			Program.AppDownloadQueue.AddToQueue(newVid.Title, newVid.URL);
			//Console.WriteLine("Newvid: " + newVid.Title);

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
