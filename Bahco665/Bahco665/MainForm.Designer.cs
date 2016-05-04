namespace Bahco665
{
    partial class MainForm
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
            this.RunButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.filesTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.downloadFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadFilesDataGrid = new System.Windows.Forms.DataGridView();
            this.Patterns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadFilesFromFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadFilesStorageTargetComboBox = new System.Windows.Forms.ComboBox();
            this.sitesTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sitesDataGridView = new System.Windows.Forms.DataGridView();
            this.Sites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadSitesFromFileButton = new System.Windows.Forms.Button();
            this.loadFilesFromFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadSitesFromFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.downloadFilesLinkDepthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadFilesConstrainToSiteCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTabControl.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadFilesDataGrid)).BeginInit();
            this.sitesTabPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(479, 582);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.filesTabPage);
            this.mainTabControl.Controls.Add(this.sitesTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(26, 23);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(528, 553);
            this.mainTabControl.TabIndex = 1;
            // 
            // filesTabPage
            // 
            this.filesTabPage.Controls.Add(this.flowLayoutPanel1);
            this.filesTabPage.Location = new System.Drawing.Point(4, 22);
            this.filesTabPage.Name = "filesTabPage";
            this.filesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filesTabPage.Size = new System.Drawing.Size(520, 527);
            this.filesTabPage.TabIndex = 0;
            this.filesTabPage.Text = "Files";
            this.filesTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.downloadFilesCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.downloadFilesDataGrid);
            this.flowLayoutPanel1.Controls.Add(this.loadFilesFromFileButton);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.downloadFilesStorageTargetComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.downloadFilesLinkDepthTextBox);
            this.flowLayoutPanel1.Controls.Add(this.downloadFilesConstrainToSiteCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 521);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // downloadFilesCheckBox
            // 
            this.downloadFilesCheckBox.AutoSize = true;
            this.downloadFilesCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadFilesCheckBox.Location = new System.Drawing.Point(3, 3);
            this.downloadFilesCheckBox.Name = "downloadFilesCheckBox";
            this.downloadFilesCheckBox.Size = new System.Drawing.Size(166, 17);
            this.downloadFilesCheckBox.TabIndex = 1;
            this.downloadFilesCheckBox.Text = "Search for and download files";
            this.downloadFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // downloadFilesDataGrid
            // 
            this.downloadFilesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.downloadFilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.downloadFilesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patterns});
            this.downloadFilesDataGrid.Location = new System.Drawing.Point(3, 26);
            this.downloadFilesDataGrid.Name = "downloadFilesDataGrid";
            this.downloadFilesDataGrid.Size = new System.Drawing.Size(495, 302);
            this.downloadFilesDataGrid.TabIndex = 2;
            // 
            // Patterns
            // 
            this.Patterns.HeaderText = "Patterns";
            this.Patterns.Name = "Patterns";
            // 
            // loadFilesFromFileButton
            // 
            this.loadFilesFromFileButton.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.loadFilesFromFileButton, true);
            this.loadFilesFromFileButton.Location = new System.Drawing.Point(3, 334);
            this.loadFilesFromFileButton.Name = "loadFilesFromFileButton";
            this.loadFilesFromFileButton.Size = new System.Drawing.Size(83, 23);
            this.loadFilesFromFileButton.TabIndex = 3;
            this.loadFilesFromFileButton.Text = "Load from File";
            this.loadFilesFromFileButton.UseVisualStyleBackColor = true;
            this.loadFilesFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Storage Target";
            // 
            // downloadFilesStorageTargetComboBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.downloadFilesStorageTargetComboBox, true);
            this.downloadFilesStorageTargetComboBox.FormattingEnabled = true;
            this.downloadFilesStorageTargetComboBox.Location = new System.Drawing.Point(87, 363);
            this.downloadFilesStorageTargetComboBox.Name = "downloadFilesStorageTargetComboBox";
            this.downloadFilesStorageTargetComboBox.Size = new System.Drawing.Size(121, 21);
            this.downloadFilesStorageTargetComboBox.TabIndex = 5;
            // 
            // sitesTabPage
            // 
            this.sitesTabPage.Controls.Add(this.flowLayoutPanel2);
            this.sitesTabPage.Location = new System.Drawing.Point(4, 22);
            this.sitesTabPage.Name = "sitesTabPage";
            this.sitesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sitesTabPage.Size = new System.Drawing.Size(520, 527);
            this.sitesTabPage.TabIndex = 1;
            this.sitesTabPage.Text = "Sites";
            this.sitesTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.sitesDataGridView);
            this.flowLayoutPanel2.Controls.Add(this.loadSitesFromFileButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(514, 521);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // sitesDataGridView
            // 
            this.sitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sitesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sites});
            this.sitesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.sitesDataGridView.Name = "sitesDataGridView";
            this.sitesDataGridView.Size = new System.Drawing.Size(495, 318);
            this.sitesDataGridView.TabIndex = 0;
            // 
            // Sites
            // 
            this.Sites.HeaderText = "Sites";
            this.Sites.Name = "Sites";
            this.Sites.Width = 452;
            // 
            // loadSitesFromFileButton
            // 
            this.loadSitesFromFileButton.AutoSize = true;
            this.loadSitesFromFileButton.Location = new System.Drawing.Point(3, 327);
            this.loadSitesFromFileButton.Name = "loadSitesFromFileButton";
            this.loadSitesFromFileButton.Size = new System.Drawing.Size(83, 23);
            this.loadSitesFromFileButton.TabIndex = 1;
            this.loadSitesFromFileButton.Text = "Load from File";
            this.loadSitesFromFileButton.UseVisualStyleBackColor = true;
            this.loadSitesFromFileButton.Click += new System.EventHandler(this.loadSitesFromFileButton_Click);
            // 
            // loadFilesFromFileOpenFileDialog
            // 
            this.loadFilesFromFileOpenFileDialog.FileName = "openFileDialog1";
            this.loadFilesFromFileOpenFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // loadSitesFromFileOpenFileDialog
            // 
            this.loadSitesFromFileOpenFileDialog.FileName = "openFileDialog1";
            // 
            // downloadFilesLinkDepthTextBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.downloadFilesLinkDepthTextBox, true);
            this.downloadFilesLinkDepthTextBox.Location = new System.Drawing.Point(87, 390);
            this.downloadFilesLinkDepthTextBox.Name = "downloadFilesLinkDepthTextBox";
            this.downloadFilesLinkDepthTextBox.Size = new System.Drawing.Size(100, 20);
            this.downloadFilesLinkDepthTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Link Depth";
            // 
            // downloadFilesConstrainToSiteCheckBox
            // 
            this.downloadFilesConstrainToSiteCheckBox.AutoSize = true;
            this.downloadFilesConstrainToSiteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadFilesConstrainToSiteCheckBox.Location = new System.Drawing.Point(3, 416);
            this.downloadFilesConstrainToSiteCheckBox.Name = "downloadFilesConstrainToSiteCheckBox";
            this.downloadFilesConstrainToSiteCheckBox.Size = new System.Drawing.Size(103, 17);
            this.downloadFilesConstrainToSiteCheckBox.TabIndex = 8;
            this.downloadFilesConstrainToSiteCheckBox.Text = "Constrain to Site";
            this.downloadFilesConstrainToSiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 617);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.RunButton);
            this.Name = "MainForm";
            this.Text = "Bahco 665";
            this.mainTabControl.ResumeLayout(false);
            this.filesTabPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadFilesDataGrid)).EndInit();
            this.sitesTabPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage filesTabPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox downloadFilesCheckBox;
        private System.Windows.Forms.DataGridView downloadFilesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patterns;
        private System.Windows.Forms.TabPage sitesTabPage;
        private System.Windows.Forms.OpenFileDialog loadFilesFromFileOpenFileDialog;
        private System.Windows.Forms.Button loadFilesFromFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView sitesDataGridView;
        private System.Windows.Forms.Button loadSitesFromFileButton;
        private System.Windows.Forms.OpenFileDialog loadSitesFromFileOpenFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox downloadFilesStorageTargetComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox downloadFilesLinkDepthTextBox;
        private System.Windows.Forms.CheckBox downloadFilesConstrainToSiteCheckBox;
    }
}

