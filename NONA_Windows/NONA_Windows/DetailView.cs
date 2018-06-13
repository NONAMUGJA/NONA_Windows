using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NONA_Windows
{
    public partial class DetailView : Form
    {
        public int PNUM;

        public DetailView(Point parentPos, int pNum, Image pImage)
        {
            InitializeComponent();
            Location = new Point(parentPos.X + 100, parentPos.Y + 40);
            pImageView.Image = pImage;
            var res = GetJson("http://busan-c.iptime.org/nona/storage/");
            productName.Text = res[pNum].itemTitle.ToString();
            quantityLabel.Text = res[pNum].count.ToString();
            commentLabel.Text = res[pNum].comment.ToString();
            PNUM = pNum;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private dynamic GetJson(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.ContentType = "application/x-www-form-urlencoded; charset=\"unicode\";";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return JsonConvert.DeserializeObject(reader.ReadToEnd());
            }
        }

        private bool SendTradeRequest(string receiver, string chgProduct, string quantity, string comment)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://busan-c.iptime.org/nona/exchange/add.php?receiver=" + receiver + "&chgProduct=" + chgProduct + "&quantity=" + quantity + "&comment=" + comment);
            request.ContentType = "application/x-www-form-urlencoded; charset=\"unicode\";";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (reader.ReadToEnd() == "SUCCESS") return true;
            }
            return false;
        }

        private void requestTradeButton_Click(object sender, EventArgs e)
        {
            RequestForm rf = new RequestForm();
            rf.ShowDialog();
        }
    }
}