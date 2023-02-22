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
            LoadData(txt_newmodel.Text);
        }

        private void LoadData(string model_)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from m_ck_point where 1=1 ");
            if(txt_newmodel.Text =="")
            {
                sql.Append(" and ck_model ='" + txt_newmodel.Text + "'");
            }    
            sqlite sqlite = new sqlite();
            sqlite.SelectData(sql.ToString(), ref dt);
            gc_main.DataSource = dt;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
        private void btn_export_Click(object sender, EventArgs e)
        {

        }
        private void btn_createnewmodel_Click(object sender, EventArgs e)
        {
            try
            {
                double maxvalues = int.Parse(txt_ratedpower.Text);
                double numberofstep = int.Parse(nud_numberofstep.Value.ToString());
                double steppower = (maxvalues / (numberofstep - 1));
                double steppercentage = 100 / (numberofstep - 1);

                double cal_steppower = 0;
                double cal_steppercentage = 0;
                if (checkcondition()&& checkmodelDB())
                {
                    for (int i = 1; i <= numberofstep; i++)
                    {

                        DataRow row = dt.NewRow();
                        row["ck_serial"] = i;
                        row["ck_Max_Noloadlimitspeed"] = txt_maxnoloadspeedlimit.Text;
                        row["ck_Min_Noloadlimitspeed"] = txt_minnoloadspeedlimit.Text;
                        row["ck_Steppower"] = Math.Round(cal_steppower, 1);
                        row["ck_power"] = txt_ratedpower.Text;
                        row["ck_Steppercentage"] = Math.Round(cal_steppercentage, 0);
                        row["ck_Max_Generator"] = txt_maxgenratorcurrentlimit.Text;
                        row["ck_Min_Generator"] = txt_mingenratorcurrentlimit.Text;
                        row["ck_Max_VolGenerator"] = txt_maxgenertorvoltagelimit.Text;
                        row["ck_Min_VolGenerator"] = txt_mingeneratorvoltagelimit.Text;
                        row["ck_Max_frequency"] = txt_maxfrequecy.Text;
                        row["ck_Min_frequency"] = txt_minfrequecy.Text;
                        row["ck_Max_braketime"] = txt_maxbrakingtimelimit.Text;
                        row["ck_Min_braketime"] = txt_minbrakingtimelimit.Text;
                        row["ck_Max_regulationspeed"] = txt_maxspeedregulationlimit.Text;
                        row["ck_Min_regulationSpeed"] = txt_minspeedregulationlimit.Text;
                        row["ck_Max_fluctuationspeed"] = txt_maxspeedfluctuationlimit.Text;
                        row["ck_Min_fluctuationspeed"] = txt_minspeedfluctuationlimit.Text;
                        row["ck_LoadTime"] = txt_loadingtime.Text;
                        row["ck_speed"] = txt_ratedspeed.Text;
                        row["ck_cycles"] = txt_cycles.Text;
                        row["ck_model"] = txt_newmodel.Text;
                        row["ck_testbrakes"] = cbm_testbarkes.SelectedItem.ToString();
                        dt.Rows.Add(row);
                        cal_steppower = cal_steppower + steppower;
                        cal_steppercentage = cal_steppercentage + steppercentage;
                    }
                    gc_main.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        bool checkcondition()
        {
            if (checknull(txt_newmodel) == false) return false;
            if (checknull(txt_maxnoloadspeedlimit) == false) return false;
            if (checknull(txt_minnoloadspeedlimit) == false) return false;
            if (checknull(txt_ratedpower) == false) return false;
            if (checknull(txt_maxgenratorcurrentlimit) == false) return false;
            if (checknull(txt_mingenratorcurrentlimit) == false) return false;
            if (checknull(txt_maxgenertorvoltagelimit) == false) return false;
            if (checknull(txt_mingeneratorvoltagelimit) == false) return false;
            if (checknull(txt_maxfrequecy) == false) return false;
            if (checknull(txt_minfrequecy) == false) return false;
            if (checknull(txt_maxbrakingtimelimit) == false) return false;
            if (checknull(txt_minbrakingtimelimit) == false) return false;
            if (checknull(txt_maxspeedregulationlimit) == false) return false;
            if (checknull(txt_minspeedregulationlimit) == false) return false;
            if (checknull(txt_maxspeedfluctuationlimit) == false) return false;
            if (checknull(txt_minspeedfluctuationlimit) == false) return false;
            if (checknull(txt_loadingtime) == false) return false;
            if (checknull(txt_ratedspeed) == false) return false;
            if (checknull(txt_cycles) == false) return false;
            if (cbm_testbarkes.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin Tại TestBarkes ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        bool checknull(TextBox txt)
        {
            if (txt.Text == "")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin Tại Text Box " + txt.Name.Trim(), "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        bool checkmodelDB()
        {
            sqlite sqlite_ = new sqlite();
            string sql = "select  ck_model  from m_ck_point where ck_model =  '" + txt_newmodel.Text + "'";
            string model_ = sqlite_.ExecuteScalarString(sql);
            if(model_.Length >0)
            {
                MessageBox.Show("Model " + txt_newmodel.Text + " Đã có trên hệ thống, hãy thực hiện chỉnh sữa, đừng thêm mới", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData(txt_newmodel.Text);
                return false;   
            }    
         
            return true;
        }
        void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #region "Keypress input numberic premision"
        private void txt_maxnoloadspeedlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_minnoloadspeedlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxbrakingtimelimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_minbrakingtimelimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxgenratorcurrentlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_mingenratorcurrentlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxspeedregulationlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxgenertorvoltagelimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_mingeneratorvoltagelimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxspeedfluctuationlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_maxfrequecy_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_minfrequecy_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_loadingtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        private void txt_ratedspeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender, e);
        }
        #endregion
    }
}
