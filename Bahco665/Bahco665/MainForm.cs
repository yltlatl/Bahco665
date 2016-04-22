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

namespace Bahco665
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var main = new Main();
        }

        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            if (loadFromFileOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            var str = new StreamReader(loadFromFileOpenFileDialog.OpenFile());
            while (!str.EndOfStream)
            {
                filePatternsDataGrid.Rows.Add(str.ReadLine());
            }
        }
    }
}
