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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellDesignedProject
{
    public partial class frmMain : Form
    {
        static string Forecast="-";
        static string Euro="-";
        static string Dollar="-";
        static string[] Headlines=new string[] { };
        static List<musicListItem> musicList = new List<musicListItem>();
        public frmMain()
        {
            InitializeComponent();
        }

        
        frmActiveBrowsers FrmActiveBrowsers;
        private void frmMain_Load(object sender, EventArgs e)
        {
            FrmActiveBrowsers = new frmActiveBrowsers();
            backWorker.RunWorkerAsync();
            backgroundWorkerMusicServer.RunWorkerAsync();

            timer15Minutes_Tick(null,null);
        }

        string getForecast()
        {

                WebBrowser browser = FrmActiveBrowsers.browserForecast;

                var doc = browser.Document;
                var ziko = doc.GetElementsByTagName("ziko");

                string retval = ziko[1].InnerHtml;
                return retval;
            
            
        }

        string[] getCurrencyArray()
        {
            var browser = FrmActiveBrowsers.browserCurrency;

            var ABD = browser.Document
                 .GetElementById("kurlarContainer")
                 .GetElementsByTagName("table")[0]
                 .GetElementsByTagName("tr")[1]
                 .GetElementsByTagName("td")[3]
                 .InnerHtml;
            var Euro = browser.Document
                .GetElementById("kurlarContainer")
                .GetElementsByTagName("table")[0]
                .GetElementsByTagName("tr")[4]
                .GetElementsByTagName("td")[3]
                .InnerHtml;

            return new string[]
            {
                ABD,
                Euro
            };
        }


        string[] getHeadlinesArray()
        {
            var browser = FrmActiveBrowsers.browserNews;

            List<string> retval = new List<string>();

            HtmlElementCollection haberlist = browser.Document
                 .GetElementById("panel1")
                 .GetElementsByTagName("h5");

            foreach (HtmlElement item in haberlist)
            {
                retval.Add(item.InnerText);
            }

            return retval.ToArray();
        }

        private void btnShowBrowsers_Click(object sender, EventArgs e)
        {
            FrmActiveBrowsers.ShowDialog();
        }

        private void backWorker_DoWork(object sender2, DoWorkEventArgs e)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9999);
            Socket newsock = new Socket(AddressFamily.InterNetwork,
            SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = sender;

            while (true)
            {
                try
                {
                    data = new byte[1024];
                    recv = newsock.ReceiveFrom(data, ref Remote);

                    string receiveData = Encoding.UTF8.GetString(data, 0, recv);

                    if (receiveData.Contains("Forecast"))
                    {

                        byte[] bytes = Encoding.UTF8.GetBytes(Forecast);

                        newsock.SendTo(bytes, bytes.Length, SocketFlags.None, Remote);
                    }
                    else if (receiveData == "Euro")
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(Euro);

                        newsock.SendTo(bytes, bytes.Length, SocketFlags.None, Remote);
                    }
                    else if (receiveData == "Dollar")
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(Dollar);

                        newsock.SendTo(bytes, bytes.Length, SocketFlags.None, Remote);
                    }
                    else if (receiveData == "Headlines")
                    {
                        if (Headlines.Length > 0)
                        {
                            foreach (var item in Headlines)
                            {
                                byte[] bytes = Encoding.UTF8.GetBytes(item);

                                newsock.SendTo(bytes, bytes.Length, SocketFlags.None, Remote);
                            }
                        }
                        else
                        {
                            byte[] bytes = Encoding.UTF8.GetBytes("-");
                            newsock.SendTo(bytes, bytes.Length, SocketFlags.None, Remote);
                        }

                    }
                }
                catch (Exception)
                {

                }
                
            }
        }

        private void timerGetValues_Tick(object sender, EventArgs e)
        {
            try
            {
                var result = getForecast();
                if (!string.IsNullOrWhiteSpace(result) && result != "-")
                {
                    Forecast = txtForecastData.Text =result +" °C";
                }
            }
            catch (Exception)
            {
                
            }
           

            string[] currency;
            try
            {
                currency = getCurrencyArray();
                txtDollar.Text = currency[0] + " ₺";
                txtEuro.Text = currency[1] + " ₺";

                Euro = currency[1];
                Dollar = currency[0];
            }
            catch (Exception)
            {
                currency = null;
            }


           
            try
            {
                var headlineArray = getHeadlinesArray();
                if (string.IsNullOrWhiteSpace(headlineArray[0]))
                {
                    throw new Exception();
                }
                txtHeadLines.Text = "";
                for (int i = 0; i < headlineArray.Length; i++)
                {
                    
                    txtHeadLines.Text += (i + 1) + "- " + headlineArray[i] + Environment.NewLine;
                }

                Headlines = headlineArray;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void timer5MinutesRefresh_Tick(object sender, EventArgs e)
        {
            FrmActiveBrowsers.browserCurrency.Refresh();
            FrmActiveBrowsers.browserForecast.Refresh();
            FrmActiveBrowsers.browserNews.Refresh();
        }

        private void timer15Minutes_Tick(object sender, EventArgs e)
        {
            lstServerMusicsList.Items.Clear();
            foreach (string item in Directory.GetFiles("c:\\"))
            {
                string filename = Path.GetFileName(item);
                string extention = Path.GetExtension(item);
                if (extention == ".mp3")
                {
                    lstServerMusicsList.Items.Add(new musicListItem()
                    {
                        FileName = filename,
                        FullPath = item
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstServerMusicsList.SelectedItems.Count>0)
            {
                if (lstCurrentPlaylist.Items.Count < 5)
                {
                    bool control = true;
                    musicListItem selectedItem = (musicListItem)lstServerMusicsList.SelectedItems[0];
                    foreach (musicListItem item in lstCurrentPlaylist.Items)
                    {
                        if (item.FullPath == selectedItem.FullPath)
                        {
                            control = false;
                        }
                    }
                    if (control)
                    {
                        lstCurrentPlaylist.Items.Add(lstServerMusicsList.SelectedItems[0]);
                    }
                    
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstCurrentPlaylist.SelectedItem != null)
            {
                lstCurrentPlaylist.Items.Remove(lstCurrentPlaylist.SelectedItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCurrentPlaylist.Items.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstCurrentPlaylist.Items.Count == 5)
            {
                musicList.Clear();
                foreach (musicListItem item in lstCurrentPlaylist.Items)
                {
                    musicList.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Lütfen 5 tane müzik seçiniz.");
            }
        }

        private void backgroundWorkerMusicServer_DoWork(object sender2, DoWorkEventArgs e)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9998);
            Socket newsock =  new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = sender;
            while (true)
            {
                data = new byte[1024];

                recv = newsock.ReceiveFrom(data, ref Remote);

                string receiveData = Encoding.UTF8.GetString(data, 0, recv);

                if (receiveData.Contains("download")) //When "download" command taken, split the command and take argument.
                {
                    string[] splitedCommand = receiveData.Split(' ');

                    string filename = splitedCommand[1];
                    filename = filename.Replace("\"", "");

                    int filenumber = int.Parse(filename);

                    filename = musicList[filenumber].FullPath;

                    string offset = splitedCommand[2];
                    string chunksize = splitedCommand[3];

                    int _chunksize = int.Parse(chunksize);
                    int _offset = int.Parse(offset);
                    //when arguments assigned to variables, starts reading the file.
                    byte[] bytes = File.ReadAllBytes(filename);

                    newsock.SendTo(bytes.Skip(_offset).Take(_chunksize).ToList().ToArray(), _chunksize, SocketFlags.None, Remote);
                    //we skip redundant bytes and take bytes about chuncksize and sent this bytes
                }
                else if (receiveData.Contains("size")) // if a command including size, that means requesting size of file.
                {
                    string[] splitedCommand = receiveData.Split(' ');

                    string filename = splitedCommand[1];

                    filename = filename.Replace("\"", "");

                    int filenumber = int.Parse(filename);

                    filename = musicList[filenumber].FullPath;

                    byte[] bytes = File.ReadAllBytes(filename);

                    var size = Encoding.UTF8.GetBytes(bytes.Length.ToString());
                    //convert size data to text, after that converting to bytes for sending process.
                    newsock.SendTo(size, size.Length, SocketFlags.None, Remote);
                }
            }


        }

        private void lstServerMusicsList_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }

    class musicListItem
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }

        public override string ToString()
        {
            return FileName;
        }
    }
}
