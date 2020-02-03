namespace ClientGUI
{
    partial class Form1
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
            this.backgroundWorkerGetForecast = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForecast = new System.Windows.Forms.Label();
            this.backgroundWorkerGetCurrency = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerGetHeadlines = new System.ComponentModel.BackgroundWorker();
            this.txtDollar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeadLines = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuroToTl = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDollarToTl = new System.Windows.Forms.MaskedTextBox();
            this.btnConvertEuroToTl = new System.Windows.Forms.Button();
            this.btnConvertDollarToTL = new System.Windows.Forms.Button();
            this.lblEuroResult = new System.Windows.Forms.Label();
            this.lblDollarResult = new System.Windows.Forms.Label();
            this.timerRefreshData = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorkerMusicDownload = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtFileNumber = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConnect = new System.Windows.Forms.Button();
            this.lblTlToDollar = new System.Windows.Forms.Label();
            this.lblTlToEuro = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTlToDollar = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTlToEuro = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEuroToDollar = new System.Windows.Forms.MaskedTextBox();
            this.lblResultDollarToEuro = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDollarToEuro = new System.Windows.Forms.MaskedTextBox();
            this.lblResultEuroToDollar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorkerGetForecast
            // 
            this.backgroundWorkerGetForecast.WorkerReportsProgress = true;
            this.backgroundWorkerGetForecast.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetForecast_DoWork);
            this.backgroundWorkerGetForecast.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetForecast_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manisa Forecast: ";
            // 
            // txtForecast
            // 
            this.txtForecast.AutoSize = true;
            this.txtForecast.Location = new System.Drawing.Point(139, 13);
            this.txtForecast.Name = "txtForecast";
            this.txtForecast.Size = new System.Drawing.Size(13, 17);
            this.txtForecast.TabIndex = 1;
            this.txtForecast.Text = "-";
            // 
            // backgroundWorkerGetCurrency
            // 
            this.backgroundWorkerGetCurrency.WorkerReportsProgress = true;
            this.backgroundWorkerGetCurrency.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetCurrency_DoWork);
            this.backgroundWorkerGetCurrency.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetCurrency_RunWorkerCompleted);
            // 
            // backgroundWorkerGetHeadlines
            // 
            this.backgroundWorkerGetHeadlines.WorkerReportsProgress = true;
            this.backgroundWorkerGetHeadlines.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetHeadlines_DoWork);
            this.backgroundWorkerGetHeadlines.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetHeadlines_RunWorkerCompleted);
            // 
            // txtDollar
            // 
            this.txtDollar.AutoSize = true;
            this.txtDollar.Location = new System.Drawing.Point(139, 65);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(13, 17);
            this.txtDollar.TabIndex = 3;
            this.txtDollar.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dollar";
            // 
            // txtEuro
            // 
            this.txtEuro.AutoSize = true;
            this.txtEuro.Location = new System.Drawing.Point(139, 39);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(13, 17);
            this.txtEuro.TabIndex = 5;
            this.txtEuro.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro";
            // 
            // txtHeadLines
            // 
            this.txtHeadLines.AutoSize = true;
            this.txtHeadLines.Location = new System.Drawing.Point(139, 94);
            this.txtHeadLines.Name = "txtHeadLines";
            this.txtHeadLines.Size = new System.Drawing.Size(30, 68);
            this.txtHeadLines.TabIndex = 10;
            this.txtHeadLines.Text = "1- -\r\n2- -\r\n3- -\r\n4- -\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Headlines:";
            // 
            // txtEuroToTl
            // 
            this.txtEuroToTl.Location = new System.Drawing.Point(240, 178);
            this.txtEuroToTl.Name = "txtEuroToTl";
            this.txtEuroToTl.Size = new System.Drawing.Size(100, 22);
            this.txtEuroToTl.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Euro to TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dollar to TL";
            // 
            // txtDollarToTl
            // 
            this.txtDollarToTl.Location = new System.Drawing.Point(240, 206);
            this.txtDollarToTl.Name = "txtDollarToTl";
            this.txtDollarToTl.Size = new System.Drawing.Size(100, 22);
            this.txtDollarToTl.TabIndex = 13;
            // 
            // btnConvertEuroToTl
            // 
            this.btnConvertEuroToTl.Location = new System.Drawing.Point(346, 178);
            this.btnConvertEuroToTl.Name = "btnConvertEuroToTl";
            this.btnConvertEuroToTl.Size = new System.Drawing.Size(37, 23);
            this.btnConvertEuroToTl.TabIndex = 15;
            this.btnConvertEuroToTl.Text = "=";
            this.btnConvertEuroToTl.UseVisualStyleBackColor = true;
            this.btnConvertEuroToTl.Click += new System.EventHandler(this.btnConvertEuroToTl_Click);
            // 
            // btnConvertDollarToTL
            // 
            this.btnConvertDollarToTL.Location = new System.Drawing.Point(346, 205);
            this.btnConvertDollarToTL.Name = "btnConvertDollarToTL";
            this.btnConvertDollarToTL.Size = new System.Drawing.Size(37, 23);
            this.btnConvertDollarToTL.TabIndex = 15;
            this.btnConvertDollarToTL.Text = "=";
            this.btnConvertDollarToTL.UseVisualStyleBackColor = true;
            this.btnConvertDollarToTL.Click += new System.EventHandler(this.btnConvertDollarToTL_Click);
            // 
            // lblEuroResult
            // 
            this.lblEuroResult.AutoSize = true;
            this.lblEuroResult.Location = new System.Drawing.Point(389, 181);
            this.lblEuroResult.Name = "lblEuroResult";
            this.lblEuroResult.Size = new System.Drawing.Size(13, 17);
            this.lblEuroResult.TabIndex = 16;
            this.lblEuroResult.Text = "-";
            // 
            // lblDollarResult
            // 
            this.lblDollarResult.AutoSize = true;
            this.lblDollarResult.Location = new System.Drawing.Point(389, 209);
            this.lblDollarResult.Name = "lblDollarResult";
            this.lblDollarResult.Size = new System.Drawing.Size(13, 17);
            this.lblDollarResult.TabIndex = 16;
            this.lblDollarResult.Text = "-";
            // 
            // timerRefreshData
            // 
            this.timerRefreshData.Interval = 1000;
            this.timerRefreshData.Tick += new System.EventHandler(this.timerRefreshData_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(392, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Download List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorkerMusicDownload
            // 
            this.backgroundWorkerMusicDownload.WorkerReportsProgress = true;
            this.backgroundWorkerMusicDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerMusicDownload_DoWork);
            this.backgroundWorkerMusicDownload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMusicDownload_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(16, 345);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(929, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.AutoSize = true;
            this.txtFileNumber.Location = new System.Drawing.Point(13, 322);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.Size = new System.Drawing.Size(0, 17);
            this.txtFileNumber.TabIndex = 20;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIP.Location = new System.Drawing.Point(844, 13);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 22);
            this.txtServerIP.TabIndex = 21;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Server IP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConnect
            // 
            this.txtConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnect.Location = new System.Drawing.Point(869, 41);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(75, 23);
            this.txtConnect.TabIndex = 23;
            this.txtConnect.Text = "Connect";
            this.txtConnect.UseVisualStyleBackColor = true;
            this.txtConnect.Click += new System.EventHandler(this.txtConnect_Click);
            // 
            // lblTlToDollar
            // 
            this.lblTlToDollar.AutoSize = true;
            this.lblTlToDollar.Location = new System.Drawing.Point(718, 207);
            this.lblTlToDollar.Name = "lblTlToDollar";
            this.lblTlToDollar.Size = new System.Drawing.Size(13, 17);
            this.lblTlToDollar.TabIndex = 30;
            this.lblTlToDollar.Text = "-";
            // 
            // lblTlToEuro
            // 
            this.lblTlToEuro.AutoSize = true;
            this.lblTlToEuro.Location = new System.Drawing.Point(718, 181);
            this.lblTlToEuro.Name = "lblTlToEuro";
            this.lblTlToEuro.Size = new System.Drawing.Size(13, 17);
            this.lblTlToEuro.TabIndex = 31;
            this.lblTlToEuro.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "TL to Dollar";
            // 
            // txtTlToDollar
            // 
            this.txtTlToDollar.Location = new System.Drawing.Point(564, 206);
            this.txtTlToDollar.Name = "txtTlToDollar";
            this.txtTlToDollar.Size = new System.Drawing.Size(100, 22);
            this.txtTlToDollar.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "TL to Euro";
            // 
            // txtTlToEuro
            // 
            this.txtTlToEuro.Location = new System.Drawing.Point(564, 178);
            this.txtTlToEuro.Name = "txtTlToEuro";
            this.txtTlToEuro.Size = new System.Drawing.Size(100, 22);
            this.txtTlToEuro.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Dollar To Euro";
            // 
            // txtEuroToDollar
            // 
            this.txtEuroToDollar.Location = new System.Drawing.Point(564, 234);
            this.txtEuroToDollar.Name = "txtEuroToDollar";
            this.txtEuroToDollar.Size = new System.Drawing.Size(100, 22);
            this.txtEuroToDollar.TabIndex = 36;
            // 
            // lblResultDollarToEuro
            // 
            this.lblResultDollarToEuro.AutoSize = true;
            this.lblResultDollarToEuro.Location = new System.Drawing.Point(389, 237);
            this.lblResultDollarToEuro.Name = "lblResultDollarToEuro";
            this.lblResultDollarToEuro.Size = new System.Drawing.Size(13, 17);
            this.lblResultDollarToEuro.TabIndex = 35;
            this.lblResultDollarToEuro.Text = "-";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(346, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Euro to Dollar";
            // 
            // txtDollarToEuro
            // 
            this.txtDollarToEuro.Location = new System.Drawing.Point(240, 234);
            this.txtDollarToEuro.Name = "txtDollarToEuro";
            this.txtDollarToEuro.Size = new System.Drawing.Size(100, 22);
            this.txtDollarToEuro.TabIndex = 32;
            // 
            // lblResultEuroToDollar
            // 
            this.lblResultEuroToDollar.AutoSize = true;
            this.lblResultEuroToDollar.Location = new System.Drawing.Point(718, 236);
            this.lblResultEuroToDollar.Name = "lblResultEuroToDollar";
            this.lblResultEuroToDollar.Size = new System.Drawing.Size(13, 17);
            this.lblResultEuroToDollar.TabIndex = 39;
            this.lblResultEuroToDollar.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 383);
            this.Controls.Add(this.lblResultEuroToDollar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEuroToDollar);
            this.Controls.Add(this.lblResultDollarToEuro);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDollarToEuro);
            this.Controls.Add(this.lblTlToDollar);
            this.Controls.Add(this.lblTlToEuro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTlToDollar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTlToEuro);
            this.Controls.Add(this.txtConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.txtFileNumber);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDollarResult);
            this.Controls.Add(this.lblEuroResult);
            this.Controls.Add(this.btnConvertDollarToTL);
            this.Controls.Add(this.btnConvertEuroToTl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDollarToTl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEuroToTl);
            this.Controls.Add(this.txtHeadLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDollar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForecast);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerGetForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtForecast;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetCurrency;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetHeadlines;
        private System.Windows.Forms.Label txtDollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtHeadLines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtEuroToTl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDollarToTl;
        private System.Windows.Forms.Button btnConvertEuroToTl;
        private System.Windows.Forms.Button btnConvertDollarToTL;
        private System.Windows.Forms.Label lblEuroResult;
        private System.Windows.Forms.Label lblDollarResult;
        private System.Windows.Forms.Timer timerRefreshData;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMusicDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtFileNumber;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtConnect;
        private System.Windows.Forms.Label lblTlToDollar;
        private System.Windows.Forms.Label lblTlToEuro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTlToDollar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtTlToEuro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtEuroToDollar;
        private System.Windows.Forms.Label lblResultDollarToEuro;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtDollarToEuro;
        private System.Windows.Forms.Label lblResultEuroToDollar;
    }
}

