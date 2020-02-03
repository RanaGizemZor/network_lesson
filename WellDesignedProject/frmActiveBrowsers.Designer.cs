namespace WellDesignedProject
{
    partial class frmActiveBrowsers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.browserCurrency = new System.Windows.Forms.WebBrowser();
            this.browserForecast = new System.Windows.Forms.WebBrowser();
            this.browserNews = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.browserForecast);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "mgm.gov.tr";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.browserCurrency);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tcmb.gov.tr";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.browserNews);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1024, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "trtworld.com";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // browserCurrency
            // 
            this.browserCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserCurrency.Location = new System.Drawing.Point(3, 3);
            this.browserCurrency.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserCurrency.Name = "browserCurrency";
            this.browserCurrency.Size = new System.Drawing.Size(1018, 452);
            this.browserCurrency.TabIndex = 3;
            this.browserCurrency.Url = new System.Uri("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun", System.UriKind.Absolute);
            // 
            // browserForecast
            // 
            this.browserForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserForecast.Location = new System.Drawing.Point(3, 3);
            this.browserForecast.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserForecast.Name = "browserForecast";
            this.browserForecast.Size = new System.Drawing.Size(1018, 452);
            this.browserForecast.TabIndex = 1;
            this.browserForecast.Url = new System.Uri("https://www.mgm.gov.tr/?il=manisa", System.UriKind.Absolute);
            // 
            // browserNews
            // 
            this.browserNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserNews.Location = new System.Drawing.Point(0, 0);
            this.browserNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserNews.Name = "browserNews";
            this.browserNews.Size = new System.Drawing.Size(1024, 458);
            this.browserNews.TabIndex = 1;
            this.browserNews.Url = new System.Uri("https://www.trtworld.com/", System.UriKind.Absolute);
            // 
            // frmActiveBrowsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmActiveBrowsers";
            this.Text = "frmActiveBrowsers";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.WebBrowser browserCurrency;
        public System.Windows.Forms.WebBrowser browserForecast;
        public System.Windows.Forms.WebBrowser browserNews;
    }
}