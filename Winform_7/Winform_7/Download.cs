using MainForm;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Winform_7
{
    public partial class Download : Form
    {
        private WebClient webClient;

        public Download()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string fileUrl = "URL_OF_YOUR_FILE";
            string destinationPath = @"C:\Users\hyeoneon.oh\Desktop";

            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            

            try
            {
                // 파일 다운로드 시작
                webClient.DownloadFileAsync(new Uri(fileUrl), destinationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"다운로드 오류: {ex.Message}");
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // 다운로드 진행 상태 표시
            progressBar.Value = e.ProgressPercentage;
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // 다운로드 완료 시 호출되는 이벤트 핸들러
            if (e.Error != null)
            {
                MessageBox.Show($"다운로드 오류: {e.Error.Message}");
            }
            else
            {
                MessageBox.Show("파일 다운로드 완료");
            }

            // WebClient 인스턴스 정리
            webClient.DownloadProgressChanged -= WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted -= WebClient_DownloadFileCompleted;
            webClient.Dispose();
            webClient = null;
        }
        
    }
}