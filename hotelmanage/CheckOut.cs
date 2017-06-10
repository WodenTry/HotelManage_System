using System;
using System.Windows.Forms;

namespace hotelmanage
{
    public partial class CheckOut : Form
    {
        Opreate op = new Opreate();
        public CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "delete from 房客信息 where 房间号 ='"+ textBox1.Text +"'";
            if (textBox1.Text != "")
            {
                if (op.OPSQL(sql))
                {

                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

            }
            else
                MessageBox.Show("编号不能为空！");
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
