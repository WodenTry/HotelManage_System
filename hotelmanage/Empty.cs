using System;
using System.Windows.Forms;


namespace hotelmanage
{
    public partial class Empty : Form
    {
        Opreate op = new Opreate();
        public Empty()
        {
            InitializeComponent();
        }

        private void Empty_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 客房信息", "客房信息");
            comboBox1.DataSource = op.GetDataTable("select distinct 房型 from 客房信息", "客房信息");
            comboBox1.DisplayMember = "房型";
            comboBox1.SelectedIndex = -1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 客房信息 where 房型 = '" + comboBox1.Text + "' or 状态 = '" + comboBox2.Text + "'","客房信息");
        }
    }
}
