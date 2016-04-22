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
            this.filesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filePatternsDataGrid = new System.Windows.Forms.DataGridView();
            this.Patterns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadFromFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.filesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePatternsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(478, 440);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // filesTabControl
            // 
            this.filesTabControl.Controls.Add(this.tabPage1);
            this.filesTabControl.Controls.Add(this.tabPage2);
            this.filesTabControl.Location = new System.Drawing.Point(26, 23);
            this.filesTabControl.Name = "filesTabControl";
            this.filesTabControl.SelectedIndex = 0;
            this.filesTabControl.Size = new System.Drawing.Size(515, 400);
            this.filesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Search for and download files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.filePatternsDataGrid);
            this.flowLayoutPanel1.Controls.Add(this.loadFromFileButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 368);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // filePatternsDataGrid
            // 
            this.filePatternsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filePatternsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filePatternsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patterns});
            this.filePatternsDataGrid.Location = new System.Drawing.Point(3, 26);
            this.filePatternsDataGrid.Name = "filePatternsDataGrid";
            this.filePatternsDataGrid.Size = new System.Drawing.Size(495, 302);
            this.filePatternsDataGrid.TabIndex = 2;
            // 
            // Patterns
            // 
            this.Patterns.HeaderText = "Patterns";
            this.Patterns.Name = "Patterns";
            // 
            // loadFromFileOpenFileDialog
            // 
            this.loadFromFileOpenFileDialog.FileName = "openFileDialog1";
            this.loadFromFileOpenFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.AutoSize = true;
            this.loadFromFileButton.Location = new System.Drawing.Point(3, 334);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(83, 23);
            this.loadFromFileButton.TabIndex = 3;
            this.loadFromFileButton.Text = "Load from File";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 475);
            this.Controls.Add(this.filesTabControl);
            this.Controls.Add(this.RunButton);
            this.Name = "MainForm";
            this.Text = "Bahco 665";
            this.filesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePatternsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TabControl filesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView filePatternsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patterns;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog loadFromFileOpenFileDialog;
        private System.Windows.Forms.Button loadFromFileButton;
    }
}

