
namespace AdvancedHMICS
{
    partial class frmPLCValueRealtime
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
            this.gc_main = new DevExpress.XtraGrid.GridControl();
            this.gv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_main
            // 
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_main.Location = new System.Drawing.Point(0, 99);
            this.gc_main.MainView = this.gv_main;
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(800, 351);
            this.gc_main.TabIndex = 0;
            this.gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_main});
            // 
            // gv_main
            // 
            this.gv_main.GridControl = this.gc_main;
            this.gv_main.Name = "gv_main";
            // 
            // frmPLCValueRealtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_main);
            this.Name = "frmPLCValueRealtime";
            this.Text = "PLCValueRealtimeForm";
            this.Load += new System.EventHandler(this.frmPLCValueRealtime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_main;
    }
}