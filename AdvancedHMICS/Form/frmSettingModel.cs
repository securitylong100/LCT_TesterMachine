using AdvancedHMICS.Class;
using DevExpress.XtraEditors.Repository;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmSettingModel : Form
    {
        public frmSettingModel()
        {
            InitializeComponent();
            AcceptButton = btn_loaddata;
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
            if(txt_newmodel.Text !="")
            {
                sql.Append(" and ck_model ='" + txt_newmodel.Text + "'");
            }    
            sqlite sqlite = new sqlite();
            sqlite.SelectData(sql.ToString(), ref dt);
            gc_main.DataSource = dt;
            GetComboxIntoGrid(cbm_testbarkes, "ck_testbrakes");

        }
        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            LoadData(txt_newmodel.Text);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_newmodel.Text = "";
        }
        private void btn_deletemodel_Click(object sender, EventArgs e)
        {
            dt.AcceptChanges();
            if (dt.Rows.Count == 0) return;
            if (txt_newmodel.Text == "") return;
            sqlite sqlite_ = new sqlite();
            string sqldelte = "delete from m_ck_point where ck_model ='"+txt_newmodel.Text+"'";
            sqlite_.exeNonQuery_auto(sqldelte);
            MessageBox.Show("Model: "+txt_newmodel.Text+" deleted", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(txt_newmodel.Text);

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
             savedb();
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "m_ck_point.xlsx";
                gc_main.ExportToXlsx(path);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        private void btn_createnewmodel_Click(object sender, EventArgs e)
        {
            //gv_main.RefreshData();
            //gc_main.RefreshDataSource();
            //gc_main.DataSource = null;
            //gv_main.Columns.Clear();
            //dt = new DataTable();
            // LoadData(txt_newmodel.Text);
            LoadData(txt_newmodel.Text);
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
                    savedb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            LoadData(txt_newmodel.Text);
        }
        void savedb()
        {
            dt.AcceptChanges();
            if (dt.Rows.Count == 0) return;
            sqlite sqlite_ = new sqlite();
            int id_current =int.Parse( sqlite_.ExecuteScalarString("select ifnull(max(id),0) as ID_current  from m_ck_point"));
            foreach (DataRow rowdt in dt.Rows)
            {
                if (rowdt["ID"].ToString() == "")
                {
                    id_current = id_current+1;
                    StringBuilder sqlinsert = new StringBuilder();
                    sqlinsert.Append(@"INSERT INTO m_ck_point
                                    (ID, ck_serial, ck_Max_Noloadlimitspeed,ck_Min_Noloadlimitspeed,ck_Steppower,ck_power,ck_Steppercentage,ck_Max_Generator,ck_Min_Generator,
                                    ck_Max_VolGenerator ,ck_Min_VolGenerator ,ck_Max_frequency ,ck_Min_frequency ,
                                    ck_Max_braketime ,ck_Min_braketime, ck_Max_regulationspeed, ck_Min_regulationSpeed ,
                                    ck_Max_fluctuationspeed ,ck_Min_fluctuationspeed ,ck_LoadTime ,ck_speed ,ck_cycles,ck_model,ck_testbrakes )
                                    VALUES("
                                    );
                    sqlinsert.Append("'" + id_current+ "',");
                    sqlinsert.Append("'" + rowdt["ck_serial"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_Noloadlimitspeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_Noloadlimitspeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Steppower"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_power"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Steppercentage"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_Generator"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_Generator"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_VolGenerator"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_VolGenerator"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_frequency"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_frequency"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_braketime"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_braketime"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_regulationspeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_regulationSpeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Max_fluctuationspeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_Min_fluctuationspeed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_LoadTime"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_speed"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_cycles"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_model"].ToString() + "',");
                    sqlinsert.Append("'" + rowdt["ck_testbrakes"].ToString() + "'");
                    sqlinsert.Append(")");
                    sqlite_.exeNonQuery_auto(sqlinsert.ToString());

                }
                else
                {
                    StringBuilder sqlupdate = new StringBuilder();
                    sqlupdate.Append(@"UPDATE m_ck_point set ");
                    sqlupdate.Append("ck_serial = '" + rowdt["ck_serial"].ToString() + "',");
                    sqlupdate.Append("ck_Max_Noloadlimitspeed = '" + rowdt["ck_Max_Noloadlimitspeed"].ToString() + "',");
                    sqlupdate.Append("ck_Min_Noloadlimitspeed = '" + rowdt["ck_Min_Noloadlimitspeed"].ToString() + "',");
                    sqlupdate.Append("ck_Steppower = '" + rowdt["ck_Steppower"].ToString() + "',");
                    sqlupdate.Append("ck_power = '" + rowdt["ck_power"].ToString() + "',");
                    sqlupdate.Append("ck_Steppercentage = '" + rowdt["ck_Steppercentage"].ToString() + "',");
                    sqlupdate.Append("ck_Max_Generator = '" + rowdt["ck_Max_Generator"].ToString() + "',");
                    sqlupdate.Append("ck_Min_Generator = '" + rowdt["ck_Min_Generator"].ToString() + "',");
                    sqlupdate.Append("ck_Max_VolGenerator = '" + rowdt["ck_Max_VolGenerator"].ToString() + "',");
                    sqlupdate.Append("ck_Min_VolGenerator = '" + rowdt["ck_Min_VolGenerator"].ToString() + "',");
                    sqlupdate.Append("ck_Max_frequency = '" + rowdt["ck_Max_frequency"].ToString() + "',");
                    sqlupdate.Append("ck_Min_frequency = '" + rowdt["ck_Min_frequency"].ToString() + "',");
                    sqlupdate.Append("ck_Max_braketime = '" + rowdt["ck_Max_braketime"].ToString() + "',");
                    sqlupdate.Append("ck_Min_braketime = '" + rowdt["ck_Min_braketime"].ToString() + "',");
                    sqlupdate.Append("ck_Max_regulationspeed = '" + rowdt["ck_Max_regulationspeed"].ToString() + "',");
                    sqlupdate.Append("ck_Min_regulationSpeed = '" + rowdt["ck_Min_regulationSpeed"].ToString() + "',");
                    sqlupdate.Append("ck_Max_fluctuationspeed = '" + rowdt["ck_Max_fluctuationspeed"].ToString() + "',");
                    sqlupdate.Append("ck_Min_fluctuationspeed = '" + rowdt["ck_Min_fluctuationspeed"].ToString() + "',");
                    sqlupdate.Append("ck_LoadTime = '" + rowdt["ck_LoadTime"].ToString() + "',");

                    sqlupdate.Append("ck_speed = '" + rowdt["ck_speed"].ToString() + "',");
                    sqlupdate.Append("ck_cycles = '" + rowdt["ck_cycles"].ToString() + "',");
                    sqlupdate.Append("ck_model = '" + rowdt["ck_model"].ToString() + "',");
                    sqlupdate.Append("ck_testbrakes = '" + rowdt["ck_testbrakes"].ToString() + "'");
                    sqlupdate.Append(" where 1=1 and ID = " + rowdt["ID"].ToString() + "");
                    sqlite_.exeNonQuery_auto(sqlupdate.ToString());
                }
            }
            MessageBox.Show("Action Successful", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(txt_newmodel.Text);
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
            string sql = "select  count(*)  from m_ck_point where ck_model =  '" + txt_newmodel.Text + "'";
            int model_ = int.Parse(sqlite_.ExecuteScalarString(sql));
            if(model_ >0)
            {
                MessageBox.Show("Model " + txt_newmodel.Text + " Đã có trên hệ thống, hãy thực hiện chỉnh sửa, đừng thêm mới", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData(txt_newmodel.Text);
                return false;   
            }         
            return true;
        }
        void GetComboxIntoGrid(System.Windows.Forms.ComboBox cbm, string colHeader)
        {
            try
            {
                var arr = cbm.Items.Cast<Object>().Select(item => item.ToString()).ToArray();
                RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
                riComboBox.Items.AddRange(arr);
                gc_main.RepositoryItems.Add(riComboBox);
                gv_main.Columns[colHeader].ColumnEdit = riComboBox;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
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

        private void frmSettingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            int f = 0;
            //call save function
        }

       
    }
}
