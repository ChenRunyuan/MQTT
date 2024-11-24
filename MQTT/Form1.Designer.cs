namespace MQTT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.IP_Addr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Client_ID = new System.Windows.Forms.TextBox();
            this.topic = new System.Windows.Forms.TextBox();
            this.pub_topic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pub_message = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.pub = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Close_Sys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // IP_Addr
            // 
            this.IP_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IP_Addr.Location = new System.Drawing.Point(104, 27);
            this.IP_Addr.Name = "IP_Addr";
            this.IP_Addr.Size = new System.Drawing.Size(100, 21);
            this.IP_Addr.TabIndex = 2;
            this.IP_Addr.Text = "103.112.96.42";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(104, 71);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 21);
            this.Port.TabIndex = 4;
            this.Port.Text = "1883";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户名";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(104, 113);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(100, 21);
            this.User_name.TabIndex = 6;
            this.User_name.Text = "cry";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(104, 160);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 21);
            this.Password.TabIndex = 7;
            this.Password.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "主题";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(37, 247);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 14;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(129, 246);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 24);
            this.stop.TabIndex = 15;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // Client_ID
            // 
            this.Client_ID.Location = new System.Drawing.Point(104, 201);
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.Size = new System.Drawing.Size(100, 21);
            this.Client_ID.TabIndex = 17;
            this.Client_ID.Text = "C#";
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(350, 20);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(124, 21);
            this.topic.TabIndex = 18;
            this.topic.Text = "home/led1";
            // 
            // pub_topic
            // 
            this.pub_topic.Location = new System.Drawing.Point(350, 65);
            this.pub_topic.Name = "pub_topic";
            this.pub_topic.Size = new System.Drawing.Size(124, 21);
            this.pub_topic.TabIndex = 21;
            this.pub_topic.Text = "home/led1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "主题";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "内容";
            // 
            // pub_message
            // 
            this.pub_message.Location = new System.Drawing.Point(350, 107);
            this.pub_message.Name = "pub_message";
            this.pub_message.Size = new System.Drawing.Size(124, 21);
            this.pub_message.TabIndex = 23;
            this.pub_message.Text = "ON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "消息";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(226, 246);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 24);
            this.Clear.TabIndex = 27;
            this.Clear.Text = "清空";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(501, 17);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 28;
            this.sub.Text = "订阅";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // pub
            // 
            this.pub.Location = new System.Drawing.Point(501, 65);
            this.pub.Name = "pub";
            this.pub.Size = new System.Drawing.Size(72, 63);
            this.pub.TabIndex = 29;
            this.pub.Text = "发布";
            this.pub.UseVisualStyleBackColor = true;
            this.pub.Click += new System.EventHandler(this.pub_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(307, 173);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(269, 97);
            this.Message.TabIndex = 31;
            this.Message.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Close_Sys
            // 
            this.Close_Sys.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close_Sys.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close_Sys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Sys.Image = ((System.Drawing.Image)(resources.GetObject("Close_Sys.Image")));
            this.Close_Sys.Location = new System.Drawing.Point(361, 184);
            this.Close_Sys.Name = "Close_Sys";
            this.Close_Sys.Size = new System.Drawing.Size(19, 20);
            this.Close_Sys.TabIndex = 32;
            this.Close_Sys.UseVisualStyleBackColor = true;
            this.Close_Sys.Click += new System.EventHandler(this.Close_Sys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close_Sys;
            this.ClientSize = new System.Drawing.Size(593, 298);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Close_Sys);
            this.Controls.Add(this.pub);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pub_message);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pub_topic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.Client_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP_Addr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MQTT客户端测试 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_Addr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Client_ID;
        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.TextBox pub_topic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pub_message;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button pub;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Close_Sys;
    }
}

