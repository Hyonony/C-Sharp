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
    public partial class Server : Form
    {
        private StreamWriter streamWriter1;
        private StreamReader streamReader1;

        public Server()
        {
            InitializeComponent();
        }

        private void iP_text(object sender, EventArgs e) //IP_text
        {

        }

        private void porT_text(object sender, EventArgs e) //Port_text
        {

        }

        private void senD_text(object sender, EventArgs e) //Send_text
        {

        }

        private void Recieve_text(object sender, EventArgs e) //recieve_Text
        {

        }

        private void connect_Button(object sender, EventArgs e) // Connect_button
        {
            Thread thread1 = new Thread(connect); // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.
        }

        private void send_Button(object sender, EventArgs e) //Send_button
        {
            string sendData1 = Send_text.Text;  // testBox3 의 내용을 sendData1 변수에 저장
            streamWriter1.WriteLine(sendData1);  // 스트림라이터를 통해 데이타를 전송

            Send_text.Text = "";
        }
        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse(IP_text.Text), int.Parse(Port_text.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpListener.Start();  // 서버 시작
            recieve_Text.Invoke((MethodInvoker)delegate { recieve_Text.AppendText("서버 준비...클라이언트 기다리는 중...\n\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            TcpClient tcpClient1 = tcpListener.AcceptTcpClient(); // 클라이언트 접속 확인
            recieve_Text.Invoke((MethodInvoker)delegate { recieve_Text.AppendText("클라이언트 연결됨...\n\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.


            streamReader1 = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                string receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                writeRichTextbox(receiveData1); // 데이타를 수신창에 쓰기                  
            }
        }
        private void writeRichTextbox(string str)  // richTextbox1 에 쓰기 함수
        {
            recieve_Text.Invoke((MethodInvoker)delegate { recieve_Text.AppendText("Client : " + str + "\r\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            recieve_Text.Invoke((MethodInvoker)delegate { recieve_Text.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }

    }
}
