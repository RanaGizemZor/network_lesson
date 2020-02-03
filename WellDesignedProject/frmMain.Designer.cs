namespace WellDesignedProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnShowBrowsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForecastData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.Label();
            this.txtDollar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeadLines = new System.Windows.Forms.Label();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.timerGetValues = new System.Windows.Forms.Timer(this.components);
            this.timer5MinutesRefresh = new System.Windows.Forms.Timer(this.components);
            this.lstServerMusicsList = new System.Windows.Forms.ListBox();
            this.lstCurrentPlaylist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer15Minutes = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.backgroundWorkerMusicServer = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowBrowsers
            // 
            this.btnShowBrowsers.Location = new System.Drawing.Point(606, 266);
            this.btnShowBrowsers.Name = "btnShowBrowsers";
            this.btnShowBrowsers.Size = new System.Drawing.Size(187, 44);
            this.btnShowBrowsers.TabIndex = 3;
            this.btnShowBrowsers.Text = "Show Browser Pages";
            this.btnShowBrowsers.UseVisualStyleBackColor = true;
            this.btnShowBrowsers.Click += new System.EventHandler(this.btnShowBrowsers_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Updated Forecast: ";
            // 
            // txtForecastData
            // 
            this.txtForecastData.AutoSize = true;
            this.txtForecastData.Location = new System.Drawing.Point(150, 9);
            this.txtForecastData.Name = "txtForecastData";
            this.txtForecastData.Size = new System.Drawing.Size(13, 17);
            this.txtForecastData.TabIndex = 4;
            this.txtForecastData.Text = "-";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "1 Euro:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "1 Dollar:";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(102, 74);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(101, 23);
            this.txtEuro.TabIndex = 5;
            this.txtEuro.Text = "-";
            // 
            // txtDollar
            // 
            this.txtDollar.Location = new System.Drawing.Point(102, 106);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(101, 23);
            this.txtDollar.TabIndex = 6;
            this.txtDollar.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Headlines:";
            // 
            // txtHeadLines
            // 
            this.txtHeadLines.AutoSize = true;
            this.txtHeadLines.Location = new System.Drawing.Point(126, 265);
            this.txtHeadLines.Name = "txtHeadLines";
            this.txtHeadLines.Size = new System.Drawing.Size(30, 68);
            this.txtHeadLines.TabIndex = 8;
            this.txtHeadLines.Text = "1- -\r\n2- -\r\n3- -\r\n4- -\r\n";
            // 
            // backWorker
            // 
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            // 
            // timerGetValues
            // 
            this.timerGetValues.Enabled = true;
            this.timerGetValues.Interval = 1000;
            this.timerGetValues.Tick += new System.EventHandler(this.timerGetValues_Tick);
            // 
            // timer5MinutesRefresh
            // 
            this.timer5MinutesRefresh.Enabled = true;
            this.timer5MinutesRefresh.Interval = 300000;
            this.timer5MinutesRefresh.Tick += new System.EventHandler(this.timer5MinutesRefresh_Tick);
            // 
            // lstServerMusicsList
            // 
            this.lstServerMusicsList.FormattingEnabled = true;
            this.lstServerMusicsList.ItemHeight = 16;
            this.lstServerMusicsList.Location = new System.Drawing.Point(259, 42);
            this.lstServerMusicsList.Name = "lstServerMusicsList";
            this.lstServerMusicsList.Size = new System.Drawing.Size(193, 164);
            this.lstServerMusicsList.TabIndex = 9;
            this.lstServerMusicsList.DoubleClick += new System.EventHandler(this.lstServerMusicsList_Click);
            // 
            // lstCurrentPlaylist
            // 
            this.lstCurrentPlaylist.FormattingEnabled = true;
            this.lstCurrentPlaylist.ItemHeight = 16;
            this.lstCurrentPlaylist.Location = new System.Drawing.Point(564, 46);
            this.lstCurrentPlaylist.Name = "lstCurrentPlaylist";
            this.lstCurrentPlaylist.Size = new System.Drawing.Size(230, 164);
            this.lstCurrentPlaylist.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listeye Aktar >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(718, 216);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(637, 216);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 12;
            this.btnDeleteItem.Text = "Sil";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "All mp3 files";
            // 
            // timer15Minutes
            // 
            this.timer15Minutes.Enabled = true;
            this.timer15Minutes.Interval = 900000;
            this.timer15Minutes.Tick += new System.EventHandler(this.timer15Minutes_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(564, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // backgroundWorkerMusicServer
            // 
            this.backgroundWorkerMusicServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMusicServer_DoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current Playlist";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCurrentPlaylist);
            this.Controls.Add(this.lstServerMusicsList);
            this.Controls.Add(this.txtHeadLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForecastData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowBrowsers);
            this.Name = "frmMain";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBrowsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtForecastData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Label txtDollar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtHeadLines;
        private System.ComponentModel.BackgroundWorker backWorker;
        private System.Windows.Forms.Timer timerGetValues;
        private System.Windows.Forms.Timer timer5MinutesRefresh;
        private System.Windows.Forms.ListBox lstServerMusicsList;
        private System.Windows.Forms.ListBox lstCurrentPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer15Minutes;
        private System.Windows.Forms.Button btnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMusicServer;
        private System.Windows.Forms.Label label6;
    }
}

