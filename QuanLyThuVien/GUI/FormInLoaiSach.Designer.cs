namespace GUI
{
    partial class FormInLoaiSach
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
            this.rpt3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt3
            // 
            this.rpt3.ActiveViewIndex = -1;
            this.rpt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt3.Location = new System.Drawing.Point(0, 0);
            this.rpt3.Name = "rpt3";
            this.rpt3.Size = new System.Drawing.Size(1060, 394);
            this.rpt3.TabIndex = 0;
            // 
            // FormInLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 394);
            this.Controls.Add(this.rpt3);
            this.Name = "FormInLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInLoaiSach";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt3;
    }
}