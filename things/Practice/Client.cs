using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // 추가
using System.Net; // 추가
using System.Net.Sockets; // 추가
using System.IO; // 추가

namespace Practice
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        StreamReader streamReader;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter;

        public int Id_count = 0;

        private void iP_text(object sender, EventArgs e) //IP_text
        {

        }

        private void porT_text(object sender, EventArgs e) //Port_text
        {

        }

        private void senD_text(object sender, EventArgs e) //Send_text
        {

        }

        private void Recieve_text(object sender, EventArgs e) //recieveText
        {

        }

        private void connect_Button(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(connect);  // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true;  // Form이 종료되면 thread1도 종료.
            thread1.Start();  // thread1 시작.
        }


        private void send_Button(object sender, EventArgs e)
        {
            string sendData1 = Send_text.Text;  // testBox3 의 내용을 sendData1 변수에 저장
            streamWriter.WriteLine(sendData1);

            Send_text.Text = "";
        }
        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpClient tcpClient1 = new TcpClient();  // TcpClient 객체 생성
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(IP_text.Text), int.Parse(Port_text.Text));  // IP주소와 Port번호를 할당
            tcpClient1.Connect(ipEnd);  // 서버에 연결 요청
            recieveText.Invoke((MethodInvoker)delegate { recieveText.AppendText("서버 연결됨...\n\n"); }); //  데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            

            streamReader = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                string receiveData1 = streamReader.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                writeRichTextbox(receiveData1);  // 데이타를 수신창에 쓰기
            }
        }
        private void writeRichTextbox(string data)  // richTextbox1 에 쓰기 함수
        {
            recieveText.Invoke((MethodInvoker)delegate { recieveText.AppendText("Server : " + data + "\r\n"); }); //  데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            recieveText.Invoke((MethodInvoker)delegate { recieveText.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }
    }
}
