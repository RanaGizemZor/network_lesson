using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        static string staticEuro = "";
        static string staticDollar = "";
        static List<string> staticHeadlines = new List<string>();
        static string serverIP = "127.0.0.1";
        private void backgroundWorkerGetForecast_DoWork(object sender2, DoWorkEventArgs e)
        {
            IPEndPoint ipep;
            Socket server;
            IPEndPoint sender;
            EndPoint Remote;
            ipep = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = sender;


            byte[] data = Encoding.UTF8.GetBytes("Forecast");
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            server.ReceiveFrom(data, ref Remote);

            string retval = Encoding.UTF8.GetString(data, 0, data.Length);

            e.Result = retval;
            

            server.Close();
            server.Dispose();
        }

        private void backgroundWorkerGetForecast_RunWorkerCompleted(object sender2, RunWorkerCompletedEventArgs e)
        {
            txtForecast.Text = e.Result.ToString();
        }

        private void backgroundWorkerGetCurrency_DoWork(object sender2, DoWorkEventArgs e)
        {
            IPEndPoint ipep;
            Socket server;
            IPEndPoint sender;
            EndPoint Remote;
            ipep = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = sender;

            byte[] data = Encoding.UTF8.GetBytes("Euro");
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            server.ReceiveFrom(data, ref Remote);

            string retval = Encoding.UTF8.GetString(data, 0, data.Length);

            staticEuro = retval;

            data = Encoding.UTF8.GetBytes("Dollar");
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            server.ReceiveFrom(data, ref Remote);

             retval = Encoding.UTF8.GetString(data, 0, data.Length);

            staticDollar = retval;


            server.Close();
            server.Dispose();
        }

        private void backgroundWorkerGetHeadlines_DoWork(object sender2, DoWorkEventArgs e)
        {
            IPEndPoint ipep;
            Socket server;
            IPEndPoint sender;
            EndPoint Remote;
            ipep = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = sender;

  
            byte[] data = Encoding.UTF8.GetBytes("Headlines");
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            server.ReceiveFrom(data, ref Remote);

            string retval = Encoding.UTF8.GetString(data, 0, data.Length).Replace("\0", "");

            

           

            if (!string.IsNullOrWhiteSpace(retval) && !retval.Equals("-"))
            {
                staticHeadlines = new List<string>();
                staticHeadlines.Add(retval);
                server.ReceiveFrom(data, ref Remote);

                retval = Encoding.UTF8.GetString(data, 0, data.Length);

                staticHeadlines.Add(retval);

                server.ReceiveFrom(data, ref Remote);

                retval = Encoding.UTF8.GetString(data, 0, data.Length);

                staticHeadlines.Add(retval);

                server.ReceiveFrom(data, ref Remote);

                retval = Encoding.UTF8.GetString(data, 0, data.Length);

                staticHeadlines.Add(retval);

            }

            server.Close();
            server.Dispose();
        }

        private void backgroundWorkerGetCurrency_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtEuro.Text = staticEuro;
            txtDollar.Text = staticDollar;
        }

        private void backgroundWorkerGetHeadlines_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtHeadLines.Text = "";

            for (int i = 0; i < staticHeadlines.Count; i++)
            {
                var text = (i + 1) + "- " + staticHeadlines[i].Replace("\0","") + Environment.NewLine; 

                txtHeadLines.Text += text;
            }
        }

        private void btnConvertEuroToTl_Click(object sender, EventArgs e)
        {
            if ( double.TryParse(staticEuro, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double oneEuro) 
                && double.TryParse(txtEuroToTl.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double customeruro))
            {
                lblEuroResult.Text = (customeruro * oneEuro).ToString();
            }
        }

        private void btnConvertDollarToTL_Click(object sender, EventArgs e)
        {
            if (double.TryParse(staticDollar, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double oneDollar) && double.TryParse(txtDollarToTl.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture,out double customdollar))
            {
                lblDollarResult.Text = (customdollar * oneDollar).ToString();
            }
        }

        private void timerRefreshData_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorkerGetForecast.IsBusy) backgroundWorkerGetForecast.RunWorkerAsync();
            if (!backgroundWorkerGetCurrency.IsBusy) backgroundWorkerGetCurrency.RunWorkerAsync();
            if (!backgroundWorkerGetHeadlines.IsBusy) backgroundWorkerGetHeadlines.RunWorkerAsync();
        }

        private void button1_Click(object sender2, EventArgs e)
        {
            if (backgroundWorkerMusicDownload.IsBusy)
            {
                MessageBox.Show("indirme devam ediyor");
            }
            else
            {
                backgroundWorkerMusicDownload.RunWorkerAsync();
            }
        }

        private void BackgroundWorkerMusicDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadHelper server0 = new DownloadHelper(serverIP);

            for (int i = 0; i < 5; i++)
            {
                int sizeOfFile = server0.GetSize(i.ToString());

                int dataleft = sizeOfFile;
                int buffersize = 8000;      //chunk size
                int downloadedData = 0;

                //The file we want to download will be saved on the desktop
                // Creating a file on the desktop and writes into the file
                string mp3Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + i.ToString() + ".mp3";

                if (File.Exists(mp3Path))
                {
                    File.Delete(mp3Path);
                }

                using (FileStream fileStream = new FileStream(mp3Path, FileMode.CreateNew, FileAccess.Write))
                {
                    while (dataleft > 0)
                    {
                        if (buffersize >= dataleft)
                        {
                            buffersize = dataleft;
                            dataleft = 0;
                        }
                        else
                        {
                            dataleft -= buffersize;
                        }

                        byte[] data;

                        data = server0.GetChunk(i.ToString(), downloadedData, buffersize);

                        foreach (byte item in data)
                        {
                            fileStream.WriteByte(item);
                        }

                        downloadedData = sizeOfFile - dataleft;

                        backgroundWorkerMusicDownload.ReportProgress((int)(100 * ((downloadedData * 1.0) / (sizeOfFile * 1.0))), i);
                    }
                    fileStream.Close();     //Save the file
                    fileStream.Dispose();
                    backgroundWorkerMusicDownload.ReportProgress(101,i);

                    Thread.Sleep(1000);
                }
            }
            
        }
        public class file
        {
            public string filename { get; set; }
            public string path { get; set; }

            public override string ToString()
            {
                return filename;
            }
        }

        private void backgroundWorkerMusicDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage<=100)
            {
                progressBar1.Value = e.ProgressPercentage;
                txtFileNumber.Text = e.UserState.ToString();
            }
            if (e.ProgressPercentage == 101)
            {
                txtFileNumber.Text = "Completed";
            }
        }

        private void txtConnect_Click(object sender, EventArgs e)
        {
            serverIP = txtServerIP.Text;

            timerRefreshData.Enabled = true;

            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(staticEuro, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double oneEuro) &&
                double.TryParse(txtTlToEuro.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double customeruro))
            {
                lblTlToEuro.Text = (customeruro / oneEuro).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(staticDollar, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double oneDollar) && 
                double.TryParse(txtTlToDollar.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double customerdollar))
            {
                lblTlToDollar.Text = (customerdollar / oneDollar).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(staticDollar,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double oneDollar) &&
                double.TryParse(staticEuro,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double oneEuro) &&
                double.TryParse(txtDollarToEuro.Text,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double customerdollar))
            {
                lblResultDollarToEuro.Text = (oneEuro * (customerdollar / oneDollar)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(staticDollar,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double oneDollar) &&
                double.TryParse(staticEuro,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double oneEuro) &&
                double.TryParse(txtEuroToDollar.Text,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double customerEuro))
            {
                lblResultEuroToDollar.Text = (oneDollar*(customerEuro / oneEuro)).ToString();
            }
        }
    }
}
