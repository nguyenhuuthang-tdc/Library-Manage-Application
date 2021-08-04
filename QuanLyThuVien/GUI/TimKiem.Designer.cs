namespace GUI
{
    partial class Tim_Kiếm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdLoaiSach = new System.Windows.Forms.RadioButton();
            this.rdBanDoc = new System.Windows.Forms.RadioButton();
            this.rdSach = new System.Windows.Forms.RadioButton();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvTimKiem);
            this.groupBox5.Controls.Add(this.btnTimKiem);
            this.groupBox5.Controls.Add(this.txtTimKiem);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(-1, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(760, 423);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm Kiếm Thông Tin";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiem.Location = new System.Drawing.Point(2, 272);
            this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 28;
            this.dgvTimKiem.Size = new System.Drawing.Size(756, 149);
            this.dgvTimKiem.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::GUI.Properties.Resources.red_search_icon__1_;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(138, 136);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 37);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(132, 79);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(205, 29);
            this.txtTimKiem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập Từ Khóa";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdLoaiSach);
            this.groupBox6.Controls.Add(this.rdBanDoc);
            this.groupBox6.Controls.Add(this.rdSach);
            this.groupBox6.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox6.Location = new System.Drawing.Point(341, 24);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(172, 158);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chọn Thông Tin";
            // 
            // rdLoaiSach
            // 
            this.rdLoaiSach.AutoSize = true;
            this.rdLoaiSach.Image = global::GUI.Properties.Resources.k_dm_config_icon;
            this.rdLoaiSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdLoaiSach.Location = new System.Drawing.Point(21, 76);
            this.rdLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdLoaiSach.Name = "rdLoaiSach";
            this.rdLoaiSach.Size = new System.Drawing.Size(136, 32);
            this.rdLoaiSach.TabIndex = 0;
            this.rdLoaiSach.Text = "     Loại Sách";
            this.rdLoaiSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdLoaiSach.UseVisualStyleBackColor = true;
            // 
            // rdBanDoc
            // 
            this.rdBanDoc.AutoSize = true;
            this.rdBanDoc.Image = global::GUI.Properties.Resources.blue_matreshka_icon1;
            this.rdBanDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdBanDoc.Location = new System.Drawing.Point(21, 119);
            this.rdBanDoc.Margin = new System.Windows.Forms.Padding(2);
            this.rdBanDoc.Name = "rdBanDoc";
            this.rdBanDoc.Size = new System.Drawing.Size(125, 32);
            this.rdBanDoc.TabIndex = 2;
            this.rdBanDoc.Text = "     Bạn Đọc";
            this.rdBanDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdBanDoc.UseVisualStyleBackColor = true;
            // 
            // rdSach
            // 
            this.rdSach.AutoSize = true;
            this.rdSach.Checked = true;
            this.rdSach.Image = global::GUI.Properties.Resources.red_matreshka_inside_icon_icon;
            this.rdSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdSach.Location = new System.Drawing.Point(21, 31);
            this.rdSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdSach.Name = "rdSach";
            this.rdSach.Size = new System.Drawing.Size(96, 32);
            this.rdSach.TabIndex = 1;
            this.rdSach.TabStop = true;
            this.rdSach.Text = "     Sách";
            this.rdSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdSach.UseVisualStyleBackColor = true;
            // 
            // Tim_Kiếm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 423);
            this.Controls.Add(this.groupBox5);
            this.Name = "Tim_Kiếm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim_Kiếm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdLoaiSach;
        private System.Windows.Forms.RadioButton rdBanDoc;
        private System.Windows.Forms.RadioButton rdSach;
        public System.Windows.Forms.GroupBox groupBox5;
    }
}