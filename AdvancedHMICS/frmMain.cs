using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using AdvancedHMICS.Class;
using ActUtlTypeLib;

namespace AdvancedHMICS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //khai báo điện trở fix
        int R = 500;
        //kết quả test 
        bool result = false;
        int minrpm = 0;
        int maxrpm = 0;
        int steadyT = 4;
        int counter = 0;
        //khai báo kết nối PLC
        public ActUtlType plc = new ActUtlType();

        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_speedrpm.Text = Math.Round(60 * float.Parse(avd_frequency.Value), 0).ToString();
                //read vaule
                if (btn_start.Text == "Running")
                {
                    short shortvalue;
                    plc.GetDevice2("D10", out shortvalue); // đọc lên giá trị từ miền nhớ
                    avd_FWVolt.Value = shortvalue.ToString();
                }
                else
                {
                    avd_FWVolt.Value = "0";
                }
            }
            catch { }
        }
        private void avd_FWVolt_ValueChanged(object sender, EventArgs e)
        {
            try
            { avd_FWcurr.Value = Math.Round(float.Parse(avd_FWVolt.Value) / R, 2).ToString(); }
            catch
            { }
        }
        private void avd_current_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                avd_electricP.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_current.Value) / 1000, 2).ToString();
                lbl_actualP.Text = avd_electricP.Value;
               // lbl_pidStop.Text = 
            }
            catch
            { }
        }
        private void avd_FWcurr_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                avd_DCpower.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_FWcurr.Value)).ToString();
            }
            catch { }
        }
        private void lbl_speedrpm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbl_speedrpm.Text != "0")
                {
                    avd_torque.Value = Math.Round(float.Parse(avd_voltage.Value) * float.Parse(avd_current.Value) * 0.95 / float.Parse(lbl_speedrpm.Text), 3).ToString();
                }
                else
                {
                    avd_torque.Value = "0";
                }
            }
            catch { }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            string sqlmodel = "select distinct(ck_model) from m_ck_point order by ck_model";
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.getComboBoxData(sqlmodel, ref cbm_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }


        }
        private void cbm_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show order id
            cbm_orderid.Text = "";
            StringBuilder sqlorderid = new StringBuilder();
            sqlorderid.Append("select distinct(orderid) from m_orderid where 1=1 ");
            if (cbm_model.SelectedItem != null)
            {
                sqlorderid.Append(" and ck_model ='" + cbm_model.SelectedItem.ToString() + "'");
            }
            sqlorderid.Append(" order by orderid");
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.getComboBoxData(sqlorderid.ToString(), ref cbm_orderid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

            //show details
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_ck_point where ck_model = '" + cbm_model.Text + "' order by ck_model";
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlmodel, ref dt);
                lbl_targetP.Text = dt.AsEnumerable()
         .Where(row => row["ck_model"].ToString() == cbm_model.Text)
         .Max(row => row["ck_power"])
         .ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel fr = new frmSettingModel();
            fr.ShowDialog();
        }
        private void btn_start_Click(object sender, EventArgs e) //this ok.
        {
            if (checkinput() == false) return;
            try
            {
                // btn_start.Text = "Start/Run";       
                if (btn_start.Text == "Start/Run")
                {
                    plc.ActLogicalStationNumber = 1;
                    plc.Open();
                    btn_start.Text = "Running";
                    btn_start.BackColor = Color.Green;
                    btn_plcstatus.BackColor = Color.Green;
                    btn_plcstatus.Enabled = true;
                    txt_barcode.ReadOnly = true;
                    cbm_model.Enabled = false;
                    cbm_orderid.Enabled = false;
                    btn_autoload.Enabled = true;
                }
                else if (btn_start.Text == "Running")
                {
                    plc.Close();
                    btn_start.Text = "Start/Run";
                    btn_start.BackColor = Color.Red;
                    btn_plcstatus.BackColor = Color.DarkGray;
                    btn_plcstatus.Enabled = false;
                    btn_plcstatus.Enabled = false;
                    txt_barcode.ReadOnly = false;
                    cbm_model.Enabled = true;
                    cbm_orderid.Enabled = true;
                    btn_autoload.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        private void btn_autoload_Click(object sender, EventArgs e)
        {
            lbl_status_automanual.Text = "AutoLoad";
            lbl_status_automanual.BackColor = Color.Green;
        }
        private void btn_DBSetting_Click(object sender, EventArgs e)
        {

        }
        private void btn_user_Click(object sender, EventArgs e)
        {
            frmUser fd = new frmUser();
            fd.ShowDialog();
        }
        private void btn_querysqlite_Click(object sender, EventArgs e)
        {
            frmQuerySQLite f = new frmQuerySQLite();
            f.ShowDialog();
        }
        private void btn_settingorder_Click(object sender, EventArgs e)
        {
            frmSettingOrder f = new frmSettingOrder();
            f.ShowDialog();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            plc.Close();
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (checkinput() == false) return;
            float step = 1;
            counter = 0;
            lbl_pcStep.Text = step.ToString();
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_ck_point where ck_model = '" + cbm_model.Text + "' order by ck_model";
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlmodel, ref dt);
                //timerlable
                steadyT = int.Parse(dt.AsEnumerable()
                       .Where(row => row["ck_serial"].ToString() == step.ToString())
                       .Max(row => row["ck_LoadTime"])
                       .ToString());
                lbl_steadyT.Text = steadyT.ToString();
                //ratedP step
                lbl_rated_P.Text = dt.AsEnumerable()
                      .Where(row => row["ck_serial"].ToString() == step.ToString())
                      .Max(row => row["ck_Steppower"])
                      .ToString();
                //get min max
                minrpm = int.Parse(dt.AsEnumerable()
                         .Where(row => row["ck_serial"].ToString() == step.ToString())
                         .Max(row => row["ck_Min_Noloadlimitspeed"])
                         .ToString());
                maxrpm = int.Parse(dt.AsEnumerable()
                       .Where(row => row["ck_serial"].ToString() == step.ToString())
                       .Max(row => row["ck_Max_Noloadlimitspeed"])
                       .ToString());
                //condtion function.,
                btn_0.BackColor = Color.Green;
                timerLoad.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            //int minrpm = 0;
            //int maxrpm = 0;
            //int counter = 0;
            //counter
            // lbl_actualP = the same 90% of  lbl_rated_P
            // lbl_speedrpm into spec of minrpm -- maxrpm
            if (minrpm <= int.Parse(lbl_speedrpm.Text) && maxrpm >= int.Parse(lbl_speedrpm.Text) && float.Parse(lbl_actualP.Text) >= float.Parse(lbl_rated_P.Text) * 0.9 && float.Parse(lbl_actualP.Text) <= float.Parse(lbl_rated_P.Text) * 1.1)
            {
                counter = counter + 1;
            }
            else
            {
                counter = 0;
                timerLoad.Enabled = false;
                //return NG
                result = false;
                MessageBox.Show("Result NG", "Notice Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_0.BackColor = Color.LightGray;
            }
            if (counter <= steadyT)
            {
                lbl_steadyT.Text = (steadyT - counter).ToString();
            }
            else
            {     
                timerLoad.Enabled = false;
                //return ok
                result = true;
                MessageBox.Show("Result OK", "Notice Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_0.BackColor = Color.LightGray;
            }
        }
        private void btn_plcstatus_Click(object sender, EventArgs e)
        {
            //int[] D_input = { 0, 1, 2, 3, 4, 5, 6, 7 };
            // int[] D_output = new int[8];
            //foreach(int i in D_input)
            //{
            //    {
            //        plc.GetDevice("D" + i, out D_output[i]);
            //    }                 
            //}         
            frmPLCValueRealtime frmplc = new frmPLCValueRealtime();
            frmplc.ShowDialog();

        }
        private void btn_loadStatus_Click(object sender, EventArgs e)
        {
        }

        //condition
        bool checkinput()
        {
            if (cbm_model.SelectedItem == null || cbm_orderid.SelectedItem == null || txt_barcode.Text == "")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin Mã Hàng ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}
