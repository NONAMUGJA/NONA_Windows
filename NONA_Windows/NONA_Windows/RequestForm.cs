using System;
using System.Windows.Forms;

namespace NONA_Windows
{
    public partial class RequestForm : Form
    {
        public string chgProduct { get; set; }
        public string quantity { get; set; }
        public string comment { get; set; }

        public RequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chgProduct = textBox1.Text;
            quantity = textBox2.Text;
            comment = textBox3.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}