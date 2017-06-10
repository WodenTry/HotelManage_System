using System;
using System.Windows.Forms;


namespace hotelmanage
{
    public partial class CheckIn : Form
    {
        Opreate op = new Opreate();
        public CheckIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into 房客信息(姓名,身份证号,房间号,房费及押金) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"','"+ textBox4.Text +"')";
            if (textBox1.Text != "")
            {
                if (op.OPSQL(sql))
                {
                  
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
               
            }
            else
                MessageBox.Show("编号不能为空！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
