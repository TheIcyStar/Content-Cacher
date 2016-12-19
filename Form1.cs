﻿using System;
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
			Console.WriteLine("Newvid title form:"+newVid.Title);
			labelVideoDesc.Text = newVid.Description;
		}
	}
}
