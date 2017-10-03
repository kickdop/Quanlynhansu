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
            this.grvnhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themnv = new System.Windows.Forms.ToolStripMenuItem();
            this.suanv = new System.Windows.Forms.ToolStripMenuItem();
            this.xoanv = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.cblocnv = new System.Windows.Forms.ComboBox();
            this.tatca = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvnhanvien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvnhanvien
            // 
            this.grvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvnhanvien.Location = new System.Drawing.Point(12, 100);
            this.grvnhanvien.Name = "grvnhanvien";
            this.grvnhanvien.Size = new System.Drawing.Size(972, 373);
            this.grvnhanvien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
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
            this.themnv.Click += new System.EventHandler(this.themnv_Click);
            // 
            // suanv
            // 
            this.suanv.Name = "suanv";
            this.suanv.Size = new System.Drawing.Size(93, 20);
            this.suanv.Text = "Sủa nhân viên";
            this.suanv.Click += new System.EventHandler(this.suanv_Click);
            // 
            // xoanv
            // 
            this.xoanv.Name = "xoanv";
            this.xoanv.Size = new System.Drawing.Size(94, 20);
            this.xoanv.Text = "Xóa nhân viên";
            this.xoanv.Click += new System.EventHandler(this.xoanv_Click);
            // 
            // timkiemToolStripMenuItem
            // 
            this.timkiemToolStripMenuItem.Name = "timkiemToolStripMenuItem";
            this.timkiemToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.timkiemToolStripMenuItem.Text = "Tìm kiếm";
            this.timkiemToolStripMenuItem.Click += new System.EventHandler(this.timkiemToolStripMenuItem_Click);
            // 
            // huongdan
            // 
            this.huongdan.Name = "huongdan";
            this.huongdan.Size = new System.Drawing.Size(82, 20);
            this.huongdan.Text = "Hướng dẫn ";
            this.huongdan.Click += new System.EventHandler(this.huongdan_Click);
            // 
            // cblocnv
            // 
            this.cblocnv.FormattingEnabled = true;
            this.cblocnv.Items.AddRange(new object[] {
            "Phòng Ban"});
            this.cblocnv.Location = new System.Drawing.Point(13, 68);
            this.cblocnv.Name = "cblocnv";
            this.cblocnv.Size = new System.Drawing.Size(167, 21);
            this.cblocnv.TabIndex = 3;
            this.cblocnv.TextChanged += new System.EventHandler(this.cblocnv_TextChanged);
            // 
            // tatca
            // 
            this.tatca.Location = new System.Drawing.Point(267, 66);
            this.tatca.Name = "tatca";
            this.tatca.Size = new System.Drawing.Size(75, 23);
            this.tatca.TabIndex = 4;
            this.tatca.Text = "Tất cả";
            this.tatca.UseVisualStyleBackColor = true;
            this.tatca.Click += new System.EventHandler(this.tatca_Click);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(186, 66);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(75, 23);
            this.loc.TabIndex = 5;
            this.loc.Text = "Lọc";
            this.loc.UseVisualStyleBackColor = true;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 485);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.tatca);
            this.Controls.Add(this.cblocnv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvnhanvien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formmain";
            this.Text = "Formmain";
            this.Activated += new System.EventHandler(this.Formmain_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.grvnhanvien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themnv;
        private System.Windows.Forms.ToolStripMenuItem suanv;
        private System.Windows.Forms.ToolStripMenuItem xoanv;
        private System.Windows.Forms.ToolStripMenuItem huongdan;
        private System.Windows.Forms.ComboBox cblocnv;
        private System.Windows.Forms.Button tatca;
        private System.Windows.Forms.ToolStripMenuItem timkiemToolStripMenuItem;
        private System.Windows.Forms.Button loc;
    }
}