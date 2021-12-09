using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitExcel
{
    public partial class FrmSplit : Form
    {
        List<string> _files;
        public FrmSplit(string[] args)
        {
            InitializeComponent();
            _files = args.ToList();
        }

        private void FrmSplit_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.smsfolder) || string.IsNullOrWhiteSpace(Properties.Settings.Default.mailfolder))
            {
                MessageBox.Show("Debe especificar las carpetas respectivas para continuar");
                return;
            }

            foreach (var file in _files)
            {
                Split(file);
            }
            this.Close();
        }

        private void Split(string file)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = false,
                ScreenUpdating = false
            };
            var fileinfo = new FileInfo(file);
            string rootDestino;
            var wb = excel.Workbooks.Open(file);
            if (fileinfo.Name.Contains("SMS", StringComparison.InvariantCultureIgnoreCase))
            {
                rootDestino = Properties.Settings.Default.smsfolder;
            }
            else if (fileinfo.Name.Contains("EMAIL", StringComparison.InvariantCultureIgnoreCase))
            {
                rootDestino = Properties.Settings.Default.mailfolder;
            }
            else
            {
                return;
            }
            foreach (dynamic sheet in wb.Sheets)
            {
                var sheetName = sheet.Name;
                if (sheetName != "TODOS")
                {
                    sheet.Copy();
                    string shordate = DateTime.Now.ToString("yyMMdd");
                    string Filename = System.IO.Path.Combine(rootDestino, $"{sheetName}-{shordate}");
                    excel.ActiveWorkbook.SaveAs2(Filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                    excel.ActiveWorkbook.Close();
                }
            }
            wb.Close();
        }
    }
}
