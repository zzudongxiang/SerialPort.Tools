namespace SerialPortTools
{
    partial class frmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.flpColNames = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxFilePath);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(510, 26);
            this.panel1.TabIndex = 2;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePath.Location = new System.Drawing.Point(0, 0);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.ReadOnly = true;
            this.tbxFilePath.Size = new System.Drawing.Size(435, 21);
            this.tbxFilePath.TabIndex = 1;
            this.tbxFilePath.TabStop = false;
            this.tbxFilePath.Click += new System.EventHandler(this.tbxFilePath_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(435, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 21);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // flpColNames
            // 
            this.flpColNames.AutoScroll = true;
            this.flpColNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpColNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpColNames.Location = new System.Drawing.Point(5, 31);
            this.flpColNames.Name = "flpColNames";
            this.flpColNames.Size = new System.Drawing.Size(510, 209);
            this.flpColNames.TabIndex = 4;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 245);
            this.Controls.Add(this.flpColNames);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FlowLayoutPanel flpColNames;
    }
}