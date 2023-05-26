using System;
using System.IO;
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
            string directoryPath = directoryTextBox.Text.Trim();

            if (Directory.Exists(directoryPath))
            {
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
            else
            {
                MessageBox.Show("Invalid directory path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}