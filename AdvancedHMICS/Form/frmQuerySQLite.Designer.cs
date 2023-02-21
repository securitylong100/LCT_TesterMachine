
namespace AdvancedHMICS
{
    partial class frmQuerySQLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuerySQLite));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SelectData = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ExecuteNonQuery = new System.Windows.Forms.Button();
            this.btn_createnewDB = new System.Windows.Forms.Button();
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txt_query, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gc_main, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 531);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_query
            // 
            this.txt_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_query.Location = new System.Drawing.Point(6, 6);
            this.txt_query.Multiline = true;
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(817, 218);
            this.txt_query.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SelectData);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_ExecuteNonQuery);
            this.panel1.Controls.Add(this.btn_createnewDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 64);
            this.panel1.TabIndex = 3;
            // 
            // btn_SelectData
            // 
            this.btn_SelectData.Location = new System.Drawing.Point(315, 17);
            this.btn_SelectData.Name = "btn_SelectData";
            this.btn_SelectData.Size = new System.Drawing.Size(131, 32);
            this.btn_SelectData.TabIndex = 3;
            this.btn_SelectData.Text = "SelectData";
            this.btn_SelectData.UseVisualStyleBackColor = true;
            this.btn_SelectData.Click += new System.EventHandler(this.btn_SelectData_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(474, 17);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 32);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ExecuteNonQuery
            // 
            this.btn_ExecuteNonQuery.Location = new System.Drawing.Point(147, 17);
            this.btn_ExecuteNonQuery.Name = "btn_ExecuteNonQuery";
            this.btn_ExecuteNonQuery.Size = new System.Drawing.Size(131, 32);
            this.btn_ExecuteNonQuery.TabIndex = 1;
            this.btn_ExecuteNonQuery.Text = "ExecuteNonQuery";
            this.btn_ExecuteNonQuery.UseVisualStyleBackColor = true;
            this.btn_ExecuteNonQuery.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // btn_createnewDB
            // 
            this.btn_createnewDB.Location = new System.Drawing.Point(6, 17);
            this.btn_createnewDB.Name = "btn_createnewDB";
            this.btn_createnewDB.Size = new System.Drawing.Size(104, 32);
            this.btn_createnewDB.TabIndex = 0;
            this.btn_createnewDB.Text = "Create New DB";
            this.btn_createnewDB.UseVisualStyleBackColor = true;
            this.btn_createnewDB.Click += new System.EventHandler(this.btn_createnewDB_Click);
            // 
            // gc_main
            // 
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_main.Location = new System.Drawing.Point(6, 306);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(817, 219);
            this.gc_main.TabIndex = 4;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // frmQuerySQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuerySQLite";
            this.Text = "Tester Machine v1.0.0: QuerySQLite";
            this.Load += new System.EventHandler(this.frmQuerySQLite_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_createnewDB;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ExecuteNonQuery;
        private System.Windows.Forms.Button btn_SelectData;
        private DevExpress.XtraGrid.GridControl gc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_main;
    }
}