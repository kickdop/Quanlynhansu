namespace baitapnhom1
{
    partial class Formtimkiem
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
            this.tatca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grvnhanvien = new System.Windows.Forms.DataGridView();
            this.textfind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // tatca
            // 
            this.tatca.Location = new System.Drawing.Point(268, 122);
            this.tatca.Name = "tatca";
            this.tatca.Size = new System.Drawing.Size(109, 23);
            this.tatca.TabIndex = 9;
            this.tatca.Text = "Lọc";
            this.tatca.UseVisualStyleBackColor = true;
            this.tatca.Click += new System.EventHandler(this.tatca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm nhân viên";
            // 
            // grvnhanvien
            // 
            this.grvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvnhanvien.Location = new System.Drawing.Point(12, 166);
            this.grvnhanvien.Name = "grvnhanvien";
            this.grvnhanvien.Size = new System.Drawing.Size(972, 278);
            this.grvnhanvien.TabIndex = 6;
            // 
            // textfind
            // 
            this.textfind.Location = new System.Drawing.Point(12, 122);
            this.textfind.Name = "textfind";
            this.textfind.Size = new System.Drawing.Size(227, 20);
            this.textfind.TabIndex = 10;
            // 
            // Formtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 459);
            this.Controls.Add(this.textfind);
            this.Controls.Add(this.tatca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvnhanvien);
            this.Name = "Formtimkiem";
            this.Text = "Formtimkiem";
            ((System.ComponentModel.ISupportInitialize)(this.grvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tatca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvnhanvien;
        private System.Windows.Forms.TextBox textfind;
    }
}