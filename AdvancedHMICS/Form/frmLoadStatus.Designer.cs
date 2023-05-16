namespace AdvancedHMICS
{
    partial class frmLoadStatus
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grLoadList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbR16 = new AdvancedHMIControls.CheckBox();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.cbR15 = new AdvancedHMIControls.CheckBox();
            this.cbR14 = new AdvancedHMIControls.CheckBox();
            this.cbR13 = new AdvancedHMIControls.CheckBox();
            this.cbR12 = new AdvancedHMIControls.CheckBox();
            this.cbR11 = new AdvancedHMIControls.CheckBox();
            this.cbR10 = new AdvancedHMIControls.CheckBox();
            this.cbR9 = new AdvancedHMIControls.CheckBox();
            this.cbR8 = new AdvancedHMIControls.CheckBox();
            this.cbR7 = new AdvancedHMIControls.CheckBox();
            this.cbR6 = new AdvancedHMIControls.CheckBox();
            this.cbR5 = new AdvancedHMIControls.CheckBox();
            this.cbR4 = new AdvancedHMIControls.CheckBox();
            this.cbR3 = new AdvancedHMIControls.CheckBox();
            this.cbR2 = new AdvancedHMIControls.CheckBox();
            this.cbR1 = new AdvancedHMIControls.CheckBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKills = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelfTest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.grLoadList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Controls.Add(this.grLoadList, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // grLoadList
            // 
            this.grLoadList.Controls.Add(this.tableLayoutPanel2);
            this.grLoadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLoadList.Location = new System.Drawing.Point(3, 3);
            this.grLoadList.Name = "grLoadList";
            this.grLoadList.Size = new System.Drawing.Size(794, 384);
            this.grLoadList.TabIndex = 2;
            this.grLoadList.TabStop = false;
            this.grLoadList.Text = "Load list";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.cbR16, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR12, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 363);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cbR16
            // 
            this.cbR16.AutoSize = true;
            this.cbR16.ComComponent = this.modbusRTUCom1;
            this.cbR16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR16.Location = new System.Drawing.Point(594, 273);
            this.cbR16.Name = "cbR16";
            this.cbR16.PLCAddressCheckChanged = "00016";
            this.cbR16.PLCAddressChecked = "";
            this.cbR16.PLCAddressText = "";
            this.cbR16.PLCAddressVisible = "";
            this.cbR16.Size = new System.Drawing.Size(191, 87);
            this.cbR16.TabIndex = 16;
            this.cbR16.Tag = "0";
            this.cbR16.Text = "Load16 = 0 W";
            this.cbR16.UseVisualStyleBackColor = true;
            this.cbR16.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // modbusRTUCom1
            // 
            this.modbusRTUCom1.BaudRate = 9600;
            this.modbusRTUCom1.DataBits = 8;
            this.modbusRTUCom1.DisableSubscriptions = false;
            this.modbusRTUCom1.EnableLogging = false;
            this.modbusRTUCom1.IniFileName = "";
            this.modbusRTUCom1.IniFileSection = null;
            this.modbusRTUCom1.MaxReadGroupSize = 20;
            this.modbusRTUCom1.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom1.PollRateOverride = 500;
            this.modbusRTUCom1.PortName = "COM3";
            this.modbusRTUCom1.StationAddress = ((byte)(1));
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 3000;
            // 
            // cbR15
            // 
            this.cbR15.AutoSize = true;
            this.cbR15.ComComponent = this.modbusRTUCom1;
            this.cbR15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR15.Location = new System.Drawing.Point(397, 273);
            this.cbR15.Name = "cbR15";
            this.cbR15.PLCAddressCheckChanged = "00015";
            this.cbR15.PLCAddressChecked = "";
            this.cbR15.PLCAddressText = "";
            this.cbR15.PLCAddressVisible = "";
            this.cbR15.Size = new System.Drawing.Size(191, 87);
            this.cbR15.TabIndex = 15;
            this.cbR15.Tag = "0";
            this.cbR15.Text = "Load15 = 0 W";
            this.cbR15.UseVisualStyleBackColor = true;
            this.cbR15.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR14
            // 
            this.cbR14.AutoSize = true;
            this.cbR14.ComComponent = this.modbusRTUCom1;
            this.cbR14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR14.Location = new System.Drawing.Point(200, 273);
            this.cbR14.Name = "cbR14";
            this.cbR14.PLCAddressCheckChanged = "00014";
            this.cbR14.PLCAddressChecked = "";
            this.cbR14.PLCAddressText = "";
            this.cbR14.PLCAddressVisible = "";
            this.cbR14.Size = new System.Drawing.Size(191, 87);
            this.cbR14.TabIndex = 14;
            this.cbR14.Tag = "4000";
            this.cbR14.Text = "Load14 = 4000 W";
            this.cbR14.UseVisualStyleBackColor = true;
            this.cbR14.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR13
            // 
            this.cbR13.AutoSize = true;
            this.cbR13.ComComponent = this.modbusRTUCom1;
            this.cbR13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR13.Location = new System.Drawing.Point(3, 273);
            this.cbR13.Name = "cbR13";
            this.cbR13.PLCAddressCheckChanged = "00013";
            this.cbR13.PLCAddressChecked = "";
            this.cbR13.PLCAddressText = "";
            this.cbR13.PLCAddressVisible = "";
            this.cbR13.Size = new System.Drawing.Size(191, 87);
            this.cbR13.TabIndex = 13;
            this.cbR13.Tag = "4000";
            this.cbR13.Text = "Load13 = 4000 W";
            this.cbR13.UseVisualStyleBackColor = true;
            this.cbR13.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR12
            // 
            this.cbR12.AutoSize = true;
            this.cbR12.ComComponent = this.modbusRTUCom1;
            this.cbR12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR12.Location = new System.Drawing.Point(594, 183);
            this.cbR12.Name = "cbR12";
            this.cbR12.PLCAddressCheckChanged = "00012";
            this.cbR12.PLCAddressChecked = "";
            this.cbR12.PLCAddressText = "";
            this.cbR12.PLCAddressVisible = "";
            this.cbR12.Size = new System.Drawing.Size(191, 84);
            this.cbR12.TabIndex = 12;
            this.cbR12.Tag = "4000";
            this.cbR12.Text = "Load12 = 4000 W";
            this.cbR12.UseVisualStyleBackColor = true;
            this.cbR12.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR11
            // 
            this.cbR11.AutoSize = true;
            this.cbR11.ComComponent = this.modbusRTUCom1;
            this.cbR11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR11.Location = new System.Drawing.Point(397, 183);
            this.cbR11.Name = "cbR11";
            this.cbR11.PLCAddressCheckChanged = "00011";
            this.cbR11.PLCAddressChecked = "";
            this.cbR11.PLCAddressText = "";
            this.cbR11.PLCAddressVisible = "";
            this.cbR11.Size = new System.Drawing.Size(191, 84);
            this.cbR11.TabIndex = 11;
            this.cbR11.Tag = "4000";
            this.cbR11.Text = "Load11 = 4000 W";
            this.cbR11.UseVisualStyleBackColor = true;
            this.cbR11.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR10
            // 
            this.cbR10.AutoSize = true;
            this.cbR10.ComComponent = this.modbusRTUCom1;
            this.cbR10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR10.Location = new System.Drawing.Point(200, 183);
            this.cbR10.Name = "cbR10";
            this.cbR10.PLCAddressCheckChanged = "00010";
            this.cbR10.PLCAddressChecked = "";
            this.cbR10.PLCAddressText = "";
            this.cbR10.PLCAddressVisible = "";
            this.cbR10.Size = new System.Drawing.Size(191, 84);
            this.cbR10.TabIndex = 10;
            this.cbR10.Tag = "2000";
            this.cbR10.Text = "Load10 = 2000 W";
            this.cbR10.UseVisualStyleBackColor = true;
            this.cbR10.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR9
            // 
            this.cbR9.AutoSize = true;
            this.cbR9.ComComponent = this.modbusRTUCom1;
            this.cbR9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR9.Location = new System.Drawing.Point(3, 183);
            this.cbR9.Name = "cbR9";
            this.cbR9.PLCAddressCheckChanged = "00009";
            this.cbR9.PLCAddressChecked = "";
            this.cbR9.PLCAddressText = "";
            this.cbR9.PLCAddressVisible = "";
            this.cbR9.Size = new System.Drawing.Size(191, 84);
            this.cbR9.TabIndex = 9;
            this.cbR9.Tag = "1280";
            this.cbR9.Text = "Load9 = 1280 W";
            this.cbR9.UseVisualStyleBackColor = true;
            this.cbR9.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR8
            // 
            this.cbR8.AutoSize = true;
            this.cbR8.ComComponent = this.modbusRTUCom1;
            this.cbR8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR8.Location = new System.Drawing.Point(594, 93);
            this.cbR8.Name = "cbR8";
            this.cbR8.PLCAddressCheckChanged = "00008";
            this.cbR8.PLCAddressChecked = "";
            this.cbR8.PLCAddressText = "";
            this.cbR8.PLCAddressVisible = "";
            this.cbR8.Size = new System.Drawing.Size(191, 84);
            this.cbR8.TabIndex = 8;
            this.cbR8.Tag = "640";
            this.cbR8.Text = "Load8 = 640 W";
            this.cbR8.UseVisualStyleBackColor = true;
            this.cbR8.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR7
            // 
            this.cbR7.AutoSize = true;
            this.cbR7.ComComponent = this.modbusRTUCom1;
            this.cbR7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR7.Location = new System.Drawing.Point(397, 93);
            this.cbR7.Name = "cbR7";
            this.cbR7.PLCAddressCheckChanged = "00007";
            this.cbR7.PLCAddressChecked = "";
            this.cbR7.PLCAddressText = "";
            this.cbR7.PLCAddressVisible = "";
            this.cbR7.Size = new System.Drawing.Size(191, 84);
            this.cbR7.TabIndex = 7;
            this.cbR7.Tag = "320";
            this.cbR7.Text = "Load7 = 320 W";
            this.cbR7.UseVisualStyleBackColor = true;
            this.cbR7.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR6
            // 
            this.cbR6.AutoSize = true;
            this.cbR6.ComComponent = this.modbusRTUCom1;
            this.cbR6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR6.Location = new System.Drawing.Point(200, 93);
            this.cbR6.Name = "cbR6";
            this.cbR6.PLCAddressCheckChanged = "00006";
            this.cbR6.PLCAddressChecked = "";
            this.cbR6.PLCAddressText = "";
            this.cbR6.PLCAddressVisible = "";
            this.cbR6.Size = new System.Drawing.Size(191, 84);
            this.cbR6.TabIndex = 6;
            this.cbR6.Tag = "160";
            this.cbR6.Text = "Load6 = 160 W";
            this.cbR6.UseVisualStyleBackColor = true;
            this.cbR6.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR5
            // 
            this.cbR5.AutoSize = true;
            this.cbR5.ComComponent = this.modbusRTUCom1;
            this.cbR5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR5.Location = new System.Drawing.Point(3, 93);
            this.cbR5.Name = "cbR5";
            this.cbR5.PLCAddressCheckChanged = "00005";
            this.cbR5.PLCAddressChecked = "";
            this.cbR5.PLCAddressText = "";
            this.cbR5.PLCAddressVisible = "";
            this.cbR5.Size = new System.Drawing.Size(191, 84);
            this.cbR5.TabIndex = 5;
            this.cbR5.Tag = "80";
            this.cbR5.Text = "Load5 = 80 W";
            this.cbR5.UseVisualStyleBackColor = true;
            this.cbR5.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR4
            // 
            this.cbR4.AutoSize = true;
            this.cbR4.ComComponent = this.modbusRTUCom1;
            this.cbR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR4.Location = new System.Drawing.Point(594, 3);
            this.cbR4.Name = "cbR4";
            this.cbR4.PLCAddressCheckChanged = "00004";
            this.cbR4.PLCAddressChecked = "";
            this.cbR4.PLCAddressText = "";
            this.cbR4.PLCAddressVisible = "";
            this.cbR4.Size = new System.Drawing.Size(191, 84);
            this.cbR4.TabIndex = 4;
            this.cbR4.Tag = "40";
            this.cbR4.Text = "Load4 = 40 W";
            this.cbR4.UseVisualStyleBackColor = true;
            this.cbR4.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR3
            // 
            this.cbR3.AutoSize = true;
            this.cbR3.ComComponent = this.modbusRTUCom1;
            this.cbR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR3.Location = new System.Drawing.Point(397, 3);
            this.cbR3.Name = "cbR3";
            this.cbR3.PLCAddressCheckChanged = "00003";
            this.cbR3.PLCAddressChecked = "";
            this.cbR3.PLCAddressText = "";
            this.cbR3.PLCAddressVisible = "";
            this.cbR3.Size = new System.Drawing.Size(191, 84);
            this.cbR3.TabIndex = 3;
            this.cbR3.Tag = "20";
            this.cbR3.Text = "Load3 = 20 W";
            this.cbR3.UseVisualStyleBackColor = true;
            this.cbR3.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR2
            // 
            this.cbR2.AutoSize = true;
            this.cbR2.ComComponent = this.modbusRTUCom1;
            this.cbR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR2.Location = new System.Drawing.Point(200, 3);
            this.cbR2.Name = "cbR2";
            this.cbR2.PLCAddressCheckChanged = "00002";
            this.cbR2.PLCAddressChecked = "";
            this.cbR2.PLCAddressText = "";
            this.cbR2.PLCAddressVisible = "";
            this.cbR2.Size = new System.Drawing.Size(191, 84);
            this.cbR2.TabIndex = 2;
            this.cbR2.Tag = "10";
            this.cbR2.Text = "Load2 = 10 W";
            this.cbR2.UseVisualStyleBackColor = true;
            this.cbR2.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR1
            // 
            this.cbR1.AutoSize = true;
            this.cbR1.ComComponent = this.modbusRTUCom1;
            this.cbR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR1.Location = new System.Drawing.Point(3, 3);
            this.cbR1.Name = "cbR1";
            this.cbR1.PLCAddressCheckChanged = "00001";
            this.cbR1.PLCAddressChecked = "";
            this.cbR1.PLCAddressText = "";
            this.cbR1.PLCAddressVisible = "";
            this.cbR1.Size = new System.Drawing.Size(191, 84);
            this.cbR1.TabIndex = 1;
            this.cbR1.Tag = "5";
            this.cbR1.Text = "Load1 = 5 W";
            this.cbR1.UseVisualStyleBackColor = true;
            this.cbR1.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 7;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.Controls.Add(this.btnClose, 6, 0);
            this.tlpButtons.Controls.Add(this.btnKills, 5, 0);
            this.tlpButtons.Controls.Add(this.btnAll, 4, 0);
            this.tlpButtons.Controls.Add(this.btnClear, 2, 0);
            this.tlpButtons.Controls.Add(this.btnSelfTest, 3, 0);
            this.tlpButtons.Controls.Add(this.lblStatus, 0, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 393);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(794, 54);
            this.tlpButtons.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(698, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKills
            // 
            this.btnKills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKills.Location = new System.Drawing.Point(599, 3);
            this.btnKills.Name = "btnKills";
            this.btnKills.Size = new System.Drawing.Size(93, 48);
            this.btnKills.TabIndex = 3;
            this.btnKills.Text = "All kill";
            this.btnKills.UseVisualStyleBackColor = true;
            this.btnKills.Click += new System.EventHandler(this.btnKills_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(500, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(93, 48);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All bright";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(302, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 48);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear s-test";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelfTest
            // 
            this.btnSelfTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelfTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfTest.Location = new System.Drawing.Point(401, 3);
            this.btnSelfTest.Name = "btnSelfTest";
            this.btnSelfTest.Size = new System.Drawing.Size(93, 48);
            this.btnSelfTest.TabIndex = 1;
            this.btnSelfTest.Text = "Self-test";
            this.btnSelfTest.UseVisualStyleBackColor = true;
            this.btnSelfTest.Click += new System.EventHandler(this.btnSelfTest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(194, 54);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "POWER: 0 W";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(203, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLoadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Name = "frmLoadStatus";
            this.Text = "Load Debug";
            this.tlpMain.ResumeLayout(false);
            this.grLoadList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grLoadList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private AdvancedHMIControls.CheckBox cbR1;
        private AdvancedHMIControls.CheckBox cbR16;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private AdvancedHMIControls.CheckBox cbR15;
        private AdvancedHMIControls.CheckBox cbR14;
        private AdvancedHMIControls.CheckBox cbR13;
        private AdvancedHMIControls.CheckBox cbR12;
        private AdvancedHMIControls.CheckBox cbR11;
        private AdvancedHMIControls.CheckBox cbR10;
        private AdvancedHMIControls.CheckBox cbR9;
        private AdvancedHMIControls.CheckBox cbR8;
        private AdvancedHMIControls.CheckBox cbR7;
        private AdvancedHMIControls.CheckBox cbR6;
        private AdvancedHMIControls.CheckBox cbR5;
        private AdvancedHMIControls.CheckBox cbR4;
        private AdvancedHMIControls.CheckBox cbR3;
        private AdvancedHMIControls.CheckBox cbR2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKills;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelfTest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
    }
}