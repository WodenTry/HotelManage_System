using System;
using System.Windows.Forms;

namespace hotelmanage
{
    public partial class RoomInfo : Form
    {
        Opreate op = new Opreate();
        public RoomInfo()
        {
            InitializeComponent();
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 客房信息", "客房信息");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 客房信息 where 房间号 = '" + textBox1.Text + "'", "客房信息");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
