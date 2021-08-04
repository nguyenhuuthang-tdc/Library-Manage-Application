namespace GUI
{
    partial class FormInBanDoc
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
            this.rpt2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt2
            // 
            this.rpt2.ActiveViewIndex = -1;
            this.rpt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt2.Location = new System.Drawing.Point(0, 0);
            this.rpt2.Name = "rpt2";
            this.rpt2.Size = new System.Drawing.Size(1041, 398);
            this.rpt2.TabIndex = 0;
            // 
            // FormInBanDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 398);
            this.Controls.Add(this.rpt2);
            this.Name = "FormInBanDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInBanDoc";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt2;
    }
}