using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMICS.Class;

namespace AdvancedHMICS
{
    public partial class frmSettingModel : Form
    {
        public frmSettingModel()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmSettingModel_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            string sql = "select * from m_ck_point";
            sqlite sqlite = new sqlite();
            sqlite.SelectData(sql, ref dt);
            gc_main.DataSource = dt;
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_createnewmodel_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkcondition())
                {
                    DataRow row = dt.NewRow();
                    row["user_name"] = cbm_username.Text;
                    row["basicsalary_month"] = calc_Basicsalary.Text;
                    row["bonussalary"] = calc_bonussalary.Text;
                    row["money_insurance"] = chb_insurance.Checked == true ? "True" : "False";
                    row["u_update"] = "";
                    row["d_update"] = DateTime.Now;
                    row["u_create"] = ClsVariables.App.UserName;
                    row["d_create"] = DateTime.Now;
                    dt.Rows.Add(row);
                    savedb();
                    // LoadData(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        bool checkcondition()
        {
            if (cbm_username.SelectedItem == null || cbm_usercd.SelectedItem == null || calc_Basicsalary.Text == "0" || calc_Basicsalary.Text == "")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
