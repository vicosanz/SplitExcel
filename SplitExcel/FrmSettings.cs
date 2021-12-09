using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitExcel
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.smsfolder))
            {
                lnksms.Text = Properties.Settings.Default.smsfolder;
            }
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.mailfolder))
            {
                lnkemail.Text = Properties.Settings.Default.mailfolder;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (lnksms.Text == "Seleccione una carpeta" || lnkemail.Text == "Seleccione una carpeta")
            {
                MessageBox.Show("Debe especificar las carpetas respectivas para continuar");
                return;
            }
            Properties.Settings.Default.smsfolder = lnksms.Text;
            Properties.Settings.Default.mailfolder = lnkemail.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void lnksms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnksms.Text != "Seleccione una carpeta")
            {
                folderBrowserDialog1.SelectedPath = lnksms.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lnksms.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void lnkemail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkemail.Text != "Seleccione una carpeta")
            {
                folderBrowserDialog1.SelectedPath = lnkemail.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lnkemail.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
