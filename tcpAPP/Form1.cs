using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpAPP
{
    public partial class Form1 : Form
    {
        // 委托
        delegate void AddIpToListBoxDelegate(string IP, string type); // 定义委托

        // 类内属性
        Socket socket = null; // 服务器端Socket对象
        Dictionary<string, Socket> clinetSocketDict = new Dictionary<string, Socket>(); // 已连接的客户端列表
        AddIpToListBoxDelegate byAddIpToListBoxDelegate;

        public Form1()
        {
            InitializeComponent();
            byAddIpToListBoxDelegate = new AddIpToListBoxDelegate(AddIpToListBox); // 实例委托
        }


        // 创建 TCP 服务器
        private void VserBtn_click(object sender, EventArgs e)
        {
            // 创建 socket
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // 绑定端口 IP
                socket.Bind(new IPEndPoint(IPAddress.Parse(this.VipTextBox.Text), int.Parse(this.VportTextBox.Text)));
                this.PrintToVconsoleTextBox(string.Format("tcp服务器：{0}:{1} 创建成功", VipTextBox.Text, VportTextBox.Text));
                this.VserBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建服务器失败" + ex);
                return;
            }
            // 开启监听 (允许最大客户端连接数 | 数量限制)
            socket.Listen(10);
            // 与客户端建立连接 (Accept会阻塞，利用阻塞等待，线程池死循环建立与多个客户端连接)
            // Socket clientSocket = socket.Accept();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptClientConnent), socket); // 委托线程池 | 回调
        }

        // 与客户端建立连接
        public void AcceptClientConnent(object socket)
        {
            // 对 object socket 参数的确认
            var serviceSocket = socket as Socket;
            while (true)
            {
                // 建立连接
                var clinetSocket = serviceSocket.Accept();
                // 取得客户端 'IP:PORT'
                String ip = clinetSocket.RemoteEndPoint.ToString();
                // 保存已连接客户端的字典
                clinetSocketDict[ip] = clinetSocket;
                // 输出 Form
                this.PrintToVconsoleTextBox(string.Format("与客户端 {0} 建立连接", clinetSocket.RemoteEndPoint.ToString()));
                Invoke(byAddIpToListBoxDelegate, clinetSocket.RemoteEndPoint.ToString(), "add");

                /** 接收 (Receive会阻塞，一直等待接收到信息在继续，需要在开线程) **/
                // 定义一个2M大小的变量，用于接收 | 用数组包装成的字节流，=python的 b''类型
                // byte[] byteMsg = new byte[1024 * 1024 * 2]; 
                // 返回接收到信息的长度
                // int len = clinetSocket.Receive(byteMsg, 0, byteMsg.Length, SocketFlags.None);
                // byte to string
                // string Msg = Encoding.Default.GetString(byteMsg, 0, len);
                // ...

                Thread trh = new Thread(this.ReceiveClientMsg);
                trh.IsBackground = true;
                trh.Start(clinetSocket);
            }
        }

        // 接收客户端消息
        public void ReceiveClientMsg(object socket)
        {
            var clinetSocket = socket as Socket;
            byte[] byteMsg = new byte[1024 * 1024 * 2];
            while (true)
            {
                int len = -1;
                string clientIP = clinetSocket.RemoteEndPoint.ToString();
                try
                {
                    len = clinetSocket.Receive(byteMsg, 0, byteMsg.Length, SocketFlags.None);
                } 
                catch (Exception ex)
                {
                    // 异常退出
                    this.PrintToVconsoleTextBox(string.Format("客户端 {0} 跑了", clientIP)); // 消息输出
                    clinetSocketDict.Remove(clientIP); // 移除字典
                    Invoke(byAddIpToListBoxDelegate, clientIP, "remove");
                    break; // 退出该线程Receive循环
                }

                // 客户端正常端口，会一直不停 Recevice 到 ""
                if (len == 0)
                {
                    // 正常退出
                    this.PrintToVconsoleTextBox(string.Format("客户端 {0} 真的退出", clientIP));
                    clinetSocketDict.Remove(clientIP); // 移除字典
                    Invoke(byAddIpToListBoxDelegate, clientIP, "remove");
                    break; // 退出该线程Receive循环
                } 
                else
                {
                    // 正常接收
                    string Msg = Encoding.Default.GetString(byteMsg, 0, len);
                    this.PrintToVconsoleTextBox(string.Format("收到客户端 {0} 的消息：{1}", clientIP, Msg));
                }
            }
        }

        // 打印到服务端主消息窗口 (利用 InvokeRequired 跨线程访问组件)
        public void PrintToVconsoleTextBox(string Msg)
        {
            if (this.VconsoleTextBox.InvokeRequired) // =true表示有一个与创建该控件外的线程想访问它
            {
                this.VconsoleTextBox.Invoke(new Action<string>((s) => {
                    // s 就是参数的 Msg
                    if (this.VconsoleTextBox.Text == "")
                    {
                        this.VconsoleTextBox.Text = s;
                    }
                    else
                    {
                        // 追加消息 | 参考 Form2 AppendText 方法更简洁
                        this.VconsoleTextBox.Text = string.Format("{0}\r\n{1}", this.VconsoleTextBox.Text, s);
                    }
                    
                }), Msg);
            }
            else
            {
                // 同一个线程访问、直接赋值
                if (this.VconsoleTextBox.Text == "")
                {
                    this.VconsoleTextBox.Text = Msg;
                } else
                {
                    // 追加消息
                    this.VconsoleTextBox.Text = string.Format("{0}\r\n{1}", this.VconsoleTextBox.Text, Msg);
                }
            }
        }

        // 新增客户端添加到列表 (利用 delegate Invoke 委托跨线程访问组件 | 全局使用Invoke的方式调用该方法可以跨线程访问)
        public void AddIpToListBox(string IP, string type)
        {
            if (type == "add")
            {
                this.VipListBox.Items.Add(IP);
            }
            else if (type == "remove")
            {
                this.VipListBox.Items.Remove(IP);
            }
        }

        // 发送消息
        private void VsendBtn_click(object sender, EventArgs e)
        {
            string Msg = this.VsendTextBox.Text;
            byte[] byteMsg = Encoding.UTF8.GetBytes(Msg);
            if (this.VipListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要发送的对象");
                return;
            }
            foreach (string item in this.VipListBox.SelectedItems)
            {
                clinetSocketDict[item].Send(byteMsg);
            }
        }

        // 创建 TCP 客户端
        private void VcliBtn_click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
