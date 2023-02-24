
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
            this.btn_deletemodel = new System.Windows.Forms.Button();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_createnewmodel = new System.Windows.Forms.Button();
            this.cbm_testbarkes = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_newmodel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_deletemodel
            // 
            this.btn_deletemodel.Location = new System.Drawing.Point(172, 123);
            this.btn_deletemodel.Name = "btn_deletemodel";
            this.btn_deletemodel.Size = new System.Drawing.Size(107, 34);
            this.btn_deletemodel.TabIndex = 51;
            this.btn_deletemodel.Text = "Delete Model";
            this.btn_deletemodel.UseVisualStyleBackColor = true;
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(23, 68);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(107, 34);
            this.btn_loaddata.TabIndex = 50;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(318, 123);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(107, 34);
            this.btn_export.TabIndex = 48;
            this.btn_export.Text = "Export to Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(318, 68);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 34);
            this.btn_clear.TabIndex = 47;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 123);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 34);
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Update Edit";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_createnewmodel
            // 
            this.btn_createnewmodel.Location = new System.Drawing.Point(172, 68);
            this.btn_createnewmodel.Name = "btn_createnewmodel";
            this.btn_createnewmodel.Size = new System.Drawing.Size(107, 34);
            this.btn_createnewmodel.TabIndex = 45;
            this.btn_createnewmodel.Text = "Create New Model";
            this.btn_createnewmodel.UseVisualStyleBackColor = true;
            // 
            // cbm_testbarkes
            // 
            this.cbm_testbarkes.FormattingEnabled = true;
            this.cbm_testbarkes.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbm_testbarkes.Location = new System.Drawing.Point(318, 22);
            this.cbm_testbarkes.Name = "cbm_testbarkes";
            this.cbm_testbarkes.Size = new System.Drawing.Size(155, 21);
            this.cbm_testbarkes.TabIndex = 44;
            this.cbm_testbarkes.Text = "No";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Test Brakes";
            // 
            // txt_newmodel
            // 
            this.txt_newmodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_newmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newmodel.Location = new System.Drawing.Point(23, 20);
            this.txt_newmodel.Name = "txt_newmodel";
            this.txt_newmodel.Size = new System.Drawing.Size(212, 22);
            this.txt_newmodel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Model:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deletemodel);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_newmodel);
            this.panel1.Controls.Add(this.btn_createnewmodel);
            this.panel1.Controls.Add(this.btn_loaddata);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbm_testbarkes);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 174);
            this.panel1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 183);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 264);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_deletemodel;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_createnewmodel;
        private System.Windows.Forms.ComboBox cbm_testbarkes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_newmodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}