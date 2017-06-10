using System;
using System.Windows.Forms;

namespace hotelmanage
{
    public partial class ALL : Form
    {
        Opreate op = new Opreate();
        public ALL()
        {
            InitializeComponent();
        }

        private void ALL_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 房客信息", "房客信息");
        }
    }
}
