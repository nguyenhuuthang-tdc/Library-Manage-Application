namespace GUI
{
    partial class FormInSach
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
            this.rpt4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt4
            // 
            this.rpt4.ActiveViewIndex = -1;
            this.rpt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt4.Location = new System.Drawing.Point(0, 0);
            this.rpt4.Name = "rpt4";
            this.rpt4.Size = new System.Drawing.Size(1057, 387);
            this.rpt4.TabIndex = 0;
            // 
            // FormInSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 387);
            this.Controls.Add(this.rpt4);
            this.Name = "FormInSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInSach";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt4;
    }
}