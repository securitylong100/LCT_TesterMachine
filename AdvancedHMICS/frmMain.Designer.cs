
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_settingorder = new System.Windows.Forms.Button();
            this.btn_deleterow = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_autoload = new System.Windows.Forms.Button();
            this.btn_manualload = new System.Windows.Forms.Button();
            this.btn_querysqlite = new System.Windows.Forms.Button();
            this.btn_modelSetting = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_plcstatus = new System.Windows.Forms.Button();
            this.btn_loadStatus = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btnSqlConnect = new System.Windows.Forms.Button();
            this.btnSqlLogs = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cbm_orderid = new System.Windows.Forms.ComboBox();
            this.cbm_model = new System.Windows.Forms.ComboBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.avd_machanicalP = new AdvancedHMIControls.AnalogValueDisplay();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_status_automanual = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_rated_P = new System.Windows.Forms.Label();
            this.lbl_targetP = new System.Windows.Forms.Label();
            this.lbl_actualP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_pidStop = new System.Windows.Forms.Label();
            this.lbl_steadyT = new System.Windows.Forms.Label();
            this.lbl_pcStep = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_90 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_100 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_75 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_50 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_25 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_0 = new System.Windows.Forms.Button();
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerSQL = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AdvancedHMICS.Properties.Resources.ifmbigsize;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.panel1.Size = new System.Drawing.Size(1208, 530);
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
            this.tableLayoutPanel2.Controls.Add(this.gc_main, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1208, 530);
            this.tableLayoutPanel2.TabIndex = 71;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.tableLayoutPanel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(806, 393);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(399, 134);
            this.panel7.TabIndex = 79;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btn_data, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_settingorder, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_deleterow, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_export, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_autoload, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_manualload, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.btn_querysqlite, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_modelSetting, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_start, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_clear, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_plcstatus, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btn_loadStatus, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btn_record, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_user, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSqlConnect, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnSqlLogs, 3, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(395, 130);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.LightGray;
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Location = new System.Drawing.Point(3, 35);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(92, 26);
            this.btn_data.TabIndex = 1;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_settingorder
            // 
            this.btn_settingorder.BackColor = System.Drawing.Color.LightGray;
            this.btn_settingorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_settingorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settingorder.Location = new System.Drawing.Point(297, 35);
            this.btn_settingorder.Name = "btn_settingorder";
            this.btn_settingorder.Size = new System.Drawing.Size(95, 26);
            this.btn_settingorder.TabIndex = 15;
            this.btn_settingorder.Text = "Setting Order";
            this.btn_settingorder.UseVisualStyleBackColor = false;
            this.btn_settingorder.Click += new System.EventHandler(this.btn_settingorder_Click);
            // 
            // btn_deleterow
            // 
            this.btn_deleterow.BackColor = System.Drawing.Color.LightGray;
            this.btn_deleterow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deleterow.Enabled = false;
            this.btn_deleterow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleterow.Location = new System.Drawing.Point(101, 3);
            this.btn_deleterow.Name = "btn_deleterow";
            this.btn_deleterow.Size = new System.Drawing.Size(92, 26);
            this.btn_deleterow.TabIndex = 4;
            this.btn_deleterow.Text = "Delete";
            this.btn_deleterow.UseVisualStyleBackColor = false;
            this.btn_deleterow.Click += new System.EventHandler(this.btn_deleterow_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.LightGray;
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_export.Enabled = false;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Location = new System.Drawing.Point(297, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(95, 26);
            this.btn_export.TabIndex = 14;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // btn_autoload
            // 
            this.btn_autoload.BackColor = System.Drawing.Color.LightGray;
            this.btn_autoload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_autoload.Enabled = false;
            this.btn_autoload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoload.Location = new System.Drawing.Point(101, 67);
            this.btn_autoload.Name = "btn_autoload";
            this.btn_autoload.Size = new System.Drawing.Size(92, 26);
            this.btn_autoload.TabIndex = 5;
            this.btn_autoload.Text = "AutoLoad";
            this.btn_autoload.UseVisualStyleBackColor = false;
            this.btn_autoload.Click += new System.EventHandler(this.btn_autoload_Click);
            // 
            // btn_manualload
            // 
            this.btn_manualload.BackColor = System.Drawing.Color.LightGray;
            this.btn_manualload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_manualload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manualload.Location = new System.Drawing.Point(199, 99);
            this.btn_manualload.Name = "btn_manualload";
            this.btn_manualload.Size = new System.Drawing.Size(92, 28);
            this.btn_manualload.TabIndex = 10;
            this.btn_manualload.Text = "ManualLoad";
            this.btn_manualload.UseVisualStyleBackColor = false;
            // 
            // btn_querysqlite
            // 
            this.btn_querysqlite.BackColor = System.Drawing.Color.LightGray;
            this.btn_querysqlite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_querysqlite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_querysqlite.Location = new System.Drawing.Point(199, 67);
            this.btn_querysqlite.Name = "btn_querysqlite";
            this.btn_querysqlite.Size = new System.Drawing.Size(92, 26);
            this.btn_querysqlite.TabIndex = 11;
            this.btn_querysqlite.Text = "QuerySQLite";
            this.btn_querysqlite.UseVisualStyleBackColor = false;
            this.btn_querysqlite.Click += new System.EventHandler(this.btn_querysqlite_Click);
            // 
            // btn_modelSetting
            // 
            this.btn_modelSetting.BackColor = System.Drawing.Color.LightGray;
            this.btn_modelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modelSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelSetting.Location = new System.Drawing.Point(199, 35);
            this.btn_modelSetting.Name = "btn_modelSetting";
            this.btn_modelSetting.Size = new System.Drawing.Size(92, 26);
            this.btn_modelSetting.TabIndex = 13;
            this.btn_modelSetting.Text = "Setting Model";
            this.btn_modelSetting.UseVisualStyleBackColor = false;
            this.btn_modelSetting.Click += new System.EventHandler(this.btn_modelSetting_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(3, 67);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(92, 26);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start/Run";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Enabled = false;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(199, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 26);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_plcstatus
            // 
            this.btn_plcstatus.BackColor = System.Drawing.Color.LightGray;
            this.btn_plcstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plcstatus.Enabled = false;
            this.btn_plcstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plcstatus.Location = new System.Drawing.Point(3, 99);
            this.btn_plcstatus.Name = "btn_plcstatus";
            this.btn_plcstatus.Size = new System.Drawing.Size(92, 28);
            this.btn_plcstatus.TabIndex = 3;
            this.btn_plcstatus.Text = "PLC Status";
            this.btn_plcstatus.UseVisualStyleBackColor = false;
            this.btn_plcstatus.Click += new System.EventHandler(this.btn_plcstatus_Click);
            // 
            // btn_loadStatus
            // 
            this.btn_loadStatus.BackColor = System.Drawing.Color.LightGray;
            this.btn_loadStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_loadStatus.Enabled = false;
            this.btn_loadStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadStatus.Location = new System.Drawing.Point(101, 99);
            this.btn_loadStatus.Name = "btn_loadStatus";
            this.btn_loadStatus.Size = new System.Drawing.Size(92, 28);
            this.btn_loadStatus.TabIndex = 9;
            this.btn_loadStatus.Text = "Load Status";
            this.btn_loadStatus.UseVisualStyleBackColor = false;
            this.btn_loadStatus.Click += new System.EventHandler(this.btn_loadStatus_Click);
            // 
            // btn_record
            // 
            this.btn_record.BackColor = System.Drawing.Color.LightGray;
            this.btn_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_record.Enabled = false;
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_record.Location = new System.Drawing.Point(3, 3);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(92, 26);
            this.btn_record.TabIndex = 0;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = false;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.LightGray;
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Location = new System.Drawing.Point(101, 35);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(92, 26);
            this.btn_user.TabIndex = 6;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btnSqlConnect
            // 
            this.btnSqlConnect.BackColor = System.Drawing.Color.Red;
            this.btnSqlConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqlConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlConnect.Location = new System.Drawing.Point(297, 67);
            this.btnSqlConnect.Name = "btnSqlConnect";
            this.btnSqlConnect.Size = new System.Drawing.Size(95, 26);
            this.btnSqlConnect.TabIndex = 16;
            this.btnSqlConnect.Text = "SQL Connect";
            this.btnSqlConnect.UseVisualStyleBackColor = false;
            this.btnSqlConnect.Click += new System.EventHandler(this.btnSqlConnect_Click);
            // 
            // btnSqlLogs
            // 
            this.btnSqlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqlLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlLogs.Location = new System.Drawing.Point(297, 99);
            this.btnSqlLogs.Name = "btnSqlLogs";
            this.btnSqlLogs.Size = new System.Drawing.Size(95, 28);
            this.btnSqlLogs.TabIndex = 17;
            this.btnSqlLogs.Text = "Logs";
            this.btnSqlLogs.UseVisualStyleBackColor = true;
            this.btnSqlLogs.Click += new System.EventHandler(this.btnSqlLogs_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(406, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 134);
            this.panel3.TabIndex = 78;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label63, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label45, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label46, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.cbm_orderid, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.cbm_model, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_barcode, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(390, 130);
            this.tableLayoutPanel6.TabIndex = 71;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(3, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(110, 32);
            this.label63.TabIndex = 61;
            this.label63.Text = "Test Standard";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(3, 32);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 32);
            this.label45.TabIndex = 62;
            this.label45.Text = "Barcode";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 64);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(110, 32);
            this.label46.TabIndex = 63;
            this.label46.Text = "Order ID";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbm_orderid
            // 
            this.cbm_orderid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbm_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_orderid.FormattingEnabled = true;
            this.cbm_orderid.Location = new System.Drawing.Point(119, 67);
            this.cbm_orderid.Name = "cbm_orderid";
            this.cbm_orderid.Size = new System.Drawing.Size(268, 24);
            this.cbm_orderid.TabIndex = 68;
            // 
            // cbm_model
            // 
            this.cbm_model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbm_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_model.FormattingEnabled = true;
            this.cbm_model.Location = new System.Drawing.Point(119, 3);
            this.cbm_model.Name = "cbm_model";
            this.cbm_model.Size = new System.Drawing.Size(268, 24);
            this.cbm_model.TabIndex = 67;
            this.cbm_model.SelectedIndexChanged += new System.EventHandler(this.cbm_model_SelectedIndexChanged);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(119, 35);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(268, 22);
            this.txt_barcode.TabIndex = 65;
            this.txt_barcode.Text = "barcodetest";
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
            this.panel5.Location = new System.Drawing.Point(806, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 224);
            this.panel5.TabIndex = 73;
            // 
            // avd_machanicalP
            // 
            this.avd_machanicalP.AutoSize = true;
            this.avd_machanicalP.ComComponent = this.modbusRTUCom1;
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
            // avd_FWcurr
            // 
            this.avd_FWcurr.AutoSize = true;
            this.avd_FWcurr.ComComponent = this.modbusRTUCom1;
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
            this.avd_frequency.ComComponent = this.modbusRTUCom1;
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
            this.avd_rotspdwav.ComComponent = this.modbusRTUCom1;
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
            this.avd_rotspdmod.ComComponent = this.modbusRTUCom1;
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
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.panel4.Location = new System.Drawing.Point(406, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 224);
            this.panel4.TabIndex = 72;
            // 
            // avd_torque
            // 
            this.avd_torque.AutoSize = true;
            this.avd_torque.ComComponent = this.modbusRTUCom1;
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
            this.avd_DCpower.ComComponent = this.modbusRTUCom1;
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
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.panel2.Size = new System.Drawing.Size(397, 224);
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
            this.avd_voltage.ComComponent = this.modbusRTUCom1;
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
            this.avd_voltage.NumericFormat = "0.00";
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
            this.avd_voltage.ValueChanged += new System.EventHandler(this.avd_voltage_ValueChanged);
            // 
            // avd_FWVolt
            // 
            this.avd_FWVolt.AutoSize = true;
            this.avd_FWVolt.ComComponent = this.modbusRTUCom1;
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
            this.avd_FWVolt.PLCAddressValue = null;
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
            this.avd_electricP.ComComponent = this.modbusRTUCom1;
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
            this.avd_electricP.PLCAddressValue = null;
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
            this.avd_current.ComComponent = this.modbusRTUCom1;
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
            this.avd_current.ValueChanged += new System.EventHandler(this.avd_current_ValueChanged);
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
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.panel6.Controls.Add(this.tableLayoutPanel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 393);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 134);
            this.panel6.TabIndex = 75;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.lbl_status_automanual, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label41, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_rated_P, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_targetP, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_actualP, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label19, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label38, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.label24, 6, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_pidStop, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_steadyT, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_pcStep, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label43, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label40, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label37, 4, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 130);
            this.tableLayoutPanel5.TabIndex = 71;
            // 
            // lbl_status_automanual
            // 
            this.lbl_status_automanual.AutoSize = true;
            this.lbl_status_automanual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status_automanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_automanual.Location = new System.Drawing.Point(80, 96);
            this.lbl_status_automanual.Name = "lbl_status_automanual";
            this.lbl_status_automanual.Size = new System.Drawing.Size(61, 34);
            this.lbl_status_automanual.TabIndex = 84;
            this.lbl_status_automanual.Text = "Manual";
            this.lbl_status_automanual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 32);
            this.label25.TabIndex = 61;
            this.label25.Text = "Rated P:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(3, 96);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 34);
            this.label41.TabIndex = 83;
            this.label41.Text = "Status:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 32);
            this.label11.TabIndex = 68;
            this.label11.Text = "Target P";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 32);
            this.label21.TabIndex = 71;
            this.label21.Text = "Actual P";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rated_P
            // 
            this.lbl_rated_P.AutoSize = true;
            this.lbl_rated_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rated_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rated_P.Location = new System.Drawing.Point(80, 0);
            this.lbl_rated_P.Name = "lbl_rated_P";
            this.lbl_rated_P.Size = new System.Drawing.Size(61, 32);
            this.lbl_rated_P.TabIndex = 66;
            this.lbl_rated_P.Text = "0.000";
            this.lbl_rated_P.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_targetP
            // 
            this.lbl_targetP.AutoSize = true;
            this.lbl_targetP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_targetP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_targetP.Location = new System.Drawing.Point(80, 32);
            this.lbl_targetP.Name = "lbl_targetP";
            this.lbl_targetP.Size = new System.Drawing.Size(61, 32);
            this.lbl_targetP.TabIndex = 69;
            this.lbl_targetP.Text = "0.000";
            this.lbl_targetP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_actualP
            // 
            this.lbl_actualP.AutoSize = true;
            this.lbl_actualP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_actualP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualP.Location = new System.Drawing.Point(80, 64);
            this.lbl_actualP.Name = "lbl_actualP";
            this.lbl_actualP.Size = new System.Drawing.Size(61, 32);
            this.lbl_actualP.TabIndex = 72;
            this.lbl_actualP.Text = "0.000";
            this.lbl_actualP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 32);
            this.label8.TabIndex = 67;
            this.label8.Text = "kW";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(147, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 32);
            this.label9.TabIndex = 70;
            this.label9.Text = "kW";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(147, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 32);
            this.label19.TabIndex = 73;
            this.label19.Text = "kW";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(367, 32);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 32);
            this.label38.TabIndex = 79;
            this.label38.Text = "s";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(367, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 32);
            this.label24.TabIndex = 82;
            this.label24.Text = "%";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pidStop
            // 
            this.lbl_pidStop.AutoSize = true;
            this.lbl_pidStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pidStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pidStop.Location = new System.Drawing.Point(321, 64);
            this.lbl_pidStop.Name = "lbl_pidStop";
            this.lbl_pidStop.Size = new System.Drawing.Size(40, 32);
            this.lbl_pidStop.TabIndex = 81;
            this.lbl_pidStop.Text = "0.00";
            this.lbl_pidStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_steadyT
            // 
            this.lbl_steadyT.AutoSize = true;
            this.lbl_steadyT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_steadyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steadyT.Location = new System.Drawing.Point(321, 32);
            this.lbl_steadyT.Name = "lbl_steadyT";
            this.lbl_steadyT.Size = new System.Drawing.Size(40, 32);
            this.lbl_steadyT.TabIndex = 78;
            this.lbl_steadyT.Text = "0";
            this.lbl_steadyT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pcStep
            // 
            this.lbl_pcStep.AutoSize = true;
            this.lbl_pcStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pcStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcStep.Location = new System.Drawing.Point(321, 0);
            this.lbl_pcStep.Name = "lbl_pcStep";
            this.lbl_pcStep.Size = new System.Drawing.Size(40, 32);
            this.lbl_pcStep.TabIndex = 75;
            this.lbl_pcStep.Text = "1-5";
            this.lbl_pcStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(237, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(78, 32);
            this.label43.TabIndex = 74;
            this.label43.Text = "PC Step: ";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(237, 32);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 32);
            this.label40.TabIndex = 77;
            this.label40.Text = "Steady T:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(237, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(78, 32);
            this.label37.TabIndex = 80;
            this.label37.Text = "PID Stop:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel3.Controls.Add(this.btn_90, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_100, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox5, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_75, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_50, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_25, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_0, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 333);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1202, 54);
            this.tableLayoutPanel3.TabIndex = 76;
            // 
            // btn_90
            // 
            this.btn_90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_90.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_90.Location = new System.Drawing.Point(1086, 6);
            this.btn_90.Name = "btn_90";
            this.btn_90.Size = new System.Drawing.Size(110, 42);
            this.btn_90.TabIndex = 10;
            this.btn_90.Text = "90% NA";
            this.btn_90.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox6.Location = new System.Drawing.Point(978, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(99, 42);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // btn_100
            // 
            this.btn_100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.Location = new System.Drawing.Point(870, 6);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(99, 42);
            this.btn_100.TabIndex = 8;
            this.btn_100.Tag = "5";
            this.btn_100.Text = "100%";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox5.Location = new System.Drawing.Point(762, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 42);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // btn_75
            // 
            this.btn_75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_75.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_75.Location = new System.Drawing.Point(654, 6);
            this.btn_75.Name = "btn_75";
            this.btn_75.Size = new System.Drawing.Size(99, 42);
            this.btn_75.TabIndex = 6;
            this.btn_75.Tag = "4";
            this.btn_75.Text = "75%";
            this.btn_75.UseVisualStyleBackColor = true;
            this.btn_75.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox4.Location = new System.Drawing.Point(546, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(99, 42);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btn_50
            // 
            this.btn_50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.Location = new System.Drawing.Point(438, 6);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(99, 42);
            this.btn_50.TabIndex = 4;
            this.btn_50.Tag = "3";
            this.btn_50.Text = "50%";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox3.Location = new System.Drawing.Point(330, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 42);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btn_25
            // 
            this.btn_25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_25.Location = new System.Drawing.Point(222, 6);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(99, 42);
            this.btn_25.TabIndex = 2;
            this.btn_25.Tag = "2";
            this.btn_25.Text = "25%";
            this.btn_25.UseVisualStyleBackColor = true;
            this.btn_25.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox2.Location = new System.Drawing.Point(114, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 42);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(6, 6);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(99, 42);
            this.btn_0.TabIndex = 1;
            this.btn_0.Tag = "1";
            this.btn_0.Text = "0%";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // gc_main
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.gc_main, 3);
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_main.Location = new System.Drawing.Point(3, 233);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(1202, 94);
            this.gc_main.TabIndex = 80;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "General Dynamics Intelligent Test System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerSQL
            // 
            this.timerSQL.Interval = 60000;
            this.timerSQL.Tick += new System.EventHandler(this.timerSQL_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Tester Machine v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btn_90;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_75;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_25;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_pidStop;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbl_steadyT;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lbl_pcStep;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_actualP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_targetP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_rated_P;
        private System.Windows.Forms.Label lbl_status_automanual;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_querysqlite;
        private System.Windows.Forms.Button btn_manualload;
        private System.Windows.Forms.Button btn_loadStatus;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_autoload;
        private System.Windows.Forms.Button btn_deleterow;
        private System.Windows.Forms.Button btn_plcstatus;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_settingorder;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_modelSetting;
        private System.Windows.Forms.Button btn_clear;
        private AdvancedHMIControls.AnalogValueDisplay avd_voltage;
        private System.Windows.Forms.Label lbl_speedrpm;
        private DevExpress.XtraGrid.GridControl gc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_main;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private System.Windows.Forms.ComboBox cbm_orderid;
        private System.Windows.Forms.ComboBox cbm_model;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnSqlConnect;
        private System.Windows.Forms.Button btnSqlLogs;
        private System.Windows.Forms.Timer timerSQL;
    }
}