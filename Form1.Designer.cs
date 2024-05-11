namespace SerialComwithArduino
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.Inbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StartComButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(108, 84);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 0;
            this.comboBoxBaudRate.Text = "Select BaudRate";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.comboBoxParity.Location = new System.Drawing.Point(108, 120);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 1;
            this.comboBoxParity.Text = "Select Parity";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(108, 48);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.Text = "Select COM";
            this.comboBoxPort.Click += new System.EventHandler(this.comboBoxPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMMUNICATION SETTINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "COM PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BAUDRATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PARITY";
            // 
            // SendBox
            // 
            this.SendBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.SendBox.ForeColor = System.Drawing.Color.Lime;
            this.SendBox.Location = new System.Drawing.Point(431, 33);
            this.SendBox.Multiline = true;
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(143, 100);
            this.SendBox.TabIndex = 8;
            // 
            // Inbox
            // 
            this.Inbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Inbox.ForeColor = System.Drawing.Color.Lime;
            this.Inbox.Location = new System.Drawing.Point(606, 33);
            this.Inbox.Multiline = true;
            this.Inbox.Name = "Inbox";
            this.Inbox.ReadOnly = true;
            this.Inbox.Size = new System.Drawing.Size(143, 100);
            this.Inbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(455, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SENDBOX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(645, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "INBOX";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(431, 133);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(143, 23);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(606, 133);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(143, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StartComButton
            // 
            this.StartComButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartComButton.Location = new System.Drawing.Point(274, 62);
            this.StartComButton.Name = "StartComButton";
            this.StartComButton.Size = new System.Drawing.Size(100, 62);
            this.StartComButton.TabIndex = 14;
            this.StartComButton.Text = "START COM";
            this.StartComButton.UseVisualStyleBackColor = true;
            this.StartComButton.Click += new System.EventHandler(this.StartComButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 170);
            this.Controls.Add(this.StartComButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Inbox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Name = "Form1";
            this.Text = "Serial Communication Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.TextBox Inbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button StartComButton;
    }
}

