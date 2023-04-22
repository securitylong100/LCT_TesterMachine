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
                string sqlmodel = "select distinct(ck_model) from m_history order by ck_model";
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
                sqlBuilder.Append(@"SELECT ID,ck_serial,DATETIME(ck_time) as ck_time,ck_model,ck_number,");
                sqlBuilder.Append("ck_order,ck_rack,ck_speed_noload,ck_load_percent,ck_speed_output,ck_power,");
                sqlBuilder.Append("ck_torque,ck_speed_adj,ck_speed_flt,ck_speed_max,ck_speed_min,ck_braking_time,");
                sqlBuilder.Append("ck_result,ck_tester,ck_upload,ck_test_type,ck_volt,ck_current,ck_frequency,");
                sqlBuilder.Append("ck_pressure_neg,ck_reason,ck_volt_dc,ck_current_dc,ck_power_dc,linecd,machinecd,");
                sqlBuilder.Append("DATETIME(datimeregister) as datimeregister,ck_pid_stop ");
                sqlBuilder.Append("FROM m_history WHERE 1=1 ");
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    sqlBuilder.AppendFormat("AND ck_number='{0}' ", txtBarcode.Text);
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
                gv_main.Columns["ck_serial"].Visible = true;
                gv_main.Columns["ck_time"].Visible = true;
                gv_main.Columns["ck_model"].Visible = true;
                gv_main.Columns["ck_number"].Visible = true;
                gv_main.Columns["ck_order"].Visible = true;
                gv_main.Columns["ck_rack"].Visible = false;
                gv_main.Columns["ck_speed_noload"].Visible = true;
                gv_main.Columns["ck_load_percent"].Visible = true;
                gv_main.Columns["ck_speed_output"].Visible = true;
                gv_main.Columns["ck_power"].Visible = true;
                gv_main.Columns["ck_torque"].Visible = true;
                gv_main.Columns["ck_speed_adj"].Visible = true;
                gv_main.Columns["ck_speed_flt"].Visible = true;
                gv_main.Columns["ck_speed_max"].Visible = true;
                gv_main.Columns["ck_speed_min"].Visible = true;
                gv_main.Columns["ck_braking_time"].Visible = false;
                gv_main.Columns["ck_result"].Visible = true;
                gv_main.Columns["ck_tester"].Visible = false;
                gv_main.Columns["ck_upload"].Visible = false;
                gv_main.Columns["ck_test_type"].Visible = false;
                gv_main.Columns["ck_volt"].Visible = true;
                gv_main.Columns["ck_current"].Visible = true;
                gv_main.Columns["ck_frequency"].Visible = true;
                gv_main.Columns["ck_pressure_neg"].Visible = false;
                gv_main.Columns["ck_reason"].Visible = false;
                gv_main.Columns["ck_volt_dc"].Visible = true;
                gv_main.Columns["ck_current_dc"].Visible = true;
                gv_main.Columns["ck_power_dc"].Visible = true;
                gv_main.Columns["linecd"].Visible = false;
                gv_main.Columns["machinecd"].Visible = false;
                gv_main.Columns["datimeregister"].Visible = false;
                gv_main.Columns["ck_pid_stop"].Visible = true;

                gv_main.Columns["ck_serial"].Caption = "Step";
                gv_main.Columns["ck_time"].Caption = "Time";
                gv_main.Columns["ck_model"].Caption = "Model";
                gv_main.Columns["ck_number"].Caption = "Barcode";
                gv_main.Columns["ck_order"].Caption = "OrderId";
                gv_main.Columns["ck_rack"].Caption = "";
                gv_main.Columns["ck_speed_noload"].Caption = "Noload Speed";
                gv_main.Columns["ck_load_percent"].Caption = "Percentage";
                gv_main.Columns["ck_load_percent"].DisplayFormat.FormatString = "{0:P2}";
                gv_main.Columns["ck_speed_output"].Caption = "ROT Speed";
                gv_main.Columns["ck_power"].Caption = "Actual Power";
                gv_main.Columns["ck_torque"].Caption = "Torque";
                gv_main.Columns["ck_speed_adj"].Caption = "ROT Speed Mod";
                gv_main.Columns["ck_speed_flt"].Caption = "ROT Speed Wav";
                gv_main.Columns["ck_speed_max"].Caption = "Speed Max";
                gv_main.Columns["ck_speed_min"].Caption = "Speed Min";
                gv_main.Columns["ck_braking_time"].Caption = "";
                gv_main.Columns["ck_result"].Caption = "Result";
                gv_main.Columns["ck_tester"].Caption = "";
                gv_main.Columns["ck_upload"].Caption = "";
                gv_main.Columns["ck_test_type"].Caption = "";
                gv_main.Columns["ck_volt"].Caption = "Voltage";
                gv_main.Columns["ck_current"].Caption = "Current";
                gv_main.Columns["ck_frequency"].Caption = "Frequency";
                gv_main.Columns["ck_pressure_neg"].Caption = "";
                gv_main.Columns["ck_reason"].Caption = "";
                gv_main.Columns["ck_volt_dc"].Caption = "FW Voltage";
                gv_main.Columns["ck_current_dc"].Caption = "FW Current";
                gv_main.Columns["ck_power_dc"].Caption = "DC Power";
                gv_main.Columns["linecd"].Caption = "";
                gv_main.Columns["machinecd"].Caption = "";
                gv_main.Columns["datimeregister"].Caption = "";
                gv_main.Columns["ck_pid_stop"].Caption = "PID Stop";
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
                string path = "m_history.xlsx";
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
            sqlBuilder.Append("DELETE FROM m_history WHERE ID in (");
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
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string result = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ck_result"]);
                if (result == "合格")
                {
                    result = "PASSED";
                    View.SetRowCellValue(e.RowHandle, View.Columns["ck_result"], result);
                }
                e.Appearance.BackColor = result == "PASSED" ? Color.Green : Color.Red;
                e.Appearance.ForeColor = Color.Yellow;
            }
        }
    }
}
