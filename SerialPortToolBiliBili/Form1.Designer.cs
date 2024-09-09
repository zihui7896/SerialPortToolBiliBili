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
            button1 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox5 = new GroupBox();
            richTextBox3 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBox2 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label6 = new Label();
            textBox3 = new TextBox();
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(13, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 396);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口配置";
            // 
            // button1
            // 
            button1.Location = new Point(168, 314);
            button1.Name = "button1";
            button1.Size = new Size(205, 76);
            button1.TabIndex = 12;
            button1.Text = "打开串口";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 344);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 35);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "DTR";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 35);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "RTS";
            checkBox1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 5;
            label1.Text = "端口号";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(168, 258);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(205, 39);
            comboBox5.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(168, 202);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(205, 39);
            comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(168, 146);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 39);
            comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(168, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 39);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 39);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(12, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 281);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "接收配置";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 38);
            textBox1.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(13, 179);
            button5.Name = "button5";
            button5.Size = new Size(161, 46);
            button5.TabIndex = 18;
            button5.Text = "选择路径";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(180, 179);
            button4.Name = "button4";
            button4.Size = new Size(189, 46);
            button4.TabIndex = 17;
            button4.Text = "保存数据";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(180, 115);
            button3.Name = "button3";
            button3.Size = new Size(189, 46);
            button3.TabIndex = 16;
            button3.Text = "暂停";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(180, 53);
            button2.Name = "button2";
            button2.Size = new Size(189, 46);
            button2.TabIndex = 15;
            button2.Text = "手动清空";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(22, 122);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(142, 35);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "十六进制";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(22, 60);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(142, 35);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "自动清空";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Location = new Point(13, 714);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 296);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "发送配置";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox2);
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Location = new Point(436, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(627, 470);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "接收区";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(621, 433);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(richTextBox3);
            groupBox5.Location = new Point(437, 520);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(626, 493);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "发送区";
            // 
            // richTextBox3
            // 
            richTextBox3.Dock = DockStyle.Fill;
            richTextBox3.Location = new Point(3, 34);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(620, 456);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 1023);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1086, 41);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(257, 31);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 38);
            textBox2.TabIndex = 26;
            // 
            // button6
            // 
            button6.Location = new Point(13, 146);
            button6.Name = "button6";
            button6.Size = new Size(161, 46);
            button6.TabIndex = 25;
            button6.Text = "打开文件";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(187, 146);
            button7.Name = "button7";
            button7.Size = new Size(189, 46);
            button7.TabIndex = 24;
            button7.Text = "发送文件";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(187, 82);
            button8.Name = "button8";
            button8.Size = new Size(189, 46);
            button8.TabIndex = 23;
            button8.Text = "清空发送";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(184, 24);
            button9.Name = "button9";
            button9.Size = new Size(189, 46);
            button9.TabIndex = 22;
            button9.Text = "手动发送";
            button9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(21, 89);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(142, 35);
            checkBox5.TabIndex = 21;
            checkBox5.Text = "十六进制";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(20, 31);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(142, 35);
            checkBox6.TabIndex = 20;
            checkBox6.Text = "自动发送";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
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
            // textBox3
            // 
            textBox3.Location = new Point(270, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 38);
            textBox3.TabIndex = 28;
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
        private RichTextBox richTextBox1;
        private GroupBox groupBox5;
        private RichTextBox richTextBox3;
        private ComboBox comboBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button3;
        private Button button2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private TextBox textBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private TextBox textBox3;
        private Label label6;
    }
}
