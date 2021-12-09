
namespace SplitExcel
{
    partial class FrmSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnksms = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkemail = new System.Windows.Forms.LinkLabel();
            this.btnguardar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnksms);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMS folder";
            // 
            // lnksms
            // 
            this.lnksms.AutoSize = true;
            this.lnksms.Location = new System.Drawing.Point(6, 19);
            this.lnksms.Name = "lnksms";
            this.lnksms.Size = new System.Drawing.Size(128, 15);
            this.lnksms.TabIndex = 0;
            this.lnksms.TabStop = true;
            this.lnksms.Text = "Seleccione una carpeta";
            this.lnksms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksms_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkemail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email folder";
            // 
            // lnkemail
            // 
            this.lnkemail.AutoSize = true;
            this.lnkemail.Location = new System.Drawing.Point(6, 19);
            this.lnkemail.Name = "lnkemail";
            this.lnkemail.Size = new System.Drawing.Size(128, 15);
            this.lnkemail.TabIndex = 0;
            this.lnkemail.TabStop = true;
            this.lnkemail.Text = "Seleccione una carpeta";
            this.lnkemail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkemail_LinkClicked);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(11, 106);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(128, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar y cerrar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 141);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSettings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Split Excel";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnksms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkemail;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

