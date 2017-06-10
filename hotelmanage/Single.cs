using System;
using System.Windows.Forms;


namespace hotelmanage
{
    public partial class Single : Form
    {
        Opreate op = new Opreate();
        public Single()
        {
            InitializeComponent();
        }

        private void Single_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 房客信息", "房客信息");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.GetDataTable("select * from 房客信息 where 身份证号 = '" + textBox1.Text + "'", "房客信息");
        }
    }
}
