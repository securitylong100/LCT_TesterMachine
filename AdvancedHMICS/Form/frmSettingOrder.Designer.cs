
namespace AdvancedHMICS
{
    partial class frmSettingOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteorderID = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.btn_createneworderID = new System.Windows.Forms.Button();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbm_model = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gc_main, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deleteorderID);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_orderid);
            this.panel1.Controls.Add(this.btn_createneworderID);
            this.panel1.Controls.Add(this.btn_loaddata);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbm_model);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 174);
            this.panel1.TabIndex = 5;
            // 
            // btn_deleteorderID
            // 
            this.btn_deleteorderID.Location = new System.Drawing.Point(172, 130);
            this.btn_deleteorderID.Name = "btn_deleteorderID";
            this.btn_deleteorderID.Size = new System.Drawing.Size(107, 34);
            this.btn_deleteorderID.TabIndex = 51;
            this.btn_deleteorderID.Text = "Delete Order ID";
            this.btn_deleteorderID.UseVisualStyleBackColor = true;
            this.btn_deleteorderID.Click += new System.EventHandler(this.btn_deleteorderID_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Order ID";
            // 
            // txt_orderid
            // 
            this.txt_orderid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderid.Location = new System.Drawing.Point(23, 29);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(155, 22);
            this.txt_orderid.TabIndex = 4;
            // 
            // btn_createneworderID
            // 
            this.btn_createneworderID.Location = new System.Drawing.Point(172, 75);
            this.btn_createneworderID.Name = "btn_createneworderID";
            this.btn_createneworderID.Size = new System.Drawing.Size(107, 34);
            this.btn_createneworderID.TabIndex = 45;
            this.btn_createneworderID.Text = "Create New OrderID";
            this.btn_createneworderID.UseVisualStyleBackColor = true;
            this.btn_createneworderID.Click += new System.EventHandler(this.btn_createneworderID_Click);
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(23, 75);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(107, 34);
            this.btn_loaddata.TabIndex = 50;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 130);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 34);
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Update Edit";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model ";
            // 
            // cbm_model
            // 
            this.cbm_model.FormattingEnabled = true;
            this.cbm_model.Location = new System.Drawing.Point(244, 29);
            this.cbm_model.Name = "cbm_model";
            this.cbm_model.Size = new System.Drawing.Size(181, 21);
            this.cbm_model.TabIndex = 44;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(318, 130);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(107, 34);
            this.btn_export.TabIndex = 48;
            this.btn_export.Text = "Export to Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(318, 75);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 34);
            this.btn_clear.TabIndex = 47;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // gc_main
            // 
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_main.Location = new System.Drawing.Point(3, 183);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(754, 264);
            this.gc_main.TabIndex = 6;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "OrderID";
            this.gridColumn2.FieldName = "orderid";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ModelName";
            this.gridColumn3.FieldName = "ck_model";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmSettingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettingOrder";
            this.Text = "ifmSettingOrder";
            this.Load += new System.EventHandler(this.frmSettingOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_deleteorderID;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_createneworderID;
        private System.Windows.Forms.ComboBox cbm_model;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_main;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}