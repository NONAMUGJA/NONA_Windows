using System;
using System.Drawing;
using System.Windows.Forms;

namespace NONA_Windows
{
    public partial class AccountForm : Form
    {
        public AccountForm(Point parentPos)
        {
            InitializeComponent();
            Location = new Point(parentPos.X + 100, parentPos.Y + 40);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}