using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

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

                    string[] files = Directory.GetFiles(directoryPath, "*.txt", SearchOption.AllDirectories);
                    resultListBox.Items.Clear();

                    if (files.Length > 0)
                    {
                        foreach (string filePath in files)
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            for (int i = 0; i < lines.Length; i++)
                            {
                                string line = lines[i];
                                if (line.Contains(searchWord))
                                {
                                    resultListBox.Items.Add($"{filePath} (Line {i + 1}): {line}");
                                }
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
                string selectedFilePath = resultListBox.SelectedItem.ToString().Split(':')[0];
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
                string selectedFilePath = resultListBox.SelectedItem.ToString().Split(':')[0];

                if (File.Exists(selectedFilePath))
                {
                    Process.Start(selectedFilePath);
                }
            }
        }

        private void SavefileButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.Items.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                    saveFileDialog.FileName = "ListContents.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationFilePath = saveFileDialog.FileName;

                        using (StreamWriter writer = new StreamWriter(destinationFilePath))
                        {
                            foreach (var item in resultListBox.Items)
                            {
                                string line = item.ToString();
                                int lastColonIndex = line.LastIndexOf(':');
                                if (lastColonIndex != -1)
                                {
                                    string value = line.Substring(lastColonIndex + 1).Trim();
                                    writer.WriteLine(value);
                                }
                            }
                        }

                        MessageBox.Show("List contents saved successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No items in the list to save.");
            }
        }
    }
}