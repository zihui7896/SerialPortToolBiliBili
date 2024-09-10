using System.Drawing;
using System.Windows.Forms;

namespace SerialPortToolBiliBili
{
    partial class SerialPortToolBiliBiliForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.DTRCheckBox = new System.Windows.Forms.CheckBox();
            this.RTSCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.checkComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reciveFileTextBox = new System.Windows.Forms.TextBox();
            this.selectionPathButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearChekBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autoTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.clearSendButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendHexCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.receiveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(-101, 48);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(99, 152);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openPortButton);
            this.groupBox1.Controls.Add(this.DTRCheckBox);
            this.groupBox1.Controls.Add(this.RTSCheckBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.stopBitsComboBox);
            this.groupBox1.Controls.Add(this.dataBitsComboBox);
            this.groupBox1.Controls.Add(this.checkComboBox);
            this.groupBox1.Controls.Add(this.baudRateComboBox);
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(333, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(144, 243);
            this.openPortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(176, 59);
            this.openPortButton.TabIndex = 12;
            this.openPortButton.Text = "打开串口";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // DTRCheckBox
            // 
            this.DTRCheckBox.AutoSize = true;
            this.DTRCheckBox.Location = new System.Drawing.Point(18, 266);
            this.DTRCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTRCheckBox.Name = "DTRCheckBox";
            this.DTRCheckBox.Size = new System.Drawing.Size(78, 28);
            this.DTRCheckBox.TabIndex = 11;
            this.DTRCheckBox.Text = "DTR";
            this.DTRCheckBox.UseVisualStyleBackColor = true;
            // 
            // RTSCheckBox
            // 
            this.RTSCheckBox.AutoSize = true;
            this.RTSCheckBox.Location = new System.Drawing.Point(18, 235);
            this.RTSCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTSCheckBox.Name = "RTSCheckBox";
            this.RTSCheckBox.Size = new System.Drawing.Size(78, 28);
            this.RTSCheckBox.TabIndex = 10;
            this.RTSCheckBox.Text = "RTS";
            this.RTSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(18, 33);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(82, 24);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "端口号";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(144, 200);
            this.stopBitsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(176, 32);
            this.stopBitsComboBox.TabIndex = 4;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(144, 156);
            this.dataBitsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(176, 32);
            this.dataBitsComboBox.TabIndex = 3;
            // 
            // checkComboBox
            // 
            this.checkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkComboBox.FormattingEnabled = true;
            this.checkComboBox.Location = new System.Drawing.Point(144, 113);
            this.checkComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkComboBox.Name = "checkComboBox";
            this.checkComboBox.Size = new System.Drawing.Size(176, 32);
            this.checkComboBox.TabIndex = 2;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(144, 70);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(176, 32);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(144, 26);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(176, 32);
            this.portComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reciveFileTextBox);
            this.groupBox2.Controls.Add(this.selectionPathButton);
            this.groupBox2.Controls.Add(this.saveDataButton);
            this.groupBox2.Controls.Add(this.stopButton);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.hexCheckBox);
            this.groupBox2.Controls.Add(this.autoClearChekBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(333, 244);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // reciveFileTextBox
            // 
            this.reciveFileTextBox.Location = new System.Drawing.Point(10, 194);
            this.reciveFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciveFileTextBox.Name = "reciveFileTextBox";
            this.reciveFileTextBox.Size = new System.Drawing.Size(312, 35);
            this.reciveFileTextBox.TabIndex = 19;
            this.reciveFileTextBox.TextChanged += new System.EventHandler(this.reciveFileTextBox_TextChanged);
            // 
            // selectionPathButton
            // 
            this.selectionPathButton.Location = new System.Drawing.Point(11, 146);
            this.selectionPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionPathButton.Name = "selectionPathButton";
            this.selectionPathButton.Size = new System.Drawing.Size(138, 36);
            this.selectionPathButton.TabIndex = 18;
            this.selectionPathButton.Text = "选择路径";
            this.selectionPathButton.UseVisualStyleBackColor = true;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(174, 143);
            this.saveDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(153, 36);
            this.saveDataButton.TabIndex = 17;
            this.saveDataButton.Text = "保存数据";
            this.saveDataButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(174, 86);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(153, 36);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "暂停";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 26);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 42);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "手动清空";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Location = new System.Drawing.Point(19, 94);
            this.hexCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(138, 28);
            this.hexCheckBox.TabIndex = 14;
            this.hexCheckBox.Text = "十六进制";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearChekBox
            // 
            this.autoClearChekBox.AutoSize = true;
            this.autoClearChekBox.Location = new System.Drawing.Point(19, 46);
            this.autoClearChekBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoClearChekBox.Name = "autoClearChekBox";
            this.autoClearChekBox.Size = new System.Drawing.Size(138, 28);
            this.autoClearChekBox.TabIndex = 13;
            this.autoClearChekBox.Text = "自动清空";
            this.autoClearChekBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autoTimeTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendFileTextBox);
            this.groupBox3.Controls.Add(this.openFileButton);
            this.groupBox3.Controls.Add(this.sendFileButton);
            this.groupBox3.Controls.Add(this.clearSendButton);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.sendHexCheckBox);
            this.groupBox3.Controls.Add(this.autoSendCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(20, 593);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(333, 286);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autoTimeTextBox
            // 
            this.autoTimeTextBox.Location = new System.Drawing.Point(235, 238);
            this.autoTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoTimeTextBox.Name = "autoTimeTextBox";
            this.autoTimeTextBox.Size = new System.Drawing.Size(89, 35);
            this.autoTimeTextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "自动发送周期(ms):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sendFileTextBox
            // 
            this.sendFileTextBox.Location = new System.Drawing.Point(9, 189);
            this.sendFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendFileTextBox.Name = "sendFileTextBox";
            this.sendFileTextBox.Size = new System.Drawing.Size(312, 35);
            this.sendFileTextBox.TabIndex = 26;
            this.sendFileTextBox.TextChanged += new System.EventHandler(this.sendFileTextBox_TextChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(9, 131);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(138, 36);
            this.openFileButton.TabIndex = 25;
            this.openFileButton.Text = "打开文件";
            this.openFileButton.UseVisualStyleBackColor = true;
            // 
            // sendFileButton
            // 
            this.sendFileButton.Location = new System.Drawing.Point(165, 131);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(162, 36);
            this.sendFileButton.TabIndex = 24;
            this.sendFileButton.Text = "发送文件";
            this.sendFileButton.UseVisualStyleBackColor = true;
            // 
            // clearSendButton
            // 
            this.clearSendButton.Location = new System.Drawing.Point(165, 76);
            this.clearSendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSendButton.Name = "clearSendButton";
            this.clearSendButton.Size = new System.Drawing.Size(162, 36);
            this.clearSendButton.TabIndex = 23;
            this.clearSendButton.Text = "清空发送";
            this.clearSendButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(165, 27);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(162, 36);
            this.sendButton.TabIndex = 22;
            this.sendButton.Text = "手动发送";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // sendHexCheckBox
            // 
            this.sendHexCheckBox.AutoSize = true;
            this.sendHexCheckBox.Location = new System.Drawing.Point(13, 81);
            this.sendHexCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendHexCheckBox.Name = "sendHexCheckBox";
            this.sendHexCheckBox.Size = new System.Drawing.Size(138, 28);
            this.sendHexCheckBox.TabIndex = 21;
            this.sendHexCheckBox.Text = "十六进制";
            this.sendHexCheckBox.UseVisualStyleBackColor = true;
            this.sendHexCheckBox.CheckedChanged += new System.EventHandler(this.sendHexCheckBox_CheckedChanged);
            // 
            // autoSendCheckBox
            // 
            this.autoSendCheckBox.AutoSize = true;
            this.autoSendCheckBox.Location = new System.Drawing.Point(6, 27);
            this.autoSendCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSendCheckBox.Name = "autoSendCheckBox";
            this.autoSendCheckBox.Size = new System.Drawing.Size(138, 28);
            this.autoSendCheckBox.TabIndex = 20;
            this.autoSendCheckBox.Text = "自动发送";
            this.autoSendCheckBox.UseVisualStyleBackColor = true;
            this.autoSendCheckBox.CheckedChanged += new System.EventHandler(this.autoSendCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.receiveRichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(380, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(537, 399);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // receiveRichTextBox
            // 
            this.receiveRichTextBox.Location = new System.Drawing.Point(6, 51);
            this.receiveRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiveRichTextBox.Name = "receiveRichTextBox";
            this.receiveRichTextBox.Size = new System.Drawing.Size(525, 327);
            this.receiveRichTextBox.TabIndex = 0;
            this.receiveRichTextBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sendRichTextBox);
            this.groupBox5.Location = new System.Drawing.Point(380, 470);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(537, 409);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.Location = new System.Drawing.Point(6, 52);
            this.sendRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(524, 367);
            this.sendRichTextBox.TabIndex = 0;
            this.sendRichTextBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stateToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.sendCountToolStripStatusLabel,
            this.toolStripStatusLabel5,
            this.receiveCountToolStripStatusLabel,
            this.clearCountToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 923);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(955, 41);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 31);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // stateToolStripStatusLabel
            // 
            this.stateToolStripStatusLabel.AutoSize = false;
            this.stateToolStripStatusLabel.Name = "stateToolStripStatusLabel";
            this.stateToolStripStatusLabel.Size = new System.Drawing.Size(250, 31);
            this.stateToolStripStatusLabel.Text = "初始化正常";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendCountToolStripStatusLabel
            // 
            this.sendCountToolStripStatusLabel.AutoSize = false;
            this.sendCountToolStripStatusLabel.Name = "sendCountToolStripStatusLabel";
            this.sendCountToolStripStatusLabel.Size = new System.Drawing.Size(70, 31);
            this.sendCountToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // receiveCountToolStripStatusLabel
            // 
            this.receiveCountToolStripStatusLabel.AutoSize = false;
            this.receiveCountToolStripStatusLabel.Name = "receiveCountToolStripStatusLabel";
            this.receiveCountToolStripStatusLabel.Size = new System.Drawing.Size(70, 31);
            this.receiveCountToolStripStatusLabel.Text = "0";
            // 
            // clearCountToolStripStatusLabel
            // 
            this.clearCountToolStripStatusLabel.Name = "clearCountToolStripStatusLabel";
            this.clearCountToolStripStatusLabel.Size = new System.Drawing.Size(110, 31);
            this.clearCountToolStripStatusLabel.Text = "清空计数";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // SerialPortToolBiliBiliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 964);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SerialPortToolBiliBiliForm";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.SerialPortToolBiliBiliForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richTextBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RichTextBox receiveRichTextBox;
        private GroupBox groupBox5;
        private RichTextBox sendRichTextBox;
        private ComboBox portComboBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox dataBitsComboBox;
        private ComboBox checkComboBox;
        private ComboBox baudRateComboBox;
        private ComboBox stopBitsComboBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label portLabel;
        private Button openPortButton;
        private CheckBox DTRCheckBox;
        private CheckBox RTSCheckBox;
        private Button stopButton;
        private Button clearButton;
        private CheckBox hexCheckBox;
        private CheckBox autoClearChekBox;
        private TextBox reciveFileTextBox;
        private Button selectionPathButton;
        private Button saveDataButton;
        private TextBox sendFileTextBox;
        private Button openFileButton;
        private Button sendFileButton;
        private Button clearSendButton;
        private Button sendButton;
        private CheckBox sendHexCheckBox;
        private CheckBox autoSendCheckBox;
        private TextBox autoTimeTextBox;
        private Label label6;
        private ToolStripStatusLabel stateToolStripStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel sendCountToolStripStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel receiveCountToolStripStatusLabel;
        private ToolStripStatusLabel clearCountToolStripStatusLabel;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
