using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmanage
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void 入住管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn CI = new CheckIn();
            CI.Show();
        }

        private void 退房管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut CO = new CheckOut();
            CO.Show();
            
        }

        private void 空房查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empty E = new Empty();
            E.Show();
        }

        private void 房间信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomInfo RI = new RoomInfo();
            RI.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
