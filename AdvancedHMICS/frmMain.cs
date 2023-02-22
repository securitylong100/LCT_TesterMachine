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

namespace AdvancedHMICS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int R = 500;
        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            lbl_speedrpm.Text = Math.Round(60 * float.Parse(avd_frequency.Value), 2).ToString();
        }
        private void avd_FWVolt_ValueChanged(object sender, EventArgs e)
        {
            avd_FWcurr.Value = Math.Round(float.Parse(avd_FWVolt.Value) / R, 2).ToString();
            // avd_DCpower.Value = Math.Round(float.Parse(avd_FWVolt.Value) *float.Parse( avd_FWcurr.Value)).ToString();
        }
        private void avd_FWcurr_ValueChanged(object sender, EventArgs e)
        {
            avd_DCpower.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_FWcurr.Value)).ToString();

        }
        private void lbl_speedrpm_TextChanged(object sender, EventArgs e)
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
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel fr = new frmSettingModel();
            fr.ShowDialog();
        }

        private void btn_DBSetting_Click(object sender, EventArgs e)
        {
            sqlite _SQLite = new sqlite();
            string sql2 = "CREATE TABLE IF NOT EXISTS test(" +
                   "StaffId VARCHAR(20) PRIMARY KEY," +
                   "FullName VARCHAR(50)," +
                   "Age INT DEFAULT 0" +
                   ")";

            DataTable dt2 = new DataTable();
            // _SQLite.SelectData(sql, ref dt);       

            _SQLite.SelectData(sql2, ref dt2);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {

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


    }
}
