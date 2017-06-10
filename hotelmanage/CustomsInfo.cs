using System;
using System.Windows.Forms;

namespace hotelmanage
{
    public partial class CustomsInfo : Form
    {
        public CustomsInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single S = new Single();
            S.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALL A = new ALL();
            A.Show();
        }
    }
}
