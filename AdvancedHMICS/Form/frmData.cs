using AdvancedHMICS.Class;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmData : Form
    {
        private GridView gv_main = new GridView();
        private GridControl gc_main = new GridControl();

        public frmData()
        {
            InitializeComponent();
            dtpFromDate.Value = dtpToDate.Value.Date;
            InitGrid();
        }

        private void InitGrid()
        {
            gc_main.MainView = gv_main;
            gc_main.Dock = DockStyle.Fill;
            gc_main.ViewCollection.Add(gv_main);
            gv_main.GridControl = gc_main;
            tlpMain.SetRow(gc_main, 3);
            tlpMain.SetColumn(gc_main, 0);
            tlpMain.SetColumnSpan(gc_main, 6);
            tlpMain.Controls.Add(gc_main);
            gv_main.CustomDrawCell += Gv_main_CustomDrawCell;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                string sqlmodel = "select distinct(ck_model) from m_ck_point_data order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.GetComboBoxData(sqlmodel, ref cboModels);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder sqlBuilder = new StringBuilder();
                sqlBuilder.Append(@"SELECT ID, ck_serial, ck_Steppower, ck_power, ck_Steppercentage, 
                                           ck_speed, ck_cycles, ck_model, ck_testbrakes, ck_time, 
                                           ck_barcode, ck_actual_power, ck_pid_stop, ck_rot_speed, 
                                           ck_fw_volt, ck_volt, ck_current, ck_result    
                                    FROM m_ck_point_data WHERE 1=1 ");
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    sqlBuilder.AppendFormat("AND ck_barcode='{0}' ", txtBarcode.Text);
                }
                if (!string.IsNullOrWhiteSpace(cboModels.Text))
                {
                    sqlBuilder.AppendFormat("AND ck_model='{0}' ", cboModels.Text);
                }
                if (cbFromDate.Checked)
                {
                    sqlBuilder.AppendFormat("AND ck_time >= '{0}' ", dtpFromDate.Value);
                }
                if (cbToDate.Checked)
                {
                    sqlBuilder.AppendFormat("AND ck_time <= '{0}' ", dtpToDate.Value);
                }
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlBuilder.ToString(), ref dt);
                gc_main.DataSource = dt;
                gv_main.Columns["ck_time"].Caption = "Time";
                gv_main.Columns["ck_time"].VisibleIndex = 0;
                gv_main.Columns["ck_model"].Caption = "Model";
                gv_main.Columns["ck_model"].VisibleIndex = 1;
                gv_main.Columns["ck_barcode"].Caption = "Barcode";
                gv_main.Columns["ck_barcode"].VisibleIndex = 2;
                gv_main.Columns["ck_power"].Caption = "Total Power";
                gv_main.Columns["ck_power"].VisibleIndex = 3;
                gv_main.Columns["ck_speed"].Caption = "Speed";
                gv_main.Columns["ck_speed"].VisibleIndex = 4;
                gv_main.Columns["ck_cycles"].Caption = "Cycles";
                gv_main.Columns["ck_cycles"].VisibleIndex = 5;
                gv_main.Columns["ck_serial"].Caption = "Step Id";
                gv_main.Columns["ck_serial"].VisibleIndex = 6;
                gv_main.Columns["ck_Steppercentage"].Caption = "Percentage";
                gv_main.Columns["ck_Steppercentage"].VisibleIndex = 7;
                gv_main.Columns["ck_Steppower"].Caption = "Step Power";
                gv_main.Columns["ck_Steppower"].VisibleIndex = 8;
                gv_main.Columns["ck_actual_power"].Caption = "Actual Power";
                gv_main.Columns["ck_actual_power"].VisibleIndex = 9;
                gv_main.Columns["ck_pid_stop"].Caption = "PID Stop";
                gv_main.Columns["ck_pid_stop"].VisibleIndex = 10;
                gv_main.Columns["ck_rot_speed"].Caption = "ROT Speed";
                gv_main.Columns["ck_rot_speed"].VisibleIndex = 11;
                gv_main.Columns["ck_fw_volt"].Caption = "FW Volt";
                gv_main.Columns["ck_fw_volt"].VisibleIndex = 12;
                gv_main.Columns["ck_volt"].Caption = "Volt";
                gv_main.Columns["ck_volt"].VisibleIndex = 13;
                gv_main.Columns["ck_current"].Caption = "Current";
                gv_main.Columns["ck_current"].VisibleIndex = 14;
                gv_main.Columns["ck_result"].Caption = "Result";
                gv_main.Columns["ck_result"].VisibleIndex = 15;
                gv_main.Columns["ck_testbrakes"].Caption = "Testbrakes";
                gv_main.Columns["ck_testbrakes"].VisibleIndex = 16;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "m_ck_point_data.xlsx";
                gc_main.ExportToXlsx(path);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want remove this rows?", "Caution",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            int[] rows = gv_main.GetSelectedRows();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM m_ck_point_data WHERE ID in (");
            var ids = rows.Select(r => gv_main.GetRowCellValue(r, "ID")?.ToString());
            sqlBuilder.Append(string.Join(",", ids));
            sqlBuilder.Append(");");
            sqlite sqlite_ = new sqlite();
            sqlite_.ExeNonQuery_auto(sqlBuilder.ToString());
            MessageBox.Show("Remove data successed");
            BtnRefresh_Click(sender, e);
        }

        private void Gv_main_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string result = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ck_result"]);
                e.Appearance.BackColor = result == "1" ? Color.Green : Color.Red;
                e.Appearance.ForeColor = Color.Yellow;
            }
        }
    }
}
