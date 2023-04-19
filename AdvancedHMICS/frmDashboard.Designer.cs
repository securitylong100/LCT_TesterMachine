namespace AdvancedHMICS
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlp_topmid = new System.Windows.Forms.TableLayoutPanel();
            this.avd_power_dc = new AdvancedHMIControls.AnalogValueDisplay();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.avd_torque = new AdvancedHMIControls.AnalogValueDisplay();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlp_topright = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.avd_speed_mod = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_speed_wav = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_freq = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_curr_fw = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_power_mec = new AdvancedHMIControls.AnalogValueDisplay();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tlp_topleft = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.avd_volt = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_curr = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_power_e = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_volt_fw = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_speed_rot = new AdvancedHMIControls.AnalogValueDisplay();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tlp_botmid = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.cbo_model = new System.Windows.Forms.ComboBox();
            this.cbo_orderid = new System.Windows.Forms.ComboBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tlp_botright = new System.Windows.Forms.TableLayoutPanel();
            this.btn_logs = new System.Windows.Forms.Button();
            this.btn_load_manual = new System.Windows.Forms.Button();
            this.btn_load_status = new System.Windows.Forms.Button();
            this.btn_plc_status = new System.Windows.Forms.Button();
            this.btn_sql_connect = new System.Windows.Forms.Button();
            this.btn_sql_query = new System.Windows.Forms.Button();
            this.btn_autoload = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_order_setting = new System.Windows.Forms.Button();
            this.btn_model_setting = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tlp_botleft = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbl_power_p = new System.Windows.Forms.Label();
            this.lbl_power_target = new System.Windows.Forms.Label();
            this.lbl_power_actual = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lbl_pc_step = new System.Windows.Forms.Label();
            this.lbl_steady_t = new System.Windows.Forms.Label();
            this.lbl_pid_stop = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tlp_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_25 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_75 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_90 = new System.Windows.Forms.Button();
            this.timer_realtime = new System.Windows.Forms.Timer(this.components);
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.tlp_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.tlp_topmid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tlp_topright.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tlp_topleft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tlp_botmid.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tlp_botright.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tlp_botleft.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tlp_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 3;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_main.Controls.Add(this.panel1, 0, 0);
            this.tlp_main.Controls.Add(this.dgvData, 0, 2);
            this.tlp_main.Controls.Add(this.panel2, 1, 1);
            this.tlp_main.Controls.Add(this.panel3, 2, 1);
            this.tlp_main.Controls.Add(this.panel4, 0, 1);
            this.tlp_main.Controls.Add(this.panel5, 1, 4);
            this.tlp_main.Controls.Add(this.panel6, 2, 4);
            this.tlp_main.Controls.Add(this.panel7, 0, 4);
            this.tlp_main.Controls.Add(this.panel8, 0, 3);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 5;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_main.Size = new System.Drawing.Size(1184, 561);
            this.tlp_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.tlp_main.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::AdvancedHMICS.Properties.Resources.ifm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Dynamics Intelligent Test System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_main.SetColumnSpan(this.dgvData, 3);
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 239);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1178, 118);
            this.dgvData.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tlp_topmid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(397, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 194);
            this.panel2.TabIndex = 21;
            // 
            // tlp_topmid
            // 
            this.tlp_topmid.BackColor = System.Drawing.Color.Gray;
            this.tlp_topmid.ColumnCount = 3;
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topmid.Controls.Add(this.avd_power_dc, 1, 0);
            this.tlp_topmid.Controls.Add(this.avd_torque, 1, 1);
            this.tlp_topmid.Controls.Add(this.label12, 0, 0);
            this.tlp_topmid.Controls.Add(this.label13, 0, 1);
            this.tlp_topmid.Controls.Add(this.label14, 2, 0);
            this.tlp_topmid.Controls.Add(this.label15, 2, 1);
            this.tlp_topmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topmid.Location = new System.Drawing.Point(0, 0);
            this.tlp_topmid.Name = "tlp_topmid";
            this.tlp_topmid.RowCount = 5;
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topmid.Size = new System.Drawing.Size(384, 190);
            this.tlp_topmid.TabIndex = 3;
            // 
            // avd_power_dc
            // 
            this.avd_power_dc.AutoSize = true;
            this.avd_power_dc.ComComponent = this.modbusRTUCom1;
            this.avd_power_dc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_power_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_power_dc.ForeColor = System.Drawing.Color.Yellow;
            this.avd_power_dc.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_power_dc.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_power_dc.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_power_dc.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_power_dc.KeypadMaxValue = 0D;
            this.avd_power_dc.KeypadMinValue = 0D;
            this.avd_power_dc.KeypadPasscode = null;
            this.avd_power_dc.KeypadScaleFactor = 1D;
            this.avd_power_dc.KeypadText = null;
            this.avd_power_dc.KeypadWidth = 300;
            this.avd_power_dc.Location = new System.Drawing.Point(117, 0);
            this.avd_power_dc.Name = "avd_power_dc";
            this.avd_power_dc.NumericFormat = "0.00";
            this.avd_power_dc.PLCAddressKeypad = "";
            this.avd_power_dc.PLCAddressValue = null;
            this.avd_power_dc.PLCAddressValueLimitLower = null;
            this.avd_power_dc.PLCAddressValueLimitUpper = null;
            this.avd_power_dc.PLCAddressVisible = null;
            this.avd_power_dc.ShowValue = true;
            this.avd_power_dc.Size = new System.Drawing.Size(208, 38);
            this.avd_power_dc.TabIndex = 0;
            this.avd_power_dc.Text = "0.00";
            this.avd_power_dc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_power_dc.Value = "0.00";
            this.avd_power_dc.ValueLimitLower = 2900D;
            this.avd_power_dc.ValueLimitUpper = 3600D;
            this.avd_power_dc.ValuePrefix = null;
            this.avd_power_dc.ValueSuffix = null;
            this.avd_power_dc.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
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
            this.modbusRTUCom1.PortName = "COM10";
            this.modbusRTUCom1.StationAddress = ((byte)(1));
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 1000;
            // 
            // avd_torque
            // 
            this.avd_torque.AutoSize = true;
            this.avd_torque.ComComponent = this.modbusRTUCom1;
            this.avd_torque.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.avd_torque.Location = new System.Drawing.Point(117, 38);
            this.avd_torque.Name = "avd_torque";
            this.avd_torque.NumericFormat = "0.00";
            this.avd_torque.PLCAddressKeypad = "";
            this.avd_torque.PLCAddressValue = null;
            this.avd_torque.PLCAddressValueLimitLower = null;
            this.avd_torque.PLCAddressValueLimitUpper = null;
            this.avd_torque.PLCAddressVisible = null;
            this.avd_torque.ShowValue = true;
            this.avd_torque.Size = new System.Drawing.Size(208, 38);
            this.avd_torque.TabIndex = 1;
            this.avd_torque.Text = "0.00";
            this.avd_torque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_torque.Value = "0.00";
            this.avd_torque.ValueLimitLower = 2900D;
            this.avd_torque.ValueLimitUpper = 3600D;
            this.avd_torque.ValuePrefix = null;
            this.avd_torque.ValueSuffix = null;
            this.avd_torque.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 38);
            this.label12.TabIndex = 2;
            this.label12.Text = "DC Power";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 38);
            this.label13.TabIndex = 3;
            this.label13.Text = "Torque";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(331, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 38);
            this.label14.TabIndex = 4;
            this.label14.Text = "W";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(331, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 38);
            this.label15.TabIndex = 5;
            this.label15.Text = "N.m";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tlp_topright);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(791, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 194);
            this.panel3.TabIndex = 22;
            // 
            // tlp_topright
            // 
            this.tlp_topright.BackColor = System.Drawing.Color.Gray;
            this.tlp_topright.ColumnCount = 3;
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topright.Controls.Add(this.label16, 0, 0);
            this.tlp_topright.Controls.Add(this.label17, 0, 1);
            this.tlp_topright.Controls.Add(this.label18, 0, 2);
            this.tlp_topright.Controls.Add(this.label19, 0, 3);
            this.tlp_topright.Controls.Add(this.label20, 0, 4);
            this.tlp_topright.Controls.Add(this.label21, 2, 0);
            this.tlp_topright.Controls.Add(this.label22, 2, 1);
            this.tlp_topright.Controls.Add(this.label23, 2, 2);
            this.tlp_topright.Controls.Add(this.label24, 2, 3);
            this.tlp_topright.Controls.Add(this.label25, 2, 4);
            this.tlp_topright.Controls.Add(this.avd_speed_mod, 1, 0);
            this.tlp_topright.Controls.Add(this.avd_speed_wav, 1, 1);
            this.tlp_topright.Controls.Add(this.avd_freq, 1, 2);
            this.tlp_topright.Controls.Add(this.avd_curr_fw, 1, 3);
            this.tlp_topright.Controls.Add(this.avd_power_mec, 1, 4);
            this.tlp_topright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topright.Location = new System.Drawing.Point(0, 0);
            this.tlp_topright.Name = "tlp_topright";
            this.tlp_topright.RowCount = 5;
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.Size = new System.Drawing.Size(386, 190);
            this.tlp_topright.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 38);
            this.label16.TabIndex = 0;
            this.label16.Text = "ROT Spd. mod";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(3, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 38);
            this.label17.TabIndex = 1;
            this.label17.Text = "ROT Spd. wav";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(3, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 38);
            this.label18.TabIndex = 2;
            this.label18.Text = "Frequency";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(3, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 38);
            this.label19.TabIndex = 3;
            this.label19.Text = "FW Current";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(3, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 38);
            this.label20.TabIndex = 4;
            this.label20.Text = "Mechanical P";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(340, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 38);
            this.label21.TabIndex = 5;
            this.label21.Text = "%";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(340, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 38);
            this.label22.TabIndex = 6;
            this.label22.Text = "%";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(340, 76);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 38);
            this.label23.TabIndex = 7;
            this.label23.Text = "Hz";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(340, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 38);
            this.label24.TabIndex = 8;
            this.label24.Text = "A";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(340, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 38);
            this.label25.TabIndex = 9;
            this.label25.Text = "kW";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avd_speed_mod
            // 
            this.avd_speed_mod.AutoSize = true;
            this.avd_speed_mod.ComComponent = this.modbusRTUCom1;
            this.avd_speed_mod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_speed_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_speed_mod.ForeColor = System.Drawing.Color.Yellow;
            this.avd_speed_mod.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_speed_mod.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_speed_mod.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_speed_mod.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_speed_mod.KeypadMaxValue = 0D;
            this.avd_speed_mod.KeypadMinValue = 0D;
            this.avd_speed_mod.KeypadPasscode = null;
            this.avd_speed_mod.KeypadScaleFactor = 1D;
            this.avd_speed_mod.KeypadText = null;
            this.avd_speed_mod.KeypadWidth = 300;
            this.avd_speed_mod.Location = new System.Drawing.Point(162, 0);
            this.avd_speed_mod.Name = "avd_speed_mod";
            this.avd_speed_mod.NumericFormat = "0.00";
            this.avd_speed_mod.PLCAddressKeypad = "";
            this.avd_speed_mod.PLCAddressValue = null;
            this.avd_speed_mod.PLCAddressValueLimitLower = null;
            this.avd_speed_mod.PLCAddressValueLimitUpper = null;
            this.avd_speed_mod.PLCAddressVisible = null;
            this.avd_speed_mod.ShowValue = true;
            this.avd_speed_mod.Size = new System.Drawing.Size(172, 38);
            this.avd_speed_mod.TabIndex = 10;
            this.avd_speed_mod.Text = "0.00";
            this.avd_speed_mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_speed_mod.Value = "0.00";
            this.avd_speed_mod.ValueLimitLower = 2900D;
            this.avd_speed_mod.ValueLimitUpper = 3600D;
            this.avd_speed_mod.ValuePrefix = null;
            this.avd_speed_mod.ValueSuffix = null;
            this.avd_speed_mod.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_speed_wav
            // 
            this.avd_speed_wav.AutoSize = true;
            this.avd_speed_wav.ComComponent = this.modbusRTUCom1;
            this.avd_speed_wav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_speed_wav.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_speed_wav.ForeColor = System.Drawing.Color.Yellow;
            this.avd_speed_wav.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_speed_wav.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_speed_wav.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_speed_wav.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_speed_wav.KeypadMaxValue = 0D;
            this.avd_speed_wav.KeypadMinValue = 0D;
            this.avd_speed_wav.KeypadPasscode = null;
            this.avd_speed_wav.KeypadScaleFactor = 1D;
            this.avd_speed_wav.KeypadText = null;
            this.avd_speed_wav.KeypadWidth = 300;
            this.avd_speed_wav.Location = new System.Drawing.Point(162, 38);
            this.avd_speed_wav.Name = "avd_speed_wav";
            this.avd_speed_wav.NumericFormat = "0.00";
            this.avd_speed_wav.PLCAddressKeypad = "";
            this.avd_speed_wav.PLCAddressValue = null;
            this.avd_speed_wav.PLCAddressValueLimitLower = null;
            this.avd_speed_wav.PLCAddressValueLimitUpper = null;
            this.avd_speed_wav.PLCAddressVisible = null;
            this.avd_speed_wav.ShowValue = true;
            this.avd_speed_wav.Size = new System.Drawing.Size(172, 38);
            this.avd_speed_wav.TabIndex = 11;
            this.avd_speed_wav.Text = "0.00";
            this.avd_speed_wav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_speed_wav.Value = "0.00";
            this.avd_speed_wav.ValueLimitLower = 2900D;
            this.avd_speed_wav.ValueLimitUpper = 3600D;
            this.avd_speed_wav.ValuePrefix = null;
            this.avd_speed_wav.ValueSuffix = null;
            this.avd_speed_wav.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_freq
            // 
            this.avd_freq.AutoSize = true;
            this.avd_freq.ComComponent = this.modbusRTUCom1;
            this.avd_freq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_freq.ForeColor = System.Drawing.Color.Yellow;
            this.avd_freq.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_freq.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_freq.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_freq.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_freq.KeypadMaxValue = 0D;
            this.avd_freq.KeypadMinValue = 0D;
            this.avd_freq.KeypadPasscode = null;
            this.avd_freq.KeypadScaleFactor = 1D;
            this.avd_freq.KeypadText = null;
            this.avd_freq.KeypadWidth = 300;
            this.avd_freq.Location = new System.Drawing.Point(162, 76);
            this.avd_freq.Name = "avd_freq";
            this.avd_freq.NumericFormat = "0.00";
            this.avd_freq.PLCAddressKeypad = "";
            this.avd_freq.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_freq.PLCAddressValue")));
            this.avd_freq.PLCAddressValueLimitLower = null;
            this.avd_freq.PLCAddressValueLimitUpper = null;
            this.avd_freq.PLCAddressVisible = null;
            this.avd_freq.ShowValue = true;
            this.avd_freq.Size = new System.Drawing.Size(172, 38);
            this.avd_freq.TabIndex = 12;
            this.avd_freq.Text = "0.00";
            this.avd_freq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_freq.Value = "0.00";
            this.avd_freq.ValueLimitLower = 2900D;
            this.avd_freq.ValueLimitUpper = 3600D;
            this.avd_freq.ValuePrefix = null;
            this.avd_freq.ValueSuffix = null;
            this.avd_freq.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_freq.ValueChanged += new System.EventHandler(this.avd_freq_ValueChanged);
            // 
            // avd_curr_fw
            // 
            this.avd_curr_fw.AutoSize = true;
            this.avd_curr_fw.ComComponent = this.modbusRTUCom1;
            this.avd_curr_fw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_curr_fw.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_curr_fw.ForeColor = System.Drawing.Color.Yellow;
            this.avd_curr_fw.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_curr_fw.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_curr_fw.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_curr_fw.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_curr_fw.KeypadMaxValue = 0D;
            this.avd_curr_fw.KeypadMinValue = 0D;
            this.avd_curr_fw.KeypadPasscode = null;
            this.avd_curr_fw.KeypadScaleFactor = 1D;
            this.avd_curr_fw.KeypadText = null;
            this.avd_curr_fw.KeypadWidth = 300;
            this.avd_curr_fw.Location = new System.Drawing.Point(162, 114);
            this.avd_curr_fw.Name = "avd_curr_fw";
            this.avd_curr_fw.NumericFormat = "0.00";
            this.avd_curr_fw.PLCAddressKeypad = "";
            this.avd_curr_fw.PLCAddressValue = null;
            this.avd_curr_fw.PLCAddressValueLimitLower = null;
            this.avd_curr_fw.PLCAddressValueLimitUpper = null;
            this.avd_curr_fw.PLCAddressVisible = null;
            this.avd_curr_fw.ShowValue = true;
            this.avd_curr_fw.Size = new System.Drawing.Size(172, 38);
            this.avd_curr_fw.TabIndex = 13;
            this.avd_curr_fw.Text = "0.00";
            this.avd_curr_fw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_curr_fw.Value = "0.00";
            this.avd_curr_fw.ValueLimitLower = 2900D;
            this.avd_curr_fw.ValueLimitUpper = 3600D;
            this.avd_curr_fw.ValuePrefix = null;
            this.avd_curr_fw.ValueSuffix = null;
            this.avd_curr_fw.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_power_mec
            // 
            this.avd_power_mec.AutoSize = true;
            this.avd_power_mec.ComComponent = this.modbusRTUCom1;
            this.avd_power_mec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_power_mec.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_power_mec.ForeColor = System.Drawing.Color.Yellow;
            this.avd_power_mec.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_power_mec.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_power_mec.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_power_mec.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_power_mec.KeypadMaxValue = 0D;
            this.avd_power_mec.KeypadMinValue = 0D;
            this.avd_power_mec.KeypadPasscode = null;
            this.avd_power_mec.KeypadScaleFactor = 1D;
            this.avd_power_mec.KeypadText = null;
            this.avd_power_mec.KeypadWidth = 300;
            this.avd_power_mec.Location = new System.Drawing.Point(162, 152);
            this.avd_power_mec.Name = "avd_power_mec";
            this.avd_power_mec.NumericFormat = "0.00";
            this.avd_power_mec.PLCAddressKeypad = "";
            this.avd_power_mec.PLCAddressValue = null;
            this.avd_power_mec.PLCAddressValueLimitLower = null;
            this.avd_power_mec.PLCAddressValueLimitUpper = null;
            this.avd_power_mec.PLCAddressVisible = null;
            this.avd_power_mec.ShowValue = true;
            this.avd_power_mec.Size = new System.Drawing.Size(172, 38);
            this.avd_power_mec.TabIndex = 14;
            this.avd_power_mec.Text = "0.00";
            this.avd_power_mec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_power_mec.Value = "0.00";
            this.avd_power_mec.ValueLimitLower = 2900D;
            this.avd_power_mec.ValueLimitUpper = 3600D;
            this.avd_power_mec.ValuePrefix = null;
            this.avd_power_mec.ValueSuffix = null;
            this.avd_power_mec.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tlp_topleft);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 194);
            this.panel4.TabIndex = 23;
            // 
            // tlp_topleft
            // 
            this.tlp_topleft.BackColor = System.Drawing.Color.Gray;
            this.tlp_topleft.ColumnCount = 3;
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topleft.Controls.Add(this.label2, 0, 0);
            this.tlp_topleft.Controls.Add(this.label3, 0, 1);
            this.tlp_topleft.Controls.Add(this.label4, 0, 2);
            this.tlp_topleft.Controls.Add(this.label5, 0, 3);
            this.tlp_topleft.Controls.Add(this.label6, 0, 4);
            this.tlp_topleft.Controls.Add(this.label7, 2, 0);
            this.tlp_topleft.Controls.Add(this.label8, 2, 1);
            this.tlp_topleft.Controls.Add(this.label9, 2, 2);
            this.tlp_topleft.Controls.Add(this.label10, 2, 3);
            this.tlp_topleft.Controls.Add(this.label11, 2, 4);
            this.tlp_topleft.Controls.Add(this.avd_volt, 1, 0);
            this.tlp_topleft.Controls.Add(this.avd_curr, 1, 1);
            this.tlp_topleft.Controls.Add(this.avd_power_e, 1, 2);
            this.tlp_topleft.Controls.Add(this.avd_volt_fw, 1, 3);
            this.tlp_topleft.Controls.Add(this.avd_speed_rot, 1, 4);
            this.tlp_topleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topleft.Location = new System.Drawing.Point(0, 0);
            this.tlp_topleft.Name = "tlp_topleft";
            this.tlp_topleft.RowCount = 5;
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.Size = new System.Drawing.Size(384, 190);
            this.tlp_topleft.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Voltage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Electric P";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "FW Volt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "ROT Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "V";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 38);
            this.label8.TabIndex = 6;
            this.label8.Text = "A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 38);
            this.label9.TabIndex = 7;
            this.label9.Text = "kW";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "V";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "rpm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avd_volt
            // 
            this.avd_volt.AutoSize = true;
            this.avd_volt.ComComponent = this.modbusRTUCom1;
            this.avd_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_volt.ForeColor = System.Drawing.Color.Yellow;
            this.avd_volt.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_volt.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_volt.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_volt.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_volt.KeypadMaxValue = 0D;
            this.avd_volt.KeypadMinValue = 0D;
            this.avd_volt.KeypadPasscode = null;
            this.avd_volt.KeypadScaleFactor = 1D;
            this.avd_volt.KeypadText = null;
            this.avd_volt.KeypadWidth = 300;
            this.avd_volt.Location = new System.Drawing.Point(133, 0);
            this.avd_volt.Name = "avd_volt";
            this.avd_volt.NumericFormat = "0.00";
            this.avd_volt.PLCAddressKeypad = "";
            this.avd_volt.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_volt.PLCAddressValue")));
            this.avd_volt.PLCAddressValueLimitLower = null;
            this.avd_volt.PLCAddressValueLimitUpper = null;
            this.avd_volt.PLCAddressVisible = null;
            this.avd_volt.ShowValue = true;
            this.avd_volt.Size = new System.Drawing.Size(194, 38);
            this.avd_volt.TabIndex = 10;
            this.avd_volt.Text = "0.00";
            this.avd_volt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_volt.Value = "0";
            this.avd_volt.ValueLimitLower = 2900D;
            this.avd_volt.ValueLimitUpper = 3600D;
            this.avd_volt.ValuePrefix = null;
            this.avd_volt.ValueSuffix = null;
            this.avd_volt.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_volt.ValueChanged += new System.EventHandler(this.avd_volt_ValueChanged);
            // 
            // avd_curr
            // 
            this.avd_curr.AutoSize = true;
            this.avd_curr.ComComponent = this.modbusRTUCom1;
            this.avd_curr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_curr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_curr.ForeColor = System.Drawing.Color.Yellow;
            this.avd_curr.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_curr.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_curr.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_curr.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_curr.KeypadMaxValue = 0D;
            this.avd_curr.KeypadMinValue = 0D;
            this.avd_curr.KeypadPasscode = null;
            this.avd_curr.KeypadScaleFactor = 1D;
            this.avd_curr.KeypadText = null;
            this.avd_curr.KeypadWidth = 300;
            this.avd_curr.Location = new System.Drawing.Point(133, 38);
            this.avd_curr.Name = "avd_curr";
            this.avd_curr.NumericFormat = "0.00";
            this.avd_curr.PLCAddressKeypad = "";
            this.avd_curr.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_curr.PLCAddressValue")));
            this.avd_curr.PLCAddressValueLimitLower = null;
            this.avd_curr.PLCAddressValueLimitUpper = null;
            this.avd_curr.PLCAddressVisible = null;
            this.avd_curr.ShowValue = true;
            this.avd_curr.Size = new System.Drawing.Size(194, 38);
            this.avd_curr.TabIndex = 11;
            this.avd_curr.Text = "0.00";
            this.avd_curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_curr.Value = "0.00";
            this.avd_curr.ValueLimitLower = 2900D;
            this.avd_curr.ValueLimitUpper = 3600D;
            this.avd_curr.ValuePrefix = null;
            this.avd_curr.ValueSuffix = null;
            this.avd_curr.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_curr.ValueChanged += new System.EventHandler(this.avd_curr_ValueChanged);
            // 
            // avd_power_e
            // 
            this.avd_power_e.AutoSize = true;
            this.avd_power_e.ComComponent = this.modbusRTUCom1;
            this.avd_power_e.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_power_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_power_e.ForeColor = System.Drawing.Color.Yellow;
            this.avd_power_e.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_power_e.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_power_e.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_power_e.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_power_e.KeypadMaxValue = 0D;
            this.avd_power_e.KeypadMinValue = 0D;
            this.avd_power_e.KeypadPasscode = null;
            this.avd_power_e.KeypadScaleFactor = 1D;
            this.avd_power_e.KeypadText = null;
            this.avd_power_e.KeypadWidth = 300;
            this.avd_power_e.Location = new System.Drawing.Point(133, 76);
            this.avd_power_e.Name = "avd_power_e";
            this.avd_power_e.NumericFormat = "0.00";
            this.avd_power_e.PLCAddressKeypad = "";
            this.avd_power_e.PLCAddressValue = null;
            this.avd_power_e.PLCAddressValueLimitLower = null;
            this.avd_power_e.PLCAddressValueLimitUpper = null;
            this.avd_power_e.PLCAddressVisible = null;
            this.avd_power_e.ShowValue = true;
            this.avd_power_e.Size = new System.Drawing.Size(194, 38);
            this.avd_power_e.TabIndex = 12;
            this.avd_power_e.Text = "0.00";
            this.avd_power_e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_power_e.Value = "0.00";
            this.avd_power_e.ValueLimitLower = 2900D;
            this.avd_power_e.ValueLimitUpper = 3600D;
            this.avd_power_e.ValuePrefix = null;
            this.avd_power_e.ValueSuffix = null;
            this.avd_power_e.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_volt_fw
            // 
            this.avd_volt_fw.AutoSize = true;
            this.avd_volt_fw.ComComponent = this.modbusRTUCom1;
            this.avd_volt_fw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_volt_fw.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_volt_fw.ForeColor = System.Drawing.Color.Yellow;
            this.avd_volt_fw.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_volt_fw.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_volt_fw.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_volt_fw.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_volt_fw.KeypadMaxValue = 0D;
            this.avd_volt_fw.KeypadMinValue = 0D;
            this.avd_volt_fw.KeypadPasscode = null;
            this.avd_volt_fw.KeypadScaleFactor = 1D;
            this.avd_volt_fw.KeypadText = null;
            this.avd_volt_fw.KeypadWidth = 300;
            this.avd_volt_fw.Location = new System.Drawing.Point(133, 114);
            this.avd_volt_fw.Name = "avd_volt_fw";
            this.avd_volt_fw.NumericFormat = "0.00";
            this.avd_volt_fw.PLCAddressKeypad = "";
            this.avd_volt_fw.PLCAddressValue = null;
            this.avd_volt_fw.PLCAddressValueLimitLower = null;
            this.avd_volt_fw.PLCAddressValueLimitUpper = null;
            this.avd_volt_fw.PLCAddressVisible = null;
            this.avd_volt_fw.ShowValue = true;
            this.avd_volt_fw.Size = new System.Drawing.Size(194, 38);
            this.avd_volt_fw.TabIndex = 13;
            this.avd_volt_fw.Text = "0.00";
            this.avd_volt_fw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_volt_fw.Value = "0.00";
            this.avd_volt_fw.ValueLimitLower = 2900D;
            this.avd_volt_fw.ValueLimitUpper = 3600D;
            this.avd_volt_fw.ValuePrefix = null;
            this.avd_volt_fw.ValueSuffix = null;
            this.avd_volt_fw.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_speed_rot
            // 
            this.avd_speed_rot.AutoSize = true;
            this.avd_speed_rot.ComComponent = this.modbusRTUCom1;
            this.avd_speed_rot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_speed_rot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_speed_rot.ForeColor = System.Drawing.Color.Yellow;
            this.avd_speed_rot.ForeColorInLimits = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.avd_speed_rot.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_speed_rot.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.avd_speed_rot.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_speed_rot.KeypadMaxValue = 0D;
            this.avd_speed_rot.KeypadMinValue = 0D;
            this.avd_speed_rot.KeypadPasscode = null;
            this.avd_speed_rot.KeypadScaleFactor = 1D;
            this.avd_speed_rot.KeypadText = null;
            this.avd_speed_rot.KeypadWidth = 300;
            this.avd_speed_rot.Location = new System.Drawing.Point(133, 152);
            this.avd_speed_rot.Name = "avd_speed_rot";
            this.avd_speed_rot.NumericFormat = "0.00";
            this.avd_speed_rot.PLCAddressKeypad = "";
            this.avd_speed_rot.PLCAddressValue = null;
            this.avd_speed_rot.PLCAddressValueLimitLower = null;
            this.avd_speed_rot.PLCAddressValueLimitUpper = null;
            this.avd_speed_rot.PLCAddressVisible = null;
            this.avd_speed_rot.ShowValue = true;
            this.avd_speed_rot.Size = new System.Drawing.Size(194, 38);
            this.avd_speed_rot.TabIndex = 14;
            this.avd_speed_rot.Text = "0.00";
            this.avd_speed_rot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avd_speed_rot.Value = "0.00";
            this.avd_speed_rot.ValueLimitLower = 2900D;
            this.avd_speed_rot.ValueLimitUpper = 3600D;
            this.avd_speed_rot.ValuePrefix = null;
            this.avd_speed_rot.ValueSuffix = null;
            this.avd_speed_rot.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tlp_botmid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(397, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 131);
            this.panel5.TabIndex = 24;
            // 
            // tlp_botmid
            // 
            this.tlp_botmid.BackColor = System.Drawing.Color.LightGray;
            this.tlp_botmid.ColumnCount = 2;
            this.tlp_botmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botmid.Controls.Add(this.label30, 0, 0);
            this.tlp_botmid.Controls.Add(this.label31, 0, 1);
            this.tlp_botmid.Controls.Add(this.label32, 0, 2);
            this.tlp_botmid.Controls.Add(this.cbo_model, 1, 0);
            this.tlp_botmid.Controls.Add(this.cbo_orderid, 1, 2);
            this.tlp_botmid.Controls.Add(this.txt_barcode, 1, 1);
            this.tlp_botmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botmid.Location = new System.Drawing.Point(0, 0);
            this.tlp_botmid.Name = "tlp_botmid";
            this.tlp_botmid.RowCount = 4;
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_botmid.Size = new System.Drawing.Size(384, 127);
            this.tlp_botmid.TabIndex = 7;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(110, 38);
            this.label30.TabIndex = 0;
            this.label30.Text = "Test Standard";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 38);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(110, 36);
            this.label31.TabIndex = 1;
            this.label31.Text = "Barcode";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(110, 38);
            this.label32.TabIndex = 2;
            this.label32.Text = "Order ID";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_model
            // 
            this.cbo_model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_model.FormattingEnabled = true;
            this.cbo_model.Location = new System.Drawing.Point(121, 5);
            this.cbo_model.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_model.Name = "cbo_model";
            this.cbo_model.Size = new System.Drawing.Size(258, 28);
            this.cbo_model.TabIndex = 3;
            this.cbo_model.SelectedIndexChanged += new System.EventHandler(this.cbo_model_SelectedIndexChanged);
            // 
            // cbo_orderid
            // 
            this.cbo_orderid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_orderid.FormattingEnabled = true;
            this.cbo_orderid.Location = new System.Drawing.Point(121, 79);
            this.cbo_orderid.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_orderid.Name = "cbo_orderid";
            this.cbo_orderid.Size = new System.Drawing.Size(258, 28);
            this.cbo_orderid.TabIndex = 4;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(121, 43);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(5);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(258, 26);
            this.txt_barcode.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.tlp_botright);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(791, 427);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 131);
            this.panel6.TabIndex = 25;
            // 
            // tlp_botright
            // 
            this.tlp_botright.BackColor = System.Drawing.Color.LightGray;
            this.tlp_botright.ColumnCount = 4;
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.Controls.Add(this.btn_logs, 3, 3);
            this.tlp_botright.Controls.Add(this.btn_load_manual, 2, 3);
            this.tlp_botright.Controls.Add(this.btn_load_status, 1, 3);
            this.tlp_botright.Controls.Add(this.btn_plc_status, 0, 3);
            this.tlp_botright.Controls.Add(this.btn_sql_connect, 3, 2);
            this.tlp_botright.Controls.Add(this.btn_sql_query, 2, 2);
            this.tlp_botright.Controls.Add(this.btn_autoload, 1, 2);
            this.tlp_botright.Controls.Add(this.btn_start, 0, 2);
            this.tlp_botright.Controls.Add(this.btn_order_setting, 3, 1);
            this.tlp_botright.Controls.Add(this.btn_model_setting, 2, 1);
            this.tlp_botright.Controls.Add(this.btn_user, 1, 1);
            this.tlp_botright.Controls.Add(this.btn_export, 3, 0);
            this.tlp_botright.Controls.Add(this.btn_clear, 2, 0);
            this.tlp_botright.Controls.Add(this.btn_delete, 1, 0);
            this.tlp_botright.Controls.Add(this.btn_record, 0, 0);
            this.tlp_botright.Controls.Add(this.btn_data, 0, 1);
            this.tlp_botright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botright.Location = new System.Drawing.Point(0, 0);
            this.tlp_botright.Name = "tlp_botright";
            this.tlp_botright.RowCount = 4;
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.Size = new System.Drawing.Size(386, 127);
            this.tlp_botright.TabIndex = 6;
            // 
            // btn_logs
            // 
            this.btn_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logs.Location = new System.Drawing.Point(291, 96);
            this.btn_logs.Name = "btn_logs";
            this.btn_logs.Size = new System.Drawing.Size(92, 28);
            this.btn_logs.TabIndex = 15;
            this.btn_logs.Text = "Logs";
            this.btn_logs.UseVisualStyleBackColor = true;
            this.btn_logs.Click += new System.EventHandler(this.btn_logs_Click);
            // 
            // btn_load_manual
            // 
            this.btn_load_manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_load_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_manual.Location = new System.Drawing.Point(195, 96);
            this.btn_load_manual.Name = "btn_load_manual";
            this.btn_load_manual.Size = new System.Drawing.Size(90, 28);
            this.btn_load_manual.TabIndex = 14;
            this.btn_load_manual.Text = "Manual Load";
            this.btn_load_manual.UseVisualStyleBackColor = true;
            this.btn_load_manual.Click += new System.EventHandler(this.btn_load_manual_Click);
            // 
            // btn_load_status
            // 
            this.btn_load_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_load_status.Enabled = false;
            this.btn_load_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_status.Location = new System.Drawing.Point(99, 96);
            this.btn_load_status.Name = "btn_load_status";
            this.btn_load_status.Size = new System.Drawing.Size(90, 28);
            this.btn_load_status.TabIndex = 13;
            this.btn_load_status.Text = "Load Status";
            this.btn_load_status.UseVisualStyleBackColor = true;
            this.btn_load_status.Click += new System.EventHandler(this.btn_load_status_Click);
            // 
            // btn_plc_status
            // 
            this.btn_plc_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plc_status.Enabled = false;
            this.btn_plc_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plc_status.Location = new System.Drawing.Point(3, 96);
            this.btn_plc_status.Name = "btn_plc_status";
            this.btn_plc_status.Size = new System.Drawing.Size(90, 28);
            this.btn_plc_status.TabIndex = 12;
            this.btn_plc_status.Text = "PLC Status";
            this.btn_plc_status.UseVisualStyleBackColor = true;
            this.btn_plc_status.Click += new System.EventHandler(this.btn_plc_status_Click);
            // 
            // btn_sql_connect
            // 
            this.btn_sql_connect.BackColor = System.Drawing.Color.Red;
            this.btn_sql_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sql_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sql_connect.ForeColor = System.Drawing.Color.Yellow;
            this.btn_sql_connect.Location = new System.Drawing.Point(291, 65);
            this.btn_sql_connect.Name = "btn_sql_connect";
            this.btn_sql_connect.Size = new System.Drawing.Size(92, 25);
            this.btn_sql_connect.TabIndex = 11;
            this.btn_sql_connect.Text = "SQL Connect";
            this.btn_sql_connect.UseVisualStyleBackColor = false;
            this.btn_sql_connect.Click += new System.EventHandler(this.btn_sql_connect_Click);
            // 
            // btn_sql_query
            // 
            this.btn_sql_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sql_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sql_query.Location = new System.Drawing.Point(195, 65);
            this.btn_sql_query.Name = "btn_sql_query";
            this.btn_sql_query.Size = new System.Drawing.Size(90, 25);
            this.btn_sql_query.TabIndex = 10;
            this.btn_sql_query.Text = "SQL Query";
            this.btn_sql_query.UseVisualStyleBackColor = true;
            this.btn_sql_query.Click += new System.EventHandler(this.btn_sql_query_Click);
            // 
            // btn_autoload
            // 
            this.btn_autoload.BackColor = System.Drawing.Color.LightGray;
            this.btn_autoload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_autoload.Enabled = false;
            this.btn_autoload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoload.ForeColor = System.Drawing.Color.Black;
            this.btn_autoload.Location = new System.Drawing.Point(99, 65);
            this.btn_autoload.Name = "btn_autoload";
            this.btn_autoload.Size = new System.Drawing.Size(90, 25);
            this.btn_autoload.TabIndex = 9;
            this.btn_autoload.Text = "Auto Load";
            this.btn_autoload.UseVisualStyleBackColor = false;
            this.btn_autoload.Click += new System.EventHandler(this.btn_autoload_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.Yellow;
            this.btn_start.Location = new System.Drawing.Point(3, 65);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 25);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start/Run";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_order_setting
            // 
            this.btn_order_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_order_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_setting.Location = new System.Drawing.Point(291, 34);
            this.btn_order_setting.Name = "btn_order_setting";
            this.btn_order_setting.Size = new System.Drawing.Size(92, 25);
            this.btn_order_setting.TabIndex = 7;
            this.btn_order_setting.Text = "Order Setting";
            this.btn_order_setting.UseVisualStyleBackColor = true;
            this.btn_order_setting.Click += new System.EventHandler(this.btn_order_setting_Click);
            // 
            // btn_model_setting
            // 
            this.btn_model_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_model_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_model_setting.Location = new System.Drawing.Point(195, 34);
            this.btn_model_setting.Name = "btn_model_setting";
            this.btn_model_setting.Size = new System.Drawing.Size(90, 25);
            this.btn_model_setting.TabIndex = 6;
            this.btn_model_setting.Text = "Model Setting";
            this.btn_model_setting.UseVisualStyleBackColor = true;
            this.btn_model_setting.Click += new System.EventHandler(this.btn_model_setting_Click);
            // 
            // btn_user
            // 
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Location = new System.Drawing.Point(99, 34);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(90, 25);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_export
            // 
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_export.Enabled = false;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Location = new System.Drawing.Point(291, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(92, 25);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Enabled = false;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(195, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 25);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(99, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 25);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_record
            // 
            this.btn_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_record.Enabled = false;
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_record.Location = new System.Drawing.Point(3, 3);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(90, 25);
            this.btn_record.TabIndex = 0;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_data
            // 
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Location = new System.Drawing.Point(3, 34);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(90, 25);
            this.btn_data.TabIndex = 1;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tlp_botleft);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 427);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(388, 131);
            this.panel7.TabIndex = 26;
            // 
            // tlp_botleft
            // 
            this.tlp_botleft.BackColor = System.Drawing.Color.LightGray;
            this.tlp_botleft.ColumnCount = 7;
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.Controls.Add(this.label26, 0, 0);
            this.tlp_botleft.Controls.Add(this.label27, 0, 1);
            this.tlp_botleft.Controls.Add(this.label28, 0, 2);
            this.tlp_botleft.Controls.Add(this.label29, 0, 3);
            this.tlp_botleft.Controls.Add(this.lbl_power_p, 1, 0);
            this.tlp_botleft.Controls.Add(this.lbl_power_target, 1, 1);
            this.tlp_botleft.Controls.Add(this.lbl_power_actual, 1, 2);
            this.tlp_botleft.Controls.Add(this.lbl_status, 1, 3);
            this.tlp_botleft.Controls.Add(this.label34, 2, 0);
            this.tlp_botleft.Controls.Add(this.label35, 2, 1);
            this.tlp_botleft.Controls.Add(this.label36, 2, 2);
            this.tlp_botleft.Controls.Add(this.label38, 4, 0);
            this.tlp_botleft.Controls.Add(this.label39, 4, 1);
            this.tlp_botleft.Controls.Add(this.label40, 4, 2);
            this.tlp_botleft.Controls.Add(this.lbl_pc_step, 5, 0);
            this.tlp_botleft.Controls.Add(this.lbl_steady_t, 5, 1);
            this.tlp_botleft.Controls.Add(this.lbl_pid_stop, 5, 2);
            this.tlp_botleft.Controls.Add(this.label45, 6, 1);
            this.tlp_botleft.Controls.Add(this.label46, 6, 2);
            this.tlp_botleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botleft.Location = new System.Drawing.Point(0, 0);
            this.tlp_botleft.Name = "tlp_botleft";
            this.tlp_botleft.RowCount = 4;
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botleft.Size = new System.Drawing.Size(388, 131);
            this.tlp_botleft.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 32);
            this.label26.TabIndex = 0;
            this.label26.Text = "Rate P:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 32);
            this.label27.TabIndex = 1;
            this.label27.Text = "Target P:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 32);
            this.label28.TabIndex = 2;
            this.label28.Text = "Actual P:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 35);
            this.label29.TabIndex = 3;
            this.label29.Text = "Status:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_power_p
            // 
            this.lbl_power_p.AutoSize = true;
            this.lbl_power_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_power_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power_p.Location = new System.Drawing.Point(82, 0);
            this.lbl_power_p.Name = "lbl_power_p";
            this.lbl_power_p.Size = new System.Drawing.Size(49, 32);
            this.lbl_power_p.TabIndex = 4;
            this.lbl_power_p.Text = "0.000";
            this.lbl_power_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_power_target
            // 
            this.lbl_power_target.AutoSize = true;
            this.lbl_power_target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_power_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power_target.Location = new System.Drawing.Point(82, 32);
            this.lbl_power_target.Name = "lbl_power_target";
            this.lbl_power_target.Size = new System.Drawing.Size(49, 32);
            this.lbl_power_target.TabIndex = 5;
            this.lbl_power_target.Text = "0.000";
            this.lbl_power_target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_power_actual
            // 
            this.lbl_power_actual.AutoSize = true;
            this.lbl_power_actual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_power_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power_actual.Location = new System.Drawing.Point(82, 64);
            this.lbl_power_actual.Name = "lbl_power_actual";
            this.lbl_power_actual.Size = new System.Drawing.Size(49, 32);
            this.lbl_power_actual.TabIndex = 6;
            this.lbl_power_actual.Text = "0.000";
            this.lbl_power_actual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.lbl_status, 6);
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(82, 96);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(303, 35);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Manual";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(137, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 32);
            this.label34.TabIndex = 8;
            this.label34.Text = "kW";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(137, 32);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 32);
            this.label35.TabIndex = 9;
            this.label35.Text = "kW";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(137, 64);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 32);
            this.label36.TabIndex = 10;
            this.label36.Text = "kW";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(232, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 32);
            this.label38.TabIndex = 12;
            this.label38.Text = "PC Step:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(232, 32);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(78, 32);
            this.label39.TabIndex = 13;
            this.label39.Text = "Steady T:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(232, 64);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 32);
            this.label40.TabIndex = 14;
            this.label40.Text = "PID Stop:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pc_step
            // 
            this.lbl_pc_step.AutoSize = true;
            this.lbl_pc_step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pc_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc_step.Location = new System.Drawing.Point(316, 0);
            this.lbl_pc_step.Name = "lbl_pc_step";
            this.lbl_pc_step.Size = new System.Drawing.Size(40, 32);
            this.lbl_pc_step.TabIndex = 15;
            this.lbl_pc_step.Text = "1-5";
            this.lbl_pc_step.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_steady_t
            // 
            this.lbl_steady_t.AutoSize = true;
            this.lbl_steady_t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_steady_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steady_t.Location = new System.Drawing.Point(316, 32);
            this.lbl_steady_t.Name = "lbl_steady_t";
            this.lbl_steady_t.Size = new System.Drawing.Size(40, 32);
            this.lbl_steady_t.TabIndex = 16;
            this.lbl_steady_t.Text = "0";
            this.lbl_steady_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pid_stop
            // 
            this.lbl_pid_stop.AutoSize = true;
            this.lbl_pid_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pid_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pid_stop.Location = new System.Drawing.Point(316, 64);
            this.lbl_pid_stop.Name = "lbl_pid_stop";
            this.lbl_pid_stop.Size = new System.Drawing.Size(40, 32);
            this.lbl_pid_stop.TabIndex = 17;
            this.lbl_pid_stop.Text = "0.00";
            this.lbl_pid_stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(362, 32);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(23, 32);
            this.label45.TabIndex = 19;
            this.label45.Text = "s";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(362, 64);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 32);
            this.label46.TabIndex = 20;
            this.label46.Text = "%";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tlp_main.SetColumnSpan(this.panel8, 3);
            this.panel8.Controls.Add(this.tlp_buttons);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 363);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1178, 58);
            this.panel8.TabIndex = 27;
            // 
            // tlp_buttons
            // 
            this.tlp_buttons.BackColor = System.Drawing.Color.LightGray;
            this.tlp_buttons.ColumnCount = 11;
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp_buttons.Controls.Add(this.pictureBox2, 1, 0);
            this.tlp_buttons.Controls.Add(this.pictureBox3, 3, 0);
            this.tlp_buttons.Controls.Add(this.pictureBox4, 5, 0);
            this.tlp_buttons.Controls.Add(this.pictureBox5, 7, 0);
            this.tlp_buttons.Controls.Add(this.pictureBox6, 9, 0);
            this.tlp_buttons.Controls.Add(this.btn_00, 0, 0);
            this.tlp_buttons.Controls.Add(this.btn_25, 2, 0);
            this.tlp_buttons.Controls.Add(this.btn_50, 4, 0);
            this.tlp_buttons.Controls.Add(this.btn_75, 6, 0);
            this.tlp_buttons.Controls.Add(this.btn_100, 8, 0);
            this.tlp_buttons.Controls.Add(this.btn_90, 10, 0);
            this.tlp_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_buttons.Location = new System.Drawing.Point(0, 0);
            this.tlp_buttons.Name = "tlp_buttons";
            this.tlp_buttons.RowCount = 1;
            this.tlp_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_buttons.Size = new System.Drawing.Size(1174, 54);
            this.tlp_buttons.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(321, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(533, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(745, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(957, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // btn_00
            // 
            this.btn_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.Location = new System.Drawing.Point(3, 3);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(100, 48);
            this.btn_00.TabIndex = 5;
            this.btn_00.Tag = "1";
            this.btn_00.Text = "0%";
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_25
            // 
            this.btn_25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_25.Location = new System.Drawing.Point(215, 3);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(100, 48);
            this.btn_25.TabIndex = 6;
            this.btn_25.Tag = "2";
            this.btn_25.Text = "25%";
            this.btn_25.UseVisualStyleBackColor = true;
            this.btn_25.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_50
            // 
            this.btn_50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.Location = new System.Drawing.Point(427, 3);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(100, 48);
            this.btn_50.TabIndex = 7;
            this.btn_50.Tag = "3";
            this.btn_50.Text = "50%";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_75
            // 
            this.btn_75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_75.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_75.Location = new System.Drawing.Point(639, 3);
            this.btn_75.Name = "btn_75";
            this.btn_75.Size = new System.Drawing.Size(100, 48);
            this.btn_75.TabIndex = 8;
            this.btn_75.Tag = "4";
            this.btn_75.Text = "75%";
            this.btn_75.UseVisualStyleBackColor = true;
            this.btn_75.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_100
            // 
            this.btn_100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.Location = new System.Drawing.Point(851, 3);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(100, 48);
            this.btn_100.TabIndex = 9;
            this.btn_100.Tag = "5";
            this.btn_100.Text = "100%";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_90
            // 
            this.btn_90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_90.Enabled = false;
            this.btn_90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_90.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_90.Location = new System.Drawing.Point(1063, 3);
            this.btn_90.Name = "btn_90";
            this.btn_90.Size = new System.Drawing.Size(108, 48);
            this.btn_90.TabIndex = 10;
            this.btn_90.Tag = "6";
            this.btn_90.Text = "90%";
            this.btn_90.UseVisualStyleBackColor = true;
            this.btn_90.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // timer_realtime
            // 
            this.timer_realtime.Interval = 1000;
            this.timer_realtime.Tick += new System.EventHandler(this.timer_realtime_Tick);
            // 
            // timer_load
            // 
            this.timer_load.Interval = 1000;
            this.timer_load.Tick += new System.EventHandler(this.timer_load_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Tester Machine v1.0.0";
            this.tlp_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tlp_topmid.ResumeLayout(false);
            this.tlp_topmid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tlp_topright.ResumeLayout(false);
            this.tlp_topright.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tlp_topleft.ResumeLayout(false);
            this.tlp_topleft.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tlp_botmid.ResumeLayout(false);
            this.tlp_botmid.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tlp_botright.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tlp_botleft.ResumeLayout(false);
            this.tlp_botleft.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tlp_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tlp_topright;
        private System.Windows.Forms.TableLayoutPanel tlp_topmid;
        private System.Windows.Forms.TableLayoutPanel tlp_topleft;
        private System.Windows.Forms.TableLayoutPanel tlp_buttons;
        private System.Windows.Forms.TableLayoutPanel tlp_botright;
        private System.Windows.Forms.TableLayoutPanel tlp_botmid;
        private System.Windows.Forms.TableLayoutPanel tlp_botleft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private AdvancedHMIControls.AnalogValueDisplay avd_volt;
        private AdvancedHMIControls.AnalogValueDisplay avd_curr;
        private AdvancedHMIControls.AnalogValueDisplay avd_power_e;
        private AdvancedHMIControls.AnalogValueDisplay avd_volt_fw;
        private AdvancedHMIControls.AnalogValueDisplay avd_speed_rot;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private AdvancedHMIControls.AnalogValueDisplay avd_power_dc;
        private AdvancedHMIControls.AnalogValueDisplay avd_torque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private AdvancedHMIControls.AnalogValueDisplay avd_speed_mod;
        private AdvancedHMIControls.AnalogValueDisplay avd_speed_wav;
        private AdvancedHMIControls.AnalogValueDisplay avd_freq;
        private AdvancedHMIControls.AnalogValueDisplay avd_curr_fw;
        private AdvancedHMIControls.AnalogValueDisplay avd_power_mec;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_25;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_75;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_90;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbl_power_p;
        private System.Windows.Forms.Label lbl_power_target;
        private System.Windows.Forms.Label lbl_power_actual;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lbl_pc_step;
        private System.Windows.Forms.Label lbl_steady_t;
        private System.Windows.Forms.Label lbl_pid_stop;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbo_model;
        private System.Windows.Forms.ComboBox cbo_orderid;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_logs;
        private System.Windows.Forms.Button btn_load_manual;
        private System.Windows.Forms.Button btn_load_status;
        private System.Windows.Forms.Button btn_plc_status;
        private System.Windows.Forms.Button btn_sql_connect;
        private System.Windows.Forms.Button btn_sql_query;
        private System.Windows.Forms.Button btn_autoload;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_order_setting;
        private System.Windows.Forms.Button btn_model_setting;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Timer timer_realtime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer_load;
    }
}