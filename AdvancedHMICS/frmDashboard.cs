using ActUtlTypeLib;
using AdvancedHMICS.Class;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
        #region --- CONSTANTS ---
        private const int SO_CAP_CUC = 6;

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
        #endregion
        #region --- FIELDS ---
        private int _iStep = 0;
        private int _iCounter = 0;
        private int _iMaxStep = STEPS;
        private bool _isAuto = false;
        private bool _isTesting = false;
        private bool _isConnectedPLC = false;
        private double _maxSpeedNoload = 9999;
        private double _minSpeedNoload = 0;

        private DataTable _dtMaster;
        private DataTable _dtResult;
        private readonly ActUtlType _plc = new ActUtlType();
        private readonly GridView _gv_main = new GridView();
        private readonly GridControl _gc_main = new GridControl();
        private readonly frmLoadStatus _frmLoad = new frmLoadStatus();
        #endregion
        #region --- VALUES ---
        public double Frequency
        {
            get
            {
                if (double.TryParse(avd_freq.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
        }

        public double Volt
        {
            get
            {
                if (double.TryParse(avd_volt.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
        }

        public double Current
        {
            get
            {
                if (double.TryParse(avd_curr.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
        }

        public double ElectricPower
        {
            get
            {
                if (double.TryParse(avd_power_e.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_power_e.Value = $"{value:0.00}";
        }

        public double DcVolt
        {
            get
            {
                if (double.TryParse(avd_volt_fw.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_volt_fw.Value = $"{value:0.00}";
        }

        public double DcCurrent
        {
            get
            {
                if (double.TryParse(avd_curr_fw.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_curr_fw.Value = $"{value:0.00}";
        }

        public double DcPower
        {
            get
            {
                if (double.TryParse(avd_power_dc.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_power_dc.Value = $"{value:0.00}";
        }

        public double Torque
        {
            get
            {
                if (double.TryParse(avd_torque.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_torque.Value = $"{value:0.00}";
        }

        public double ROTSpeed
        {
            get
            {
                if (double.TryParse(avd_speed_rot.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_speed_rot.Value = $"{value:0.00}";
        }

        public double ROTSpeedMod
        {
            get
            {
                if (double.TryParse(avd_speed_mod.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_speed_mod.Value = $"{value:0.00}";
        }

        public double ROTSpeedWav
        {
            get
            {
                if (double.TryParse(avd_speed_wav.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_speed_wav.Value = $"{value:0.00}";
        }

        public double MechanialPower
        {
            get
            {
                if (double.TryParse(avd_power_mec.Value, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => avd_power_mec.Value = $"{value:0.00}";
        }

        public double RatedPower
        {
            get
            {
                if (double.TryParse(lbl_power_p.Text, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => lbl_power_p.Text = $"{value:0.00}";
        }

        public double TargetPower
        {
            get
            {
                if (double.TryParse(lbl_power_target.Text, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => lbl_power_target.Text = $"{value:0.00}";
        }

        public double ActualPower
        {
            get
            {
                if (double.TryParse(lbl_power_actual.Text, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => lbl_power_actual.Text = $"{value:0.00}";
        }

        public double PIDStop
        {
            get
            {
                if (double.TryParse(lbl_pid_stop.Text, out double dVal))
                {
                    return dVal;
                }
                return 0;
            }
            set => lbl_pid_stop.Text = $"{value:0.00}";
        }

        public int SteadyTime
        {
            get
            {
                if (int.TryParse(lbl_steady_t.Text, out int iVal))
                {
                    return iVal;
                }
                return 0;
            }
            set => lbl_steady_t.Text = $"{value:N0}";
        }
        #endregion
        #region --- LIMIT ---
        public double MaxVolt
        {
            get => avd_volt.ValueLimitUpper;
            set => avd_volt.ValueLimitUpper = value;
        }

        public double MinVolt
        {
            get => avd_volt.ValueLimitLower;
            set => avd_volt.ValueLimitLower = value;
        }

        public double MaxCurrent
        {
            get => avd_curr.ValueLimitUpper;
            set => avd_curr.ValueLimitUpper = value;
        }

        public double MinCurrent
        {
            get => avd_curr.ValueLimitLower;
            set => avd_curr.ValueLimitLower = value;
        }

        public double MaxFrequency
        {
            get => avd_freq.ValueLimitUpper;
            set => avd_freq.ValueLimitUpper = value;
        }

        public double MinFrequency
        {
            get => avd_freq.ValueLimitLower;
            set => avd_freq.ValueLimitLower = value;
        }

        public double MaxSpeedMod
        {
            get => avd_speed_mod.ValueLimitUpper;
            set => avd_speed_mod.ValueLimitUpper = value;
        }

        public double MinSpeedMod
        {
            get => avd_speed_mod.ValueLimitLower;
            set => avd_speed_mod.ValueLimitLower = value;
        }
        #endregion
        public frmDashboard()
        {
            InitializeComponent();
            _gc_main.Dock = DockStyle.Fill;
            _gv_main.GridControl = _gc_main;
            _gc_main.MainView = _gv_main;
            _gc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { _gv_main });
            tlp_main.SetRow(_gc_main, 2);
            tlp_main.SetColumn(_gc_main, 0);
            tlp_main.SetColumnSpan(_gc_main, 3);
            tlp_main.Controls.Add(_gc_main);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                DefineResultTable();
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
                if (_isConnectedPLC)
                {
                    _plc.GetDevice2(FW_VOLT, out short shortValue);
                    DcVolt = shortValue / 100;
                }
            }
            catch
            {
            }
            try
            {
                if (_isTesting)
                {
                    double speed = ROTSpeed;
                    double speedMod = ROTSpeedMod;
                    double reatedPower = RatedPower;
                    double actualPower = ActualPower;
                    double minPower = reatedPower * 0.9;
                    double maxPower = reatedPower * 1.1;
                    PIDStop = reatedPower == actualPower ? 100 : reatedPower == 0
                        ? 0 : (actualPower / reatedPower) * 100;
                    if (0 < _iStep && speedMod < MaxSpeedMod && Volt < MaxVolt
                        && _minSpeedNoload <= speed && speed <= _maxSpeedNoload)
                    {
                        if (speed < MaxSpeedMod)
                        {

                        }
                    }

                    if (SteadyTime > 0)
                    {
                        SteadyTime--;
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

        private void avd_volt_fw_ValueChanged(object sender, EventArgs e)
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
                double torque_ = 0;
                double volt_ = Volt;
                double curr_ = Current;
                double freq_ = Frequency;
                double dcVolt_ = DcVolt;
                double dcCurr_ = dcVolt_ / FIXED_RES;
                double speed_ = (60 * freq_) / SO_CAP_CUC;
                double actualP_ = (volt_ * curr_) / 1000;
                if (speed_ > 0)
                {
                    torque_ = (volt_ * curr_ * 9.95) / speed_;
                }

                Torque = torque_;
                ROTSpeed = speed_;
                DcPower = dcVolt_ * dcCurr_;
                ActualPower = ElectricPower = actualP_;
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
                var drStep = _dtMaster.AsEnumerable().FirstOrDefault(row => row["ck_serial"].ToString() == step.ToString());
                #region --- CURRENT LIMIT ---
                if (!double.TryParse(drStep["ck_Min_Generator"]?.ToString(), out double minCurr))
                {
                    minCurr = 0;
                }
                if (!double.TryParse(drStep["ck_Max_Generator"]?.ToString(), out double maxCurr))
                {
                    maxCurr = 9999;
                }
                MinCurrent = minCurr;
                MaxCurrent = maxCurr;
                #endregion
                #region --- VOLTAGE LIMIT ---
                if (!double.TryParse(drStep["ck_Min_VolGenerator"]?.ToString(), out double minVolt))
                {
                    minVolt = 0;
                }
                if (!double.TryParse(drStep["ck_Max_VolGenerator"]?.ToString(), out double maxVolt))
                {
                    maxVolt = 9999;
                }
                MaxVolt = maxVolt;
                MinVolt = minVolt;
                #endregion
                #region --- FREQUENCY LIMIT ---
                if (!double.TryParse(drStep["ck_Min_frequency"]?.ToString(), out double minFreq))
                {
                    minFreq = 0;
                }
                if (!double.TryParse(drStep["ck_Max_frequency"]?.ToString(), out double maxFreq))
                {
                    maxFreq = 9999;
                }
                MaxFrequency = maxFreq;
                MinFrequency = minFreq;
                #endregion
                #region --- SPEED MOD LIMIT ---
                if (!double.TryParse(drStep["ck_Min_fluctuationspeed"]?.ToString(), out double minFluc))
                {
                    minFluc = 0;
                }
                if (!double.TryParse(drStep["ck_Max_fluctuationspeed"]?.ToString(), out double maxFluc))
                {
                    maxFluc = 9999;
                }
                MaxSpeedMod = maxFluc;
                MinSpeedMod = minFluc;
                #endregion
                if (!int.TryParse(drStep["ck_LoadTime"]?.ToString(), out int loadTime))
                {
                    loadTime = TIME_OUT;
                }
                if (!double.TryParse(drStep["ck_Min_Noloadlimitspeed"]?.ToString(), out double minSpeed))
                {
                    minSpeed = 0;
                }
                if (!double.TryParse(drStep["ck_Max_Noloadlimitspeed"]?.ToString(), out double maxSpeed))
                {
                    maxSpeed = 0;
                }

                ROTSpeed = 0;
                SteadyTime = loadTime;

                _iStep = step;
                _isTesting = true;
                _iCounter = loadTime;
                _minSpeedNoload = minSpeed;
                _maxSpeedNoload = maxSpeed;
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
                lbl_status.BackColor = Color.Green;
                _frmLoad.CheckBits(drStep["ck_load"]?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                EndTest();
            }
        }

        private void EndTest()
        {
            try
            {
                _isTesting = false;
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

        private void DefineResultTable()
        {
            _dtResult = new DataTable();
            _dtResult.Columns.Add("ck_serial");
            _dtResult.Columns.Add("ck_time");
            _dtResult.Columns.Add("ck_model");
            _dtResult.Columns.Add("ck_number");
            _dtResult.Columns.Add("ck_order");
            _dtResult.Columns.Add("ck_rack");
            _dtResult.Columns.Add("ck_speed_noload");
            _dtResult.Columns.Add("ck_load_percent");
            _dtResult.Columns.Add("ck_speed_output");
            _dtResult.Columns.Add("ck_power");
            _dtResult.Columns.Add("ck_torque");
            _dtResult.Columns.Add("ck_speed_adj");
            _dtResult.Columns.Add("ck_speed_flt");
            _dtResult.Columns.Add("ck_speed_max");
            _dtResult.Columns.Add("ck_speed_min");
            _dtResult.Columns.Add("ck_braking_time");
            _dtResult.Columns.Add("ck_result");
            _dtResult.Columns.Add("ck_tester");
            _dtResult.Columns.Add("ck_upload");
            _dtResult.Columns.Add("ck_test_type");
            _dtResult.Columns.Add("ck_volt");
            _dtResult.Columns.Add("ck_current");
            _dtResult.Columns.Add("ck_frequency");
            _dtResult.Columns.Add("ck_pressure_neg");
            _dtResult.Columns.Add("ck_reason");
            _dtResult.Columns.Add("ck_volt_dc");
            _dtResult.Columns.Add("ck_current_dc");
            _dtResult.Columns.Add("ck_power_dc");
            _dtResult.Columns.Add("linecd");
            _dtResult.Columns.Add("machinecd");
            _dtResult.Columns.Add("datimeregister");
            _dtResult.Columns.Add("ck_pid_stop");

            _gc_main.DataSource = _dtResult;

            _gv_main.Columns["ck_serial"].Visible = true;
            _gv_main.Columns["ck_time"].Visible = true;
            _gv_main.Columns["ck_model"].Visible = true;
            _gv_main.Columns["ck_number"].Visible = true;
            _gv_main.Columns["ck_order"].Visible = true;
            _gv_main.Columns["ck_rack"].Visible = false;
            _gv_main.Columns["ck_speed_noload"].Visible = true;
            _gv_main.Columns["ck_load_percent"].Visible = true;
            _gv_main.Columns["ck_speed_output"].Visible = true;
            _gv_main.Columns["ck_power"].Visible = true;
            _gv_main.Columns["ck_torque"].Visible = true;
            _gv_main.Columns["ck_speed_adj"].Visible = true;
            _gv_main.Columns["ck_speed_flt"].Visible = true;
            _gv_main.Columns["ck_speed_max"].Visible = true;
            _gv_main.Columns["ck_speed_min"].Visible = true;
            _gv_main.Columns["ck_braking_time"].Visible = false;
            _gv_main.Columns["ck_result"].Visible = true;
            _gv_main.Columns["ck_tester"].Visible = false;
            _gv_main.Columns["ck_upload"].Visible = false;
            _gv_main.Columns["ck_test_type"].Visible = false;
            _gv_main.Columns["ck_volt"].Visible = true;
            _gv_main.Columns["ck_current"].Visible = true;
            _gv_main.Columns["ck_frequency"].Visible = true;
            _gv_main.Columns["ck_pressure_neg"].Visible = false;
            _gv_main.Columns["ck_reason"].Visible = false;
            _gv_main.Columns["ck_volt_dc"].Visible = true;
            _gv_main.Columns["ck_current_dc"].Visible = true;
            _gv_main.Columns["ck_power_dc"].Visible = true;
            _gv_main.Columns["linecd"].Visible = false;
            _gv_main.Columns["machinecd"].Visible = false;
            _gv_main.Columns["datimeregister"].Visible = false;
            _gv_main.Columns["ck_pid_stop"].Visible = true;

            _gv_main.Columns["ck_serial"].Caption = "Step";
            _gv_main.Columns["ck_time"].Caption = "Time";
            _gv_main.Columns["ck_model"].Caption = "Model";
            _gv_main.Columns["ck_number"].Caption = "Barcode";
            _gv_main.Columns["ck_order"].Caption = "OrderId";
            _gv_main.Columns["ck_rack"].Caption = "";
            _gv_main.Columns["ck_speed_noload"].Caption = "Noload Speed";
            _gv_main.Columns["ck_load_percent"].Caption = "Percentage";
            _gv_main.Columns["ck_load_percent"].DisplayFormat.FormatString = "{0:P2}";
            _gv_main.Columns["ck_speed_output"].Caption = "ROT Speed";
            _gv_main.Columns["ck_power"].Caption = "Actual Power";
            _gv_main.Columns["ck_torque"].Caption = "Torque";
            _gv_main.Columns["ck_speed_adj"].Caption = "ROT Speed Mod";
            _gv_main.Columns["ck_speed_flt"].Caption = "ROT Speed Wav";
            _gv_main.Columns["ck_speed_max"].Caption = "Speed Max";
            _gv_main.Columns["ck_speed_min"].Caption = "Speed Min";
            _gv_main.Columns["ck_braking_time"].Caption = "";
            _gv_main.Columns["ck_result"].Caption = "Result";
            _gv_main.Columns["ck_tester"].Caption = "";
            _gv_main.Columns["ck_upload"].Caption = "";
            _gv_main.Columns["ck_test_type"].Caption = "";
            _gv_main.Columns["ck_volt"].Caption = "Voltage";
            _gv_main.Columns["ck_current"].Caption = "Current";
            _gv_main.Columns["ck_frequency"].Caption = "Frequency";
            _gv_main.Columns["ck_pressure_neg"].Caption = "";
            _gv_main.Columns["ck_reason"].Caption = "";
            _gv_main.Columns["ck_volt_dc"].Caption = "FW Voltage";
            _gv_main.Columns["ck_current_dc"].Caption = "FW Current";
            _gv_main.Columns["ck_power_dc"].Caption = "DC Power";
            _gv_main.Columns["linecd"].Caption = "";
            _gv_main.Columns["machinecd"].Caption = "";
            _gv_main.Columns["datimeregister"].Caption = "";
            _gv_main.Columns["ck_pid_stop"].Caption = "PID Stop";
        }
        #endregion
    }
}
