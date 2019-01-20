using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace robotclient
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        //定义回调
        private delegate void SetTextCallBack(string strValue);
        //声明
        private SetTextCallBack setCallBack;

        //定义接收服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);
        //声明
        private ReceiveMsgCallBack receiveCallBack;

        //创建连接的Socket
        Socket socketSend;
        //创建接收客户端发送消息的线程
        Thread threadReceive;

        bool bIsSocketClosed;

        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(this.txt_IP.Text.Trim());
                socketSend.Connect(ip, Convert.ToInt32(this.txt_Port.Text.Trim()));
                //实例化回调
                setCallBack = new SetTextCallBack(SetValue);
                receiveCallBack = new ReceiveMsgCallBack(SetValue);
                this.txt_Log.Invoke(setCallBack, "连接成功");

                //开启一个新的线程不停的接收服务器发送消息的线程
                threadReceive = new Thread(new ThreadStart(Receive));
                //设置为后台线程
                threadReceive.IsBackground = true;
                threadReceive.Start();
                bIsSocketClosed = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务端出错:" + ex.ToString());
            }
        }

        /// <summary>
        /// 接口服务器发送的消息
        /// </summary>
        private void Receive()
        {
            if (bIsSocketClosed)
                return;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[2048];
                    //实际接收到的字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    else
                    {
                        string str = Encoding.Default.GetString(buffer, 0, r);
                        this.txt_Log.Invoke(receiveCallBack, "接收远程服务器:" + str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("接收服务端发送的消息出错:" + ex.ToString());
            }
        }

        private void SetValue(string strValue)
        {
            this.txt_Log.AppendText(strValue + "\n");
        }

        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = this.txt_Msg.Text.Trim();
                byte[] buffer = new byte[2048];
                buffer = Encoding.Default.GetBytes(strMsg);
                int receive = socketSend.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }

        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Washgun_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = "<Rob><Notify>1</Notify><Argc>0</Argc></Rob>";
                byte[] buffer = new byte[2048];
                buffer = Encoding.Default.GetBytes(strMsg);
                int receive = socketSend.Send(buffer);
                this.txt_Msg.AppendText(strMsg + "\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }


        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            this.txt_Log.Clear();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btn_CloseConnect_Click(object sender, EventArgs e)
        {
            //关闭socket
            if (socketSend != null)
            {

                //终止线程
                try
                {
                    if (threadReceive.IsAlive)
                    {
                        bIsSocketClosed = true;
                        socketSend.Shutdown(SocketShutdown.Both);
                        threadReceive.Abort();

                        socketSend.Close();
                    }
                }
                catch(ThreadAbortException ex)
                {
                    LogExecute.WriteExceptionLog("ClientThread",ex);
                }
            }
        }
    }
}
