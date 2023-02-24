
namespace AdvancedHMICS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.modbusRTUCom2 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.modbusRTUCom3 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_settingorder = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn_modelSetting = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btn_querysqlite = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_DBSetting = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.avd_machanicalP = new AdvancedHMIControls.AnalogValueDisplay();
            this.modbusRTUCom4 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.avd_FWcurr = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_frequency = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_rotspdwav = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_rotspdmod = new AdvancedHMIControls.AnalogValueDisplay();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.avd_torque = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_DCpower = new AdvancedHMIControls.AnalogValueDisplay();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_speedrpm = new System.Windows.Forms.Label();
            this.avd_voltage = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_FWVolt = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_electricP = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_current = new AdvancedHMIControls.AnalogValueDisplay();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom4)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.modbusRTUCom1.PortName = "COM4";
            this.modbusRTUCom1.StationAddress = ((byte)(1));
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 3000;
            // 
            // modbusRTUCom2
            // 
            this.modbusRTUCom2.BaudRate = 19200;
            this.modbusRTUCom2.DataBits = 8;
            this.modbusRTUCom2.DisableSubscriptions = false;
            this.modbusRTUCom2.EnableLogging = false;
            this.modbusRTUCom2.IniFileName = "";
            this.modbusRTUCom2.IniFileSection = null;
            this.modbusRTUCom2.MaxReadGroupSize = 20;
            this.modbusRTUCom2.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom2.PollRateOverride = 500;
            this.modbusRTUCom2.PortName = "COM1";
            this.modbusRTUCom2.StationAddress = ((byte)(1));
            this.modbusRTUCom2.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom2.SwapBytes = true;
            this.modbusRTUCom2.SwapWords = false;
            this.modbusRTUCom2.TimeOut = 3000;
            // 
            // modbusRTUCom3
            // 
            this.modbusRTUCom3.BaudRate = 19200;
            this.modbusRTUCom3.DataBits = 8;
            this.modbusRTUCom3.DisableSubscriptions = false;
            this.modbusRTUCom3.EnableLogging = false;
            this.modbusRTUCom3.IniFileName = "";
            this.modbusRTUCom3.IniFileSection = null;
            this.modbusRTUCom3.MaxReadGroupSize = 20;
            this.modbusRTUCom3.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom3.PollRateOverride = 500;
            this.modbusRTUCom3.PortName = "COM1";
            this.modbusRTUCom3.StationAddress = ((byte)(1));
            this.modbusRTUCom3.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom3.SwapBytes = true;
            this.modbusRTUCom3.SwapWords = false;
            this.modbusRTUCom3.TimeOut = 3000;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1309, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AdvancedHMICS.Properties.Resources.ifmbigsize;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 654);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.9975F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00249F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1303, 654);
            this.tableLayoutPanel2.TabIndex = 71;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.btn_settingorder);
            this.panel7.Controls.Add(this.button20);
            this.panel7.Controls.Add(this.btn_modelSetting);
            this.panel7.Controls.Add(this.button22);
            this.panel7.Controls.Add(this.btn_querysqlite);
            this.panel7.Controls.Add(this.button18);
            this.panel7.Controls.Add(this.button16);
            this.panel7.Controls.Add(this.btn_DBSetting);
            this.panel7.Controls.Add(this.button14);
            this.panel7.Controls.Add(this.btn_user);
            this.panel7.Controls.Add(this.button12);
            this.panel7.Controls.Add(this.button11);
            this.panel7.Controls.Add(this.button10);
            this.panel7.Controls.Add(this.button9);
            this.panel7.Controls.Add(this.button8);
            this.panel7.Controls.Add(this.button7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(854, 517);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(446, 134);
            this.panel7.TabIndex = 79;
            // 
            // btn_settingorder
            // 
            this.btn_settingorder.BackColor = System.Drawing.Color.Yellow;
            this.btn_settingorder.Location = new System.Drawing.Point(341, 41);
            this.btn_settingorder.Name = "btn_settingorder";
            this.btn_settingorder.Size = new System.Drawing.Size(97, 25);
            this.btn_settingorder.TabIndex = 15;
            this.btn_settingorder.Text = "Setting Order";
            this.btn_settingorder.UseVisualStyleBackColor = false;
            this.btn_settingorder.Click += new System.EventHandler(this.btn_settingorder_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(341, 11);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(97, 25);
            this.button20.TabIndex = 14;
            this.button20.Text = "Export";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // btn_modelSetting
            // 
            this.btn_modelSetting.BackColor = System.Drawing.Color.Green;
            this.btn_modelSetting.Location = new System.Drawing.Point(230, 41);
            this.btn_modelSetting.Name = "btn_modelSetting";
            this.btn_modelSetting.Size = new System.Drawing.Size(97, 25);
            this.btn_modelSetting.TabIndex = 13;
            this.btn_modelSetting.Text = "Setting Model";
            this.btn_modelSetting.UseVisualStyleBackColor = false;
            this.btn_modelSetting.Click += new System.EventHandler(this.btn_modelSetting_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(230, 11);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(97, 25);
            this.button22.TabIndex = 12;
            this.button22.Text = "Clear";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // btn_querysqlite
            // 
            this.btn_querysqlite.BackColor = System.Drawing.Color.Green;
            this.btn_querysqlite.Location = new System.Drawing.Point(341, 101);
            this.btn_querysqlite.Name = "btn_querysqlite";
            this.btn_querysqlite.Size = new System.Drawing.Size(97, 25);
            this.btn_querysqlite.TabIndex = 11;
            this.btn_querysqlite.Text = "QuerySQLite";
            this.btn_querysqlite.UseVisualStyleBackColor = false;
            this.btn_querysqlite.Click += new System.EventHandler(this.btn_querysqlite_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(341, 73);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(97, 25);
            this.button18.TabIndex = 10;
            this.button18.Text = "Setting Machine";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Yellow;
            this.button16.Location = new System.Drawing.Point(230, 101);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 25);
            this.button16.TabIndex = 9;
            this.button16.Text = "Cap Status";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // btn_DBSetting
            // 
            this.btn_DBSetting.Location = new System.Drawing.Point(230, 73);
            this.btn_DBSetting.Name = "btn_DBSetting";
            this.btn_DBSetting.Size = new System.Drawing.Size(97, 25);
            this.btn_DBSetting.TabIndex = 8;
            this.btn_DBSetting.Text = "Setting DB";
            this.btn_DBSetting.UseVisualStyleBackColor = true;
            this.btn_DBSetting.Click += new System.EventHandler(this.btn_DBSetting_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Yellow;
            this.button14.Location = new System.Drawing.Point(116, 102);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(97, 25);
            this.button14.TabIndex = 7;
            this.button14.Text = "Com Status";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(116, 73);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(97, 25);
            this.btn_user.TabIndex = 6;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(116, 42);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(97, 25);
            this.button12.TabIndex = 5;
            this.button12.Text = "Auto/Manual";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(116, 11);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 25);
            this.button11.TabIndex = 4;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Yellow;
            this.button10.Location = new System.Drawing.Point(3, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 25);
            this.button10.TabIndex = 3;
            this.button10.Text = "PLC Status";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 73);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 25);
            this.button9.TabIndex = 2;
            this.button9.Text = "Start/Run";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 25);
            this.button8.TabIndex = 1;
            this.button8.Text = "Data";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 25);
            this.button7.TabIndex = 0;
            this.button7.Text = "Record";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.label63);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(454, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 134);
            this.panel3.TabIndex = 78;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 65;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 64;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(13, 76);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(70, 20);
            this.label46.TabIndex = 63;
            this.label46.Text = "Order ID";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(13, 45);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 20);
            this.label45.TabIndex = 62;
            this.label45.Text = "Barcode";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(10, 15);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(110, 20);
            this.label63.TabIndex = 61;
            this.label63.Text = "Test Standard";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.avd_machanicalP);
            this.panel5.Controls.Add(this.avd_FWcurr);
            this.panel5.Controls.Add(this.avd_frequency);
            this.panel5.Controls.Add(this.avd_rotspdwav);
            this.panel5.Controls.Add(this.avd_rotspdmod);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(854, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 224);
            this.panel5.TabIndex = 73;
            // 
            // avd_machanicalP
            // 
            this.avd_machanicalP.AutoSize = true;
            this.avd_machanicalP.ComComponent = this.modbusRTUCom4;
            this.avd_machanicalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_machanicalP.ForeColor = System.Drawing.Color.Yellow;
            this.avd_machanicalP.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_machanicalP.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_machanicalP.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_machanicalP.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_machanicalP.KeypadMaxValue = 0D;
            this.avd_machanicalP.KeypadMinValue = 0D;
            this.avd_machanicalP.KeypadPasscode = null;
            this.avd_machanicalP.KeypadScaleFactor = 1D;
            this.avd_machanicalP.KeypadText = null;
            this.avd_machanicalP.KeypadWidth = 300;
            this.avd_machanicalP.Location = new System.Drawing.Point(196, 177);
            this.avd_machanicalP.Name = "avd_machanicalP";
            this.avd_machanicalP.NumericFormat = null;
            this.avd_machanicalP.PLCAddressKeypad = "";
            this.avd_machanicalP.PLCAddressValue = null;
            this.avd_machanicalP.PLCAddressValueLimitLower = null;
            this.avd_machanicalP.PLCAddressValueLimitUpper = null;
            this.avd_machanicalP.PLCAddressVisible = null;
            this.avd_machanicalP.ShowValue = true;
            this.avd_machanicalP.Size = new System.Drawing.Size(95, 42);
            this.avd_machanicalP.TabIndex = 78;
            this.avd_machanicalP.Text = "0.00";
            this.avd_machanicalP.Value = "0.00";
            this.avd_machanicalP.ValueLimitLower = 2900D;
            this.avd_machanicalP.ValueLimitUpper = 3600D;
            this.avd_machanicalP.ValuePrefix = null;
            this.avd_machanicalP.ValueSuffix = null;
            this.avd_machanicalP.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // modbusRTUCom4
            // 
            this.modbusRTUCom4.BaudRate = 9600;
            this.modbusRTUCom4.DataBits = 8;
            this.modbusRTUCom4.DisableSubscriptions = false;
            this.modbusRTUCom4.EnableLogging = false;
            this.modbusRTUCom4.IniFileName = "";
            this.modbusRTUCom4.IniFileSection = null;
            this.modbusRTUCom4.MaxReadGroupSize = 32;
            this.modbusRTUCom4.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom4.PollRateOverride = 100;
            this.modbusRTUCom4.PortName = "COM4";
            this.modbusRTUCom4.StationAddress = ((byte)(1));
            this.modbusRTUCom4.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom4.SwapBytes = true;
            this.modbusRTUCom4.SwapWords = false;
            this.modbusRTUCom4.TimeOut = 1000;
            // 
            // avd_FWcurr
            // 
            this.avd_FWcurr.AutoSize = true;
            this.avd_FWcurr.ComComponent = this.modbusRTUCom4;
            this.avd_FWcurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_FWcurr.ForeColor = System.Drawing.Color.Yellow;
            this.avd_FWcurr.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_FWcurr.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_FWcurr.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_FWcurr.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_FWcurr.KeypadMaxValue = 0D;
            this.avd_FWcurr.KeypadMinValue = 0D;
            this.avd_FWcurr.KeypadPasscode = null;
            this.avd_FWcurr.KeypadScaleFactor = 1D;
            this.avd_FWcurr.KeypadText = null;
            this.avd_FWcurr.KeypadWidth = 300;
            this.avd_FWcurr.Location = new System.Drawing.Point(196, 135);
            this.avd_FWcurr.Name = "avd_FWcurr";
            this.avd_FWcurr.NumericFormat = null;
            this.avd_FWcurr.PLCAddressKeypad = "";
            this.avd_FWcurr.PLCAddressValue = null;
            this.avd_FWcurr.PLCAddressValueLimitLower = null;
            this.avd_FWcurr.PLCAddressValueLimitUpper = null;
            this.avd_FWcurr.PLCAddressVisible = null;
            this.avd_FWcurr.ShowValue = true;
            this.avd_FWcurr.Size = new System.Drawing.Size(95, 42);
            this.avd_FWcurr.TabIndex = 77;
            this.avd_FWcurr.Text = "0.00";
            this.avd_FWcurr.Value = "0.00";
            this.avd_FWcurr.ValueLimitLower = 2900D;
            this.avd_FWcurr.ValueLimitUpper = 3600D;
            this.avd_FWcurr.ValuePrefix = null;
            this.avd_FWcurr.ValueSuffix = null;
            this.avd_FWcurr.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_FWcurr.ValueChanged += new System.EventHandler(this.avd_FWcurr_ValueChanged);
            // 
            // avd_frequency
            // 
            this.avd_frequency.AutoSize = true;
            this.avd_frequency.ComComponent = this.modbusRTUCom4;
            this.avd_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_frequency.ForeColor = System.Drawing.Color.Yellow;
            this.avd_frequency.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_frequency.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_frequency.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_frequency.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_frequency.KeypadMaxValue = 0D;
            this.avd_frequency.KeypadMinValue = 0D;
            this.avd_frequency.KeypadPasscode = null;
            this.avd_frequency.KeypadScaleFactor = 1D;
            this.avd_frequency.KeypadText = null;
            this.avd_frequency.KeypadWidth = 300;
            this.avd_frequency.Location = new System.Drawing.Point(196, 91);
            this.avd_frequency.Name = "avd_frequency";
            this.avd_frequency.NumericFormat = null;
            this.avd_frequency.PLCAddressKeypad = "";
            this.avd_frequency.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_frequency.PLCAddressValue")));
            this.avd_frequency.PLCAddressValueLimitLower = null;
            this.avd_frequency.PLCAddressValueLimitUpper = null;
            this.avd_frequency.PLCAddressVisible = null;
            this.avd_frequency.ShowValue = true;
            this.avd_frequency.Size = new System.Drawing.Size(95, 42);
            this.avd_frequency.TabIndex = 76;
            this.avd_frequency.Text = "0.00";
            this.avd_frequency.Value = "0.00";
            this.avd_frequency.ValueLimitLower = 2900D;
            this.avd_frequency.ValueLimitUpper = 3600D;
            this.avd_frequency.ValuePrefix = null;
            this.avd_frequency.ValueSuffix = null;
            this.avd_frequency.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_frequency.ValueChanged += new System.EventHandler(this.avd_frequency_ValueChanged);
            // 
            // avd_rotspdwav
            // 
            this.avd_rotspdwav.AutoSize = true;
            this.avd_rotspdwav.ComComponent = this.modbusRTUCom4;
            this.avd_rotspdwav.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_rotspdwav.ForeColor = System.Drawing.Color.Yellow;
            this.avd_rotspdwav.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_rotspdwav.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_rotspdwav.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_rotspdwav.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_rotspdwav.KeypadMaxValue = 0D;
            this.avd_rotspdwav.KeypadMinValue = 0D;
            this.avd_rotspdwav.KeypadPasscode = null;
            this.avd_rotspdwav.KeypadScaleFactor = 1D;
            this.avd_rotspdwav.KeypadText = null;
            this.avd_rotspdwav.KeypadWidth = 300;
            this.avd_rotspdwav.Location = new System.Drawing.Point(196, 47);
            this.avd_rotspdwav.Name = "avd_rotspdwav";
            this.avd_rotspdwav.NumericFormat = null;
            this.avd_rotspdwav.PLCAddressKeypad = "";
            this.avd_rotspdwav.PLCAddressValue = null;
            this.avd_rotspdwav.PLCAddressValueLimitLower = null;
            this.avd_rotspdwav.PLCAddressValueLimitUpper = null;
            this.avd_rotspdwav.PLCAddressVisible = null;
            this.avd_rotspdwav.ShowValue = true;
            this.avd_rotspdwav.Size = new System.Drawing.Size(95, 42);
            this.avd_rotspdwav.TabIndex = 75;
            this.avd_rotspdwav.Text = "0.00";
            this.avd_rotspdwav.Value = "0.00";
            this.avd_rotspdwav.ValueLimitLower = 2900D;
            this.avd_rotspdwav.ValueLimitUpper = 3600D;
            this.avd_rotspdwav.ValuePrefix = null;
            this.avd_rotspdwav.ValueSuffix = null;
            this.avd_rotspdwav.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_rotspdmod
            // 
            this.avd_rotspdmod.AutoSize = true;
            this.avd_rotspdmod.ComComponent = this.modbusRTUCom4;
            this.avd_rotspdmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_rotspdmod.ForeColor = System.Drawing.Color.Yellow;
            this.avd_rotspdmod.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_rotspdmod.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_rotspdmod.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_rotspdmod.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_rotspdmod.KeypadMaxValue = 0D;
            this.avd_rotspdmod.KeypadMinValue = 0D;
            this.avd_rotspdmod.KeypadPasscode = null;
            this.avd_rotspdmod.KeypadScaleFactor = 1D;
            this.avd_rotspdmod.KeypadText = null;
            this.avd_rotspdmod.KeypadWidth = 300;
            this.avd_rotspdmod.Location = new System.Drawing.Point(196, 3);
            this.avd_rotspdmod.Name = "avd_rotspdmod";
            this.avd_rotspdmod.NumericFormat = null;
            this.avd_rotspdmod.PLCAddressKeypad = "";
            this.avd_rotspdmod.PLCAddressValue = null;
            this.avd_rotspdmod.PLCAddressValueLimitLower = null;
            this.avd_rotspdmod.PLCAddressValueLimitUpper = null;
            this.avd_rotspdmod.PLCAddressVisible = null;
            this.avd_rotspdmod.ShowValue = true;
            this.avd_rotspdmod.Size = new System.Drawing.Size(95, 42);
            this.avd_rotspdmod.TabIndex = 74;
            this.avd_rotspdmod.Text = "0.00";
            this.avd_rotspdmod.Value = "0.00";
            this.avd_rotspdmod.ValueLimitLower = 2900D;
            this.avd_rotspdmod.ValueLimitUpper = 3600D;
            this.avd_rotspdmod.ValuePrefix = null;
            this.avd_rotspdmod.ValueSuffix = null;
            this.avd_rotspdmod.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(333, 192);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 25);
            this.label27.TabIndex = 73;
            this.label27.Text = "Kw";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(333, 152);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 25);
            this.label28.TabIndex = 72;
            this.label28.Text = "A";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(333, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 25);
            this.label29.TabIndex = 69;
            this.label29.Text = "%";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(333, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 25);
            this.label30.TabIndex = 71;
            this.label30.Text = "Hz";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(333, 62);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 25);
            this.label31.TabIndex = 70;
            this.label31.Text = "%";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Red;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 192);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(142, 25);
            this.label32.TabIndex = 68;
            this.label32.Text = "Mechanical P";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 152);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 25);
            this.label33.TabIndex = 67;
            this.label33.Text = "FW Curr";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Red;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(153, 25);
            this.label34.TabIndex = 61;
            this.label34.Text = "ROT Spd. mod";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 106);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(114, 25);
            this.label35.TabIndex = 66;
            this.label35.Text = "Frequency";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Red;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(8, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(150, 25);
            this.label36.TabIndex = 65;
            this.label36.Text = "ROT Spd. wav";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.avd_torque);
            this.panel4.Controls.Add(this.avd_DCpower);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(454, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 224);
            this.panel4.TabIndex = 72;
            // 
            // avd_torque
            // 
            this.avd_torque.AutoSize = true;
            this.avd_torque.ComComponent = this.modbusRTUCom4;
            this.avd_torque.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_torque.ForeColor = System.Drawing.Color.Yellow;
            this.avd_torque.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_torque.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_torque.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_torque.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_torque.KeypadMaxValue = 0D;
            this.avd_torque.KeypadMinValue = 0D;
            this.avd_torque.KeypadPasscode = null;
            this.avd_torque.KeypadScaleFactor = 1D;
            this.avd_torque.KeypadText = null;
            this.avd_torque.KeypadWidth = 300;
            this.avd_torque.Location = new System.Drawing.Point(174, 49);
            this.avd_torque.Name = "avd_torque";
            this.avd_torque.NumericFormat = null;
            this.avd_torque.PLCAddressKeypad = "";
            this.avd_torque.PLCAddressValue = null;
            this.avd_torque.PLCAddressValueLimitLower = null;
            this.avd_torque.PLCAddressValueLimitUpper = null;
            this.avd_torque.PLCAddressVisible = null;
            this.avd_torque.ShowValue = true;
            this.avd_torque.Size = new System.Drawing.Size(95, 42);
            this.avd_torque.TabIndex = 78;
            this.avd_torque.Text = "0.00";
            this.avd_torque.Value = "0.00";
            this.avd_torque.ValueLimitLower = 2900D;
            this.avd_torque.ValueLimitUpper = 3600D;
            this.avd_torque.ValuePrefix = null;
            this.avd_torque.ValueSuffix = null;
            this.avd_torque.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_DCpower
            // 
            this.avd_DCpower.AutoSize = true;
            this.avd_DCpower.ComComponent = this.modbusRTUCom4;
            this.avd_DCpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_DCpower.ForeColor = System.Drawing.Color.Yellow;
            this.avd_DCpower.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_DCpower.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_DCpower.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_DCpower.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_DCpower.KeypadMaxValue = 0D;
            this.avd_DCpower.KeypadMinValue = 0D;
            this.avd_DCpower.KeypadPasscode = null;
            this.avd_DCpower.KeypadScaleFactor = 1D;
            this.avd_DCpower.KeypadText = null;
            this.avd_DCpower.KeypadWidth = 300;
            this.avd_DCpower.Location = new System.Drawing.Point(174, 1);
            this.avd_DCpower.Name = "avd_DCpower";
            this.avd_DCpower.NumericFormat = null;
            this.avd_DCpower.PLCAddressKeypad = "";
            this.avd_DCpower.PLCAddressValue = null;
            this.avd_DCpower.PLCAddressValueLimitLower = null;
            this.avd_DCpower.PLCAddressValueLimitUpper = null;
            this.avd_DCpower.PLCAddressVisible = null;
            this.avd_DCpower.ShowValue = true;
            this.avd_DCpower.Size = new System.Drawing.Size(40, 42);
            this.avd_DCpower.TabIndex = 77;
            this.avd_DCpower.Text = "0";
            this.avd_DCpower.Value = "0";
            this.avd_DCpower.ValueLimitLower = 2900D;
            this.avd_DCpower.ValueLimitUpper = 3600D;
            this.avd_DCpower.ValuePrefix = null;
            this.avd_DCpower.ValueSuffix = null;
            this.avd_DCpower.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(335, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 25);
            this.label17.TabIndex = 73;
            this.label17.Text = "N.m";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(335, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 25);
            this.label18.TabIndex = 72;
            this.label18.Text = "W";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 25);
            this.label22.TabIndex = 68;
            this.label22.Text = "Torque";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 25);
            this.label23.TabIndex = 67;
            this.label23.Text = "DC Power";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_speedrpm);
            this.panel2.Controls.Add(this.avd_voltage);
            this.panel2.Controls.Add(this.avd_FWVolt);
            this.panel2.Controls.Add(this.avd_electricP);
            this.panel2.Controls.Add(this.avd_current);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 224);
            this.panel2.TabIndex = 69;
            // 
            // lbl_speedrpm
            // 
            this.lbl_speedrpm.AutoSize = true;
            this.lbl_speedrpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speedrpm.Location = new System.Drawing.Point(160, 171);
            this.lbl_speedrpm.Name = "lbl_speedrpm";
            this.lbl_speedrpm.Size = new System.Drawing.Size(95, 42);
            this.lbl_speedrpm.TabIndex = 80;
            this.lbl_speedrpm.Text = "0.00";
            this.lbl_speedrpm.TextChanged += new System.EventHandler(this.lbl_speedrpm_TextChanged);
            // 
            // avd_voltage
            // 
            this.avd_voltage.AutoSize = true;
            this.avd_voltage.ComComponent = this.modbusRTUCom4;
            this.avd_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_voltage.ForeColor = System.Drawing.Color.Yellow;
            this.avd_voltage.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_voltage.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_voltage.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_voltage.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_voltage.KeypadMaxValue = 0D;
            this.avd_voltage.KeypadMinValue = 0D;
            this.avd_voltage.KeypadPasscode = null;
            this.avd_voltage.KeypadScaleFactor = 1D;
            this.avd_voltage.KeypadText = null;
            this.avd_voltage.KeypadWidth = 300;
            this.avd_voltage.Location = new System.Drawing.Point(160, 4);
            this.avd_voltage.Name = "avd_voltage";
            this.avd_voltage.NumericFormat = null;
            this.avd_voltage.PLCAddressKeypad = "";
            this.avd_voltage.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_voltage.PLCAddressValue")));
            this.avd_voltage.PLCAddressValueLimitLower = null;
            this.avd_voltage.PLCAddressValueLimitUpper = null;
            this.avd_voltage.PLCAddressVisible = null;
            this.avd_voltage.ShowValue = true;
            this.avd_voltage.Size = new System.Drawing.Size(95, 42);
            this.avd_voltage.TabIndex = 79;
            this.avd_voltage.Text = "0.00";
            this.avd_voltage.Value = "0.00";
            this.avd_voltage.ValueLimitLower = 2900D;
            this.avd_voltage.ValueLimitUpper = 3600D;
            this.avd_voltage.ValuePrefix = null;
            this.avd_voltage.ValueSuffix = null;
            this.avd_voltage.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_FWVolt
            // 
            this.avd_FWVolt.AutoSize = true;
            this.avd_FWVolt.ComComponent = this.modbusRTUCom4;
            this.avd_FWVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_FWVolt.ForeColor = System.Drawing.Color.Yellow;
            this.avd_FWVolt.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_FWVolt.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_FWVolt.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_FWVolt.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_FWVolt.KeypadMaxValue = 0D;
            this.avd_FWVolt.KeypadMinValue = 0D;
            this.avd_FWVolt.KeypadPasscode = null;
            this.avd_FWVolt.KeypadScaleFactor = 1D;
            this.avd_FWVolt.KeypadText = null;
            this.avd_FWVolt.KeypadWidth = 300;
            this.avd_FWVolt.Location = new System.Drawing.Point(160, 131);
            this.avd_FWVolt.Name = "avd_FWVolt";
            this.avd_FWVolt.NumericFormat = null;
            this.avd_FWVolt.PLCAddressKeypad = "";
            this.avd_FWVolt.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_FWVolt.PLCAddressValue")));
            this.avd_FWVolt.PLCAddressValueLimitLower = null;
            this.avd_FWVolt.PLCAddressValueLimitUpper = null;
            this.avd_FWVolt.PLCAddressVisible = null;
            this.avd_FWVolt.ShowValue = true;
            this.avd_FWVolt.Size = new System.Drawing.Size(95, 42);
            this.avd_FWVolt.TabIndex = 77;
            this.avd_FWVolt.Text = "0.00";
            this.avd_FWVolt.Value = "0.00";
            this.avd_FWVolt.ValueLimitLower = 2900D;
            this.avd_FWVolt.ValueLimitUpper = 3600D;
            this.avd_FWVolt.ValuePrefix = null;
            this.avd_FWVolt.ValueSuffix = null;
            this.avd_FWVolt.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_FWVolt.ValueChanged += new System.EventHandler(this.avd_FWVolt_ValueChanged);
            // 
            // avd_electricP
            // 
            this.avd_electricP.AutoSize = true;
            this.avd_electricP.ComComponent = this.modbusRTUCom4;
            this.avd_electricP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_electricP.ForeColor = System.Drawing.Color.Yellow;
            this.avd_electricP.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_electricP.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_electricP.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_electricP.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_electricP.KeypadMaxValue = 0D;
            this.avd_electricP.KeypadMinValue = 0D;
            this.avd_electricP.KeypadPasscode = null;
            this.avd_electricP.KeypadScaleFactor = 1D;
            this.avd_electricP.KeypadText = null;
            this.avd_electricP.KeypadWidth = 300;
            this.avd_electricP.Location = new System.Drawing.Point(160, 88);
            this.avd_electricP.Name = "avd_electricP";
            this.avd_electricP.NumericFormat = null;
            this.avd_electricP.PLCAddressKeypad = "";
            this.avd_electricP.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_electricP.PLCAddressValue")));
            this.avd_electricP.PLCAddressValueLimitLower = null;
            this.avd_electricP.PLCAddressValueLimitUpper = null;
            this.avd_electricP.PLCAddressVisible = null;
            this.avd_electricP.ShowValue = true;
            this.avd_electricP.Size = new System.Drawing.Size(95, 42);
            this.avd_electricP.TabIndex = 76;
            this.avd_electricP.Text = "0.00";
            this.avd_electricP.Value = "0.00";
            this.avd_electricP.ValueLimitLower = 2900D;
            this.avd_electricP.ValueLimitUpper = 3600D;
            this.avd_electricP.ValuePrefix = null;
            this.avd_electricP.ValueSuffix = null;
            this.avd_electricP.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_current
            // 
            this.avd_current.AutoSize = true;
            this.avd_current.ComComponent = this.modbusRTUCom4;
            this.avd_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_current.ForeColor = System.Drawing.Color.Yellow;
            this.avd_current.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_current.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_current.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_current.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_current.KeypadMaxValue = 0D;
            this.avd_current.KeypadMinValue = 0D;
            this.avd_current.KeypadPasscode = null;
            this.avd_current.KeypadScaleFactor = 1D;
            this.avd_current.KeypadText = null;
            this.avd_current.KeypadWidth = 300;
            this.avd_current.Location = new System.Drawing.Point(160, 45);
            this.avd_current.Name = "avd_current";
            this.avd_current.NumericFormat = null;
            this.avd_current.PLCAddressKeypad = "";
            this.avd_current.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_current.PLCAddressValue")));
            this.avd_current.PLCAddressValueLimitLower = null;
            this.avd_current.PLCAddressValueLimitUpper = null;
            this.avd_current.PLCAddressVisible = null;
            this.avd_current.ShowValue = true;
            this.avd_current.Size = new System.Drawing.Size(95, 42);
            this.avd_current.TabIndex = 75;
            this.avd_current.Text = "0.00";
            this.avd_current.Value = "0.00";
            this.avd_current.ValueLimitLower = 2900D;
            this.avd_current.ValueLimitUpper = 3600D;
            this.avd_current.ValuePrefix = null;
            this.avd_current.ValueSuffix = null;
            this.avd_current.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 25);
            this.label12.TabIndex = 73;
            this.label12.Text = "rpm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(303, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 72;
            this.label13.Text = "V";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(303, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 25);
            this.label14.TabIndex = 69;
            this.label14.Text = "V";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(303, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 25);
            this.label15.TabIndex = 71;
            this.label15.Text = "kW";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(303, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 25);
            this.label16.TabIndex = 70;
            this.label16.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "ROT Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "FW Volt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Voltage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Electric P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Current";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label44);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.label38);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 517);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(445, 134);
            this.panel6.TabIndex = 75;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(83, 105);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(99, 20);
            this.label44.TabIndex = 84;
            this.label44.Text = "Auto/Manual";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(7, 105);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 20);
            this.label41.TabIndex = 83;
            this.label41.Text = "Status:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(353, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 20);
            this.label24.TabIndex = 82;
            this.label24.Text = "%";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(298, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 20);
            this.label26.TabIndex = 81;
            this.label26.Text = "0.00";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(222, 76);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(78, 20);
            this.label37.TabIndex = 80;
            this.label37.Text = "PID Stop:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(353, 45);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 20);
            this.label38.TabIndex = 79;
            this.label38.Text = "s";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(298, 45);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 20);
            this.label39.TabIndex = 78;
            this.label39.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(222, 45);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(76, 20);
            this.label40.TabIndex = 77;
            this.label40.Text = "Steady T:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(298, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 20);
            this.label42.TabIndex = 75;
            this.label42.Text = "0-5";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(222, 15);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 20);
            this.label43.TabIndex = 74;
            this.label43.Text = "PC Step: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(138, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 20);
            this.label19.TabIndex = 73;
            this.label19.Text = "kW";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(83, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 72;
            this.label20.Text = "0.000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 20);
            this.label21.TabIndex = 71;
            this.label21.Text = "Rated P:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "kW";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "0.000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Rated P:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "kW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "0.000";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 20);
            this.label25.TabIndex = 61;
            this.label25.Text = "Rated P:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Controls.Add(this.button6, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox5, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 457);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1297, 54);
            this.tableLayoutPanel3.TabIndex = 76;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1176, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 42);
            this.button6.TabIndex = 10;
            this.button6.Text = "90% NA";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox6.Location = new System.Drawing.Point(1059, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 42);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(942, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "100%";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox5.Location = new System.Drawing.Point(825, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 42);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(708, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "75%";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox4.Location = new System.Drawing.Point(591, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 42);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(474, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "50%";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox3.Location = new System.Drawing.Point(357, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 42);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(240, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "25%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox2.Location = new System.Drawing.Point(123, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 42);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "0%";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 233);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1297, 218);
            this.gridControl1.TabIndex = 80;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1153, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "General Dynamics Intelligent Test System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Tester Machine v1.0.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom2;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private AdvancedHMIControls.AnalogValueDisplay avd_machanicalP;
        private AdvancedHMIControls.AnalogValueDisplay avd_FWcurr;
        private AdvancedHMIControls.AnalogValueDisplay avd_frequency;
        private AdvancedHMIControls.AnalogValueDisplay avd_rotspdwav;
        private AdvancedHMIControls.AnalogValueDisplay avd_rotspdmod;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel4;
        private AdvancedHMIControls.AnalogValueDisplay avd_torque;
        private AdvancedHMIControls.AnalogValueDisplay avd_DCpower;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel2;
        private AdvancedHMIControls.AnalogValueDisplay avd_FWVolt;
        private AdvancedHMIControls.AnalogValueDisplay avd_electricP;
        private AdvancedHMIControls.AnalogValueDisplay avd_current;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_querysqlite;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn_DBSetting;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_settingorder;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btn_modelSetting;
        private System.Windows.Forms.Button button22;
        private AdvancedHMIControls.AnalogValueDisplay avd_voltage;
        private System.Windows.Forms.Label lbl_speedrpm;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}