namespace ezCPU
{
    partial class ezCPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ezCPU));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBIOSDate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBIOSVersion = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBIOSBrand = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMBStatus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMBBusType = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMBSerial = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMBModel = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMBManufacturer = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGPUDriverVersion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGPUStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGPURefresh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGPUVideoMode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGPUManufacturer = new System.Windows.Forms.TextBox();
            this.txtGPUName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArchitecture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrentSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPUManufacturer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPUName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cpuTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(380, 355);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Motherboard";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtBIOSDate);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtBIOSVersion);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtBIOSBrand);
            this.groupBox4.Location = new System.Drawing.Point(6, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 142);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BIOS Information";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Release Date";
            // 
            // txtBIOSDate
            // 
            this.txtBIOSDate.Enabled = false;
            this.txtBIOSDate.Location = new System.Drawing.Point(96, 82);
            this.txtBIOSDate.Name = "txtBIOSDate";
            this.txtBIOSDate.Size = new System.Drawing.Size(252, 20);
            this.txtBIOSDate.TabIndex = 14;
            this.txtBIOSDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Version";
            // 
            // txtBIOSVersion
            // 
            this.txtBIOSVersion.Enabled = false;
            this.txtBIOSVersion.Location = new System.Drawing.Point(96, 56);
            this.txtBIOSVersion.Name = "txtBIOSVersion";
            this.txtBIOSVersion.Size = new System.Drawing.Size(252, 20);
            this.txtBIOSVersion.TabIndex = 12;
            this.txtBIOSVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Brand";
            // 
            // txtBIOSBrand
            // 
            this.txtBIOSBrand.Enabled = false;
            this.txtBIOSBrand.Location = new System.Drawing.Point(96, 30);
            this.txtBIOSBrand.Name = "txtBIOSBrand";
            this.txtBIOSBrand.Size = new System.Drawing.Size(252, 20);
            this.txtBIOSBrand.TabIndex = 10;
            this.txtBIOSBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMBStatus);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtMBBusType);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtMBSerial);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtMBModel);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtMBManufacturer);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motherboard Information";
            // 
            // txtMBStatus
            // 
            this.txtMBStatus.Enabled = false;
            this.txtMBStatus.Location = new System.Drawing.Point(262, 106);
            this.txtMBStatus.Name = "txtMBStatus";
            this.txtMBStatus.Size = new System.Drawing.Size(84, 20);
            this.txtMBStatus.TabIndex = 17;
            this.txtMBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(184, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Status";
            // 
            // txtMBBusType
            // 
            this.txtMBBusType.Enabled = false;
            this.txtMBBusType.Location = new System.Drawing.Point(94, 106);
            this.txtMBBusType.Name = "txtMBBusType";
            this.txtMBBusType.Size = new System.Drawing.Size(84, 20);
            this.txtMBBusType.TabIndex = 15;
            this.txtMBBusType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Bus Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Serial Number";
            // 
            // txtMBSerial
            // 
            this.txtMBSerial.Enabled = false;
            this.txtMBSerial.Location = new System.Drawing.Point(94, 80);
            this.txtMBSerial.Name = "txtMBSerial";
            this.txtMBSerial.Size = new System.Drawing.Size(252, 20);
            this.txtMBSerial.TabIndex = 8;
            this.txtMBSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Model";
            // 
            // txtMBModel
            // 
            this.txtMBModel.Enabled = false;
            this.txtMBModel.Location = new System.Drawing.Point(94, 54);
            this.txtMBModel.Name = "txtMBModel";
            this.txtMBModel.Size = new System.Drawing.Size(252, 20);
            this.txtMBModel.TabIndex = 6;
            this.txtMBModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Manufacturer";
            // 
            // txtMBManufacturer
            // 
            this.txtMBManufacturer.Enabled = false;
            this.txtMBManufacturer.Location = new System.Drawing.Point(94, 28);
            this.txtMBManufacturer.Name = "txtMBManufacturer";
            this.txtMBManufacturer.Size = new System.Drawing.Size(252, 20);
            this.txtMBManufacturer.TabIndex = 4;
            this.txtMBManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(380, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GPU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGPUDriverVersion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtGPUStatus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtGPURefresh);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtGPUVideoMode);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGPUManufacturer);
            this.groupBox2.Controls.Add(this.txtGPUName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 195);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graphics Information";
            // 
            // txtGPUDriverVersion
            // 
            this.txtGPUDriverVersion.Enabled = false;
            this.txtGPUDriverVersion.Location = new System.Drawing.Point(94, 132);
            this.txtGPUDriverVersion.Name = "txtGPUDriverVersion";
            this.txtGPUDriverVersion.Size = new System.Drawing.Size(252, 20);
            this.txtGPUDriverVersion.TabIndex = 17;
            this.txtGPUDriverVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Driver Version";
            // 
            // txtGPUStatus
            // 
            this.txtGPUStatus.Enabled = false;
            this.txtGPUStatus.Location = new System.Drawing.Point(262, 106);
            this.txtGPUStatus.Name = "txtGPUStatus";
            this.txtGPUStatus.Size = new System.Drawing.Size(84, 20);
            this.txtGPUStatus.TabIndex = 13;
            this.txtGPUStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Status";
            // 
            // txtGPURefresh
            // 
            this.txtGPURefresh.Enabled = false;
            this.txtGPURefresh.Location = new System.Drawing.Point(94, 106);
            this.txtGPURefresh.Name = "txtGPURefresh";
            this.txtGPURefresh.Size = new System.Drawing.Size(84, 20);
            this.txtGPURefresh.TabIndex = 11;
            this.txtGPURefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Refresh Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Video Mode";
            // 
            // txtGPUVideoMode
            // 
            this.txtGPUVideoMode.Enabled = false;
            this.txtGPUVideoMode.Location = new System.Drawing.Point(94, 80);
            this.txtGPUVideoMode.Name = "txtGPUVideoMode";
            this.txtGPUVideoMode.Size = new System.Drawing.Size(252, 20);
            this.txtGPUVideoMode.TabIndex = 6;
            this.txtGPUVideoMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Manufacturer";
            // 
            // txtGPUManufacturer
            // 
            this.txtGPUManufacturer.Enabled = false;
            this.txtGPUManufacturer.Location = new System.Drawing.Point(94, 54);
            this.txtGPUManufacturer.Name = "txtGPUManufacturer";
            this.txtGPUManufacturer.Size = new System.Drawing.Size(252, 20);
            this.txtGPUManufacturer.TabIndex = 4;
            this.txtGPUManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGPUName
            // 
            this.txtGPUName.Enabled = false;
            this.txtGPUName.Location = new System.Drawing.Point(94, 28);
            this.txtGPUName.Name = "txtGPUName";
            this.txtGPUName.Size = new System.Drawing.Size(252, 20);
            this.txtGPUName.TabIndex = 1;
            this.txtGPUName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtArchitecture);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCaption);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCurrentSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtThreads);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCores);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCPUManufacturer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCPUName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processor Information";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(262, 106);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(84, 20);
            this.txtStatus.TabIndex = 31;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status";
            // 
            // txtArchitecture
            // 
            this.txtArchitecture.Enabled = false;
            this.txtArchitecture.Location = new System.Drawing.Point(94, 106);
            this.txtArchitecture.Name = "txtArchitecture";
            this.txtArchitecture.Size = new System.Drawing.Size(84, 20);
            this.txtArchitecture.TabIndex = 29;
            this.txtArchitecture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Architecture";
            // 
            // txtCaption
            // 
            this.txtCaption.Enabled = false;
            this.txtCaption.Location = new System.Drawing.Point(94, 158);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(252, 20);
            this.txtCaption.TabIndex = 23;
            this.txtCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Caption";
            // 
            // txtCurrentSpeed
            // 
            this.txtCurrentSpeed.Enabled = false;
            this.txtCurrentSpeed.Location = new System.Drawing.Point(262, 132);
            this.txtCurrentSpeed.Name = "txtCurrentSpeed";
            this.txtCurrentSpeed.Size = new System.Drawing.Size(84, 20);
            this.txtCurrentSpeed.TabIndex = 13;
            this.txtCurrentSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current Speed";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Enabled = false;
            this.txtMaxSpeed.Location = new System.Drawing.Point(94, 132);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(84, 20);
            this.txtMaxSpeed.TabIndex = 11;
            this.txtMaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clock Speed";
            // 
            // txtThreads
            // 
            this.txtThreads.Enabled = false;
            this.txtThreads.Location = new System.Drawing.Point(262, 80);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(84, 20);
            this.txtThreads.TabIndex = 9;
            this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Threads";
            // 
            // txtCores
            // 
            this.txtCores.Enabled = false;
            this.txtCores.Location = new System.Drawing.Point(94, 80);
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(84, 20);
            this.txtCores.TabIndex = 7;
            this.txtCores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manufacturer";
            // 
            // txtCPUManufacturer
            // 
            this.txtCPUManufacturer.Enabled = false;
            this.txtCPUManufacturer.Location = new System.Drawing.Point(94, 54);
            this.txtCPUManufacturer.Name = "txtCPUManufacturer";
            this.txtCPUManufacturer.Size = new System.Drawing.Size(252, 20);
            this.txtCPUManufacturer.TabIndex = 2;
            this.txtCPUManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtCPUName
            // 
            this.txtCPUName.Enabled = false;
            this.txtCPUName.Location = new System.Drawing.Point(94, 28);
            this.txtCPUName.Name = "txtCPUName";
            this.txtCPUName.Size = new System.Drawing.Size(252, 20);
            this.txtCPUName.TabIndex = 0;
            this.txtCPUName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(380, 355);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Memory";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 355);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cpuTimer
            // 
            this.cpuTimer.Enabled = true;
            this.cpuTimer.Interval = 1000;
            // 
            // ezCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 405);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ezCPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ezCPU";
            this.Load += new System.EventHandler(this.ezCPU_Load);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer cpuTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCPUManufacturer;
        public System.Windows.Forms.TextBox txtCPUName;
        public System.Windows.Forms.TextBox txtCores;
        public System.Windows.Forms.TextBox txtThreads;
        public System.Windows.Forms.TextBox txtMaxSpeed;
        public System.Windows.Forms.TextBox txtCurrentSpeed;
        public System.Windows.Forms.TextBox txtCaption;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.TextBox txtArchitecture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGPUName;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtGPUManufacturer;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtGPUVideoMode;
        public System.Windows.Forms.TextBox txtGPUStatus;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtGPURefresh;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtGPUDriverVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtMBManufacturer;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtMBModel;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtMBSerial;
        public System.Windows.Forms.TextBox txtMBStatus;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtMBBusType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtBIOSDate;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtBIOSVersion;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txtBIOSBrand;
    }
}

