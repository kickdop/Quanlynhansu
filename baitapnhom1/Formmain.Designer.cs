namespace baitapnhom1
{
    partial class Formmain
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
            this.themnv = new System.Windows.Forms.ToolStripMenuItem();
            this.suanv = new System.Windows.Forms.ToolStripMenuItem();
            this.xoanv = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themnv,
            this.suanv,
            this.xoanv,
            this.timkiemToolStripMenuItem,
            this.huongdan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themnv
            // 
            this.themnv.Name = "themnv";
            this.themnv.Size = new System.Drawing.Size(105, 20);
            this.themnv.Text = "Thêm nhân viên";
         
            // 
            // suanv
            // 
            this.suanv.Name = "suanv";
            this.suanv.Size = new System.Drawing.Size(93, 20);
            this.suanv.Text = "Sủa nhân viên";
           
            // 
            // xoanv
            // 
            this.xoanv.Name = "xoanv";
            this.xoanv.Size = new System.Drawing.Size(94, 20);
            this.xoanv.Text = "Xóa nhân viên";
            
            // 
            // timkiemToolStripMenuItem
            // 
            this.timkiemToolStripMenuItem.Name = "timkiemToolStripMenuItem";
            this.timkiemToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.timkiemToolStripMenuItem.Text = "Tìm kiếm";
            
            // 
            // huongdan
            // 
            this.huongdan.Name = "huongdan";
            this.huongdan.Size = new System.Drawing.Size(82, 20);
            this.huongdan.Text = "Hướng dẫn ";
           
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formmain";
            this.Text = "Formmain";
           
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themnv;
        private System.Windows.Forms.ToolStripMenuItem suanv;
        private System.Windows.Forms.ToolStripMenuItem xoanv;
        private System.Windows.Forms.ToolStripMenuItem huongdan;
        private System.Windows.Forms.ToolStripMenuItem timkiemToolStripMenuItem;
    }
}