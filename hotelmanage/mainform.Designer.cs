namespace hotelmanage
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.客房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入住管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空房查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房客查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房管理ToolStripMenuItem,
            this.查询信息ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 客房管理ToolStripMenuItem
            // 
            this.客房管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住管理ToolStripMenuItem,
            this.退房管理ToolStripMenuItem});
            this.客房管理ToolStripMenuItem.Name = "客房管理ToolStripMenuItem";
            this.客房管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客房管理ToolStripMenuItem.Text = "客房管理";
            // 
            // 查询信息ToolStripMenuItem
            // 
            this.查询信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间查询ToolStripMenuItem,
            this.房客查询ToolStripMenuItem});
            this.查询信息ToolStripMenuItem.Name = "查询信息ToolStripMenuItem";
            this.查询信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询信息ToolStripMenuItem.Text = "查询信息";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 入住管理ToolStripMenuItem
            // 
            this.入住管理ToolStripMenuItem.Name = "入住管理ToolStripMenuItem";
            this.入住管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.入住管理ToolStripMenuItem.Text = "入住管理";
            this.入住管理ToolStripMenuItem.Click += new System.EventHandler(this.入住管理ToolStripMenuItem_Click);
            // 
            // 退房管理ToolStripMenuItem
            // 
            this.退房管理ToolStripMenuItem.Name = "退房管理ToolStripMenuItem";
            this.退房管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退房管理ToolStripMenuItem.Text = "退房管理";
            this.退房管理ToolStripMenuItem.Click += new System.EventHandler(this.退房管理ToolStripMenuItem_Click);
            // 
            // 房间查询ToolStripMenuItem
            // 
            this.房间查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.空房查询ToolStripMenuItem,
            this.房间信息ToolStripMenuItem});
            this.房间查询ToolStripMenuItem.Name = "房间查询ToolStripMenuItem";
            this.房间查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间查询ToolStripMenuItem.Text = "房间查询";
            // 
            // 空房查询ToolStripMenuItem
            // 
            this.空房查询ToolStripMenuItem.Name = "空房查询ToolStripMenuItem";
            this.空房查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空房查询ToolStripMenuItem.Text = "空房查询";
            this.空房查询ToolStripMenuItem.Click += new System.EventHandler(this.空房查询ToolStripMenuItem_Click);
            // 
            // 房间信息ToolStripMenuItem
            // 
            this.房间信息ToolStripMenuItem.Name = "房间信息ToolStripMenuItem";
            this.房间信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间信息ToolStripMenuItem.Text = "房间信息";
            this.房间信息ToolStripMenuItem.Click += new System.EventHandler(this.房间信息ToolStripMenuItem_Click);
            // 
            // 房客查询ToolStripMenuItem
            // 
            this.房客查询ToolStripMenuItem.Name = "房客查询ToolStripMenuItem";
            this.房客查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房客查询ToolStripMenuItem.Text = "房客查询";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 客房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入住管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空房查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房客查询ToolStripMenuItem;
    }
}