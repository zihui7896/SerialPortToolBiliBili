namespace SerialPortToolBiliBili
{
    partial class Form1
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
            richTextBox2 = new RichTextBox();
            groupBox1 = new GroupBox();
            openPortButton = new Button();
            DTRCheckBox = new CheckBox();
            RTSCheckBox = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            portLabel = new Label();
            stopbitComboBox = new ComboBox();
            datebitecomboBox = new ComboBox();
            checkComboBox = new ComboBox();
            baudComboBox = new ComboBox();
            portComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            reciveFileTextBox = new TextBox();
            selectionPathButton = new Button();
            saveDataButton = new Button();
            stopButton = new Button();
            clearButton = new Button();
            hexCheckBox = new CheckBox();
            autoClearChekBox = new CheckBox();
            groupBox3 = new GroupBox();
            autoTimeTextBox = new TextBox();
            label6 = new Label();
            sendFileTextBox = new TextBox();
            openFileButton = new Button();
            sendFileButton = new Button();
            clearSendButton = new Button();
            sendButton = new Button();
            sendHexCheckBox = new CheckBox();
            autoSendCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            receiveRichTextBox = new RichTextBox();
            groupBox5 = new GroupBox();
            sendRichTextBox = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            stateToolStripStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            sendCountToolStripStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            receiveCountToolStripStatusLabel = new ToolStripStatusLabel();
            clearCountToolStripStatusLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(-118, 62);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(115, 195);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(openPortButton);
            groupBox1.Controls.Add(DTRCheckBox);
            groupBox1.Controls.Add(RTSCheckBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(portLabel);
            groupBox1.Controls.Add(stopbitComboBox);
            groupBox1.Controls.Add(datebitecomboBox);
            groupBox1.Controls.Add(checkComboBox);
            groupBox1.Controls.Add(baudComboBox);
            groupBox1.Controls.Add(portComboBox);
            groupBox1.Location = new Point(13, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 396);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口配置";
            // 
            // openPortButton
            // 
            openPortButton.Location = new Point(168, 314);
            openPortButton.Name = "openPortButton";
            openPortButton.Size = new Size(205, 76);
            openPortButton.TabIndex = 12;
            openPortButton.Text = "打开串口";
            openPortButton.UseVisualStyleBackColor = true;
            openPortButton.Click += button1_Click_1;
            // 
            // DTRCheckBox
            // 
            DTRCheckBox.AutoSize = true;
            DTRCheckBox.Location = new Point(21, 344);
            DTRCheckBox.Name = "DTRCheckBox";
            DTRCheckBox.Size = new Size(94, 35);
            DTRCheckBox.TabIndex = 11;
            DTRCheckBox.Text = "DTR";
            DTRCheckBox.UseVisualStyleBackColor = true;
            DTRCheckBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // RTSCheckBox
            // 
            RTSCheckBox.AutoSize = true;
            RTSCheckBox.Location = new Point(21, 303);
            RTSCheckBox.Name = "RTSCheckBox";
            RTSCheckBox.Size = new Size(90, 35);
            RTSCheckBox.TabIndex = 10;
            RTSCheckBox.Text = "RTS";
            RTSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 258);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 9;
            label5.Text = "停止位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 204);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 8;
            label4.Text = "数据位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 150);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 7;
            label3.Text = "校验位";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 6;
            label2.Text = "波特率";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(21, 42);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(86, 31);
            portLabel.TabIndex = 5;
            portLabel.Text = "端口号";
            // 
            // stopbitComboBox
            // 
            stopbitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stopbitComboBox.FormattingEnabled = true;
            stopbitComboBox.Location = new Point(168, 258);
            stopbitComboBox.Name = "stopbitComboBox";
            stopbitComboBox.Size = new Size(205, 39);
            stopbitComboBox.TabIndex = 4;
            // 
            // datebitecomboBox
            // 
            datebitecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            datebitecomboBox.FormattingEnabled = true;
            datebitecomboBox.Location = new Point(168, 202);
            datebitecomboBox.Name = "datebitecomboBox";
            datebitecomboBox.Size = new Size(205, 39);
            datebitecomboBox.TabIndex = 3;
            // 
            // checkComboBox
            // 
            checkComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            checkComboBox.FormattingEnabled = true;
            checkComboBox.Location = new Point(168, 146);
            checkComboBox.Name = "checkComboBox";
            checkComboBox.Size = new Size(205, 39);
            checkComboBox.TabIndex = 2;
            // 
            // baudComboBox
            // 
            baudComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            baudComboBox.FormattingEnabled = true;
            baudComboBox.Location = new Point(168, 90);
            baudComboBox.Name = "baudComboBox";
            baudComboBox.Size = new Size(205, 39);
            baudComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            portComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            portComboBox.FormattingEnabled = true;
            portComboBox.Location = new Point(168, 34);
            portComboBox.Name = "portComboBox";
            portComboBox.Size = new Size(205, 39);
            portComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(reciveFileTextBox);
            groupBox2.Controls.Add(selectionPathButton);
            groupBox2.Controls.Add(saveDataButton);
            groupBox2.Controls.Add(stopButton);
            groupBox2.Controls.Add(clearButton);
            groupBox2.Controls.Add(hexCheckBox);
            groupBox2.Controls.Add(autoClearChekBox);
            groupBox2.Location = new Point(12, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 281);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "接收配置";
            // 
            // reciveFileTextBox
            // 
            reciveFileTextBox.Location = new Point(6, 232);
            reciveFileTextBox.Name = "reciveFileTextBox";
            reciveFileTextBox.Size = new Size(363, 38);
            reciveFileTextBox.TabIndex = 19;
            // 
            // selectionPathButton
            // 
            selectionPathButton.Location = new Point(13, 179);
            selectionPathButton.Name = "selectionPathButton";
            selectionPathButton.Size = new Size(161, 46);
            selectionPathButton.TabIndex = 18;
            selectionPathButton.Text = "选择路径";
            selectionPathButton.UseVisualStyleBackColor = true;
            // 
            // saveDataButton
            // 
            saveDataButton.Location = new Point(180, 179);
            saveDataButton.Name = "saveDataButton";
            saveDataButton.Size = new Size(189, 46);
            saveDataButton.TabIndex = 17;
            saveDataButton.Text = "保存数据";
            saveDataButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(180, 115);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(189, 46);
            stopButton.TabIndex = 16;
            stopButton.Text = "暂停";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(180, 53);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(189, 46);
            clearButton.TabIndex = 15;
            clearButton.Text = "手动清空";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button2_Click;
            // 
            // hexCheckBox
            // 
            hexCheckBox.AutoSize = true;
            hexCheckBox.Location = new Point(22, 122);
            hexCheckBox.Name = "hexCheckBox";
            hexCheckBox.Size = new Size(142, 35);
            hexCheckBox.TabIndex = 14;
            hexCheckBox.Text = "十六进制";
            hexCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearChekBox
            // 
            autoClearChekBox.AutoSize = true;
            autoClearChekBox.Location = new Point(22, 60);
            autoClearChekBox.Name = "autoClearChekBox";
            autoClearChekBox.Size = new Size(142, 35);
            autoClearChekBox.TabIndex = 13;
            autoClearChekBox.Text = "自动清空";
            autoClearChekBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(autoTimeTextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(sendFileTextBox);
            groupBox3.Controls.Add(openFileButton);
            groupBox3.Controls.Add(sendFileButton);
            groupBox3.Controls.Add(clearSendButton);
            groupBox3.Controls.Add(sendButton);
            groupBox3.Controls.Add(sendHexCheckBox);
            groupBox3.Controls.Add(autoSendCheckBox);
            groupBox3.Location = new Point(13, 714);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 296);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "发送配置";
            // 
            // autoTimeTextBox
            // 
            autoTimeTextBox.Location = new Point(270, 253);
            autoTimeTextBox.Name = "autoTimeTextBox";
            autoTimeTextBox.Size = new Size(103, 38);
            autoTimeTextBox.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 257);
            label6.Name = "label6";
            label6.Size = new Size(213, 31);
            label6.TabIndex = 27;
            label6.Text = "自动发送周期(ms):";
            // 
            // sendFileTextBox
            // 
            sendFileTextBox.Location = new Point(13, 199);
            sendFileTextBox.Name = "sendFileTextBox";
            sendFileTextBox.Size = new Size(363, 38);
            sendFileTextBox.TabIndex = 26;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(13, 146);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(161, 46);
            openFileButton.TabIndex = 25;
            openFileButton.Text = "打开文件";
            openFileButton.UseVisualStyleBackColor = true;
            // 
            // sendFileButton
            // 
            sendFileButton.Location = new Point(187, 146);
            sendFileButton.Name = "sendFileButton";
            sendFileButton.Size = new Size(189, 46);
            sendFileButton.TabIndex = 24;
            sendFileButton.Text = "发送文件";
            sendFileButton.UseVisualStyleBackColor = true;
            // 
            // clearSendButton
            // 
            clearSendButton.Location = new Point(187, 82);
            clearSendButton.Name = "clearSendButton";
            clearSendButton.Size = new Size(189, 46);
            clearSendButton.TabIndex = 23;
            clearSendButton.Text = "清空发送";
            clearSendButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(184, 24);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(189, 46);
            sendButton.TabIndex = 22;
            sendButton.Text = "手动发送";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // sendHexCheckBox
            // 
            sendHexCheckBox.AutoSize = true;
            sendHexCheckBox.Location = new Point(20, 89);
            sendHexCheckBox.Name = "sendHexCheckBox";
            sendHexCheckBox.Size = new Size(142, 35);
            sendHexCheckBox.TabIndex = 21;
            sendHexCheckBox.Text = "十六进制";
            sendHexCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoSendCheckBox
            // 
            autoSendCheckBox.AutoSize = true;
            autoSendCheckBox.Location = new Point(20, 31);
            autoSendCheckBox.Name = "autoSendCheckBox";
            autoSendCheckBox.Size = new Size(142, 35);
            autoSendCheckBox.TabIndex = 20;
            autoSendCheckBox.Text = "自动发送";
            autoSendCheckBox.UseVisualStyleBackColor = true;
            autoSendCheckBox.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox2);
            groupBox4.Controls.Add(receiveRichTextBox);
            groupBox4.Location = new Point(436, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(627, 470);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "接收区";
            // 
            // receiveRichTextBox
            // 
            receiveRichTextBox.Dock = DockStyle.Fill;
            receiveRichTextBox.Location = new Point(3, 34);
            receiveRichTextBox.Name = "receiveRichTextBox";
            receiveRichTextBox.Size = new Size(621, 433);
            receiveRichTextBox.TabIndex = 0;
            receiveRichTextBox.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(sendRichTextBox);
            groupBox5.Location = new Point(437, 520);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(626, 493);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "发送区";
            // 
            // sendRichTextBox
            // 
            sendRichTextBox.Dock = DockStyle.Fill;
            sendRichTextBox.Location = new Point(3, 34);
            sendRichTextBox.Name = "sendRichTextBox";
            sendRichTextBox.Size = new Size(620, 456);
            sendRichTextBox.TabIndex = 0;
            sendRichTextBox.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, stateToolStripStatusLabel, toolStripStatusLabel3, sendCountToolStripStatusLabel, toolStripStatusLabel5, receiveCountToolStripStatusLabel, clearCountToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 1023);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1086, 41);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(86, 31);
            toolStripStatusLabel1.Text = "状态：";
            // 
            // stateToolStripStatusLabel
            // 
            stateToolStripStatusLabel.AutoSize = false;
            stateToolStripStatusLabel.Name = "stateToolStripStatusLabel";
            stateToolStripStatusLabel.Size = new Size(250, 31);
            stateToolStripStatusLabel.Text = "初始化正常";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(134, 31);
            toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendCountToolStripStatusLabel
            // 
            sendCountToolStripStatusLabel.AutoSize = false;
            sendCountToolStripStatusLabel.Name = "sendCountToolStripStatusLabel";
            sendCountToolStripStatusLabel.Size = new Size(70, 31);
            sendCountToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(134, 31);
            toolStripStatusLabel5.Text = "接收计数：";
            // 
            // receiveCountToolStripStatusLabel
            // 
            receiveCountToolStripStatusLabel.AutoSize = false;
            receiveCountToolStripStatusLabel.Name = "receiveCountToolStripStatusLabel";
            receiveCountToolStripStatusLabel.Size = new Size(70, 31);
            receiveCountToolStripStatusLabel.Text = "0";
            // 
            // clearCountToolStripStatusLabel
            // 
            clearCountToolStripStatusLabel.Name = "clearCountToolStripStatusLabel";
            clearCountToolStripStatusLabel.Size = new Size(110, 31);
            clearCountToolStripStatusLabel.Text = "清空计数";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 1064);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "串口助手";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox datebitecomboBox;
        private ComboBox checkComboBox;
        private ComboBox baudComboBox;
        private ComboBox stopbitComboBox;
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
    }
}
