using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoSearchDirectory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string directoryPath = folderBrowserDialog.SelectedPath;
                    string searchWord = Seach_Word.Text;

                    string[] files = Directory.GetFiles(directoryPath, "*.cpp", SearchOption.AllDirectories);
                    resultListBox.Items.Clear();

                    if (files.Length > 0)
                    {
                        foreach (string filePath in files)
                        {
                            string fileContents = File.ReadAllText(filePath);
                            // Perform your desired content validation logic here
                            if (fileContents.Contains(searchWord))
                            {
                                resultListBox.Items.Add(filePath);
                            }
                        }
                    }
                    else
                    {
                        resultListBox.Items.Add("No files found.");
                    }
                }

                
            }
        }

        private void DIR_BUTTON_Click(object sender, EventArgs e) //DIR_BUTTON
        {
            if (resultListBox.SelectedItem != null)
            {
                string selectedFilePath = resultListBox.SelectedItem.ToString();
                string selectedFolderPath = Path.GetDirectoryName(selectedFilePath);

                if (Directory.Exists(selectedFolderPath))
                {
                    Process.Start("explorer.exe", selectedFolderPath);
                }
            }
        }

        private void Seach_Word_TextChanged(object sender, EventArgs e) //Seach_Word
        {

        }

        private void FileOpenButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.SelectedItem != null)
            {
                string selectedFilePath = resultListBox.SelectedItem.ToString();

                if (File.Exists(selectedFilePath))
                {
                    Process.Start(selectedFilePath);
                }
            }
        }

        private void SavefileButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.SelectedItem != null)
            {
                string selectedFilePath = resultListBox.SelectedItem.ToString();

                if (File.Exists(selectedFilePath))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text files (*.cpp)|*.cpp";
                        saveFileDialog.FileName = Path.GetFileName(selectedFilePath);

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string destinationFilePath = saveFileDialog.FileName;
                            File.WriteAllText(destinationFilePath, File.ReadAllText(selectedFilePath));
                            MessageBox.Show("File saved successfully!");
                        }
                    }
                }
            }
        }
    }
}