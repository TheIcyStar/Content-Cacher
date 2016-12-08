namespace Content_Cacher {
	partial class MainFrame {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.ButtonDownload = new System.Windows.Forms.Label();
			this.LogoPanel = new System.Windows.Forms.Panel();
			this.txt2 = new System.Windows.Forms.Label();
			this.Txt1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Resolutions = new System.Windows.Forms.ComboBox();
			this.DownloadProgress = new System.Windows.Forms.ProgressBar();
			this.labelVideoDesc = new System.Windows.Forms.Label();
			this.labelVideoName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.videoList = new System.Windows.Forms.ListView();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddUrl = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUrlBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.LogoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ButtonDownload);
			this.panel1.Controls.Add(this.LogoPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 501);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Silver;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(0, 129);
			this.label4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(46, 15, 47, 15);
			this.label4.Size = new System.Drawing.Size(200, 61);
			this.label4.TabIndex = 2;
			this.label4.Text = "Configs";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonDownload
			// 
			this.ButtonDownload.AutoSize = true;
			this.ButtonDownload.BackColor = System.Drawing.Color.Silver;
			this.ButtonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDownload.Location = new System.Drawing.Point(0, 65);
			this.ButtonDownload.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonDownload.Name = "ButtonDownload";
			this.ButtonDownload.Padding = new System.Windows.Forms.Padding(25, 15, 26, 15);
			this.ButtonDownload.Size = new System.Drawing.Size(200, 61);
			this.ButtonDownload.TabIndex = 1;
			this.ButtonDownload.Text = "Downloads";
			this.ButtonDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LogoPanel
			// 
			this.LogoPanel.AutoSize = true;
			this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(117)))), ((int)(((byte)(136)))));
			this.LogoPanel.Controls.Add(this.txt2);
			this.LogoPanel.Controls.Add(this.Txt1);
			this.LogoPanel.Controls.Add(this.pictureBox1);
			this.LogoPanel.Location = new System.Drawing.Point(0, 0);
			this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
			this.LogoPanel.Name = "LogoPanel";
			this.LogoPanel.Size = new System.Drawing.Size(200, 65);
			this.LogoPanel.TabIndex = 0;
			// 
			// txt2
			// 
			this.txt2.AutoSize = true;
			this.txt2.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.ForeColor = System.Drawing.Color.White;
			this.txt2.Location = new System.Drawing.Point(0, 21);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(76, 24);
			this.txt2.TabIndex = 2;
			this.txt2.Text = "content";
			// 
			// Txt1
			// 
			this.Txt1.AutoSize = true;
			this.Txt1.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt1.ForeColor = System.Drawing.Color.White;
			this.Txt1.Location = new System.Drawing.Point(131, 21);
			this.Txt1.Name = "Txt1";
			this.Txt1.Size = new System.Drawing.Size(66, 24);
			this.Txt1.TabIndex = 1;
			this.Txt1.Text = "cacher";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Content_Cacher.Properties.Resources.SmallLogo50px;
			this.pictureBox1.Location = new System.Drawing.Point(75, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.Resolutions);
			this.panel2.Controls.Add(this.DownloadProgress);
			this.panel2.Controls.Add(this.labelVideoDesc);
			this.panel2.Controls.Add(this.labelVideoName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.videoList);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnAddUrl);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtUrlBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(744, 501);
			this.panel2.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(282, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "itag selection";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(31, 449);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(271, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Downloads stored in the downloads folder";
			// 
			// Resolutions
			// 
			this.Resolutions.DisplayMember = "Nonn";
			this.Resolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Resolutions.FormattingEnabled = true;
			this.Resolutions.Items.AddRange(new object[] {
            "none!"});
			this.Resolutions.Location = new System.Drawing.Point(379, 65);
			this.Resolutions.Name = "Resolutions";
			this.Resolutions.Size = new System.Drawing.Size(121, 21);
			this.Resolutions.TabIndex = 9;
			this.Resolutions.ValueMember = " ";
			// 
			// DownloadProgress
			// 
			this.DownloadProgress.Location = new System.Drawing.Point(30, 167);
			this.DownloadProgress.Name = "DownloadProgress";
			this.DownloadProgress.Size = new System.Drawing.Size(470, 23);
			this.DownloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.DownloadProgress.TabIndex = 8;
			// 
			// labelVideoDesc
			// 
			this.labelVideoDesc.AutoSize = true;
			this.labelVideoDesc.BackColor = System.Drawing.SystemColors.Control;
			this.labelVideoDesc.Location = new System.Drawing.Point(136, 142);
			this.labelVideoDesc.Name = "labelVideoDesc";
			this.labelVideoDesc.Size = new System.Drawing.Size(90, 13);
			this.labelVideoDesc.TabIndex = 7;
			this.labelVideoDesc.Text = "Video Description";
			// 
			// labelVideoName
			// 
			this.labelVideoName.AutoSize = true;
			this.labelVideoName.BackColor = System.Drawing.SystemColors.Control;
			this.labelVideoName.Location = new System.Drawing.Point(136, 113);
			this.labelVideoName.Name = "labelVideoName";
			this.labelVideoName.Size = new System.Drawing.Size(65, 13);
			this.labelVideoName.TabIndex = 6;
			this.labelVideoName.Text = "Video Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Downloading";
			// 
			// videoList
			// 
			this.videoList.Location = new System.Drawing.Point(30, 266);
			this.videoList.Name = "videoList";
			this.videoList.Size = new System.Drawing.Size(470, 180);
			this.videoList.TabIndex = 4;
			this.videoList.UseCompatibleStateImageBehavior = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Download queue";
			// 
			// btnAddUrl
			// 
			this.btnAddUrl.Location = new System.Drawing.Point(126, 38);
			this.btnAddUrl.Name = "btnAddUrl";
			this.btnAddUrl.Size = new System.Drawing.Size(100, 31);
			this.btnAddUrl.TabIndex = 2;
			this.btnAddUrl.Text = "Add to queue";
			this.btnAddUrl.UseVisualStyleBackColor = true;
			this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Youtube URL";
			// 
			// txtUrlBox
			// 
			this.txtUrlBox.Location = new System.Drawing.Point(126, 12);
			this.txtUrlBox.Name = "txtUrlBox";
			this.txtUrlBox.Size = new System.Drawing.Size(374, 20);
			this.txtUrlBox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(506, 266);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "Begin download";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainFrame";
			this.Text = "Content Cacher";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.LogoPanel.ResumeLayout(false);
			this.LogoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel LogoPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label txt2;
		private System.Windows.Forms.Label Txt1;
		private System.Windows.Forms.Label ButtonDownload;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView videoList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrlBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar DownloadProgress;
		private System.Windows.Forms.Label labelVideoDesc;
		private System.Windows.Forms.Label labelVideoName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox Resolutions;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
	}
}

