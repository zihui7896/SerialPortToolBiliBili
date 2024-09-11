using Microsoft.Win32;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortToolBiliBili
{
    public partial class SerialPortToolBiliBiliForm : System.Windows.Forms.Form
    {
        private bool isOpenPort = false;
        public SerialPortToolBiliBiliForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = portComboBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudRateComboBox.Text);
                    serialPort1.DataBits = Convert.ToInt32(dataBitsComboBox.Text);

                    switch (checkComboBox.Text)
                    {
                        case "None":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    switch(stopBitsComboBox.SelectedIndex)
                    {
                        // 1 1.5 2
                        case 0:
                           serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }
                    serialPort1.Open();
                    isOpenPort = true;
                    openPortButton.Text = "关闭串口";
                } else
                {
                    serialPort1.Close();
                    isOpenPort = false;
                    openPortButton.Text = "打开串口";
                }
                //if (portComboBox.Text != "")
                //{
                //    serialPort1.PortName = portComboBox.Text;
                //    serialPort1.Open();
                //}
                //if (serialPort1.IsOpen) { 
                //    MessageBox.Show(serialPort1.PortName.ToString() +"串口已打开");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }
        }

        private void serialLoad()
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM");
            //string[] sSubKeys = keyCom.GetSubKeyNames();
            string[] sSubkeys = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(sSubkeys);
            this.portComboBox.SelectedIndex = 0;
            //portComboBox.Items.Clear();
            //foreach (var sValue in sSubKeys)
            //{
            //    string portName = (string)keyCom.GetValue(sValue);
            //    portComboBox.Items.Add(portName);
            //}

        }

        private void SerialPortToolBiliBiliForm_Load(object sender, EventArgs e)
        {
            //串口初始化  从本地注册表中获取 
            serialLoad();
            //for (int i = 1; i< 5; i ++)  
            //{
            //    this.portComboBox.Items.Add("COM" + i.ToString());
            //}
            //this.portComboBox.Text = "COM1";

            // 波特率初始化
            for (int i = 1; i < 4; i ++)
            {
                this.baudRateComboBox.Items.Add(i * 4800);
            }
            this.baudRateComboBox.SelectedIndex = 0;

            //校验位初始化
            string[] arrcheckComboBox =
            {
                "None", "Odd", "Even"
            };
            this.checkComboBox.Items.AddRange(arrcheckComboBox);
            this.checkComboBox.Text = "None";


            //数据位初始化
            for (int i = 5; i < 9; i ++)
            {
                this.dataBitsComboBox.Items.Add(i.ToString());
            }
            this.dataBitsComboBox.Text = "5";
            //this.receiveRichTextBox.Text = "接收框";
            //this.sendRichTextBox.Text = "发送框";

            // 停止位初始化
            string[] arrstopComboBox =
            {
                "1", "1.5", "2"
            };
            this.stopBitsComboBox.Items.AddRange(arrstopComboBox);
            this.stopBitsComboBox.Text = "1";
            



        }

        private void reciveFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sendHexCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void autoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // 如果发送数据不为空，且串口打开，则发送数据
            if (this.sendRichTextBox.Text != "" && serialPort1.IsOpen)
            {
                serialPort1.Write(sendRichTextBox.Text);
                MessageBox.Show("发送成功" + sendRichTextBox.Text);
            } else
            {
                MessageBox.Show("请检查串口是否打开或发送框是否为空");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataReceive =  serialPort1.ReadExisting();
            receiveRichTextBox.AppendText(dataReceive);

        }
    }
}
