namespace ControlLed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grSetting = new System.Windows.Forms.GroupBox();
            this.btDisconnet = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPortBaud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grStatus = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLed1Off = new System.Windows.Forms.Button();
            this.btLed1On = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.grSetting.SuspendLayout();
            this.grStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSetting
            // 
            this.grSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grSetting.Controls.Add(this.btDisconnet);
            this.grSetting.Controls.Add(this.btConnect);
            this.grSetting.Controls.Add(this.cbStopBits);
            this.grSetting.Controls.Add(this.cbParity);
            this.grSetting.Controls.Add(this.cbDataSize);
            this.grSetting.Controls.Add(this.label5);
            this.grSetting.Controls.Add(this.cbPortBaud);
            this.grSetting.Controls.Add(this.label4);
            this.grSetting.Controls.Add(this.label3);
            this.grSetting.Controls.Add(this.cbPortName);
            this.grSetting.Controls.Add(this.label2);
            this.grSetting.Controls.Add(this.label1);
            this.grSetting.Location = new System.Drawing.Point(16, 17);
            this.grSetting.Name = "grSetting";
            this.grSetting.Size = new System.Drawing.Size(442, 407);
            this.grSetting.TabIndex = 0;
            this.grSetting.TabStop = false;
            this.grSetting.Text = "Setting COM";
            // 
            // btDisconnet
            // 
            this.btDisconnet.Location = new System.Drawing.Point(138, 352);
            this.btDisconnet.Name = "btDisconnet";
            this.btDisconnet.Size = new System.Drawing.Size(276, 49);
            this.btDisconnet.TabIndex = 3;
            this.btDisconnet.Text = "Disconnet";
            this.btDisconnet.UseVisualStyleBackColor = true;
            this.btDisconnet.Click += new System.EventHandler(this.btDisconnet_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(138, 297);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(276, 49);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(138, 233);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(276, 33);
            this.cbStopBits.TabIndex = 4;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "none",
            "even",
            "odd"});
            this.cbParity.Location = new System.Drawing.Point(138, 194);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(276, 33);
            this.cbParity.TabIndex = 3;
            // 
            // cbDataSize
            // 
            this.cbDataSize.FormattingEnabled = true;
            this.cbDataSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbDataSize.Location = new System.Drawing.Point(138, 139);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(276, 33);
            this.cbDataSize.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stop bit:";
            // 
            // cbPortBaud
            // 
            this.cbPortBaud.FormattingEnabled = true;
            this.cbPortBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbPortBaud.Location = new System.Drawing.Point(138, 87);
            this.cbPortBaud.Name = "cbPortBaud";
            this.cbPortBaud.Size = new System.Drawing.Size(276, 33);
            this.cbPortBaud.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data size:";
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(138, 38);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(276, 33);
            this.cbPortName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grStatus
            // 
            this.grStatus.Controls.Add(this.groupBox3);
            this.grStatus.Location = new System.Drawing.Point(495, 17);
            this.grStatus.Name = "grStatus";
            this.grStatus.Size = new System.Drawing.Size(630, 596);
            this.grStatus.TabIndex = 1;
            this.grStatus.TabStop = false;
            this.grStatus.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLed1Off);
            this.groupBox3.Controls.Add(this.btLed1On);
            this.groupBox3.Location = new System.Drawing.Point(20, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Led 1";
            // 
            // btLed1Off
            // 
            this.btLed1Off.Location = new System.Drawing.Point(14, 87);
            this.btLed1Off.Name = "btLed1Off";
            this.btLed1Off.Size = new System.Drawing.Size(144, 39);
            this.btLed1Off.TabIndex = 0;
            this.btLed1Off.Text = "OFF";
            this.btLed1Off.UseVisualStyleBackColor = true;
            // 
            // btLed1On
            // 
            this.btLed1On.Location = new System.Drawing.Point(14, 35);
            this.btLed1On.Name = "btLed1On";
            this.btLed1On.Size = new System.Drawing.Size(144, 39);
            this.btLed1On.TabIndex = 0;
            this.btLed1On.Text = "ON";
            this.btLed1On.UseVisualStyleBackColor = true;
            this.btLed1On.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btLed1On_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(16, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(7, 44);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMessage.Size = new System.Drawing.Size(429, 125);
            this.tbMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grStatus);
            this.Controls.Add(this.grSetting);
            this.Name = "Form1";
            this.Text = "Control led";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grSetting.ResumeLayout(false);
            this.grSetting.PerformLayout();
            this.grStatus.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grSetting;
        private System.Windows.Forms.Button btDisconnet;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataSize;
        private System.Windows.Forms.ComboBox cbPortBaud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLed1Off;
        private System.Windows.Forms.Button btLed1On;
    }
}

