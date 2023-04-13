using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System;
using System.IO;
using SeleniumExtras.WaitHelpers;

namespace Practice
{
    public partial class Crawling : Form
    {
        private IWebDriver driver;

        public Crawling()
        {
            InitializeComponent();
        }

        public string url;

        private void connect_button(object sender, EventArgs e) //Connect_button
        {
            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();

            driver.Navigate().GoToUrl("https://www.google.com/"); // 구글 페이지로 이동합니다.
            IWebElement searchBox = driver.FindElement(By.Name("q")); // 검색 입력 상자를 찾습니다.
            searchBox.SendKeys(Url_text.Text); // 입력한 텍스트를 검색 입력 상자에 입력합니다.
            searchBox.Submit(); // 검색 입력 상자를 제출합니다.

            IWebElement contents_element = driver.FindElement(By.CssSelector("#hdtb-msb > div:nth-child(1) > div > div:nth-child(2) > a"));
            contents_element.Click();

            IWebElement imgElement = driver.FindElement(By.CssSelector("#islrg > div.islrc > div:nth-child(2) > a.wXeWr.islib.nfEiy > div.bRMDJf.islir > img"));
            imgElement.Click();



            //IWebElement Imageurl = driver.FindElement(By.CssSelector("#Sva75c > div.DyeYj > div > div.dFMRD > div.pxAole > div.tvh9oe.BIB1wf > c-wiz > div > div.n4hgof > div.MAtCL.b0vFpe > a"));
            //var Imageurl = "https://t1.daumcdn.net/cfile/tistory/265F9B365742641841?original";
            //var Image = driver.FindElements(By.CssSelector("#Sva75c > div.DyeYj > div > div.dFMRD > div.pxAole > div.tvh9oe.BIB1wf > c-wiz > div > div.n4hgof > div.MAtCL.b0vFpe > a > img.r48jcc.pT0Scc.iPVvYb")).ToString();

            IWebElement imgurl = driver.FindElement(By.ClassName("r48jcc pT0Scc iPVvYb"));
            //var Image = driver.FindElements(By.ClassName("r48jcc pT0Scc iPVvYb")).ToString();
            var Image = imgurl.GetAttribute("src");





            //var imageUrl = Image.GetAttribute("src");
            string fileName = Url_text.Text + ".jpg";

            MessageBox.Show(Image);

            WebClient webClient = new WebClient();
            //webClient.DownloadFileAsync(new Uri(Image), fileName);

            driver.Quit();
        }

        private void url_text(object sender, EventArgs e) //Url_text
        {
            
        }

        private void Search_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
