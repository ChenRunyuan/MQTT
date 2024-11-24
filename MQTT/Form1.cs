using System;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

namespace MQTT
{
    public partial class Form1 : Form
    {
        private IMqttClient _mqttClient;

        public Form1()
        {
            InitializeComponent();            // 初始化窗体组件

            // 注册 Load 事件
            this.Load += new System.EventHandler(this.Form1_Load);

            var factory = new MqttFactory();  // 创建 MQTT 工厂实例
            _mqttClient = factory.CreateMqttClient(); // 创建 MQTT 客户端实例

            _mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync;
            Console.ReadLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 设置窗体边框样式为固定
            this.MaximizeBox = false; // 禁用最大化按钮
            // this.MinimizeBox = false; // 如果希望禁用最小化按钮，也可以设置为false

            // 计算屏幕中央位置
            int centerX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int centerY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            // 将窗体移动到中央
            this.StartPosition = FormStartPosition.Manual; // 设置窗体位置为手动
            this.Location = new System.Drawing.Point(centerX, centerY); // 设置窗体位置
        }


        // 定义异步消息接收处理程序
        private async Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            string message = arg.ApplicationMessage.ConvertPayloadToString(); // 获取消息内容
            string topic = arg.ApplicationMessage.Topic; // 获取主题
            DateTime currentTime = DateTime.Now;
            // 格式化时间字符串
            string Now_Time = currentTime.ToString("HH:mm:ss");
            // 在 UI 线程上更新界面
            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // 更新主题显示框内容
                    Message.AppendText($"\r\n{Now_Time}:主题: {topic} | 消息: {message}");
                    Message.AppendText(Environment.NewLine); // 添加换行符

                    if (Message.Text.Length - 1 == Message.Text.LastIndexOf('\n')) // 如果最后一个字符是换行符，则删除最后一个字符
                    {
                        Message.Text = Message.Text.Substring(0, Message.Text.Length - 1); // 删除最后一个字符
                    }
                    // 滚动到消息显示框的底部
                    Message.SelectionStart = Message.Text.Length;
                    Message.ScrollToCaret(); // 滚动到底部

                });
            });
        }


        private async void connect_Click(object sender, EventArgs e)
        {
            string IP = IP_Addr.Text;         // 获取 IP 地址
            int port = int.Parse(Port.Text);  // 获取端口号
            string ID = Client_ID.Text;       // 获取客户端 ID
            string username = User_name.Text; // 获取用户名
            string password = Password.Text;   // 获取密码

            var options = new MqttClientOptionsBuilder()
                            .WithClientId(ID)
                            .WithTcpServer(IP, port) // 确保使用输入的端口
                            .WithCredentials(username, password)
                            .Build();

            try
            {
                await _mqttClient.ConnectAsync(options);
                // MessageBox.Show("连接成功！");
                Message.AppendText("连接成功！\r\n"); // 在消息显示框中添加连接成功信息
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"连接失败：{ex.Message}");
                Message.AppendText($"连接失败：{ex.Message}\r\n"); // 在消息显示框中添加连接失败信息
            }
        }


        private void stop_Click(object sender, EventArgs e) // 断开连接
        {
            try
            {
                _mqttClient.DisconnectAsync().Wait();
                // MessageBox.Show("断开成功！");
                Message.AppendText("断开成功！\r\n"); // 在消息显示框中添加断开成功信息
            }
            catch (Exception ex)
            {
                MessageBox.Show($"断开失败：{ex.Message}\r\n");
            }
        }

        private void Clear_Click(object sender, EventArgs e) // 清空输入框内容
        {
            // IP_Addr.Clear();
            // Port.Clear();
            // Client_ID.Clear();
            // User_name.Clear();
            // Password.Clear();
            // topic.Clear(); // 清空主题输入框
            Message.Clear(); // 清空消息显示框
        }

        private async void sub_Click(object sender, EventArgs e) // 订阅主题
        {
            string topicName = topic.Text; // 获取要订阅的主题

            if (!string.IsNullOrEmpty(topicName))
            {
                try
                {
                    // 订阅主题
                    await _mqttClient.SubscribeAsync(topicName);  // 这里应该是 SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(topicName).Build()); 修正如下：

                    // MessageBox.Show($"已成功订阅主题: {topicName}");
                    Message.AppendText($"\r\n已成功订阅主题: {topicName}");
                    Message.AppendText(Environment.NewLine); // 添加换行符

                    if (Message.Text.Length - 1 == Message.Text.LastIndexOf('\n')) // 如果最后一个字符是换行符，则删除最后一个字符
                    {
                        Message.Text = Message.Text.Substring(0, Message.Text.Length - 1); // 删除最后一个字符
                    }
                    // 滚动到消息显示框的底部
                    Message.SelectionStart = Message.Text.Length;
                    Message.ScrollToCaret(); // 滚动到底部
                }
                catch (Exception ex)
                {
                    // MessageBox.Show($"订阅失败：{ex.Message}");
                    Message.AppendText($"订阅失败：{ex.Message}\r\n");
                }
            }
            else
            {
                MessageBox.Show("主题不能为空！");
            }
        }

        private async void pub_Click(object sender, EventArgs e) // 发布消息
        {
            string publishTopic = pub_topic.Text; // 获取要发布的主题
            string publishMessage = pub_message.Text; // 获取要发布的消息（假设你有一个名为 messageTextBox 的 TextBox 控件）

            if (!string.IsNullOrEmpty(publishTopic) && !string.IsNullOrEmpty(publishMessage))
            {
                try
                {

                    var message = new MqttApplicationMessageBuilder()
                                    .WithTopic(publishTopic)
                                    .WithPayload(publishMessage)
                                    .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce)
                                     .Build();  // 构建消息对象，设置主题、消息内容和 QoS 级别（这里设置为最多一次）

                    // 发布消息
                    await _mqttClient.PublishAsync(message);
                    // MessageBox.Show($"成功发布消息到主题: {publishTopic}");
                    Message.AppendText($"\r\n成功发布消息到主题: {publishTopic}"); // 这里应该是 Message.AppendText($"成功发布消息到主题: {publishTopic}"); 修正如下：
                    Message.AppendText(Environment.NewLine); // 添加换行符

                    if (Message.Text.Length - 1 == Message.Text.LastIndexOf('\n')) // 如果最后一个字符是换行符，则删除最后一个字符
                    {
                        Message.Text = Message.Text.Substring(0, Message.Text.Length - 1); // 删除最后一个字符
                    }
                    // 滚动到消息显示框的底部
                    Message.SelectionStart = Message.Text.Length;
                    Message.ScrollToCaret(); // 滚动到底部

                }
                catch (Exception ex)
                {
                    // MessageBox.Show($"发布消息失败：{ex.Message}");
                    Message.AppendText($"发布消息失败：{ex.Message}\r\n"); // 这里应该是 Message.AppendText($"发布消息失败：{ex.Message}"); 修正如下：
                }
            }
            else
            {
                MessageBox.Show("主题或消息不能为空！");
            }
        }


        private void Close_Sys_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.025)
            {
                this.Opacity -= 0.025;
            }
            else 
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
