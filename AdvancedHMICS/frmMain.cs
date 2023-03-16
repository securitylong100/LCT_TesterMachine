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
        //khai báo kết nối PLC
        public ActUtlType plc = new ActUtlType();

        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_speedrpm.Text = Math.Round(60 * float.Parse(avd_frequency.Value), 2).ToString();
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
            { avd_electricP.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_current.Value)/1000, 2).ToString(); }
            catch
            { }
        }
        private void avd_FWcurr_ValueChanged(object sender, EventArgs e)
        {
            try
            { avd_DCpower.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_FWcurr.Value)).ToString(); }
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

        }
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel fr = new frmSettingModel();
            fr.ShowDialog();
        }
        private void btn_start_Click(object sender, EventArgs e) //this ok.
        {
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
                }
                else if (btn_start.Text == "Running")
                {
                    plc.Close();
                    btn_start.Text = "Start/Run";
                    btn_start.BackColor = Color.Red;
                    btn_plcstatus.BackColor = Color.DarkGray;
                    btn_plcstatus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }


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

      

    }
}
