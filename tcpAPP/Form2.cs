using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace tcpAPP
{
    public partial class Form2 : Form
    {
        delegate void PrintToVconsoleTextBoxDelegate(string Msg);

        private bool IsRunning = true;
        private PrintToVconsoleTextBoxDelegate byPrintToVconsoleTextBoxDelegate;
        private Socket serverSocket = null;


        public Form2()
        {
            InitializeComponent();
            byPrintToVconsoleTextBoxDelegate = new PrintToVconsoleTextBoxDelegate(PrintToVconsoleTextBox);
        }

        // 连接 TCP 服务器
        private void VconnectBtn_click(object sender, EventArgs e)
        {
            this.serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // 与服务器建立连接
                serverSocket.Connect(new IPEndPoint(IPAddress.Parse(this.VipTextBox.Text), int.Parse(this.VportTextBox.Text)));
                this.VconncentBtn.Enabled = false;
                Invoke(byPrintToVconsoleTextBoxDelegate, string.Format("连接服务器 {0}{1} 成功", VipTextBox.Text, VportTextBox.Text));
            } 
            catch (Exception ex)
            {
                MessageBox.Show("连接失败" + ex);
                return;
            }

            // 接收
            Thread thr = new Thread(this.ReceiveServerMsg);
            thr.IsBackground = true;
            thr.Start(serverSocket);

        }

        // 发送消息
        private void VsendBtn_click(object sender, EventArgs e)
        {
            string Msg = this.VsendTextBox.Text;
            byte[] byteMsg = Encoding.UTF8.GetBytes(Msg);
            serverSocket.Send(byteMsg);
        }

        // 打印到客户端主消息窗口
        public void PrintToVconsoleTextBox(string Msg)
        {
            this.VconsoleTextBox.AppendText(string.Format("{0}\r\n", Msg));
        }

        // 接收消息
        public void ReceiveServerMsg(object socket)
        {
            var serverSocket = socket as Socket;
            byte[] byteMsg = new byte[1024 * 1024 * 2];
            while (IsRunning)
            {
                int len = -1;
                string serverIP = serverSocket.RemoteEndPoint.ToString();
                try
                {
                    len = serverSocket.Receive(byteMsg, 0, byteMsg.Length, SocketFlags.None);
                }
                catch (SocketException)
                {
                    // 窗口关闭
                    break;
                }
                catch (Exception ex)
                {
                    // 连接异常
                    MessageBox.Show(ex.ToString());
                    Invoke(byPrintToVconsoleTextBoxDelegate, string.Format("连接 {0} 服务器异常", serverIP));
                    break;
                }

                if (len == 0)
                {
                    // 连接断开
                    Invoke(byPrintToVconsoleTextBoxDelegate, string.Format("连接 {0} 服务器断开", serverIP));
                    break;
                }
                else
                {
                    // 正常接收
                    string Msg = Encoding.Default.GetString(byteMsg, 0, len);
                    Invoke(byPrintToVconsoleTextBoxDelegate, string.Format("收到服务器 {0} 的消息：{1}", serverIP, Msg));

                }
            }
        }

        // 关闭客户端
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsRunning = false;
            serverSocket?.Close();
        }
    }
}
