namespace osu_Sync
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.videoCheckbox = new System.Windows.Forms.CheckBox();
            this.scanBeatmaps = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // videoCheckbox
            // 
            this.videoCheckbox.AutoSize = true;
            this.videoCheckbox.Location = new System.Drawing.Point(12, 114);
            this.videoCheckbox.Name = "videoCheckbox";
            this.videoCheckbox.Size = new System.Drawing.Size(113, 19);
            this.videoCheckbox.TabIndex = 0;
            this.videoCheckbox.Text = "Download Video";
            this.videoCheckbox.UseVisualStyleBackColor = true;
            this.videoCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // scanBeatmaps
            // 
            this.scanBeatmaps.Location = new System.Drawing.Point(12, 12);
            this.scanBeatmaps.Name = "scanBeatmaps";
            this.scanBeatmaps.Size = new System.Drawing.Size(341, 45);
            this.scanBeatmaps.TabIndex = 1;
            this.scanBeatmaps.Text = "Scan Beatmaps";
            this.scanBeatmaps.UseVisualStyleBackColor = true;
            this.scanBeatmaps.Click += new System.EventHandler(this.scanBeatmaps_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import Beatmaps";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scanBeatmaps);
            this.Controls.Add(this.videoCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "osu!Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox videoCheckbox;
        private Button scanButton;
        private Button importButton;
        private CheckBox videoDownloadCheckBox;
        private Button scanBeatmaps;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}