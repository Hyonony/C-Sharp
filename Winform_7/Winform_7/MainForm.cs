using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using Winform_7;
using System.Net;
using System.ComponentModel;

namespace MainForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
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
                            string[] lines = await ReadAllLinesAsync(filePath);
                            for (int i = 0; i < lines.Length; i++)
                            {
                                string line = lines[i];
                                if (line.Contains(searchWord))
                                {
                                    resultListBox.Items.Add($"{filePath}:{line}");
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
        

        private async Task<string[]> ReadAllLinesAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string contents = await reader.ReadToEndAsync();
                string[] lines = contents.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                return lines;
            }
        }

        private void DIR_BUTTON_Click(object sender, EventArgs e)
        {
            if (resultListBox.SelectedItem != null)
            {
                string selectedLine = resultListBox.SelectedItem.ToString();
                int lastColonIndex = selectedLine.LastIndexOf(':');
                if (lastColonIndex != -1)
                {
                    string selectedValue = selectedLine.Substring(0, lastColonIndex);
                    string selectedFolderPath = Path.GetDirectoryName(selectedValue);

                    if (Directory.Exists(selectedFolderPath))
                    {
                        Process.Start("explorer.exe", selectedFolderPath);
                    }
                }
            }
        }

        private void searchWordTextBox_TextChanged(object sender, EventArgs e)
        {
            // This event handler is empty, no changes needed here.
        }

        private void FileOpenButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.SelectedItem != null)
            {
                string selectedLine = resultListBox.SelectedItem.ToString();
                int lastColonIndex = selectedLine.LastIndexOf(':');
                if (lastColonIndex != -1)
                {
                    string selectedValue = selectedLine.Substring(0, lastColonIndex);
                    if (File.Exists(selectedValue))
                    {
                        Process.Start(selectedValue);
                    }
                }
            }
        }
        private async void SavefileButton_Click(object sender, EventArgs e)
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
                                int lastBackslashIndex = line.LastIndexOf('\\');
                                int lastIndex = Math.Max(lastColonIndex, lastBackslashIndex);
                                if (lastIndex != -1 && lastIndex < line.Length - 1)
                                {
                                    string value = line.Substring(lastIndex + 1).TrimStart();
                                    if (!resultListBox.Items.Contains(value))
                                    {
                                        await writer.WriteLineAsync(value);
                                    }
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
        private void downloadButton_Click(object sender, EventArgs e)
        {
            Download download = new Download();
            download.Show();
        }
        
    }
}