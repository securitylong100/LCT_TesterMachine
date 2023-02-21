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

        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            lbl_speedrpm.Text = (60 * float.Parse(avd_frequency.Value)).ToString();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {

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
    }
}
