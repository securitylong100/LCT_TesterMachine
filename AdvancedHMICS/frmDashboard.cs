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
    public partial class frmDashboard : Form
    {
        /// <summary>
        /// Địa chỉ FW Voltage
        /// </summary>
        private const string FW_VOLT = "D10";

        /// <summary>
        /// Số lần NG tối đa cho phép
        /// </summary>
        private const int MAX_NG = 3;

        /// <summary>
        /// Số step kiểm tra
        /// </summary>
        private const int STEPS = 5;

        /// <summary>
        /// Thời gian chờ kiểm tra
        /// </summary>
        private const int TIME_OUT = 4;

        /// <summary>
        /// Điện trở
        /// </summary>
        private const double FIXED_RES = 100;

        private int _iStep = 0;
        private int _iCounter = 0;
        private int _iMaxStep = STEPS;
        private bool _isAuto = false;
        private bool _isTesting = false;
        private bool _isConnectedPLC = false;

        private DataTable _dtMaster;
        private readonly ActUtlType _plc = new ActUtlType();
        private readonly frmLoadStatus _frmLoad = new frmLoadStatus();

        public frmDashboard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                timer_realtime.Enabled = true;
                string sqlmodel = "select distinct(ck_model) from m_ck_point order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.GetComboBoxData(sqlmodel, ref cbo_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void cbo_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show order id
            cbo_orderid.Text = "";
            StringBuilder sqlorderid = new StringBuilder();
            sqlorderid.Append("select distinct(orderid) from m_orderid where 1=1 ");
            if (cbo_model.SelectedItem != null)
            {
                sqlorderid.Append(" and ck_model ='" + cbo_model.SelectedItem.ToString() + "'");
            }
            sqlorderid.Append(" order by orderid");
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.GetComboBoxData(sqlorderid.ToString(), ref cbo_orderid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

            //show details
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_ck_point where ck_model = '" + cbo_model.Text + "' order by ck_model";
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlmodel, ref dt);
                lbl_power_target.Text = dt.AsEnumerable()
                    .Where(row => row["ck_model"].ToString() == cbo_model.Text)
                    .Max(row => row["ck_power"])
                    .ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        #region --- TIMERS ---
        private void timer_realtime_Tick(object sender, EventArgs e)
        {
            try
            {
                int fwVolt = 0;
                if (_isConnectedPLC)
                {
                    _plc.GetDevice2(FW_VOLT, out short shortValue);
                    fwVolt = shortValue / 100;
                }
                avd_volt_fw.Value = fwVolt.ToString();
                CalcValues();
            }
            catch
            {
            }
        }

        private void timer_load_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_iCounter > 0)
                {
                    _iCounter--;
                    lbl_steady_t.Text = _iCounter.ToString();
                }
                else
                {
                    EndTest();
                    if (_isAuto)
                    {
                        if (_iStep < _iMaxStep)
                        {
                            StartTest(_iStep + 1);
                        }
                        else
                        {
                            RunAuto();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        #endregion
        #region --- BUTTONS ---
        private void btn_record_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        private void btn_data_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_model_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            RunPLC();
        }

        private void btn_autoload_Click(object sender, EventArgs e)
        {
            RunAuto();
        }

        private void btn_sql_query_Click(object sender, EventArgs e)
        {

        }

        private void btn_sql_connect_Click(object sender, EventArgs e)
        {

        }

        private void btn_plc_status_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_status_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_manual_Click(object sender, EventArgs e)
        {

        }

        private void btn_logs_Click(object sender, EventArgs e)
        {

        }
        private void btn_step_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Tag?.ToString(), out int step))
            {
                StartTest(step);
            }
        }
        #endregion
        #region --- VALUES ---
        private void avd_volt_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }

        private void avd_curr_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }

        private void avd_freq_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }
        #endregion
        #region --- METHODS ---
        private bool CheckInput()
        {
            return !string.IsNullOrWhiteSpace(cbo_model.Text)
                && !string.IsNullOrWhiteSpace(cbo_orderid.Text)
                && !string.IsNullOrWhiteSpace(txt_barcode.Text);
        }

        private void CalcValues()
        {
            try
            {
                if (!float.TryParse(avd_freq.Value, out float freq_))
                {
                    freq_ = 0;
                }
                float speed_ = (60 * freq_) / 6;
                avd_speed_rot.Value = $"{speed_:N0}";

                if (!float.TryParse(avd_volt.Value, out float volt_))
                {
                    volt_ = 0;
                }
                if (!float.TryParse(avd_curr.Value, out float curr_))
                {
                    curr_ = 0;
                }
                var power_ = (volt_ * curr_) / 1000;
                avd_power_e.Value = $"{power_:0.000}";
                lbl_power_actual.Text = avd_power_e.Text;

                double torque_ = 0;
                if (speed_ > 0)
                {
                    torque_ = volt_ * curr_ * 9.95 / speed_;
                }
                avd_torque.Value = $"{torque_:0.000}";

                if (!float.TryParse(avd_volt_fw.Value, out float fwVolt_))
                {
                    fwVolt_ = 0;
                }
                double fwCurrent_ = fwVolt_ / FIXED_RES;
                avd_curr_fw.Value = $"{fwCurrent_:0.000}";

                double fwPower_ = fwVolt_ * fwCurrent_;
                avd_power_dc.Value = fwPower_.ToString();
            }
            catch
            {
            }
        }

        private void RunPLC()
        {
            try
            {
                if (_isConnectedPLC)
                {
                    _plc.Close();
                    _isConnectedPLC = false;

                    btn_start.Text = "Start/Run";
                    btn_start.BackColor = Color.Red;
                    btn_autoload.ForeColor = Color.Black;
                    btn_autoload.BackColor = Color.LightGray;
                }
                else
                {
                    if (!CheckInput())
                    {
                        MessageBox.Show("Chưa chọn đầy đủ Thông Tin Mã Hàng ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _dtMaster = GetMaster();
                    _iMaxStep = GetTestSteps();
                    _plc.ActLogicalStationNumber = 1;
                    _plc.Open();

                    _isConnectedPLC = true;
                    btn_start.Text = "Running";
                    btn_start.BackColor = Color.Green;
                    btn_autoload.BackColor = Color.Red;
                    btn_autoload.ForeColor = Color.Yellow;
                }

                tlp_botmid.Enabled = !_isConnectedPLC;
                btn_record.Enabled = _isConnectedPLC;
                btn_delete.Enabled = _isConnectedPLC;
                btn_clear.Enabled = _isConnectedPLC;
                btn_export.Enabled = _isConnectedPLC;
                btn_autoload.Enabled = _isConnectedPLC;
                btn_plc_status.Enabled = _isConnectedPLC;
                btn_load_status.Enabled = _isConnectedPLC;
                btn_load_manual.Enabled = _isConnectedPLC;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void RunAuto()
        {
            try
            {
                if (_isAuto)
                {
                    _isAuto = false;
                    lbl_status.Text = "Manual";
                    btn_autoload.BackColor = Color.Red;
                    EndTest();
                }
                else
                {
                    _isAuto = true;
                    lbl_status.Text = "Auto";
                    btn_autoload.BackColor = Color.Green;
                    StartTest(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void StartTest(int step)
        {
            try
            {
                if (_isTesting)
                {
                    if (_iStep == step)
                    {
                        EndTest();
                    }
                    return;
                }
                _iStep = step;
                _isTesting = true;
                timer_load.Enabled = true;
                lbl_status.BackColor = Color.Green;
                switch (_iStep)
                {
                    case 1:
                        btn_00.BackColor = Color.Green;
                        break;
                    case 2:
                        btn_25.BackColor = Color.Green;
                        break;
                    case 3:
                        btn_50.BackColor = Color.Green;
                        break;
                    case 4:
                        btn_75.BackColor = Color.Green;
                        break;
                    case 5:
                        btn_100.BackColor = Color.Green;
                        break;
                    default:
                        break;
                }
                var drStep = _dtMaster.AsEnumerable().FirstOrDefault(row => row["ck_serial"].ToString() == step.ToString());
                #region --- CURRENT LIMIT ---
                if (!float.TryParse(drStep["ck_Min_Generator"]?.ToString(), out float minCurr))
                {
                    minCurr = 0;
                }
                if (!float.TryParse(drStep["ck_Max_Generator"]?.ToString(), out float maxCurr))
                {
                    maxCurr = 9999;
                }
                avd_curr.ValueLimitUpper = maxCurr;
                avd_curr.ValueLimitLower = minCurr;
                #endregion
                #region --- VOLTAGE LIMIT ---
                if (!float.TryParse(drStep["ck_Min_VolGenerator"]?.ToString(), out float minVolt))
                {
                    minVolt = 0;
                }
                if (!float.TryParse(drStep["ck_Max_VolGenerator"]?.ToString(), out float maxVolt))
                {
                    maxVolt = 9999;
                }
                avd_volt.ValueLimitUpper = maxVolt;
                avd_volt.ValueLimitLower = minVolt;
                #endregion
                #region --- FREQUENCY LIMIT ---
                if (!float.TryParse(drStep["ck_Min_frequency"]?.ToString(), out float minFreq))
                {
                    minFreq = 0;
                }
                if (!float.TryParse(drStep["ck_Max_frequency"]?.ToString(), out float maxFreq))
                {
                    maxFreq = 9999;
                }
                avd_freq.ValueLimitUpper = maxFreq;
                avd_freq.ValueLimitLower = minFreq;
                #endregion
                #region --- SPEED MOD LIMIT ---
                if (!float.TryParse(drStep["ck_Min_fluctuationspeed"]?.ToString(), out float minFluc))
                {
                    minFluc = 0;
                }
                if (!float.TryParse(drStep["ck_Max_fluctuationspeed"]?.ToString(), out float maxFluc))
                {
                    maxFluc = 9999;
                }
                avd_speed_rot.ValueLimitUpper = maxFluc;
                avd_speed_rot.ValueLimitLower = minFluc;
                #endregion
                _frmLoad.CheckBits(drStep["ck_load"]?.ToString());
                if (!int.TryParse(drStep["ck_LoadTime"]?.ToString(), out int loadTime))
                {
                    loadTime =TIME_OUT;
                }
                if (!float.TryParse(drStep["ck_Min_Noloadlimitspeed"]?.ToString(), out float minSpeed))
                {
                    minSpeed = 0;
                }
                if (!float.TryParse(drStep["ck_Max_Noloadlimitspeed"]?.ToString(), out float maxSpeed))
                {
                    maxSpeed = 0;
                }
                _iCounter = loadTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void EndTest()
        {
            try
            {
                _isTesting = false;
                timer_load.Enabled = false;
                btn_00.BackColor = Color.LightGray;
                btn_25.BackColor = Color.LightGray;
                btn_50.BackColor = Color.LightGray;
                btn_75.BackColor = Color.LightGray;
                btn_100.BackColor = Color.LightGray;
                lbl_status.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private int GetTestSteps()
        {
            string sql = "select max(ck_serial) as ck_serial from m_ck_point where ck_model = '" + cbo_model.Text + "'";
            sqlite sqlite_ = new sqlite();
            string strMaxStep = sqlite_.ExecuteScalarString(sql);
            if (!int.TryParse(strMaxStep, out int maxStep))
            {
                maxStep = STEPS;
            }
            return maxStep;
        }

        private DataTable GetMaster()
        {
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_ck_point where ck_model = '" + cbo_model.Text + "' order by ck_model";
            sqlite sqlite_ = new sqlite();
            sqlite_.SelectData(sqlmodel, ref dt);
            return dt;
        }
        #endregion
    }
}
