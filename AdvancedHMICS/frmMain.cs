using ActUtlTypeLib;
using AdvancedHMICS.Class;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmMain : Form
    {
        // Khai báo điện trở fix
        private int R = 500;
        private int minrpm = 0;
        private int maxrpm = 0;
        private int steadyT = 4;
        private int counter = 0;
        private int _currStep = 0;
        private int _numberOfTest = 3;
        private int _numberOfSteps = 5;
        // Kết quả test 
        private bool result = false;
        private bool _isTest = false;
        private bool _isAutoTest = false;
        // Khai báo kết nối PLC
        public ActUtlType plc = new ActUtlType();

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cập nhật danh sách models
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            //int minrpm = 0;
            //int maxrpm = 0;
            //int counter = 0;
            //counter
            // lbl_actualP = the same 90% of  lbl_rated_P
            // lbl_speedrpm into spec of minrpm -- maxrpm
            try
            {
                if (!int.TryParse(lbl_speedrpm.Text, out int speedrpm))
                {
                    speedrpm = 0;
                }
                if (!float.TryParse(lbl_actualP.Text, out float actualP))
                {
                    actualP = 0;
                }
                if (!float.TryParse(lbl_rated_P.Text, out float reatedP))
                {
                    reatedP = 0;
                }
                double min = reatedP * 0.9;
                double max = reatedP * 1.1;
                double pidStop = reatedP == 0 ? 0 : (actualP / reatedP) * 100;
                lbl_pidStop.Text = $"{pidStop:0.##}";
                if (minrpm <= speedrpm && maxrpm >= speedrpm)
                {
                    counter--;
                    if (actualP < min)
                    {
                        _numberOfTest--;
                        counter = steadyT;
                    }
                    if (actualP > max || _numberOfTest < 0)
                    {
                        EndTest(false);
                        return;
                    }
                    if (counter < 1)
                    {
                        EndTest(true);
                    }
                }
            }
            finally
            {
                lbl_steadyT.Text = counter.ToString();
            }
            //else
            //{
            //counter = 0;
            //timerLoad.Enabled = false;
            ////return NG
            //result = false;
            //MessageBox.Show("Result NG", "Notice Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //btn_0.BackColor = Color.LightGray;
            //btn_25.BackColor = Color.LightGray;
            //btn_50.BackColor = Color.LightGray;
            //btn_75.BackColor = Color.LightGray;
            //btn_100.BackColor = Color.LightGray;
            //}
        }

        /// <summary>
        /// Tính Torque khi ROT speed thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Tính DC power khi FW curr thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avd_FWcurr_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                avd_DCpower.Value = Math.Round(float.Parse(avd_FWVolt.Value) * float.Parse(avd_FWcurr.Value)).ToString();
            }
            catch { }
        }

        /// <summary>
        /// Tính FW curr khi FW Volt thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avd_FWVolt_ValueChanged(object sender, EventArgs e)
        {
            try
            { avd_FWcurr.Value = Math.Round(float.Parse(avd_FWVolt.Value) / R, 2).ToString(); }
            catch
            { }
        }

        /// <summary>
        /// Tính Actual P khi current thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Tính ROT speed khi Frequency thay đổi
        /// Nếu đang chạy thì đọc giá trị FW Volt từ PLC D10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_speedrpm.Text = Math.Round(60 * float.Parse(avd_frequency.Value), 0).ToString();
                //read vaule
                if (_isTest || _isAutoTest)
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

        /// <summary>
        /// Thay đổi giá trị relay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyboardInput1_TextChanged(object sender, EventArgs e)
        {
            keyboardInput1.PLCAddressWriteValue.PLCAddress = textBox1.Text;
        }

        /// <summary>
        /// Lấy danh sách order id khi chọn model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            plc.Close();
        }

        /// <summary>
        /// Chạy step test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_step_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (int.TryParse(btn.Tag?.ToString(), out int step))
            {
                Steptest(btn, step);
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            frmUser fd = new frmUser();
            fd.ShowDialog();
        }

        /// <summary>
        /// Chạy chế độ manual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e) //this ok.
        {
            if (Checkinput() == false) return;
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
                    btn_autoload.Enabled = false;
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
                    btn_autoload.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        /// <summary>
        /// Chạy chế độ auto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autoload_Click(object sender, EventArgs e)
        {
            if (Checkinput() == false) return;
            try
            {
                lbl_status_automanual.Text = "AutoLoad";
                lbl_status_automanual.BackColor = Color.Green;

                // btn_start.Text = "Start/Run";       
                if (btn_autoload.Text == "AutoLoad")
                {
                    plc.ActLogicalStationNumber = 1;
                    plc.Open();
                    btn_autoload.Text = "Running";
                    btn_autoload.BackColor = Color.Green;
                    btn_plcstatus.BackColor = Color.Green;
                    btn_plcstatus.Enabled = true;
                    txt_barcode.ReadOnly = true;
                    cbm_model.Enabled = false;
                    cbm_orderid.Enabled = false;
                    btn_start.Enabled = false;
                }
                else if (btn_autoload.Text == "Running")
                {
                    plc.Close();
                    btn_autoload.Text = "AutoLoad";
                    btn_autoload.BackColor = Color.Red;
                    btn_plcstatus.BackColor = Color.DarkGray;
                    btn_plcstatus.Enabled = false;
                    btn_plcstatus.Enabled = false;
                    txt_barcode.ReadOnly = false;
                    cbm_model.Enabled = true;
                    cbm_orderid.Enabled = true;
                    btn_start.Enabled = true;
                }
                string sql = "select max(ck_serial) as ck_serial from m_ck_point where ck_model = '" + cbm_model.Text + "'";
                sqlite sqlite_ = new sqlite();
                string maxStep = sqlite_.ExecuteScalarString(sql);
                if (int.TryParse(maxStep, out int steps))
                {
                    _numberOfSteps = steps;
                }
                _isAutoTest = true;
                Steptest(btn_90, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_DBSetting_Click(object sender, EventArgs e)
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
        private void btn_querysqlite_Click(object sender, EventArgs e)
        {
            frmQuerySQLite f = new frmQuerySQLite();
            f.ShowDialog();
        }
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel fr = new frmSettingModel();
            fr.ShowDialog();
        }
        private void btn_settingorder_Click(object sender, EventArgs e)
        {
            frmSettingOrder f = new frmSettingOrder();
            f.ShowDialog();
        }

        //condition
        bool Checkinput()
        {
            if (cbm_model.SelectedItem == null || cbm_orderid.SelectedItem == null || txt_barcode.Text == "")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin Mã Hàng ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kết thúc test
        /// </summary>
        /// <param name="isOk"></param>
        private void EndTest(bool isOk)
        {
            result = isOk;
            _isTest = false;
            timerLoad.Enabled = false;
            btn_0.BackColor = Color.LightGray;
            btn_25.BackColor = Color.LightGray;
            btn_50.BackColor = Color.LightGray;
            btn_75.BackColor = Color.LightGray;
            btn_90.BackColor = Color.LightGray;
            btn_100.BackColor = Color.LightGray;

            if (_isAutoTest)
            {
                _currStep++;
                Steptest(btn_90, _currStep);
                _isAutoTest = _currStep < _numberOfSteps;
            }
            else
            {
                if (btn_start.Text == "Start/Run")
                {
                    plc.Close();
                }
                btn_autoload.Text = "AutoLoad";
                btn_autoload.BackColor = Color.Red;
                btn_plcstatus.BackColor = Color.DarkGray;
                btn_plcstatus.Enabled = false;
                btn_plcstatus.Enabled = false;
                txt_barcode.ReadOnly = false;
                cbm_model.Enabled = true;
                cbm_orderid.Enabled = true;
                btn_start.Enabled = true;
            }
        }

        /// <summary>
        /// Chạy test
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="step"></param>
        private void Steptest(Button btn, int step)
        {
            try
            {
                if (Checkinput() == false) return;
                // Nếu đang chạy thì ngừng lại
                if (_isTest)
                {
                    if (_currStep == step)
                    {
                        _isTest = false;
                        timerLoad.Enabled = false;
                        btn.BackColor = Color.LightGray;
                    }
                    return;
                }
                _isTest = true;
                _currStep = step;
                timerLoad.Enabled = true;
                btn.BackColor = Color.Green;

                // step = 1;
                counter = steadyT;
                _numberOfTest = 3;
                lbl_pcStep.Text = step.ToString();
                DataTable dt = new DataTable();
                string sqlmodel = "select * from m_ck_point where ck_model = '" + cbm_model.Text + "' order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlmodel, ref dt);
                var rows = dt.AsEnumerable().Where(row => row["ck_serial"].ToString() == step.ToString());
                //timerlable
                steadyT = int.Parse(rows.Max(row => row["ck_LoadTime"]).ToString());
                lbl_steadyT.Text = steadyT.ToString();
                //ratedP step
                lbl_rated_P.Text = rows.Max(row => row["ck_Steppower"]).ToString();
                //get min max
                minrpm = int.Parse(rows.Max(row => row["ck_Min_Noloadlimitspeed"]).ToString());
                maxrpm = int.Parse(rows.Max(row => row["ck_Max_Noloadlimitspeed"]).ToString());

                btn_90.Text = $"{rows.Max(row => row["ck_Steppercentage"])}%";

                //condtion function.,
                //if (btn.BackColor == Color.LightGray)
                //{
                //    btn.BackColor = Color.Green;
                //    timerLoad.Enabled = true;
                //}
                //else
                //{
                //    timerLoad.Enabled = false;
                //    btn.BackColor = Color.LightGray;
                //}
                //if (minrpm <= int.Parse(lbl_speedrpm.Text) && float.Parse(lbl_actualP.Text) >= float.Parse(lbl_rated_P.Text) * 0.85)
                //{
                //    timerLoad.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                timerLoad.Enabled = false;
                MessageBox.Show("Error :" + ex.Message);
            }
        }
    }
}
