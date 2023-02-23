
namespace AdvancedHMICS
{
    partial class frmSettingModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingModel));
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_numberofstep = new System.Windows.Forms.NumericUpDown();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_createnewmodel = new System.Windows.Forms.Button();
            this.cbm_testbarkes = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_cycles = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_ratedspeed = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_loadingtime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_minspeedfluctuationlimit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_maxspeedfluctuationlimit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_minspeedregulationlimit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_maxspeedregulationlimit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_minbrakingtimelimit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_maxbrakingtimelimit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_minfrequecy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_maxfrequecy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mingeneratorvoltagelimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_maxgenertorvoltagelimit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mingenratorcurrentlimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maxgenratorcurrentlimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ratedpower = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minnoloadspeedlimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maxnoloadspeedlimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newmodel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.btn_deletemodel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberofstep)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_main
            // 
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_main.Location = new System.Drawing.Point(3, 263);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(1122, 172);
            this.gc_main.TabIndex = 2;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn24,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23});
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "ID";
            this.gridColumn24.FieldName = "ID";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Steps";
            this.gridColumn1.FieldName = "ck_serial";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Max No-load speed limit";
            this.gridColumn2.FieldName = "ck_Max_Noloadlimitspeed";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Min No-load speed  limit";
            this.gridColumn3.FieldName = "ck_Min_Noloadlimitspeed";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Step load power";
            this.gridColumn4.FieldName = "ck_Steppower";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "rated power";
            this.gridColumn5.FieldName = "ck_power";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "load percentage";
            this.gridColumn6.FieldName = "ck_Steppercentage";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Max Generator";
            this.gridColumn7.FieldName = "ck_Max_Generator";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Min Generator";
            this.gridColumn8.FieldName = "ck_Min_Generator";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Max VolGenerator";
            this.gridColumn9.FieldName = "ck_Max_VolGenerator";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Min VolGenerator";
            this.gridColumn10.FieldName = "ck_Min_VolGenerator";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Max frequency";
            this.gridColumn11.FieldName = "ck_Max_frequency";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Min frequency";
            this.gridColumn12.FieldName = "ck_Min_frequency";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Max braketime";
            this.gridColumn13.FieldName = "ck_Max_braketime";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Min braketime";
            this.gridColumn14.FieldName = "ck_Min_braketime";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 14;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Max regulationspeed";
            this.gridColumn15.FieldName = "ck_Max_regulationspeed";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 15;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Min regulationSpeed";
            this.gridColumn16.FieldName = "ck_Min_regulationSpeed";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 16;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Max fluctuationspeed";
            this.gridColumn17.FieldName = "ck_Max_fluctuationspeed";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 17;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Min fluctuationspeed";
            this.gridColumn18.FieldName = "ck_Min_fluctuationspeed";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 18;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "LoadTime";
            this.gridColumn19.FieldName = "ck_LoadTime";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 19;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Speed";
            this.gridColumn20.FieldName = "ck_speed";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 20;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Cycles";
            this.gridColumn21.FieldName = "ck_cycles";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 21;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "model";
            this.gridColumn22.FieldName = "ck_model";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 22;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "testbrakes";
            this.gridColumn23.FieldName = "ck_testbrakes";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gc_main, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 438);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deletemodel);
            this.panel1.Controls.Add(this.btn_loaddata);
            this.panel1.Controls.Add(this.nud_numberofstep);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_createnewmodel);
            this.panel1.Controls.Add(this.cbm_testbarkes);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_cycles);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_ratedspeed);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txt_loadingtime);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txt_minspeedfluctuationlimit);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_maxspeedfluctuationlimit);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txt_minspeedregulationlimit);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_maxspeedregulationlimit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txt_minbrakingtimelimit);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_maxbrakingtimelimit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_minfrequecy);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_maxfrequecy);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_mingeneratorvoltagelimit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_maxgenertorvoltagelimit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_mingenratorcurrentlimit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_maxgenratorcurrentlimit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_ratedpower);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_minnoloadspeedlimit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_maxnoloadspeedlimit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_newmodel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 254);
            this.panel1.TabIndex = 3;
            // 
            // nud_numberofstep
            // 
            this.nud_numberofstep.Location = new System.Drawing.Point(23, 72);
            this.nud_numberofstep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_numberofstep.Name = "nud_numberofstep";
            this.nud_numberofstep.Size = new System.Drawing.Size(86, 20);
            this.nud_numberofstep.TabIndex = 49;
            this.nud_numberofstep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(788, 207);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(107, 34);
            this.btn_export.TabIndex = 48;
            this.btn_export.Text = "Export to Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(644, 207);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 34);
            this.btn_clear.TabIndex = 47;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(322, 207);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 34);
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Update Edit";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_createnewmodel
            // 
            this.btn_createnewmodel.Location = new System.Drawing.Point(172, 207);
            this.btn_createnewmodel.Name = "btn_createnewmodel";
            this.btn_createnewmodel.Size = new System.Drawing.Size(107, 34);
            this.btn_createnewmodel.TabIndex = 45;
            this.btn_createnewmodel.Text = "Create New Model";
            this.btn_createnewmodel.UseVisualStyleBackColor = true;
            this.btn_createnewmodel.Click += new System.EventHandler(this.btn_createnewmodel_Click);
            // 
            // cbm_testbarkes
            // 
            this.cbm_testbarkes.FormattingEnabled = true;
            this.cbm_testbarkes.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbm_testbarkes.Location = new System.Drawing.Point(149, 123);
            this.cbm_testbarkes.Name = "cbm_testbarkes";
            this.cbm_testbarkes.Size = new System.Drawing.Size(86, 21);
            this.cbm_testbarkes.TabIndex = 44;
            this.cbm_testbarkes.Text = "No";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(146, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Test Brakes";
            // 
            // txt_cycles
            // 
            this.txt_cycles.Location = new System.Drawing.Point(23, 123);
            this.txt_cycles.Name = "txt_cycles";
            this.txt_cycles.Size = new System.Drawing.Size(86, 20);
            this.txt_cycles.TabIndex = 42;
            this.txt_cycles.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Cycles";
            // 
            // txt_ratedspeed
            // 
            this.txt_ratedspeed.Location = new System.Drawing.Point(912, 169);
            this.txt_ratedspeed.Name = "txt_ratedspeed";
            this.txt_ratedspeed.Size = new System.Drawing.Size(90, 20);
            this.txt_ratedspeed.TabIndex = 40;
            this.txt_ratedspeed.Text = "3600";
            this.txt_ratedspeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ratedspeed_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(909, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Rated speed";
            // 
            // txt_loadingtime
            // 
            this.txt_loadingtime.Location = new System.Drawing.Point(912, 123);
            this.txt_loadingtime.Name = "txt_loadingtime";
            this.txt_loadingtime.Size = new System.Drawing.Size(90, 20);
            this.txt_loadingtime.TabIndex = 38;
            this.txt_loadingtime.Text = "4";
            this.txt_loadingtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loadingtime_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(909, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Loading Time";
            // 
            // txt_minspeedfluctuationlimit
            // 
            this.txt_minspeedfluctuationlimit.Location = new System.Drawing.Point(711, 169);
            this.txt_minspeedfluctuationlimit.Name = "txt_minspeedfluctuationlimit";
            this.txt_minspeedfluctuationlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_minspeedfluctuationlimit.TabIndex = 36;
            this.txt_minspeedfluctuationlimit.Text = "-10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(708, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Min Speed fluctuation  limit";
            // 
            // txt_maxspeedfluctuationlimit
            // 
            this.txt_maxspeedfluctuationlimit.Location = new System.Drawing.Point(711, 123);
            this.txt_maxspeedfluctuationlimit.Name = "txt_maxspeedfluctuationlimit";
            this.txt_maxspeedfluctuationlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxspeedfluctuationlimit.TabIndex = 34;
            this.txt_maxspeedfluctuationlimit.Text = "10";
            this.txt_maxspeedfluctuationlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxspeedfluctuationlimit_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(708, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Max Speed fluctuation  limit";
            // 
            // txt_minspeedregulationlimit
            // 
            this.txt_minspeedregulationlimit.Location = new System.Drawing.Point(507, 166);
            this.txt_minspeedregulationlimit.Name = "txt_minspeedregulationlimit";
            this.txt_minspeedregulationlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_minspeedregulationlimit.TabIndex = 32;
            this.txt_minspeedregulationlimit.Text = "-5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Min Speed regulation  limit";
            // 
            // txt_maxspeedregulationlimit
            // 
            this.txt_maxspeedregulationlimit.Location = new System.Drawing.Point(507, 120);
            this.txt_maxspeedregulationlimit.Name = "txt_maxspeedregulationlimit";
            this.txt_maxspeedregulationlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxspeedregulationlimit.TabIndex = 30;
            this.txt_maxspeedregulationlimit.Text = "5";
            this.txt_maxspeedregulationlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxspeedregulationlimit_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Max Speed regulation  limit";
            // 
            // txt_minbrakingtimelimit
            // 
            this.txt_minbrakingtimelimit.Location = new System.Drawing.Point(307, 166);
            this.txt_minbrakingtimelimit.Name = "txt_minbrakingtimelimit";
            this.txt_minbrakingtimelimit.Size = new System.Drawing.Size(123, 20);
            this.txt_minbrakingtimelimit.TabIndex = 28;
            this.txt_minbrakingtimelimit.Text = "0";
            this.txt_minbrakingtimelimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minbrakingtimelimit_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Min Braking time limit";
            // 
            // txt_maxbrakingtimelimit
            // 
            this.txt_maxbrakingtimelimit.Location = new System.Drawing.Point(307, 120);
            this.txt_maxbrakingtimelimit.Name = "txt_maxbrakingtimelimit";
            this.txt_maxbrakingtimelimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxbrakingtimelimit.TabIndex = 26;
            this.txt_maxbrakingtimelimit.Text = "5";
            this.txt_maxbrakingtimelimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxbrakingtimelimit_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max Braking time limit";
            // 
            // txt_minfrequecy
            // 
            this.txt_minfrequecy.Location = new System.Drawing.Point(912, 71);
            this.txt_minfrequecy.Name = "txt_minfrequecy";
            this.txt_minfrequecy.Size = new System.Drawing.Size(90, 20);
            this.txt_minfrequecy.TabIndex = 24;
            this.txt_minfrequecy.Text = "0";
            this.txt_minfrequecy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minfrequecy_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(909, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Min frequency";
            // 
            // txt_maxfrequecy
            // 
            this.txt_maxfrequecy.Location = new System.Drawing.Point(912, 25);
            this.txt_maxfrequecy.Name = "txt_maxfrequecy";
            this.txt_maxfrequecy.Size = new System.Drawing.Size(90, 20);
            this.txt_maxfrequecy.TabIndex = 22;
            this.txt_maxfrequecy.Text = "69";
            this.txt_maxfrequecy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxfrequecy_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Max Frequency";
            // 
            // txt_mingeneratorvoltagelimit
            // 
            this.txt_mingeneratorvoltagelimit.Location = new System.Drawing.Point(711, 71);
            this.txt_mingeneratorvoltagelimit.Name = "txt_mingeneratorvoltagelimit";
            this.txt_mingeneratorvoltagelimit.Size = new System.Drawing.Size(123, 20);
            this.txt_mingeneratorvoltagelimit.TabIndex = 20;
            this.txt_mingeneratorvoltagelimit.Text = "0";
            this.txt_mingeneratorvoltagelimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mingeneratorvoltagelimit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Min Generator voltage limit";
            // 
            // txt_maxgenertorvoltagelimit
            // 
            this.txt_maxgenertorvoltagelimit.Location = new System.Drawing.Point(711, 25);
            this.txt_maxgenertorvoltagelimit.Name = "txt_maxgenertorvoltagelimit";
            this.txt_maxgenertorvoltagelimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxgenertorvoltagelimit.TabIndex = 18;
            this.txt_maxgenertorvoltagelimit.Text = "240";
            this.txt_maxgenertorvoltagelimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxgenertorvoltagelimit_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(708, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Max Generator voltage limit";
            // 
            // txt_mingenratorcurrentlimit
            // 
            this.txt_mingenratorcurrentlimit.Location = new System.Drawing.Point(507, 71);
            this.txt_mingenratorcurrentlimit.Name = "txt_mingenratorcurrentlimit";
            this.txt_mingenratorcurrentlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_mingenratorcurrentlimit.TabIndex = 16;
            this.txt_mingenratorcurrentlimit.Text = "0";
            this.txt_mingenratorcurrentlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mingenratorcurrentlimit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Min Generator current  limit";
            // 
            // txt_maxgenratorcurrentlimit
            // 
            this.txt_maxgenratorcurrentlimit.Location = new System.Drawing.Point(507, 25);
            this.txt_maxgenratorcurrentlimit.Name = "txt_maxgenratorcurrentlimit";
            this.txt_maxgenratorcurrentlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxgenratorcurrentlimit.TabIndex = 14;
            this.txt_maxgenratorcurrentlimit.Text = "100";
            this.txt_maxgenratorcurrentlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxgenratorcurrentlimit_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Max Generator current  limit";
            // 
            // txt_ratedpower
            // 
            this.txt_ratedpower.Location = new System.Drawing.Point(149, 71);
            this.txt_ratedpower.Name = "txt_ratedpower";
            this.txt_ratedpower.Size = new System.Drawing.Size(86, 20);
            this.txt_ratedpower.TabIndex = 12;
            this.txt_ratedpower.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rated Power";
            // 
            // txt_minnoloadspeedlimit
            // 
            this.txt_minnoloadspeedlimit.Location = new System.Drawing.Point(307, 71);
            this.txt_minnoloadspeedlimit.Name = "txt_minnoloadspeedlimit";
            this.txt_minnoloadspeedlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_minnoloadspeedlimit.TabIndex = 10;
            this.txt_minnoloadspeedlimit.Text = "2900";
            this.txt_minnoloadspeedlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minnoloadspeedlimit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min No-load speed limit";
            // 
            // txt_maxnoloadspeedlimit
            // 
            this.txt_maxnoloadspeedlimit.Location = new System.Drawing.Point(307, 25);
            this.txt_maxnoloadspeedlimit.Name = "txt_maxnoloadspeedlimit";
            this.txt_maxnoloadspeedlimit.Size = new System.Drawing.Size(123, 20);
            this.txt_maxnoloadspeedlimit.TabIndex = 8;
            this.txt_maxnoloadspeedlimit.Text = "3600";
            this.txt_maxnoloadspeedlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxnoloadspeedlimit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max No-load speed limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Steps";
            // 
            // txt_newmodel
            // 
            this.txt_newmodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_newmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newmodel.Location = new System.Drawing.Point(23, 25);
            this.txt_newmodel.Name = "txt_newmodel";
            this.txt_newmodel.Size = new System.Drawing.Size(212, 22);
            this.txt_newmodel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Model:";
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(23, 207);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(107, 34);
            this.btn_loaddata.TabIndex = 50;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // btn_deletemodel
            // 
            this.btn_deletemodel.Location = new System.Drawing.Point(496, 207);
            this.btn_deletemodel.Name = "btn_deletemodel";
            this.btn_deletemodel.Size = new System.Drawing.Size(107, 34);
            this.btn_deletemodel.TabIndex = 51;
            this.btn_deletemodel.Text = "Delete Model";
            this.btn_deletemodel.UseVisualStyleBackColor = true;
            this.btn_deletemodel.Click += new System.EventHandler(this.btn_deletemodel_Click);
            // 
            // frmSettingModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettingModel";
            this.Text = "frmSettingModel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettingModel_FormClosing);
            this.Load += new System.EventHandler(this.frmSettingModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberofstep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_maxnoloadspeedlimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newmodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ratedpower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_minnoloadspeedlimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mingenratorcurrentlimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maxgenratorcurrentlimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_cycles;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_ratedspeed;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_loadingtime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_minspeedfluctuationlimit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_maxspeedfluctuationlimit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_minspeedregulationlimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_maxspeedregulationlimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_minbrakingtimelimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_maxbrakingtimelimit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_minfrequecy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_maxfrequecy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_mingeneratorvoltagelimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_maxgenertorvoltagelimit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_createnewmodel;
        private System.Windows.Forms.NumericUpDown nud_numberofstep;
        private System.Windows.Forms.ComboBox cbm_testbarkes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.Button btn_deletemodel;
    }
}