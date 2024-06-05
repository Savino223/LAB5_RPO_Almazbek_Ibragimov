using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FolderDetailsForm : Form
    {
        public FolderDetailsForm(string folderPath)
        {
            InitializeComponent();
            LoadFolderDetails(folderPath);
        }

        private void LoadFolderDetails(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            folderNameLabel.Text = $"Folder Name: {directoryInfo.Name}";
            lastModifiedLabel.Text = $"Last Modif: {directoryInfo.LastWriteTime}";
            this.CenterToScreen();
        }

        private void InitializeComponent()
        {
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.lastModifiedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(38, 27);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(100, 20);
            this.folderNameLabel.TabIndex = 0;
            this.folderNameLabel.Text = "FolderName:";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.Location = new System.Drawing.Point(51, 111);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(87, 20);
            this.lastModifiedLabel.TabIndex = 1;
            this.lastModifiedLabel.Text = "Last Modif:";
            // 
            // FolderDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(379, 182);
            this.Controls.Add(this.lastModifiedLabel);
            this.Controls.Add(this.folderNameLabel);
            this.Name = "FolderDetailsForm";
            this.Text = "Folder INFO";
            this.Load += new System.EventHandler(this.FolderDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.Label lastModifiedLabel;

        private void FolderDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
