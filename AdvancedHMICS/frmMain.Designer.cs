
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
            this.tlp_ground = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_layout = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_botmid_ground = new System.Windows.Forms.Panel();
            this.tlp_botmid = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cbm_orderid = new System.Windows.Forms.ComboBox();
            this.cbm_model = new System.Windows.Forms.ComboBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.tlp_steps = new System.Windows.Forms.TableLayoutPanel();
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
            this.pnl_topleft_ground = new System.Windows.Forms.Panel();
            this.tlp_topleft = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_speedrpm = new System.Windows.Forms.Label();
            this.avd_FWVolt = new AdvancedHMIControls.AnalogValueDisplay();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.avd_voltage = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_electricP = new AdvancedHMIControls.AnalogValueDisplay();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.avd_current = new AdvancedHMIControls.AnalogValueDisplay();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_botleft_ground = new System.Windows.Forms.Panel();
            this.tlp_botleft = new System.Windows.Forms.TableLayoutPanel();
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
            this.lbl_adj_value = new System.Windows.Forms.Label();
            this.lbl_steadyT = new System.Windows.Forms.Label();
            this.lbl_pcStep = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lbl_adj = new System.Windows.Forms.Label();
            this.pnl_topright_ground = new System.Windows.Forms.Panel();
            this.tlp_topright = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.avd_machanicalP = new AdvancedHMIControls.AnalogValueDisplay();
            this.label28 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.avd_FWcurr = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_rotspdmod = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_frequency = new AdvancedHMIControls.AnalogValueDisplay();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.avd_rotspdwav = new AdvancedHMIControls.AnalogValueDisplay();
            this.label36 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pnl_topmid_ground = new System.Windows.Forms.Panel();
            this.tlp_topmid = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.avd_torque = new AdvancedHMIControls.AnalogValueDisplay();
            this.avd_DCpower = new AdvancedHMIControls.AnalogValueDisplay();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pnl_botright_ground = new System.Windows.Forms.Panel();
            this.tlp_botright = new System.Windows.Forms.TableLayoutPanel();
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
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerSQL = new System.Windows.Forms.Timer(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tlp_ground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlp_layout.SuspendLayout();
            this.pnl_botmid_ground.SuspendLayout();
            this.tlp_botmid.SuspendLayout();
            this.tlp_steps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_topleft_ground.SuspendLayout();
            this.tlp_topleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            this.pnl_botleft_ground.SuspendLayout();
            this.tlp_botleft.SuspendLayout();
            this.pnl_topright_ground.SuspendLayout();
            this.tlp_topright.SuspendLayout();
            this.pnl_topmid_ground.SuspendLayout();
            this.tlp_topmid.SuspendLayout();
            this.pnl_botright_ground.SuspendLayout();
            this.tlp_botright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_ground
            // 
            this.tlp_ground.BackColor = System.Drawing.Color.White;
            this.tlp_ground.ColumnCount = 2;
            this.tlp_ground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_ground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ground.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_ground.Controls.Add(this.label1, 1, 0);
            this.tlp_ground.Controls.Add(this.tlp_layout, 0, 1);
            this.tlp_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ground.Location = new System.Drawing.Point(0, 0);
            this.tlp_ground.Name = "tlp_ground";
            this.tlp_ground.RowCount = 2;
            this.tlp_ground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlp_ground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ground.Size = new System.Drawing.Size(1184, 561);
            this.tlp_ground.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "General Dynamics Intelligent Test System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_layout
            // 
            this.tlp_layout.ColumnCount = 3;
            this.tlp_ground.SetColumnSpan(this.tlp_layout, 2);
            this.tlp_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_layout.Controls.Add(this.pnl_botmid_ground, 1, 3);
            this.tlp_layout.Controls.Add(this.tlp_steps, 0, 2);
            this.tlp_layout.Controls.Add(this.pnl_topleft_ground, 0, 0);
            this.tlp_layout.Controls.Add(this.pnl_botleft_ground, 0, 3);
            this.tlp_layout.Controls.Add(this.pnl_topright_ground, 2, 0);
            this.tlp_layout.Controls.Add(this.pnl_topmid_ground, 1, 0);
            this.tlp_layout.Controls.Add(this.pnl_botright_ground, 2, 3);
            this.tlp_layout.Controls.Add(this.gc_main, 0, 1);
            this.tlp_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_layout.Location = new System.Drawing.Point(3, 45);
            this.tlp_layout.Name = "tlp_layout";
            this.tlp_layout.RowCount = 4;
            this.tlp_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_layout.Size = new System.Drawing.Size(1178, 513);
            this.tlp_layout.TabIndex = 3;
            // 
            // pnl_botmid_ground
            // 
            this.pnl_botmid_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_botmid_ground.Controls.Add(this.tlp_botmid);
            this.pnl_botmid_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_botmid_ground.Location = new System.Drawing.Point(395, 379);
            this.pnl_botmid_ground.Name = "pnl_botmid_ground";
            this.pnl_botmid_ground.Size = new System.Drawing.Size(386, 131);
            this.pnl_botmid_ground.TabIndex = 78;
            // 
            // tlp_botmid
            // 
            this.tlp_botmid.ColumnCount = 2;
            this.tlp_botmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botmid.Controls.Add(this.label63, 0, 0);
            this.tlp_botmid.Controls.Add(this.label45, 0, 1);
            this.tlp_botmid.Controls.Add(this.label46, 0, 2);
            this.tlp_botmid.Controls.Add(this.cbm_orderid, 1, 2);
            this.tlp_botmid.Controls.Add(this.cbm_model, 1, 0);
            this.tlp_botmid.Controls.Add(this.txt_barcode, 1, 1);
            this.tlp_botmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botmid.Location = new System.Drawing.Point(0, 0);
            this.tlp_botmid.Name = "tlp_botmid";
            this.tlp_botmid.RowCount = 4;
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botmid.Size = new System.Drawing.Size(382, 127);
            this.tlp_botmid.TabIndex = 71;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(3, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(110, 31);
            this.label63.TabIndex = 61;
            this.label63.Text = "Test Standard";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(3, 31);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 31);
            this.label45.TabIndex = 62;
            this.label45.Text = "Barcode";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 62);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(110, 31);
            this.label46.TabIndex = 63;
            this.label46.Text = "Order ID";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbm_orderid
            // 
            this.cbm_orderid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbm_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_orderid.FormattingEnabled = true;
            this.cbm_orderid.Location = new System.Drawing.Point(119, 65);
            this.cbm_orderid.Name = "cbm_orderid";
            this.cbm_orderid.Size = new System.Drawing.Size(260, 24);
            this.cbm_orderid.TabIndex = 68;
            // 
            // cbm_model
            // 
            this.cbm_model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbm_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_model.FormattingEnabled = true;
            this.cbm_model.Location = new System.Drawing.Point(119, 3);
            this.cbm_model.Name = "cbm_model";
            this.cbm_model.Size = new System.Drawing.Size(260, 24);
            this.cbm_model.TabIndex = 67;
            this.cbm_model.SelectedIndexChanged += new System.EventHandler(this.cbm_model_SelectedIndexChanged);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(119, 34);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(260, 22);
            this.txt_barcode.TabIndex = 65;
            this.txt_barcode.Text = "barcodetest";
            // 
            // tlp_steps
            // 
            this.tlp_steps.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlp_steps.ColumnCount = 11;
            this.tlp_layout.SetColumnSpan(this.tlp_steps, 3);
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tlp_steps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tlp_steps.Controls.Add(this.btn_90, 10, 0);
            this.tlp_steps.Controls.Add(this.pictureBox6, 9, 0);
            this.tlp_steps.Controls.Add(this.btn_100, 8, 0);
            this.tlp_steps.Controls.Add(this.pictureBox5, 7, 0);
            this.tlp_steps.Controls.Add(this.btn_75, 6, 0);
            this.tlp_steps.Controls.Add(this.pictureBox4, 5, 0);
            this.tlp_steps.Controls.Add(this.btn_50, 4, 0);
            this.tlp_steps.Controls.Add(this.pictureBox3, 3, 0);
            this.tlp_steps.Controls.Add(this.btn_25, 2, 0);
            this.tlp_steps.Controls.Add(this.pictureBox2, 1, 0);
            this.tlp_steps.Controls.Add(this.btn_0, 0, 0);
            this.tlp_steps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_steps.Location = new System.Drawing.Point(3, 319);
            this.tlp_steps.Name = "tlp_steps";
            this.tlp_steps.RowCount = 1;
            this.tlp_steps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_steps.Size = new System.Drawing.Size(1172, 54);
            this.tlp_steps.TabIndex = 76;
            // 
            // btn_90
            // 
            this.btn_90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_90.Location = new System.Drawing.Point(1056, 6);
            this.btn_90.Name = "btn_90";
            this.btn_90.Size = new System.Drawing.Size(110, 42);
            this.btn_90.TabIndex = 10;
            this.btn_90.Text = "90%";
            this.btn_90.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox6.Location = new System.Drawing.Point(956, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(91, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // btn_100
            // 
            this.btn_100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.Location = new System.Drawing.Point(846, 6);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(101, 42);
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
            this.pictureBox5.Location = new System.Drawing.Point(746, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // btn_75
            // 
            this.btn_75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_75.Location = new System.Drawing.Point(636, 6);
            this.btn_75.Name = "btn_75";
            this.btn_75.Size = new System.Drawing.Size(101, 42);
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
            this.pictureBox4.Location = new System.Drawing.Point(536, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btn_50
            // 
            this.btn_50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.Location = new System.Drawing.Point(426, 6);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(101, 42);
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
            this.pictureBox3.Location = new System.Drawing.Point(326, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btn_25
            // 
            this.btn_25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_25.Location = new System.Drawing.Point(216, 6);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(101, 42);
            this.btn_25.TabIndex = 2;
            this.btn_25.Tag = "2";
            this.btn_25.Text = "25%";
            this.btn_25.UseVisualStyleBackColor = true;
            this.btn_25.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::AdvancedHMICS.Properties.Resources.nexticon;
            this.pictureBox2.Location = new System.Drawing.Point(116, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(6, 6);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(101, 42);
            this.btn_0.TabIndex = 1;
            this.btn_0.Tag = "1";
            this.btn_0.Text = "0%";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // pnl_topleft_ground
            // 
            this.pnl_topleft_ground.BackColor = System.Drawing.Color.White;
            this.pnl_topleft_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_topleft_ground.Controls.Add(this.tlp_topleft);
            this.pnl_topleft_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_topleft_ground.Location = new System.Drawing.Point(3, 3);
            this.pnl_topleft_ground.Name = "pnl_topleft_ground";
            this.pnl_topleft_ground.Size = new System.Drawing.Size(386, 175);
            this.pnl_topleft_ground.TabIndex = 69;
            // 
            // tlp_topleft
            // 
            this.tlp_topleft.ColumnCount = 3;
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topleft.Controls.Add(this.label12, 2, 4);
            this.tlp_topleft.Controls.Add(this.label2, 0, 0);
            this.tlp_topleft.Controls.Add(this.lbl_speedrpm, 1, 4);
            this.tlp_topleft.Controls.Add(this.avd_FWVolt, 1, 3);
            this.tlp_topleft.Controls.Add(this.label13, 2, 3);
            this.tlp_topleft.Controls.Add(this.avd_voltage, 1, 0);
            this.tlp_topleft.Controls.Add(this.avd_electricP, 1, 2);
            this.tlp_topleft.Controls.Add(this.label6, 0, 4);
            this.tlp_topleft.Controls.Add(this.label15, 2, 2);
            this.tlp_topleft.Controls.Add(this.label14, 2, 0);
            this.tlp_topleft.Controls.Add(this.avd_current, 1, 1);
            this.tlp_topleft.Controls.Add(this.label5, 0, 3);
            this.tlp_topleft.Controls.Add(this.label3, 0, 1);
            this.tlp_topleft.Controls.Add(this.label16, 2, 1);
            this.tlp_topleft.Controls.Add(this.label4, 0, 2);
            this.tlp_topleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topleft.Location = new System.Drawing.Point(0, 0);
            this.tlp_topleft.Name = "tlp_topleft";
            this.tlp_topleft.RowCount = 5;
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topleft.Size = new System.Drawing.Size(382, 171);
            this.tlp_topleft.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(340, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 35);
            this.label12.TabIndex = 73;
            this.label12.Text = "rpm";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 61;
            this.label2.Text = "Voltage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_speedrpm
            // 
            this.lbl_speedrpm.AutoSize = true;
            this.lbl_speedrpm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_speedrpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speedrpm.Location = new System.Drawing.Point(111, 136);
            this.lbl_speedrpm.Name = "lbl_speedrpm";
            this.lbl_speedrpm.Size = new System.Drawing.Size(223, 35);
            this.lbl_speedrpm.TabIndex = 80;
            this.lbl_speedrpm.Text = "0.00";
            this.lbl_speedrpm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // avd_FWVolt
            // 
            this.avd_FWVolt.AutoSize = true;
            this.avd_FWVolt.ComComponent = this.modbusRTUCom1;
            this.avd_FWVolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_FWVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_FWVolt.ForeColor = System.Drawing.Color.Red;
            this.avd_FWVolt.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_FWVolt.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_FWVolt.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_FWVolt.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_FWVolt.KeypadMaxValue = 0D;
            this.avd_FWVolt.KeypadMinValue = 0D;
            this.avd_FWVolt.KeypadPasscode = null;
            this.avd_FWVolt.KeypadScaleFactor = 1D;
            this.avd_FWVolt.KeypadText = null;
            this.avd_FWVolt.KeypadWidth = 300;
            this.avd_FWVolt.Location = new System.Drawing.Point(111, 102);
            this.avd_FWVolt.Name = "avd_FWVolt";
            this.avd_FWVolt.NumericFormat = null;
            this.avd_FWVolt.PLCAddressKeypad = "";
            this.avd_FWVolt.PLCAddressValue = null;
            this.avd_FWVolt.PLCAddressValueLimitLower = null;
            this.avd_FWVolt.PLCAddressValueLimitUpper = null;
            this.avd_FWVolt.PLCAddressVisible = null;
            this.avd_FWVolt.ShowValue = true;
            this.avd_FWVolt.Size = new System.Drawing.Size(223, 34);
            this.avd_FWVolt.TabIndex = 77;
            this.avd_FWVolt.Text = "0.00";
            this.avd_FWVolt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_FWVolt.Value = "0.00";
            this.avd_FWVolt.ValueLimitLower = 2900D;
            this.avd_FWVolt.ValueLimitUpper = 3600D;
            this.avd_FWVolt.ValuePrefix = null;
            this.avd_FWVolt.ValueSuffix = null;
            this.avd_FWVolt.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
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
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.Two;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 1000;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(340, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 34);
            this.label13.TabIndex = 72;
            this.label13.Text = "V";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_voltage
            // 
            this.avd_voltage.AutoSize = true;
            this.avd_voltage.ComComponent = this.modbusRTUCom1;
            this.avd_voltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_voltage.ForeColor = System.Drawing.Color.Red;
            this.avd_voltage.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_voltage.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_voltage.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_voltage.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_voltage.KeypadMaxValue = 0D;
            this.avd_voltage.KeypadMinValue = 0D;
            this.avd_voltage.KeypadPasscode = null;
            this.avd_voltage.KeypadScaleFactor = 1D;
            this.avd_voltage.KeypadText = null;
            this.avd_voltage.KeypadWidth = 300;
            this.avd_voltage.Location = new System.Drawing.Point(111, 0);
            this.avd_voltage.Name = "avd_voltage";
            this.avd_voltage.NumericFormat = "0.00";
            this.avd_voltage.PLCAddressKeypad = "";
            this.avd_voltage.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_voltage.PLCAddressValue")));
            this.avd_voltage.PLCAddressValueLimitLower = null;
            this.avd_voltage.PLCAddressValueLimitUpper = null;
            this.avd_voltage.PLCAddressVisible = null;
            this.avd_voltage.ShowValue = true;
            this.avd_voltage.Size = new System.Drawing.Size(223, 34);
            this.avd_voltage.TabIndex = 79;
            this.avd_voltage.Text = "0.00";
            this.avd_voltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_voltage.Value = "0.00";
            this.avd_voltage.ValueLimitLower = 2900D;
            this.avd_voltage.ValueLimitUpper = 3600D;
            this.avd_voltage.ValuePrefix = null;
            this.avd_voltage.ValueSuffix = null;
            this.avd_voltage.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_voltage.ValueChanged += new System.EventHandler(this.avd_voltage_ValueChanged);
            // 
            // avd_electricP
            // 
            this.avd_electricP.AutoSize = true;
            this.avd_electricP.ComComponent = this.modbusRTUCom1;
            this.avd_electricP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_electricP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_electricP.ForeColor = System.Drawing.Color.Red;
            this.avd_electricP.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_electricP.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_electricP.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_electricP.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_electricP.KeypadMaxValue = 0D;
            this.avd_electricP.KeypadMinValue = 0D;
            this.avd_electricP.KeypadPasscode = null;
            this.avd_electricP.KeypadScaleFactor = 1D;
            this.avd_electricP.KeypadText = null;
            this.avd_electricP.KeypadWidth = 300;
            this.avd_electricP.Location = new System.Drawing.Point(111, 68);
            this.avd_electricP.Name = "avd_electricP";
            this.avd_electricP.NumericFormat = null;
            this.avd_electricP.PLCAddressKeypad = "";
            this.avd_electricP.PLCAddressValue = null;
            this.avd_electricP.PLCAddressValueLimitLower = null;
            this.avd_electricP.PLCAddressValueLimitUpper = null;
            this.avd_electricP.PLCAddressVisible = null;
            this.avd_electricP.ShowValue = true;
            this.avd_electricP.Size = new System.Drawing.Size(223, 34);
            this.avd_electricP.TabIndex = 76;
            this.avd_electricP.Text = "0.00";
            this.avd_electricP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_electricP.Value = "0.00";
            this.avd_electricP.ValueLimitLower = 2900D;
            this.avd_electricP.ValueLimitUpper = 3600D;
            this.avd_electricP.ValuePrefix = null;
            this.avd_electricP.ValueSuffix = null;
            this.avd_electricP.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 35);
            this.label6.TabIndex = 68;
            this.label6.Text = "ROT Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(340, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 34);
            this.label15.TabIndex = 71;
            this.label15.Text = "kW";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(340, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 34);
            this.label14.TabIndex = 69;
            this.label14.Text = "V";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_current
            // 
            this.avd_current.AutoSize = true;
            this.avd_current.ComComponent = this.modbusRTUCom1;
            this.avd_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_current.ForeColor = System.Drawing.Color.Red;
            this.avd_current.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_current.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_current.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_current.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_current.KeypadMaxValue = 0D;
            this.avd_current.KeypadMinValue = 0D;
            this.avd_current.KeypadPasscode = null;
            this.avd_current.KeypadScaleFactor = 1D;
            this.avd_current.KeypadText = null;
            this.avd_current.KeypadWidth = 300;
            this.avd_current.Location = new System.Drawing.Point(111, 34);
            this.avd_current.Name = "avd_current";
            this.avd_current.NumericFormat = null;
            this.avd_current.PLCAddressKeypad = "";
            this.avd_current.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_current.PLCAddressValue")));
            this.avd_current.PLCAddressValueLimitLower = null;
            this.avd_current.PLCAddressValueLimitUpper = null;
            this.avd_current.PLCAddressVisible = null;
            this.avd_current.ShowValue = true;
            this.avd_current.Size = new System.Drawing.Size(223, 34);
            this.avd_current.TabIndex = 75;
            this.avd_current.Text = "0.00";
            this.avd_current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_current.Value = "0.00";
            this.avd_current.ValueLimitLower = 2900D;
            this.avd_current.ValueLimitUpper = 3600D;
            this.avd_current.ValuePrefix = null;
            this.avd_current.ValueSuffix = null;
            this.avd_current.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_current.ValueChanged += new System.EventHandler(this.avd_current_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 34);
            this.label5.TabIndex = 67;
            this.label5.Text = "FW Volt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 65;
            this.label3.Text = "Current";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 34);
            this.label16.TabIndex = 70;
            this.label16.Text = "A";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 34);
            this.label4.TabIndex = 66;
            this.label4.Text = "Electric P";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_botleft_ground
            // 
            this.pnl_botleft_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_botleft_ground.Controls.Add(this.tlp_botleft);
            this.pnl_botleft_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_botleft_ground.Location = new System.Drawing.Point(3, 379);
            this.pnl_botleft_ground.Name = "pnl_botleft_ground";
            this.pnl_botleft_ground.Size = new System.Drawing.Size(386, 131);
            this.pnl_botleft_ground.TabIndex = 75;
            // 
            // tlp_botleft
            // 
            this.tlp_botleft.ColumnCount = 5;
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_botleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_botleft.Controls.Add(this.lbl_status_automanual, 1, 6);
            this.tlp_botleft.Controls.Add(this.label25, 0, 0);
            this.tlp_botleft.Controls.Add(this.label41, 0, 6);
            this.tlp_botleft.Controls.Add(this.label11, 0, 2);
            this.tlp_botleft.Controls.Add(this.label21, 0, 4);
            this.tlp_botleft.Controls.Add(this.lbl_rated_P, 0, 1);
            this.tlp_botleft.Controls.Add(this.lbl_targetP, 0, 3);
            this.tlp_botleft.Controls.Add(this.lbl_actualP, 0, 5);
            this.tlp_botleft.Controls.Add(this.label8, 1, 1);
            this.tlp_botleft.Controls.Add(this.label9, 1, 3);
            this.tlp_botleft.Controls.Add(this.label19, 1, 5);
            this.tlp_botleft.Controls.Add(this.label38, 4, 3);
            this.tlp_botleft.Controls.Add(this.label24, 4, 5);
            this.tlp_botleft.Controls.Add(this.lbl_adj_value, 3, 5);
            this.tlp_botleft.Controls.Add(this.lbl_steadyT, 3, 3);
            this.tlp_botleft.Controls.Add(this.lbl_pcStep, 3, 1);
            this.tlp_botleft.Controls.Add(this.label43, 3, 0);
            this.tlp_botleft.Controls.Add(this.label40, 3, 2);
            this.tlp_botleft.Controls.Add(this.lbl_adj, 3, 4);
            this.tlp_botleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botleft.Location = new System.Drawing.Point(0, 0);
            this.tlp_botleft.Name = "tlp_botleft";
            this.tlp_botleft.RowCount = 7;
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_botleft.Size = new System.Drawing.Size(382, 127);
            this.tlp_botleft.TabIndex = 71;
            // 
            // lbl_status_automanual
            // 
            this.lbl_status_automanual.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.lbl_status_automanual, 4);
            this.lbl_status_automanual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status_automanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_automanual.Location = new System.Drawing.Point(153, 108);
            this.lbl_status_automanual.Name = "lbl_status_automanual";
            this.lbl_status_automanual.Size = new System.Drawing.Size(226, 19);
            this.lbl_status_automanual.TabIndex = 84;
            this.lbl_status_automanual.Text = "Manual";
            this.lbl_status_automanual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.label25, 2);
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(179, 18);
            this.label25.TabIndex = 61;
            this.label25.Text = "Rated P:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(3, 108);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(144, 19);
            this.label41.TabIndex = 83;
            this.label41.Text = "Status:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.label11, 2);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 18);
            this.label11.TabIndex = 68;
            this.label11.Text = "Target P";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.label21, 2);
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(179, 18);
            this.label21.TabIndex = 71;
            this.label21.Text = "Actual P";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rated_P
            // 
            this.lbl_rated_P.AutoSize = true;
            this.lbl_rated_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rated_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rated_P.Location = new System.Drawing.Point(3, 18);
            this.lbl_rated_P.Name = "lbl_rated_P";
            this.lbl_rated_P.Size = new System.Drawing.Size(144, 18);
            this.lbl_rated_P.TabIndex = 66;
            this.lbl_rated_P.Text = "0.000";
            this.lbl_rated_P.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_targetP
            // 
            this.lbl_targetP.AutoSize = true;
            this.lbl_targetP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_targetP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_targetP.Location = new System.Drawing.Point(3, 54);
            this.lbl_targetP.Name = "lbl_targetP";
            this.lbl_targetP.Size = new System.Drawing.Size(144, 18);
            this.lbl_targetP.TabIndex = 69;
            this.lbl_targetP.Text = "0.000";
            this.lbl_targetP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_actualP
            // 
            this.lbl_actualP.AutoSize = true;
            this.lbl_actualP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_actualP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualP.Location = new System.Drawing.Point(3, 90);
            this.lbl_actualP.Name = "lbl_actualP";
            this.lbl_actualP.Size = new System.Drawing.Size(144, 18);
            this.lbl_actualP.TabIndex = 72;
            this.lbl_actualP.Text = "0.000";
            this.lbl_actualP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "kW";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "kW";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(153, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 18);
            this.label19.TabIndex = 73;
            this.label19.Text = "kW";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(358, 54);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(21, 18);
            this.label38.TabIndex = 79;
            this.label38.Text = "s";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(358, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 18);
            this.label24.TabIndex = 82;
            this.label24.Text = "%";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adj_value
            // 
            this.lbl_adj_value.AutoSize = true;
            this.lbl_adj_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_adj_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adj_value.Location = new System.Drawing.Point(208, 90);
            this.lbl_adj_value.Name = "lbl_adj_value";
            this.lbl_adj_value.Size = new System.Drawing.Size(144, 18);
            this.lbl_adj_value.TabIndex = 81;
            this.lbl_adj_value.Text = "0.00";
            this.lbl_adj_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_steadyT
            // 
            this.lbl_steadyT.AutoSize = true;
            this.lbl_steadyT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_steadyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steadyT.Location = new System.Drawing.Point(208, 54);
            this.lbl_steadyT.Name = "lbl_steadyT";
            this.lbl_steadyT.Size = new System.Drawing.Size(144, 18);
            this.lbl_steadyT.TabIndex = 78;
            this.lbl_steadyT.Text = "0";
            this.lbl_steadyT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pcStep
            // 
            this.lbl_pcStep.AutoSize = true;
            this.lbl_pcStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pcStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcStep.Location = new System.Drawing.Point(208, 18);
            this.lbl_pcStep.Name = "lbl_pcStep";
            this.lbl_pcStep.Size = new System.Drawing.Size(144, 18);
            this.lbl_pcStep.TabIndex = 75;
            this.lbl_pcStep.Text = "1-5";
            this.lbl_pcStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.label43, 2);
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(208, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(171, 18);
            this.label43.TabIndex = 74;
            this.label43.Text = "PC Step: ";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.label40, 2);
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(208, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(171, 18);
            this.label40.TabIndex = 77;
            this.label40.Text = "Steady T:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adj
            // 
            this.lbl_adj.AutoSize = true;
            this.tlp_botleft.SetColumnSpan(this.lbl_adj, 2);
            this.lbl_adj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_adj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adj.Location = new System.Drawing.Point(208, 72);
            this.lbl_adj.Name = "lbl_adj";
            this.lbl_adj.Size = new System.Drawing.Size(171, 18);
            this.lbl_adj.TabIndex = 80;
            this.lbl_adj.Text = "Adjusting";
            this.lbl_adj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_topright_ground
            // 
            this.pnl_topright_ground.BackColor = System.Drawing.Color.White;
            this.pnl_topright_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_topright_ground.Controls.Add(this.tlp_topright);
            this.pnl_topright_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_topright_ground.Location = new System.Drawing.Point(787, 3);
            this.pnl_topright_ground.Name = "pnl_topright_ground";
            this.pnl_topright_ground.Size = new System.Drawing.Size(388, 175);
            this.pnl_topright_ground.TabIndex = 73;
            // 
            // tlp_topright
            // 
            this.tlp_topright.ColumnCount = 3;
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topright.Controls.Add(this.label27, 2, 4);
            this.tlp_topright.Controls.Add(this.avd_machanicalP, 1, 4);
            this.tlp_topright.Controls.Add(this.label28, 2, 3);
            this.tlp_topright.Controls.Add(this.label34, 0, 0);
            this.tlp_topright.Controls.Add(this.avd_FWcurr, 1, 3);
            this.tlp_topright.Controls.Add(this.avd_rotspdmod, 1, 0);
            this.tlp_topright.Controls.Add(this.avd_frequency, 1, 2);
            this.tlp_topright.Controls.Add(this.label29, 2, 0);
            this.tlp_topright.Controls.Add(this.label32, 0, 4);
            this.tlp_topright.Controls.Add(this.label30, 2, 2);
            this.tlp_topright.Controls.Add(this.label33, 0, 3);
            this.tlp_topright.Controls.Add(this.avd_rotspdwav, 1, 1);
            this.tlp_topright.Controls.Add(this.label36, 0, 1);
            this.tlp_topright.Controls.Add(this.label31, 2, 1);
            this.tlp_topright.Controls.Add(this.label35, 0, 2);
            this.tlp_topright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topright.Location = new System.Drawing.Point(0, 0);
            this.tlp_topright.Name = "tlp_topright";
            this.tlp_topright.RowCount = 5;
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_topright.Size = new System.Drawing.Size(384, 171);
            this.tlp_topright.TabIndex = 79;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(349, 136);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 35);
            this.label27.TabIndex = 73;
            this.label27.Text = "Kw";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_machanicalP
            // 
            this.avd_machanicalP.AutoSize = true;
            this.avd_machanicalP.ComComponent = this.modbusRTUCom1;
            this.avd_machanicalP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_machanicalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_machanicalP.ForeColor = System.Drawing.Color.Red;
            this.avd_machanicalP.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_machanicalP.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_machanicalP.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_machanicalP.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_machanicalP.KeypadMaxValue = 0D;
            this.avd_machanicalP.KeypadMinValue = 0D;
            this.avd_machanicalP.KeypadPasscode = null;
            this.avd_machanicalP.KeypadScaleFactor = 1D;
            this.avd_machanicalP.KeypadText = null;
            this.avd_machanicalP.KeypadWidth = 300;
            this.avd_machanicalP.Location = new System.Drawing.Point(135, 136);
            this.avd_machanicalP.Name = "avd_machanicalP";
            this.avd_machanicalP.NumericFormat = null;
            this.avd_machanicalP.PLCAddressKeypad = "";
            this.avd_machanicalP.PLCAddressValue = null;
            this.avd_machanicalP.PLCAddressValueLimitLower = null;
            this.avd_machanicalP.PLCAddressValueLimitUpper = null;
            this.avd_machanicalP.PLCAddressVisible = null;
            this.avd_machanicalP.ShowValue = true;
            this.avd_machanicalP.Size = new System.Drawing.Size(208, 35);
            this.avd_machanicalP.TabIndex = 78;
            this.avd_machanicalP.Text = "0.00";
            this.avd_machanicalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_machanicalP.Value = "0.00";
            this.avd_machanicalP.ValueLimitLower = 2900D;
            this.avd_machanicalP.ValueLimitUpper = 3600D;
            this.avd_machanicalP.ValuePrefix = null;
            this.avd_machanicalP.ValueSuffix = null;
            this.avd_machanicalP.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(349, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 34);
            this.label28.TabIndex = 72;
            this.label28.Text = "A";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.White;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(126, 34);
            this.label34.TabIndex = 61;
            this.label34.Text = "ROT Spd. mod";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_FWcurr
            // 
            this.avd_FWcurr.AutoSize = true;
            this.avd_FWcurr.ComComponent = this.modbusRTUCom1;
            this.avd_FWcurr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_FWcurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_FWcurr.ForeColor = System.Drawing.Color.Red;
            this.avd_FWcurr.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_FWcurr.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_FWcurr.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_FWcurr.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_FWcurr.KeypadMaxValue = 0D;
            this.avd_FWcurr.KeypadMinValue = 0D;
            this.avd_FWcurr.KeypadPasscode = null;
            this.avd_FWcurr.KeypadScaleFactor = 1D;
            this.avd_FWcurr.KeypadText = null;
            this.avd_FWcurr.KeypadWidth = 300;
            this.avd_FWcurr.Location = new System.Drawing.Point(135, 102);
            this.avd_FWcurr.Name = "avd_FWcurr";
            this.avd_FWcurr.NumericFormat = null;
            this.avd_FWcurr.PLCAddressKeypad = "";
            this.avd_FWcurr.PLCAddressValue = null;
            this.avd_FWcurr.PLCAddressValueLimitLower = null;
            this.avd_FWcurr.PLCAddressValueLimitUpper = null;
            this.avd_FWcurr.PLCAddressVisible = null;
            this.avd_FWcurr.ShowValue = true;
            this.avd_FWcurr.Size = new System.Drawing.Size(208, 34);
            this.avd_FWcurr.TabIndex = 77;
            this.avd_FWcurr.Text = "0.00";
            this.avd_FWcurr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_FWcurr.Value = "0.00";
            this.avd_FWcurr.ValueLimitLower = 2900D;
            this.avd_FWcurr.ValueLimitUpper = 3600D;
            this.avd_FWcurr.ValuePrefix = null;
            this.avd_FWcurr.ValueSuffix = null;
            this.avd_FWcurr.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_rotspdmod
            // 
            this.avd_rotspdmod.AutoSize = true;
            this.avd_rotspdmod.ComComponent = this.modbusRTUCom1;
            this.avd_rotspdmod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_rotspdmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_rotspdmod.ForeColor = System.Drawing.Color.Red;
            this.avd_rotspdmod.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_rotspdmod.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_rotspdmod.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_rotspdmod.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_rotspdmod.KeypadMaxValue = 0D;
            this.avd_rotspdmod.KeypadMinValue = 0D;
            this.avd_rotspdmod.KeypadPasscode = null;
            this.avd_rotspdmod.KeypadScaleFactor = 1D;
            this.avd_rotspdmod.KeypadText = null;
            this.avd_rotspdmod.KeypadWidth = 300;
            this.avd_rotspdmod.Location = new System.Drawing.Point(135, 0);
            this.avd_rotspdmod.Name = "avd_rotspdmod";
            this.avd_rotspdmod.NumericFormat = null;
            this.avd_rotspdmod.PLCAddressKeypad = "";
            this.avd_rotspdmod.PLCAddressValue = null;
            this.avd_rotspdmod.PLCAddressValueLimitLower = null;
            this.avd_rotspdmod.PLCAddressValueLimitUpper = null;
            this.avd_rotspdmod.PLCAddressVisible = null;
            this.avd_rotspdmod.ShowValue = true;
            this.avd_rotspdmod.Size = new System.Drawing.Size(208, 34);
            this.avd_rotspdmod.TabIndex = 74;
            this.avd_rotspdmod.Text = "0.00";
            this.avd_rotspdmod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_rotspdmod.Value = "0.00";
            this.avd_rotspdmod.ValueLimitLower = 2900D;
            this.avd_rotspdmod.ValueLimitUpper = 3600D;
            this.avd_rotspdmod.ValuePrefix = null;
            this.avd_rotspdmod.ValueSuffix = null;
            this.avd_rotspdmod.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // avd_frequency
            // 
            this.avd_frequency.AutoSize = true;
            this.avd_frequency.ComComponent = this.modbusRTUCom1;
            this.avd_frequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_frequency.ForeColor = System.Drawing.Color.Red;
            this.avd_frequency.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_frequency.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_frequency.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_frequency.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_frequency.KeypadMaxValue = 0D;
            this.avd_frequency.KeypadMinValue = 0D;
            this.avd_frequency.KeypadPasscode = null;
            this.avd_frequency.KeypadScaleFactor = 1D;
            this.avd_frequency.KeypadText = null;
            this.avd_frequency.KeypadWidth = 300;
            this.avd_frequency.Location = new System.Drawing.Point(135, 68);
            this.avd_frequency.Name = "avd_frequency";
            this.avd_frequency.NumericFormat = null;
            this.avd_frequency.PLCAddressKeypad = "";
            this.avd_frequency.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("avd_frequency.PLCAddressValue")));
            this.avd_frequency.PLCAddressValueLimitLower = null;
            this.avd_frequency.PLCAddressValueLimitUpper = null;
            this.avd_frequency.PLCAddressVisible = null;
            this.avd_frequency.ShowValue = true;
            this.avd_frequency.Size = new System.Drawing.Size(208, 34);
            this.avd_frequency.TabIndex = 76;
            this.avd_frequency.Text = "0.00";
            this.avd_frequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_frequency.Value = "0.00";
            this.avd_frequency.ValueLimitLower = 2900D;
            this.avd_frequency.ValueLimitUpper = 3600D;
            this.avd_frequency.ValuePrefix = null;
            this.avd_frequency.ValueSuffix = null;
            this.avd_frequency.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.avd_frequency.ValueChanged += new System.EventHandler(this.avd_frequency_ValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(349, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 34);
            this.label29.TabIndex = 69;
            this.label29.Text = "%";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 136);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(126, 35);
            this.label32.TabIndex = 68;
            this.label32.Text = "Mechanical P";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(349, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 34);
            this.label30.TabIndex = 71;
            this.label30.Text = "Hz";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(3, 102);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(126, 34);
            this.label33.TabIndex = 67;
            this.label33.Text = "FW Curr";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_rotspdwav
            // 
            this.avd_rotspdwav.AutoSize = true;
            this.avd_rotspdwav.ComComponent = this.modbusRTUCom1;
            this.avd_rotspdwav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_rotspdwav.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_rotspdwav.ForeColor = System.Drawing.Color.Red;
            this.avd_rotspdwav.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_rotspdwav.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_rotspdwav.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_rotspdwav.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_rotspdwav.KeypadMaxValue = 0D;
            this.avd_rotspdwav.KeypadMinValue = 0D;
            this.avd_rotspdwav.KeypadPasscode = null;
            this.avd_rotspdwav.KeypadScaleFactor = 1D;
            this.avd_rotspdwav.KeypadText = null;
            this.avd_rotspdwav.KeypadWidth = 300;
            this.avd_rotspdwav.Location = new System.Drawing.Point(135, 34);
            this.avd_rotspdwav.Name = "avd_rotspdwav";
            this.avd_rotspdwav.NumericFormat = null;
            this.avd_rotspdwav.PLCAddressKeypad = "";
            this.avd_rotspdwav.PLCAddressValue = null;
            this.avd_rotspdwav.PLCAddressValueLimitLower = null;
            this.avd_rotspdwav.PLCAddressValueLimitUpper = null;
            this.avd_rotspdwav.PLCAddressVisible = null;
            this.avd_rotspdwav.ShowValue = true;
            this.avd_rotspdwav.Size = new System.Drawing.Size(208, 34);
            this.avd_rotspdwav.TabIndex = 75;
            this.avd_rotspdwav.Text = "0.00";
            this.avd_rotspdwav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_rotspdwav.Value = "0.00";
            this.avd_rotspdwav.ValueLimitLower = 2900D;
            this.avd_rotspdwav.ValueLimitUpper = 3600D;
            this.avd_rotspdwav.ValuePrefix = null;
            this.avd_rotspdwav.ValueSuffix = null;
            this.avd_rotspdwav.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.White;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(3, 34);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(126, 34);
            this.label36.TabIndex = 65;
            this.label36.Text = "ROT Spd. wav";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(349, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 34);
            this.label31.TabIndex = 70;
            this.label31.Text = "%";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(126, 34);
            this.label35.TabIndex = 66;
            this.label35.Text = "Frequency";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_topmid_ground
            // 
            this.pnl_topmid_ground.BackColor = System.Drawing.Color.White;
            this.pnl_topmid_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_topmid_ground.Controls.Add(this.tlp_topmid);
            this.pnl_topmid_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_topmid_ground.Location = new System.Drawing.Point(395, 3);
            this.pnl_topmid_ground.Name = "pnl_topmid_ground";
            this.pnl_topmid_ground.Size = new System.Drawing.Size(386, 175);
            this.pnl_topmid_ground.TabIndex = 72;
            // 
            // tlp_topmid
            // 
            this.tlp_topmid.ColumnCount = 3;
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topmid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_topmid.Controls.Add(this.label23, 0, 0);
            this.tlp_topmid.Controls.Add(this.label17, 2, 1);
            this.tlp_topmid.Controls.Add(this.avd_torque, 1, 1);
            this.tlp_topmid.Controls.Add(this.avd_DCpower, 1, 0);
            this.tlp_topmid.Controls.Add(this.label18, 2, 0);
            this.tlp_topmid.Controls.Add(this.label22, 0, 1);
            this.tlp_topmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topmid.Location = new System.Drawing.Point(0, 0);
            this.tlp_topmid.Name = "tlp_topmid";
            this.tlp_topmid.RowCount = 3;
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_topmid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_topmid.Size = new System.Drawing.Size(382, 171);
            this.tlp_topmid.TabIndex = 79;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 40);
            this.label23.TabIndex = 67;
            this.label23.Text = "DC Power";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(339, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 40);
            this.label17.TabIndex = 73;
            this.label17.Text = "N.m";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avd_torque
            // 
            this.avd_torque.AutoSize = true;
            this.avd_torque.ComComponent = this.modbusRTUCom1;
            this.avd_torque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_torque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_torque.ForeColor = System.Drawing.Color.Red;
            this.avd_torque.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_torque.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_torque.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_torque.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_torque.KeypadMaxValue = 0D;
            this.avd_torque.KeypadMinValue = 0D;
            this.avd_torque.KeypadPasscode = null;
            this.avd_torque.KeypadScaleFactor = 1D;
            this.avd_torque.KeypadText = null;
            this.avd_torque.KeypadWidth = 300;
            this.avd_torque.Location = new System.Drawing.Point(97, 40);
            this.avd_torque.Name = "avd_torque";
            this.avd_torque.NumericFormat = null;
            this.avd_torque.PLCAddressKeypad = "";
            this.avd_torque.PLCAddressValue = null;
            this.avd_torque.PLCAddressValueLimitLower = null;
            this.avd_torque.PLCAddressValueLimitUpper = null;
            this.avd_torque.PLCAddressVisible = null;
            this.avd_torque.ShowValue = true;
            this.avd_torque.Size = new System.Drawing.Size(236, 40);
            this.avd_torque.TabIndex = 78;
            this.avd_torque.Text = "0.00";
            this.avd_torque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.avd_DCpower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avd_DCpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avd_DCpower.ForeColor = System.Drawing.Color.Red;
            this.avd_DCpower.ForeColorInLimits = System.Drawing.Color.Black;
            this.avd_DCpower.ForeColorOverLimit = System.Drawing.Color.Red;
            this.avd_DCpower.ForeColorUnderLimit = System.Drawing.Color.Red;
            this.avd_DCpower.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.avd_DCpower.KeypadMaxValue = 0D;
            this.avd_DCpower.KeypadMinValue = 0D;
            this.avd_DCpower.KeypadPasscode = null;
            this.avd_DCpower.KeypadScaleFactor = 1D;
            this.avd_DCpower.KeypadText = null;
            this.avd_DCpower.KeypadWidth = 300;
            this.avd_DCpower.Location = new System.Drawing.Point(97, 0);
            this.avd_DCpower.Name = "avd_DCpower";
            this.avd_DCpower.NumericFormat = null;
            this.avd_DCpower.PLCAddressKeypad = "";
            this.avd_DCpower.PLCAddressValue = null;
            this.avd_DCpower.PLCAddressValueLimitLower = null;
            this.avd_DCpower.PLCAddressValueLimitUpper = null;
            this.avd_DCpower.PLCAddressVisible = null;
            this.avd_DCpower.ShowValue = true;
            this.avd_DCpower.Size = new System.Drawing.Size(236, 40);
            this.avd_DCpower.TabIndex = 77;
            this.avd_DCpower.Text = "0";
            this.avd_DCpower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avd_DCpower.Value = "0";
            this.avd_DCpower.ValueLimitLower = 2900D;
            this.avd_DCpower.ValueLimitUpper = 3600D;
            this.avd_DCpower.ValuePrefix = null;
            this.avd_DCpower.ValueSuffix = null;
            this.avd_DCpower.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(339, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 40);
            this.label18.TabIndex = 72;
            this.label18.Text = "W";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 40);
            this.label22.TabIndex = 68;
            this.label22.Text = "Torque";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_botright_ground
            // 
            this.pnl_botright_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_botright_ground.Controls.Add(this.tlp_botright);
            this.pnl_botright_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_botright_ground.Location = new System.Drawing.Point(787, 379);
            this.pnl_botright_ground.Name = "pnl_botright_ground";
            this.pnl_botright_ground.Size = new System.Drawing.Size(388, 131);
            this.pnl_botright_ground.TabIndex = 79;
            // 
            // tlp_botright
            // 
            this.tlp_botright.ColumnCount = 4;
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.Controls.Add(this.btn_data, 0, 1);
            this.tlp_botright.Controls.Add(this.btn_settingorder, 3, 1);
            this.tlp_botright.Controls.Add(this.btn_deleterow, 1, 0);
            this.tlp_botright.Controls.Add(this.btn_export, 3, 0);
            this.tlp_botright.Controls.Add(this.btn_autoload, 1, 2);
            this.tlp_botright.Controls.Add(this.btn_manualload, 2, 3);
            this.tlp_botright.Controls.Add(this.btn_querysqlite, 2, 2);
            this.tlp_botright.Controls.Add(this.btn_modelSetting, 2, 1);
            this.tlp_botright.Controls.Add(this.btn_start, 0, 2);
            this.tlp_botright.Controls.Add(this.btn_clear, 2, 0);
            this.tlp_botright.Controls.Add(this.btn_plcstatus, 0, 3);
            this.tlp_botright.Controls.Add(this.btn_loadStatus, 1, 3);
            this.tlp_botright.Controls.Add(this.btn_record, 0, 0);
            this.tlp_botright.Controls.Add(this.btn_user, 1, 1);
            this.tlp_botright.Controls.Add(this.btnSqlConnect, 3, 2);
            this.tlp_botright.Controls.Add(this.btnSqlLogs, 3, 3);
            this.tlp_botright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botright.Location = new System.Drawing.Point(0, 0);
            this.tlp_botright.Name = "tlp_botright";
            this.tlp_botright.RowCount = 4;
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_botright.Size = new System.Drawing.Size(384, 127);
            this.tlp_botright.TabIndex = 16;
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.LightGray;
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Location = new System.Drawing.Point(3, 34);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(90, 25);
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
            this.btn_settingorder.Location = new System.Drawing.Point(291, 34);
            this.btn_settingorder.Name = "btn_settingorder";
            this.btn_settingorder.Size = new System.Drawing.Size(90, 25);
            this.btn_settingorder.TabIndex = 15;
            this.btn_settingorder.Text = "Order Setting";
            this.btn_settingorder.UseVisualStyleBackColor = false;
            this.btn_settingorder.Click += new System.EventHandler(this.btn_settingorder_Click);
            // 
            // btn_deleterow
            // 
            this.btn_deleterow.BackColor = System.Drawing.Color.LightGray;
            this.btn_deleterow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deleterow.Enabled = false;
            this.btn_deleterow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleterow.Location = new System.Drawing.Point(99, 3);
            this.btn_deleterow.Name = "btn_deleterow";
            this.btn_deleterow.Size = new System.Drawing.Size(90, 25);
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
            this.btn_export.Location = new System.Drawing.Point(291, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(90, 25);
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
            this.btn_autoload.Location = new System.Drawing.Point(99, 65);
            this.btn_autoload.Name = "btn_autoload";
            this.btn_autoload.Size = new System.Drawing.Size(90, 25);
            this.btn_autoload.TabIndex = 5;
            this.btn_autoload.Text = "Auto Load";
            this.btn_autoload.UseVisualStyleBackColor = false;
            this.btn_autoload.Click += new System.EventHandler(this.btn_autoload_Click);
            // 
            // btn_manualload
            // 
            this.btn_manualload.BackColor = System.Drawing.Color.LightGray;
            this.btn_manualload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_manualload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manualload.Location = new System.Drawing.Point(195, 96);
            this.btn_manualload.Name = "btn_manualload";
            this.btn_manualload.Size = new System.Drawing.Size(90, 28);
            this.btn_manualload.TabIndex = 10;
            this.btn_manualload.Text = "Manual Load";
            this.btn_manualload.UseVisualStyleBackColor = false;
            // 
            // btn_querysqlite
            // 
            this.btn_querysqlite.BackColor = System.Drawing.Color.LightGray;
            this.btn_querysqlite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_querysqlite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_querysqlite.Location = new System.Drawing.Point(195, 65);
            this.btn_querysqlite.Name = "btn_querysqlite";
            this.btn_querysqlite.Size = new System.Drawing.Size(90, 25);
            this.btn_querysqlite.TabIndex = 11;
            this.btn_querysqlite.Text = "Query SQLite";
            this.btn_querysqlite.UseVisualStyleBackColor = false;
            this.btn_querysqlite.Click += new System.EventHandler(this.btn_querysqlite_Click);
            // 
            // btn_modelSetting
            // 
            this.btn_modelSetting.BackColor = System.Drawing.Color.LightGray;
            this.btn_modelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modelSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelSetting.Location = new System.Drawing.Point(195, 34);
            this.btn_modelSetting.Name = "btn_modelSetting";
            this.btn_modelSetting.Size = new System.Drawing.Size(90, 25);
            this.btn_modelSetting.TabIndex = 13;
            this.btn_modelSetting.Text = "Model Setting";
            this.btn_modelSetting.UseVisualStyleBackColor = false;
            this.btn_modelSetting.Click += new System.EventHandler(this.btn_modelSetting_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(3, 65);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 25);
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
            this.btn_clear.Location = new System.Drawing.Point(195, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 25);
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
            this.btn_plcstatus.Location = new System.Drawing.Point(3, 96);
            this.btn_plcstatus.Name = "btn_plcstatus";
            this.btn_plcstatus.Size = new System.Drawing.Size(90, 28);
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
            this.btn_loadStatus.Location = new System.Drawing.Point(99, 96);
            this.btn_loadStatus.Name = "btn_loadStatus";
            this.btn_loadStatus.Size = new System.Drawing.Size(90, 28);
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
            this.btn_record.Size = new System.Drawing.Size(90, 25);
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
            this.btn_user.Location = new System.Drawing.Point(99, 34);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(90, 25);
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
            this.btnSqlConnect.Location = new System.Drawing.Point(291, 65);
            this.btnSqlConnect.Name = "btnSqlConnect";
            this.btnSqlConnect.Size = new System.Drawing.Size(90, 25);
            this.btnSqlConnect.TabIndex = 16;
            this.btnSqlConnect.Text = "SQL Connect";
            this.btnSqlConnect.UseVisualStyleBackColor = false;
            this.btnSqlConnect.Click += new System.EventHandler(this.btnSqlConnect_Click);
            // 
            // btnSqlLogs
            // 
            this.btnSqlLogs.BackColor = System.Drawing.Color.LightGray;
            this.btnSqlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqlLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlLogs.Location = new System.Drawing.Point(291, 96);
            this.btnSqlLogs.Name = "btnSqlLogs";
            this.btnSqlLogs.Size = new System.Drawing.Size(90, 28);
            this.btnSqlLogs.TabIndex = 17;
            this.btnSqlLogs.Text = "Logs";
            this.btnSqlLogs.UseVisualStyleBackColor = false;
            this.btnSqlLogs.Click += new System.EventHandler(this.btnSqlLogs_Click);
            // 
            // gc_main
            // 
            this.tlp_layout.SetColumnSpan(this.gc_main, 3);
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_main.Location = new System.Drawing.Point(3, 184);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(1172, 129);
            this.gc_main.TabIndex = 80;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerSQL
            // 
            this.timerSQL.Interval = 60000;
            this.timerSQL.Tick += new System.EventHandler(this.timerSQL_Tick);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tlp_ground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Tester Machine v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlp_ground.ResumeLayout(false);
            this.tlp_ground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlp_layout.ResumeLayout(false);
            this.pnl_botmid_ground.ResumeLayout(false);
            this.tlp_botmid.ResumeLayout(false);
            this.tlp_botmid.PerformLayout();
            this.tlp_steps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_topleft_ground.ResumeLayout(false);
            this.tlp_topleft.ResumeLayout(false);
            this.tlp_topleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            this.pnl_botleft_ground.ResumeLayout(false);
            this.tlp_botleft.ResumeLayout(false);
            this.tlp_botleft.PerformLayout();
            this.pnl_topright_ground.ResumeLayout(false);
            this.tlp_topright.ResumeLayout(false);
            this.tlp_topright.PerformLayout();
            this.pnl_topmid_ground.ResumeLayout(false);
            this.tlp_topmid.ResumeLayout(false);
            this.tlp_topmid.PerformLayout();
            this.pnl_botright_ground.ResumeLayout(false);
            this.tlp_botright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_topright_ground;
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
        private System.Windows.Forms.Panel pnl_topmid_ground;
        private AdvancedHMIControls.AnalogValueDisplay avd_torque;
        private AdvancedHMIControls.AnalogValueDisplay avd_DCpower;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnl_topleft_ground;
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
        private System.Windows.Forms.Panel pnl_botleft_ground;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tlp_steps;
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
        private System.Windows.Forms.Label lbl_adj_value;
        private System.Windows.Forms.Label lbl_adj;
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
        private System.Windows.Forms.Panel pnl_botmid_ground;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel pnl_botright_ground;
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
        private System.Windows.Forms.TableLayoutPanel tlp_botright;
        private System.Windows.Forms.TableLayoutPanel tlp_botleft;
        private System.Windows.Forms.TableLayoutPanel tlp_botmid;
        private System.Windows.Forms.Button btnSqlConnect;
        private System.Windows.Forms.Button btnSqlLogs;
        private System.Windows.Forms.Timer timerSQL;
        private System.Windows.Forms.TableLayoutPanel tlp_topmid;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.TableLayoutPanel tlp_topleft;
        private System.Windows.Forms.TableLayoutPanel tlp_topright;
        private System.Windows.Forms.TableLayoutPanel tlp_layout;
    }
}