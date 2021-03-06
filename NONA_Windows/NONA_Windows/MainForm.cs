﻿using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NONA_Windows
{
    public partial class NONAMain : Form
    {
        public NONAMain()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tileRefreshWorker.RunWorkerAsync();
            notificationService.RunWorkerAsync();
            notifyIcon.BalloonTipTitle = "NONA";
        }

        private static DateTime Delay(int ms)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void WndProc(ref Message m) // Borderless form moving script
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.LightGray;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.Transparent;
        }

        private void recentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("최근 알림");
        }

        private void recentButton_MouseEnter(object sender, EventArgs e)
        {
            recentButton.BackColor = Color.LightGray;
        }

        private void recentButton_MouseLeave(object sender, EventArgs e)
        {
            recentButton.BackColor = Color.Transparent;
        }

        private void accountButton_MouseEnter(object sender, EventArgs e)
        {
            accountButton.BackColor = Color.LightGray;
        }

        private void accountButton_MouseLeave(object sender, EventArgs e)
        {
            accountButton.BackColor = Color.Transparent;
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm(Location);
            af.ShowDialog();
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

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void portraitLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void NONAMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pImg1_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 0, pImg1.Image);
            dv.ShowDialog();
        }

        private void pImg2_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 1, pImg2.Image);
            dv.ShowDialog();
        }

        private void pImg3_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 2, pImg3.Image);
            dv.ShowDialog();
        }

        private void pImg4_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 3, pImg4.Image);
            dv.ShowDialog();
        }

        private void pImg5_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 4, pImg5.Image);
            dv.ShowDialog();
        }

        private void pImg6_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 5, pImg6.Image);
            dv.ShowDialog();
        }

        private void pImg7_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 6, pImg7.Image);
            dv.ShowDialog();
        }

        private void pImg8_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 7, pImg8.Image);
            dv.ShowDialog();
        }

        private void pImg9_Click(object sender, EventArgs e)
        {
            DetailView dv = new DetailView(Location, 8, pImg9.Image);
            dv.ShowDialog();
        }

        private void tileRefreshWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                var res = GetJson("http://busan-c.iptime.org/nona/storage/");
                pImg1.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[0].imageId.ToString();
                pImg2.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[1].imageId.ToString();
                pImg3.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[2].imageId.ToString();
                pImg4.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[3].imageId.ToString();
                pImg5.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[4].imageId.ToString();
                pImg6.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[5].imageId.ToString();
                pImg7.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[6].imageId.ToString();
                pImg8.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[7].imageId.ToString();
                pImg9.ImageLocation = "http://busan-c.iptime.org/nona/storage/img/uploads/" + res[8].imageId.ToString();
                Delay(10000);
            }
        }

        private dynamic prevJsonData = null;

        private void notificationService_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                var res = GetJson("http://busan-c.iptime.org/nona/storage/");
                if (res != prevJsonData)
                {
                    prevJsonData = res;
                    notifyIcon.BalloonTipText = "새로운 상품이 등록되었습니다.";
                    notifyIcon.ShowBalloonTip(1000);
                }
                Delay(2000);
            }
        }
    }
}