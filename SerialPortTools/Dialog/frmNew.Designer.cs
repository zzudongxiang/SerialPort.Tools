namespace SerialPortTools
{
    partial class frmNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew));
            this.tbxNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxNew
            // 
            this.tbxNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNew.Font = new System.Drawing.Font("宋体", 12F);
            this.tbxNew.Location = new System.Drawing.Point(5, 5);
            this.tbxNew.Multiline = true;
            this.tbxNew.Name = "tbxNew";
            this.tbxNew.ReadOnly = true;
            this.tbxNew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxNew.Size = new System.Drawing.Size(274, 251);
            this.tbxNew.TabIndex = 1;
            this.tbxNew.TabStop = false;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNew";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s New";
            this.Load += new System.EventHandler(this.frmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNew;
    }
}