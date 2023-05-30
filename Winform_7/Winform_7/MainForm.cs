﻿using System;
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

                    string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
                    resultListBox.Items.Clear();

                    if (files.Length > 0)
                    {
                        resultListBox.Items.AddRange(files);
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
    }
}