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
    //Handy way to encapsulate these parameters for each target type
    public struct TargetParameters
    {
        #region Constructors

        public TargetParameters(StorageTarget storageTarget, int linkDepth, bool constrainToSite) : this()
        {
            StorageTarget = storageTarget;
            LinkDepth = linkDepth;
            ConstrainToSite = constrainToSite;
        }

        #endregion

        #region Properties
        public StorageTarget StorageTarget { get; set; }

        public int LinkDepth { get; set; }

        public bool ConstrainToSite { get; set; }

        #endregion
    }


    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Populate the storage target comboboxes
            foreach (var value in Enum.GetValues(typeof (StorageTarget)))
            {
                downloadFilesStorageTargetComboBox.Items.Add(value);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //Get the root list of sites we want to scrape
            var sitesList = sitesDataGridView.Rows.OfType<DataGridViewRow>().Select(currentRow => currentRow.Cells[0].Value.ToString()).ToList();

            //Get the file types we want to download (if applicable)
            var downloadFilesList = new List<string>();
            if (downloadFilesCheckBox.Checked)
            {
                downloadFilesList.AddRange(downloadFilesDataGrid.Rows.OfType<DataGridViewRow>()
                        .Select(currentRow => currentRow.Cells[0].Value.ToString())
                        .ToList());
            }

            //Set the download parameters
            var downloadFilesTargetParameters = new TargetParameters();
            if (downloadFilesCheckBox.Checked)
            {
                if (downloadFilesStorageTargetComboBox.SelectedItem == null)
                {
                    MessageBox.Show(
                        @"No file download storage target selected.  Please select a storage target and try again.");
                    return;
                }

                if (string.IsNullOrEmpty(downloadFilesLinkDepthTextBox.Text))
                {
                    MessageBox.Show(
                        @"A link depth for file downloads is required.  Please enter a link depth and try again.");
                    return;
                }
                int downloadFilesLinkDepth;
                if (!int.TryParse(downloadFilesLinkDepthTextBox.Text, out downloadFilesLinkDepth))
                {
                    MessageBox.Show(@"Please enter a valid integer for the download files link depth and try again.");
                    return;
                }

                downloadFilesTargetParameters.StorageTarget =
                    (StorageTarget) downloadFilesStorageTargetComboBox.SelectedIndex;

                downloadFilesTargetParameters.LinkDepth = downloadFilesLinkDepth;

                downloadFilesTargetParameters.ConstrainToSite = downloadFilesConstrainToSiteCheckBox.Checked;
            }

            var main = new Main(sitesList, downloadFilesList, downloadFilesTargetParameters);
        }

        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            if (loadFilesFromFileOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            var str = new StreamReader(loadFilesFromFileOpenFileDialog.OpenFile());
            while (!str.EndOfStream)
            {
                downloadFilesDataGrid.Rows.Add(str.ReadLine());
            }
            str.Dispose();
        }

        private void loadSitesFromFileButton_Click(object sender, EventArgs e)
        {
            if (loadSitesFromFileOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            var str = new StreamReader(loadSitesFromFileOpenFileDialog.OpenFile());
            while (!str.EndOfStream)
            {
                sitesDataGridView.Rows.Add(str.ReadLine());
            }
            str.Dispose();
        }
    }
}
