using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NONA_Windows
{
    public partial class NONAMain : Form
    {
        public NONAMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            tabControl.SelectedTab = recentPage;
        }

        private void recentButton_MouseEnter(object sender, EventArgs e)
        {
            recentButton.BackColor = Color.LightGray;
        }

        private void recentButton_MouseLeave(object sender, EventArgs e)
        {
            recentButton.BackColor = Color.Transparent;
        }
    }
}