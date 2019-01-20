namespace robotclient
{
    partial class FrmClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.txt_Msg = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Washgun = new System.Windows.Forms.Button();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(38, 30);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(113, 21);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "192.168.1.3";
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(200, 28);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(57, 21);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "6000";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.Location = new System.Drawing.Point(354, 24);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(80, 24);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.Location = new System.Drawing.Point(461, 23);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 25);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "断开连接";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_CloseConnect_Click);
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(17, 64);
            this.txt_Log.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(596, 130);
            this.txt_Log.TabIndex = 4;
            this.txt_Log.Text = "";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(17, 246);
            this.txt_Msg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(596, 141);
            this.txt_Msg.TabIndex = 5;
            this.txt_Msg.Text = "";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(486, 396);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 22);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "发送消息";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Washgun
            // 
            this.btn_Washgun.Location = new System.Drawing.Point(18, 398);
            this.btn_Washgun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Washgun.Name = "btn_Washgun";
            this.btn_Washgun.Size = new System.Drawing.Size(56, 25);
            this.btn_Washgun.TabIndex = 7;
            this.btn_Washgun.Text = "清枪";
            this.btn_Washgun.UseVisualStyleBackColor = true;
            this.btn_Washgun.Click += new System.EventHandler(this.btn_Washgun_Click);
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(508, 213);
            this.btn_ClearLog.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(86, 25);
            this.btn_ClearLog.TabIndex = 8;
            this.btn_ClearLog.Text = "清除接收数据";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 438);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.btn_Washgun);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClient";
            this.Text = "测试机";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RichTextBox txt_Log;
        private System.Windows.Forms.RichTextBox txt_Msg;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Washgun;
        private System.Windows.Forms.Button btn_ClearLog;
    }
}

