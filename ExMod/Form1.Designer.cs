namespace ExMod
{
    partial class FrmMaster
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaster));
            this.btnReadInputRegister = new System.Windows.Forms.Button();
            this.btnReadHoldingRegister = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.txtDeviceAddr = new System.Windows.Forms.TextBox();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBit = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtWrong = new System.Windows.Forms.TextBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWriteRegisters = new System.Windows.Forms.Button();
            this.btnSetAddress = new System.Windows.Forms.Button();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.btnCRC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComData = new System.Windows.Forms.TextBox();
            this.btnSendAny = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.lnkHelp = new System.Windows.Forms.LinkLabel();
            this.chkModbus = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRegAddr = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkHEX = new System.Windows.Forms.CheckBox();
            this.chkAddressColumn = new System.Windows.Forms.CheckBox();
            this.chkHexShow = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCurLine = new System.Windows.Forms.Label();
            this.txtCurLine = new System.Windows.Forms.TextBox();
            this.chkSend = new System.Windows.Forms.CheckBox();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadInputRegister
            // 
            this.btnReadInputRegister.Location = new System.Drawing.Point(389, 418);
            this.btnReadInputRegister.Name = "btnReadInputRegister";
            this.btnReadInputRegister.Size = new System.Drawing.Size(135, 23);
            this.btnReadInputRegister.TabIndex = 71;
            this.btnReadInputRegister.Text = "读取输入寄存器";
            this.btnReadInputRegister.UseVisualStyleBackColor = true;
            this.btnReadInputRegister.Click += new System.EventHandler(this.btnReadInputRegister_Click);
            // 
            // btnReadHoldingRegister
            // 
            this.btnReadHoldingRegister.Location = new System.Drawing.Point(232, 418);
            this.btnReadHoldingRegister.Name = "btnReadHoldingRegister";
            this.btnReadHoldingRegister.Size = new System.Drawing.Size(135, 23);
            this.btnReadHoldingRegister.TabIndex = 70;
            this.btnReadHoldingRegister.Text = "读取Holding寄存器";
            this.btnReadHoldingRegister.UseVisualStyleBackColor = true;
            this.btnReadHoldingRegister.Click += new System.EventHandler(this.btnReadHoldingRegister_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(110, 327);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(605, 21);
            this.txtRead.TabIndex = 69;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 68;
            this.label19.Text = "读取内容";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 67;
            this.label16.Text = "数量";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 66;
            this.label17.Text = "起始地址";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(440, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 65;
            this.label18.Text = "设备地址";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(269, 294);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 64;
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(110, 294);
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(100, 21);
            this.txtStartAddr.TabIndex = 63;
            // 
            // txtDeviceAddr
            // 
            this.txtDeviceAddr.Location = new System.Drawing.Point(499, 294);
            this.txtDeviceAddr.Name = "txtDeviceAddr";
            this.txtDeviceAddr.Size = new System.Drawing.Size(58, 21);
            this.txtDeviceAddr.TabIndex = 62;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(95, 133);
            this.cmbStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(92, 20);
            this.cmbStopBit.TabIndex = 61;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(95, 103);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(92, 20);
            this.cmbParity.TabIndex = 60;
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.FormattingEnabled = true;
            this.cmbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5",
            "4"});
            this.cmbDataBit.Location = new System.Drawing.Point(95, 73);
            this.cmbDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(92, 20);
            this.cmbDataBit.TabIndex = 59;
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(95, 43);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(92, 20);
            this.cmbBaud.TabIndex = 58;
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(95, 13);
            this.cmbCom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(92, 20);
            this.cmbCom.TabIndex = 57;
            this.cmbCom.SelectedIndexChanged += new System.EventHandler(this.cmbCom_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 56;
            this.label7.Text = "Stop Bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "Parity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "Data Bit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 53;
            this.label10.Text = "Baud.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 52;
            this.label11.Text = "Com";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(116, 173);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "关闭串口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(32, 173);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(71, 23);
            this.btnOpen.TabIndex = 50;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtWrong
            // 
            this.txtWrong.Location = new System.Drawing.Point(110, 385);
            this.txtWrong.Multiline = true;
            this.txtWrong.Name = "txtWrong";
            this.txtWrong.Size = new System.Drawing.Size(605, 21);
            this.txtWrong.TabIndex = 49;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(110, 356);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(605, 21);
            this.txtWrite.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "写入内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "错误信息";
            // 
            // btnWriteRegisters
            // 
            this.btnWriteRegisters.Location = new System.Drawing.Point(546, 418);
            this.btnWriteRegisters.Name = "btnWriteRegisters";
            this.btnWriteRegisters.Size = new System.Drawing.Size(135, 23);
            this.btnWriteRegisters.TabIndex = 43;
            this.btnWriteRegisters.Text = "写入多个寄存器";
            this.btnWriteRegisters.UseVisualStyleBackColor = true;
            this.btnWriteRegisters.Click += new System.EventHandler(this.btnWriteRegisters_Click);
            // 
            // btnSetAddress
            // 
            this.btnSetAddress.Location = new System.Drawing.Point(565, 292);
            this.btnSetAddress.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetAddress.Name = "btnSetAddress";
            this.btnSetAddress.Size = new System.Drawing.Size(94, 23);
            this.btnSetAddress.TabIndex = 50;
            this.btnSetAddress.Text = "设置设备地址";
            this.btnSetAddress.UseVisualStyleBackColor = true;
            this.btnSetAddress.Click += new System.EventHandler(this.btnSetAddress_Click);
            // 
            // txtCRC
            // 
            this.txtCRC.Location = new System.Drawing.Point(470, 252);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.Size = new System.Drawing.Size(48, 21);
            this.txtCRC.TabIndex = 75;
            // 
            // btnCRC
            // 
            this.btnCRC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCRC.Location = new System.Drawing.Point(649, 250);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(92, 23);
            this.btnCRC.TabIndex = 74;
            this.btnCRC.Text = "计算CRC并发送";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 73;
            this.label3.Text = "CRC效验码：";
            // 
            // txtComData
            // 
            this.txtComData.Location = new System.Drawing.Point(27, 252);
            this.txtComData.Name = "txtComData";
            this.txtComData.Size = new System.Drawing.Size(361, 21);
            this.txtComData.TabIndex = 72;
            // 
            // btnSendAny
            // 
            this.btnSendAny.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSendAny.Location = new System.Drawing.Point(531, 250);
            this.btnSendAny.Name = "btnSendAny";
            this.btnSendAny.Size = new System.Drawing.Size(112, 23);
            this.btnSendAny.TabIndex = 76;
            this.btnSendAny.Text = "发送任意串口数据";
            this.btnSendAny.UseVisualStyleBackColor = true;
            this.btnSendAny.Click += new System.EventHandler(this.btnSendAny_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(202, 31);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(290, 202);
            this.txtReceived.TabIndex = 63;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(500, 31);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(241, 202);
            this.txtSend.TabIndex = 63;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(290, 459);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 21);
            this.txtPath.TabIndex = 78;
            // 
            // btnSendFile
            // 
            this.btnSendFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSendFile.Location = new System.Drawing.Point(575, 457);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(107, 23);
            this.btnSendFile.TabIndex = 77;
            this.btnSendFile.Text = "发送文件中数据";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowse.Location = new System.Drawing.Point(230, 458);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 23);
            this.btnBrowse.TabIndex = 77;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStop.Location = new System.Drawing.Point(690, 457);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 23);
            this.btnStop.TabIndex = 77;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(173, 490);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(57, 21);
            this.txtFrom.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 73;
            this.label12.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(259, 490);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(57, 21);
            this.txtTo.TabIndex = 75;
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(333, 492);
            this.chkLine.Name = "chkLine";
            this.chkLine.Size = new System.Drawing.Size(72, 16);
            this.chkLine.TabIndex = 79;
            this.chkLine.Text = "单行手动";
            this.chkLine.UseVisualStyleBackColor = true;
            // 
            // lnkHelp
            // 
            this.lnkHelp.AutoSize = true;
            this.lnkHelp.Location = new System.Drawing.Point(688, 13);
            this.lnkHelp.Name = "lnkHelp";
            this.lnkHelp.Size = new System.Drawing.Size(53, 12);
            this.lnkHelp.TabIndex = 80;
            this.lnkHelp.TabStop = true;
            this.lnkHelp.Text = "使用说明";
            this.lnkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
            // 
            // chkModbus
            // 
            this.chkModbus.AutoSize = true;
            this.chkModbus.Location = new System.Drawing.Point(411, 492);
            this.chkModbus.Name = "chkModbus";
            this.chkModbus.Size = new System.Drawing.Size(84, 16);
            this.chkModbus.TabIndex = 79;
            this.chkModbus.Text = "Modbus数据";
            this.chkModbus.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 73;
            this.label13.Text = "延时";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 73;
            this.label14.Text = " 功能码";
            this.label14.Visible = false;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(147, 460);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(57, 21);
            this.txtDelay.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(614, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 73;
            this.label15.Text = "寄存器地址";
            // 
            // txtRegAddr
            // 
            this.txtRegAddr.Location = new System.Drawing.Point(685, 490);
            this.txtRegAddr.Name = "txtRegAddr";
            this.txtRegAddr.Size = new System.Drawing.Size(57, 21);
            this.txtRegAddr.TabIndex = 75;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(205, 462);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 73;
            this.label20.Text = "ms";
            // 
            // chkHEX
            // 
            this.chkHEX.AutoSize = true;
            this.chkHEX.Location = new System.Drawing.Point(27, 462);
            this.chkHEX.Name = "chkHEX";
            this.chkHEX.Size = new System.Drawing.Size(84, 16);
            this.chkHEX.TabIndex = 79;
            this.chkHEX.Text = "16进制发送";
            this.chkHEX.UseVisualStyleBackColor = true;
            // 
            // chkAddressColumn
            // 
            this.chkAddressColumn.AutoSize = true;
            this.chkAddressColumn.Location = new System.Drawing.Point(501, 492);
            this.chkAddressColumn.Name = "chkAddressColumn";
            this.chkAddressColumn.Size = new System.Drawing.Size(96, 16);
            this.chkAddressColumn.TabIndex = 79;
            this.chkAddressColumn.Text = "第一列为地址";
            this.chkAddressColumn.UseVisualStyleBackColor = true;
            // 
            // chkHexShow
            // 
            this.chkHexShow.AutoSize = true;
            this.chkHexShow.Location = new System.Drawing.Point(32, 217);
            this.chkHexShow.Name = "chkHexShow";
            this.chkHexShow.Size = new System.Drawing.Size(84, 16);
            this.chkHexShow.TabIndex = 79;
            this.chkHexShow.Text = "16进制显示";
            this.chkHexShow.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCurLine
            // 
            this.lblCurLine.AutoSize = true;
            this.lblCurLine.Location = new System.Drawing.Point(25, 493);
            this.lblCurLine.Name = "lblCurLine";
            this.lblCurLine.Size = new System.Drawing.Size(41, 12);
            this.lblCurLine.TabIndex = 73;
            this.lblCurLine.Text = "当前行";
            // 
            // txtCurLine
            // 
            this.txtCurLine.Location = new System.Drawing.Point(72, 490);
            this.txtCurLine.Name = "txtCurLine";
            this.txtCurLine.ReadOnly = true;
            this.txtCurLine.Size = new System.Drawing.Size(57, 21);
            this.txtCurLine.TabIndex = 75;
            // 
            // chkSend
            // 
            this.chkSend.AutoSize = true;
            this.chkSend.Location = new System.Drawing.Point(515, 12);
            this.chkSend.Name = "chkSend";
            this.chkSend.Size = new System.Drawing.Size(72, 16);
            this.chkSend.TabIndex = 82;
            this.chkSend.Text = "发送数据";
            this.chkSend.UseVisualStyleBackColor = true;
            this.chkSend.CheckedChanged += new System.EventHandler(this.chkSend_CheckedChanged);
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Location = new System.Drawing.Point(218, 12);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(72, 16);
            this.chkReceived.TabIndex = 82;
            this.chkReceived.Text = "接收数据";
            this.chkReceived.UseVisualStyleBackColor = true;
            this.chkReceived.CheckedChanged += new System.EventHandler(this.chkReceived_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 420);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 20);
            this.comboBox1.TabIndex = 83;
            this.comboBox1.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(147, 418);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(52, 23);
            this.btnSend.TabIndex = 84;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 537);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkReceived);
            this.Controls.Add(this.chkSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnkHelp);
            this.Controls.Add(this.chkHexShow);
            this.Controls.Add(this.chkHEX);
            this.Controls.Add(this.chkAddressColumn);
            this.Controls.Add(this.chkModbus);
            this.Controls.Add(this.chkLine);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSendAny);
            this.Controls.Add(this.txtRegAddr);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCurLine);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCurLine);
            this.Controls.Add(this.txtCRC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCRC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComData);
            this.Controls.Add(this.btnReadInputRegister);
            this.Controls.Add(this.btnReadHoldingRegister);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtStartAddr);
            this.Controls.Add(this.txtDeviceAddr);
            this.Controls.Add(this.cmbStopBit);
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.cmbDataBit);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetAddress);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtWrong);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWriteRegisters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMaster";
            this.Text = "ExMod Serial Assistant";
            this.Load += new System.EventHandler(this.FrmMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadInputRegister;
        private System.Windows.Forms.Button btnReadHoldingRegister;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.TextBox txtDeviceAddr;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBit;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtWrong;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteRegisters;
        private System.Windows.Forms.Button btnSetAddress;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComData;
        private System.Windows.Forms.Button btnSendAny;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.LinkLabel lnkHelp;
        private System.Windows.Forms.CheckBox chkModbus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRegAddr;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkHEX;
        private System.Windows.Forms.CheckBox chkAddressColumn;
        private System.Windows.Forms.CheckBox chkHexShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCurLine;
        private System.Windows.Forms.TextBox txtCurLine;
        private System.Windows.Forms.CheckBox chkSend;
        private System.Windows.Forms.CheckBox chkReceived;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSend;
    }
}

