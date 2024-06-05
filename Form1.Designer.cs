namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.DataGridView filesDataGridView;
        private System.Windows.Forms.Button processFilesButton;
        private System.Windows.Forms.Button infoButton; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.filesDataGridView = new System.Windows.Forms.DataGridView();
            this.processFilesButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(1043, 283);
            this.selectFolderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(244, 101);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(13, 147);
            this.folderPathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.ReadOnly = true;
            this.folderPathTextBox.Size = new System.Drawing.Size(825, 26);
            this.folderPathTextBox.TabIndex = 2;
            // 
            // foldersListBox
            // 
            this.foldersListBox.ItemHeight = 20;
            this.foldersListBox.Location = new System.Drawing.Point(738, 283);
            this.foldersListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(287, 184);
            this.foldersListBox.TabIndex = 3;
            this.foldersListBox.DoubleClick += new System.EventHandler(this.foldersListBox_DoubleClick);
            // 
            // filesDataGridView
            // 
            this.filesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDataGridView.Location = new System.Drawing.Point(18, 283);
            this.filesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filesDataGridView.Name = "filesDataGridView";
            this.filesDataGridView.RowHeadersWidth = 62;
            this.filesDataGridView.Size = new System.Drawing.Size(712, 260);
            this.filesDataGridView.TabIndex = 4;
            this.filesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filesDataGridView_CellContentClick);
            this.filesDataGridView.DoubleClick += new System.EventHandler(this.filesDataGridView_DoubleClick);
            // 
            // processFilesButton
            // 
            this.processFilesButton.Location = new System.Drawing.Point(1043, 405);
            this.processFilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processFilesButton.Name = "processFilesButton";
            this.processFilesButton.Size = new System.Drawing.Size(155, 101);
            this.processFilesButton.TabIndex = 5;
            this.processFilesButton.Text = "Process Files";
            this.processFilesButton.UseVisualStyleBackColor = true;
            this.processFilesButton.Visible = false;
            this.processFilesButton.Click += new System.EventHandler(this.processFilesButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(52, 24);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(155, 101);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "INFO";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 938);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.processFilesButton);
            this.Controls.Add(this.filesDataGridView);
            this.Controls.Add(this.foldersListBox);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.selectFolderButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LAB5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
