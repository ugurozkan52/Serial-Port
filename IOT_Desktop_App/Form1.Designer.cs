namespace IOT_Desktop_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.lblOpenBackSpeed = new System.Windows.Forms.Label();
            this.lblOpenFrontSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCloseCount = new System.Windows.Forms.Label();
            this.lblCloseBackSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCloseFrontSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TBoxInputData = new System.Windows.Forms.TextBox();
            this.BtnTextSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.lblCloseCnt = new System.Windows.Forms.Label();
            this.lblFront1Sens = new System.Windows.Forms.Label();
            this.lblFront2Sens = new System.Windows.Forms.Label();
            this.lblOpenCnt = new System.Windows.Forms.Label();
            this.lblBack2Sens = new System.Windows.Forms.Label();
            this.lblBack1Sens = new System.Windows.Forms.Label();
            this.pBoxDoorStatus = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnExel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorStatus)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.BtnOpen);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORT SETTINGS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 14);
            this.progressBar1.TabIndex = 6;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(175, 102);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(96, 38);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpen.Location = new System.Drawing.Point(9, 100);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(97, 40);
            this.BtnOpen.TabIndex = 4;
            this.BtnOpen.Text = "OPEN";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(150, 62);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudRate.TabIndex = 3;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(150, 28);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.cBoxComPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.lblOpenCount);
            this.groupBox2.Controls.Add(this.lblOpenBackSpeed);
            this.groupBox2.Controls.Add(this.lblOpenFrontSpeed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Door Opening";
            // 
            // lblOpenCount
            // 
            this.lblOpenCount.AutoSize = true;
            this.lblOpenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCount.Location = new System.Drawing.Point(171, 124);
            this.lblOpenCount.Name = "lblOpenCount";
            this.lblOpenCount.Size = new System.Drawing.Size(69, 20);
            this.lblOpenCount.TabIndex = 7;
            this.lblOpenCount.Text = "000000";
            // 
            // lblOpenBackSpeed
            // 
            this.lblOpenBackSpeed.AutoSize = true;
            this.lblOpenBackSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenBackSpeed.Location = new System.Drawing.Point(171, 74);
            this.lblOpenBackSpeed.Name = "lblOpenBackSpeed";
            this.lblOpenBackSpeed.Size = new System.Drawing.Size(69, 20);
            this.lblOpenBackSpeed.TabIndex = 6;
            this.lblOpenBackSpeed.Text = "000000";
            // 
            // lblOpenFrontSpeed
            // 
            this.lblOpenFrontSpeed.AutoSize = true;
            this.lblOpenFrontSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFrontSpeed.Location = new System.Drawing.Point(171, 29);
            this.lblOpenFrontSpeed.Name = "lblOpenFrontSpeed";
            this.lblOpenFrontSpeed.Size = new System.Drawing.Size(69, 20);
            this.lblOpenFrontSpeed.TabIndex = 5;
            this.lblOpenFrontSpeed.Text = "000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Opening Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Back Speed :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Front Speed : ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.lblCloseCount);
            this.groupBox3.Controls.Add(this.lblCloseBackSpeed);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblCloseFrontSpeed);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 173);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Door Closing";
            // 
            // lblCloseCount
            // 
            this.lblCloseCount.AutoSize = true;
            this.lblCloseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseCount.Location = new System.Drawing.Point(171, 124);
            this.lblCloseCount.Name = "lblCloseCount";
            this.lblCloseCount.Size = new System.Drawing.Size(69, 20);
            this.lblCloseCount.TabIndex = 10;
            this.lblCloseCount.Text = "000000";
            // 
            // lblCloseBackSpeed
            // 
            this.lblCloseBackSpeed.AutoSize = true;
            this.lblCloseBackSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseBackSpeed.Location = new System.Drawing.Point(171, 74);
            this.lblCloseBackSpeed.Name = "lblCloseBackSpeed";
            this.lblCloseBackSpeed.Size = new System.Drawing.Size(69, 20);
            this.lblCloseBackSpeed.TabIndex = 9;
            this.lblCloseBackSpeed.Text = "000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Closing Count :";
            // 
            // lblCloseFrontSpeed
            // 
            this.lblCloseFrontSpeed.AutoSize = true;
            this.lblCloseFrontSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseFrontSpeed.Location = new System.Drawing.Point(171, 26);
            this.lblCloseFrontSpeed.Name = "lblCloseFrontSpeed";
            this.lblCloseFrontSpeed.Size = new System.Drawing.Size(69, 20);
            this.lblCloseFrontSpeed.TabIndex = 8;
            this.lblCloseFrontSpeed.Text = "000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Back Speed :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Front Speed : ";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // TBoxInputData
            // 
            this.TBoxInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxInputData.Location = new System.Drawing.Point(3, 40);
            this.TBoxInputData.Multiline = true;
            this.TBoxInputData.Name = "TBoxInputData";
            this.TBoxInputData.ReadOnly = true;
            this.TBoxInputData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBoxInputData.Size = new System.Drawing.Size(920, 251);
            this.TBoxInputData.TabIndex = 5;
            // 
            // BtnTextSave
            // 
            this.BtnTextSave.Location = new System.Drawing.Point(3, 297);
            this.BtnTextSave.Name = "BtnTextSave";
            this.BtnTextSave.Size = new System.Drawing.Size(92, 47);
            this.BtnTextSave.TabIndex = 6;
            this.BtnTextSave.Text = "Text Save";
            this.BtnTextSave.UseVisualStyleBackColor = true;
            this.BtnTextSave.Click += new System.EventHandler(this.BtnTextSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(199, 297);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(83, 47);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblCloseCnt
            // 
            this.lblCloseCnt.AutoSize = true;
            this.lblCloseCnt.Location = new System.Drawing.Point(6, 33);
            this.lblCloseCnt.Name = "lblCloseCnt";
            this.lblCloseCnt.Size = new System.Drawing.Size(71, 13);
            this.lblCloseCnt.TabIndex = 8;
            this.lblCloseCnt.Text = "CloseCount";
            this.lblCloseCnt.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblFront1Sens
            // 
            this.lblFront1Sens.AutoSize = true;
            this.lblFront1Sens.Location = new System.Drawing.Point(125, 33);
            this.lblFront1Sens.Name = "lblFront1Sens";
            this.lblFront1Sens.Size = new System.Drawing.Size(71, 13);
            this.lblFront1Sens.TabIndex = 9;
            this.lblFront1Sens.Text = "FrontSens1";
            this.lblFront1Sens.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lblFront2Sens
            // 
            this.lblFront2Sens.AutoSize = true;
            this.lblFront2Sens.Location = new System.Drawing.Point(247, 34);
            this.lblFront2Sens.Name = "lblFront2Sens";
            this.lblFront2Sens.Size = new System.Drawing.Size(71, 13);
            this.lblFront2Sens.TabIndex = 10;
            this.lblFront2Sens.Text = "FrontSens2";
            this.lblFront2Sens.Click += new System.EventHandler(this.Label8_Click);
            // 
            // lblOpenCnt
            // 
            this.lblOpenCnt.AutoSize = true;
            this.lblOpenCnt.Location = new System.Drawing.Point(843, 34);
            this.lblOpenCnt.Name = "lblOpenCnt";
            this.lblOpenCnt.Size = new System.Drawing.Size(70, 13);
            this.lblOpenCnt.TabIndex = 13;
            this.lblOpenCnt.Text = "OpenCount";
            this.lblOpenCnt.Click += new System.EventHandler(this.Label12_Click);
            // 
            // lblBack2Sens
            // 
            this.lblBack2Sens.AutoSize = true;
            this.lblBack2Sens.Location = new System.Drawing.Point(727, 34);
            this.lblBack2Sens.Name = "lblBack2Sens";
            this.lblBack2Sens.Size = new System.Drawing.Size(71, 13);
            this.lblBack2Sens.TabIndex = 12;
            this.lblBack2Sens.Text = "BackSens2";
            this.lblBack2Sens.Click += new System.EventHandler(this.Label13_Click);
            // 
            // lblBack1Sens
            // 
            this.lblBack1Sens.AutoSize = true;
            this.lblBack1Sens.Location = new System.Drawing.Point(609, 33);
            this.lblBack1Sens.Name = "lblBack1Sens";
            this.lblBack1Sens.Size = new System.Drawing.Size(71, 13);
            this.lblBack1Sens.TabIndex = 11;
            this.lblBack1Sens.Text = "BackSens1";
            this.lblBack1Sens.Click += new System.EventHandler(this.Label14_Click);
            // 
            // pBoxDoorStatus
            // 
            this.pBoxDoorStatus.Image = ((System.Drawing.Image)(resources.GetObject("pBoxDoorStatus.Image")));
            this.pBoxDoorStatus.Location = new System.Drawing.Point(6, 72);
            this.pBoxDoorStatus.Name = "pBoxDoorStatus";
            this.pBoxDoorStatus.Size = new System.Drawing.Size(68, 87);
            this.pBoxDoorStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDoorStatus.TabIndex = 14;
            this.pBoxDoorStatus.TabStop = false;
            this.pBoxDoorStatus.Click += new System.EventHandler(this.PBoxDoor_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 157);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(907, 14);
            this.progressBar2.TabIndex = 15;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 62);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(907, 14);
            this.progressBar3.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFront1Sens);
            this.groupBox4.Controls.Add(this.progressBar2);
            this.groupBox4.Controls.Add(this.progressBar3);
            this.groupBox4.Controls.Add(this.pBoxDoorStatus);
            this.groupBox4.Controls.Add(this.lblCloseCnt);
            this.groupBox4.Controls.Add(this.lblFront2Sens);
            this.groupBox4.Controls.Add(this.lblBack1Sens);
            this.groupBox4.Controls.Add(this.lblOpenCnt);
            this.groupBox4.Controls.Add(this.lblBack2Sens);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(300, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(920, 176);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Door Status Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "O.F.Speed_1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "O.F.Speed_2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(567, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "C.F.Speed_1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(804, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Opened";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(711, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "C.F.Speed_2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Closed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "DateTime";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbldatetime);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.BtnExel);
            this.groupBox5.Controls.Add(this.TBoxInputData);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.BtnTextSave);
            this.groupBox5.Controls.Add(this.BtnClear);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(300, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(920, 349);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Door_Watch_Panel";
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.Location = new System.Drawing.Point(731, 309);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(0, 20);
            this.lbldatetime.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(621, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Date - Time : ";
            // 
            // BtnExel
            // 
            this.BtnExel.Location = new System.Drawing.Point(101, 297);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(92, 47);
            this.BtnExel.TabIndex = 25;
            this.BtnExel.Text = "Exel Save";
            this.BtnExel.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Opening Front Speed 1 (m/s)";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Opening Front Speed 2 (m/s)";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Closing Front Speed 1 (m/s)";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Closing Front Speed 2 (m/s)";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Closed";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Opened";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1195, 318);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 550);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1211, 366);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Graphic Panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 969);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Com Port GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorStatus)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label lblOpenBackSpeed;
        private System.Windows.Forms.Label lblOpenFrontSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCloseCount;
        private System.Windows.Forms.Label lblCloseBackSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCloseFrontSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TBoxInputData;
        private System.Windows.Forms.Button BtnTextSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label lblCloseCnt;
        private System.Windows.Forms.Label lblFront1Sens;
        private System.Windows.Forms.Label lblFront2Sens;
        private System.Windows.Forms.Label lblOpenCnt;
        private System.Windows.Forms.Label lblBack2Sens;
        private System.Windows.Forms.Label lblBack1Sens;
        private System.Windows.Forms.PictureBox pBoxDoorStatus;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnExel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

