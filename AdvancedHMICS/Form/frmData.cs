using AdvancedHMICS.Class;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Diagnostics;
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                string sqlmodel = "select distinct(ck_model) from m_ck_point_data order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.getComboBoxData(sqlmodel, ref cboModels);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, System.EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }
    }
}
