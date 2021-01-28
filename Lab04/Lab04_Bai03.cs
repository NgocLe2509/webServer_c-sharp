using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab04_Bai03 : Form
    {
        // web is opening
        string link;

        public Lab04_Bai03()
        {
            InitializeComponent();
            webBrowser.Navigate("google.com");
        }

        public static string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        public static string check(string url)
        {
            int countDot = 0;
            char[] strURL = url.ToCharArray();
            foreach(char _str in strURL)
            {
                if(_str == '.')
                {
                    countDot++;
                }
            }
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                if (countDot == 0)
                {
                    string _url = "http://google.com.vn/search?q=" + url + "&tbm=";
                    return _url;
                }
                else
                {
                    string _url = "http://" + url;
                    return _url;
                }
            }
            return url;
        }

        // view source
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string source = getHTML(link);
                Lab04_Bai03_Source formSource = new Lab04_Bai03_Source(cbbSearch.Text, source);
                formSource.Show();
            }
            catch
            {
                MessageBox.Show("URL không hợp lệ!");
            }
        }

        private void cbbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (cbbSearch.Items.Count < 4)
                {
                    cbbSearch.Items.Add(cbbSearch.Text);
                }
                else
                {
                    cbbSearch.Items.RemoveAt(3);
                    cbbSearch.Items.Add(cbbSearch.Text);
                }
                cbbSearch.Text = check(cbbSearch.Text);
                webBrowser.Navigate(cbbSearch.Text);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var myClient = new WebClient();
            Stream response = myClient.OpenRead(link);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            string path = sfd.FileName;
            if (path != "")
            {
                myClient.DownloadFile(link, path);
                int index = path.LastIndexOf("\\");
                path = path.Remove(index + 1);

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                try
                {
                    doc = web.Load(link);
                    foreach (HtmlNode img_or_script in doc.DocumentNode.SelectNodes("//img[@src] | //script[@src]"))
                    {
                        string _path = path;
                        String src = img_or_script.GetAttributeValue("src", "");
                        if (src.Contains("base64"))
                        {
                            src = img_or_script.GetAttributeValue("src-data", "");
                        }
                        if (!src.Contains("http"))
                        {
                            int indexFirst = link.IndexOf("/");
                            indexFirst = link.IndexOf("/", indexFirst + 2);
                            String server = link.Substring(0, indexFirst);
                            src = server + src;
                        }
                        int indexLast = src.LastIndexOf("/");
                        string nameFile = src.Substring(indexLast + 1);
                        _path += nameFile;
                        MessageBox.Show(src);
                        try
                        {
                            myClient.DownloadFile(src, _path);
                        }
                        catch
                        {
                            MessageBox.Show("Dowload File " + nameFile + " Error!");
                        }
                    }
                    response.Close();
                }
                catch
                {
                    MessageBox.Show("Dowload Error!");
                }
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnCanGoBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void picResearch_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            link = webBrowser.Url.ToString();
            cbbSearch.Text = link;
        }
    }
}