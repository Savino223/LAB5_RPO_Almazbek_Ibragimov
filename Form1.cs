using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.7);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.7);
            this.CenterToScreen();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maker: Almazbek Ibragimov", "INFO");
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folderPathTextBox.Text = dialog.SelectedPath;
                    LoadFolderData(dialog.SelectedPath);
                }
            }
        }

        private void LoadFolderData(string folderPath)
        {
            try
            {
                foldersListBox.Items.Clear();
                filesDataGridView.Columns.Clear();
                filesDataGridView.Rows.Clear();

                var directories = Directory.GetDirectories(folderPath);
                foreach (var dir in directories)
                {
                    foldersListBox.Items.Add(Path.GetFileName(dir));
                }

                var files = Directory.GetFiles(folderPath);
                filesDataGridView.Columns.Add("Name", "Name");
                filesDataGridView.Columns.Add("Last Modif", "Last modif");
                filesDataGridView.Columns.Add("Size", "Size");

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    filesDataGridView.Rows.Add(fileInfo.Name, fileInfo.LastWriteTime, fileInfo.Length);
                }

                processFilesButton.Visible = files.Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void foldersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (foldersListBox.SelectedItem != null)
            {
                string selectedFolder = Path.Combine(folderPathTextBox.Text, foldersListBox.SelectedItem.ToString());
                FolderDetailsForm detailsForm = new FolderDetailsForm(selectedFolder);
                detailsForm.Show();
            }
        }

        private void filesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (filesDataGridView.CurrentRow != null)
            {
                string selectedFile = Path.Combine(folderPathTextBox.Text, filesDataGridView.CurrentRow.Cells[0].Value.ToString());
                var result = MessageBox.Show($"Duplicate {selectedFile}?", "Duplicate File", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string newFileName = Path.Combine(folderPathTextBox.Text, Path.GetFileNameWithoutExtension(selectedFile) + "_copy" + Path.GetExtension(selectedFile));
                        File.Copy(selectedFile, newFileName);
                        LoadFolderData(folderPathTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private async void processFilesButton_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(folderPathTextBox.Text);
            var random = new Random();
            filesDataGridView.Columns.Add("Delay", "Delay");

            var tasks = filesDataGridView.Rows
                .Cast<DataGridViewRow>()
                .Select(async row =>
                {
                    int delay = random.Next(1, files.Length+1);
                    await Task.Delay(delay * 1000);
                    row.Cells["Delay"].Value = delay;
                });

            await Task.WhenAll(tasks);
        }

        private void filesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
