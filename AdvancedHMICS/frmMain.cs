using ActUtlTypeLib;
using AdvancedHMICS.Class;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmMain : Form
    {
        #region --- Fields ---
        private const int SO_CAP_CUC = 1;
        private const int STEPS = 5;

        /// <summary>
        /// Số lần NG tối đa cho phép
        /// </summary>
        private const int MAX_NG = 3;

        private const int TIME_OUT = 30;
        private const float FIXED_RES = 0.3f; //dơn vị là ôm.

        private int _iTimeOut = 0;
        private int _iCounter = 0;
        private int _iLoadTime = 0;
        private int _iCurrStep = 0;
        private int _iSteps = STEPS;
        private int _iMaxNG = MAX_NG;

        private bool _isRun = false;
        private bool _isAuto = false;
        private bool _isPlcConnected = false;

        private string _logFile;

        private DataRow _drStepData;
        private readonly DataTable _dtResult = new DataTable();

        private readonly frmData _frmData = new frmData();
        private readonly frmUser _frmUser = new frmUser();
        private readonly frmLoadStatus _frmLoad = new frmLoadStatus();
        private readonly frmQuerySQLite _frmSqlLite = new frmQuerySQLite();
        private readonly frmSettingModel _frmModels = new frmSettingModel();
        private readonly frmSettingOrder _frmOrders = new frmSettingOrder();
        private readonly frmPLCValueRealtime _frmPlc = new frmPLCValueRealtime();

        // Khai báo kết nối PLC
        private readonly ActUtlType _plc = new ActUtlType();

        private float _fFreq = 0;
        private float _fUperFreq = 0;
        private float _fLowerFreq = 0;

        private float _fVolt = 0;
        private float _fUperVolt = 0;
        private float _fLowerVolt = 0;
        private float _fDcVolt = 0;

        private float _fCurrent = 0;
        private float _fUperCurrent = 0;
        private float _fLowerCurrent = 0;
        private float _fDcCurrent = 0;

        private float _fDcPower = 0;
        private float _fActualPower = 0;

        private float _fSpeed = 0;
        private float _fMaxSpeed = 0;
        private float _fMinSpeed = 0;
        private float _fUperSpeed = 0;
        private float _fLowerSpeed = 0;
        private float _fNoLoadSpeed = 0;
        private float _fModSpeed = 0;
        private float _fUperModlSpeed = 0;
        private float _fLowerModSpeed = 0;

        private float _fTorque = 0;
        private float _fPidStop = 0;
        #endregion
        #region --- KHỞI TẠO ---
        public frmMain()
        {
            InitializeComponent();
            DefineResultTable();
            _plc.ActLogicalStationNumber = 1;
            gv_main.OptionsBehavior.ReadOnly = true;
            gv_main.OptionsBehavior.Editable = false;
            gv_main.OptionsSelection.MultiSelect = true;
            gv_main.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gv_main.CustomDrawCell += Gv_main_CustomDrawCell;
        }

        private void DefineResultTable()
        {
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
            gc_main.DataSource = _dtResult;

            gv_main.Columns["ck_serial"].Visible = true;
            gv_main.Columns["ck_time"].Visible = true;
            gv_main.Columns["ck_model"].Visible = true;
            gv_main.Columns["ck_number"].Visible = true;
            gv_main.Columns["ck_order"].Visible = true;
            gv_main.Columns["ck_rack"].Visible = false;
            gv_main.Columns["ck_speed_noload"].Visible = true;
            gv_main.Columns["ck_load_percent"].Visible = true;
            gv_main.Columns["ck_speed_output"].Visible = true;
            gv_main.Columns["ck_power"].Visible = true;
            gv_main.Columns["ck_torque"].Visible = true;
            gv_main.Columns["ck_speed_adj"].Visible = true;
            gv_main.Columns["ck_speed_flt"].Visible = true;
            gv_main.Columns["ck_speed_max"].Visible = true;
            gv_main.Columns["ck_speed_min"].Visible = true;
            gv_main.Columns["ck_braking_time"].Visible = false;
            gv_main.Columns["ck_result"].Visible = true;
            gv_main.Columns["ck_tester"].Visible = false;
            gv_main.Columns["ck_upload"].Visible = false;
            gv_main.Columns["ck_test_type"].Visible = false;
            gv_main.Columns["ck_volt"].Visible = true;
            gv_main.Columns["ck_current"].Visible = true;
            gv_main.Columns["ck_frequency"].Visible = true;
            gv_main.Columns["ck_pressure_neg"].Visible = false;
            gv_main.Columns["ck_reason"].Visible = false;
            gv_main.Columns["ck_volt_dc"].Visible = true;
            gv_main.Columns["ck_current_dc"].Visible = true;
            gv_main.Columns["ck_power_dc"].Visible = true;
            gv_main.Columns["linecd"].Visible = false;
            gv_main.Columns["machinecd"].Visible = false;
            gv_main.Columns["datimeregister"].Visible = false;
            gv_main.Columns["ck_pid_stop"].Visible = true;

            gv_main.Columns["ck_serial"].Caption = "Step";
            gv_main.Columns["ck_time"].Caption = "Time";
            gv_main.Columns["ck_model"].Caption = "Model";
            gv_main.Columns["ck_number"].Caption = "Barcode";
            gv_main.Columns["ck_order"].Caption = "OrderId";
            gv_main.Columns["ck_rack"].Caption = "";
            gv_main.Columns["ck_speed_noload"].Caption = "Noload Speed";
            gv_main.Columns["ck_load_percent"].Caption = "Percentage";
            gv_main.Columns["ck_load_percent"].DisplayFormat.FormatString = "{0:P2}";
            gv_main.Columns["ck_speed_output"].Caption = "ROT Speed";
            gv_main.Columns["ck_power"].Caption = "Actual Power";
            gv_main.Columns["ck_torque"].Caption = "Torque";
            gv_main.Columns["ck_speed_adj"].Caption = "ROT Speed Mod";
            gv_main.Columns["ck_speed_flt"].Caption = "ROT Speed Wav";
            gv_main.Columns["ck_speed_max"].Caption = "Speed Max";
            gv_main.Columns["ck_speed_min"].Caption = "Speed Min";
            gv_main.Columns["ck_braking_time"].Caption = "";
            gv_main.Columns["ck_result"].Caption = "Result";
            gv_main.Columns["ck_tester"].Caption = "";
            gv_main.Columns["ck_upload"].Caption = "";
            gv_main.Columns["ck_test_type"].Caption = "";
            gv_main.Columns["ck_volt"].Caption = "Voltage";
            gv_main.Columns["ck_current"].Caption = "Current";
            gv_main.Columns["ck_frequency"].Caption = "Frequency";
            gv_main.Columns["ck_pressure_neg"].Caption = "";
            gv_main.Columns["ck_reason"].Caption = "";
            gv_main.Columns["ck_volt_dc"].Caption = "FW Voltage";
            gv_main.Columns["ck_current_dc"].Caption = "FW Current";
            gv_main.Columns["ck_power_dc"].Caption = "DC Power";
            gv_main.Columns["linecd"].Caption = "";
            gv_main.Columns["machinecd"].Caption = "";
            gv_main.Columns["datimeregister"].Caption = "";
            gv_main.Columns["ck_pid_stop"].Caption = "PID Stop";
        }
        #endregion
        #region --- SỰ KIỆN ---
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                CheckPressure();
                ClsVariables.ReadConfigFile();
                string sqlmodel = "select distinct(ck_model) from m_ck_point order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.GetComboBoxData(sqlmodel, ref cbm_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            _frmUser.ShowDialog();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            _frmData.Show();
        }

        private void btn_plcstatus_Click(object sender, EventArgs e)
        {
            _frmPlc.ShowDialog();
        }

        private void btn_loadStatus_Click(object sender, EventArgs e)
        {
            _frmLoad.Show();
        }

        private void btn_querysqlite_Click(object sender, EventArgs e)
        {
            _frmSqlLite.ShowDialog();
        }

        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            _frmModels.ShowDialog();
        }

        private void btn_settingorder_Click(object sender, EventArgs e)
        {
            _frmOrders.ShowDialog();
        }

        private void avd_voltage_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }

        private void avd_current_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }

        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            CalcValues();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _plc.Close();
        }

        private void Gv_main_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string result = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ck_result"]);
                if (result == "合格")
                {
                    result = "PASSED";
                    View.SetRowCellValue(e.RowHandle, View.Columns["ck_result"], result);
                }
                e.Appearance.BackColor = result == "PASSED" ? Color.Green : Color.Red;
                e.Appearance.ForeColor = Color.Yellow;
            }
        }
        #endregion
        #region --- CHẾ ĐỘ TEST ---
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                _dtResult.Rows.Clear();
                if (Checkinput() == false || CheckPressure() == false) return;
                if (_isPlcConnected)
                {
                    SetPLCStatus(false);
                    _plc.Close();
                    return;
                }
                SetPLCStatus(true);
                _plc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isAuto)
                {
                    var btn = (Button)sender;
                    if (int.TryParse(btn.Tag?.ToString(), out int step))
                    {
                        if (_isRun)
                        {
                            if (step == _iCurrStep) SetTestStatus(false);
                            return;
                        }
                        StartTest(step);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_autoload_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isRun)
                {
                    if (_isAuto)
                    {
                        _isAuto = false;
                        SetTestStatus(false);
                    }
                    return;
                }
                _isAuto = true;
                _dtResult.Rows.Clear();
                _iSteps = GetTestSteps();
                StartTest(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            try
            {
                CalcValues();
                if (_isRun)
                {
                    if (_iCounter == _iLoadTime)
                    {
                        _fMinSpeed = _fSpeed;
                        _fMaxSpeed = _fSpeed;
                    }
                    // Điều kiện kiểm tra (nếu không đạt điều kiện thì sẽ đợi)
                    if (_iCurrStep > 0
                        && (_fLowerSpeed <= _fSpeed && _fUperSpeed >= _fSpeed)
                        && (_fLowerModSpeed <= _fModSpeed && _fModSpeed <= _fUperModlSpeed)
                        && (_fLowerVolt <= _fVolt && _fVolt <= _fUperVolt)
                        && (_fLowerCurrent <= _fCurrent && _fCurrent <= _fUperCurrent)
                        && (_fLowerFreq <= _fFreq && _fFreq <= _fUperFreq))
                    {
                        _iCounter--;
                        // Với các step > 1 thì tính mod speed
                        if (_iCurrStep > 1)
                        {
                            if (_fSpeed < _fMinSpeed)
                            {
                                _fMinSpeed = _fSpeed;
                            }
                            if (_fSpeed > _fMaxSpeed)
                            {
                                _fMaxSpeed = _fSpeed;
                            }
                            _fModSpeed = Math.Abs(_fMinSpeed - _fMaxSpeed);
                            _fModSpeed = _fModSpeed / _fNoLoadSpeed * 100;
                        }

                    }
                    if (!float.TryParse(lbl_rated_P.Text, out float reatedPower))
                    {
                        reatedPower = 0;
                    }
                    double minPower = reatedPower * 0.99;
                    double maxPower = reatedPower * 1.01;
                    _fPidStop = reatedPower == _fActualPower
                        ? 100 : (reatedPower == 0 ? 0 : (_fActualPower / reatedPower) * 100);
                    if (_fActualPower < minPower)
                    {
                        // Đếm 20s trước khi xác định lại số lần test
                        _iTimeOut--;
                        _iCounter = _iLoadTime;
                        if (_iTimeOut < 1)
                        {
                            _iMaxNG--;
                        }
                    }
                    if (_fActualPower > maxPower || _iMaxNG < 0)
                    {
                        EndTest(false);
                        return;
                    }
                    if (_iCounter < 1)
                    {
                        EndTest(true);
                    }
                    lbl_adj_value.Text = $"{_fPidStop:0.##}";
                }
            }
            finally
            {
                lbl_steadyT.Text = _iCounter.ToString();
            }
        }

        private void SetPLCStatus(bool isConnect)
        {
            _isPlcConnected = isConnect;
            btn_clear.Enabled = isConnect;
            btn_record.Enabled = isConnect;
            btn_export.Enabled = isConnect;
            cbm_model.Enabled = !isConnect;
            cbm_orderid.Enabled = !isConnect;
            txt_barcode.ReadOnly = isConnect;
            btn_autoload.Enabled = isConnect;
            btn_plcstatus.Enabled = isConnect;
            btn_deleterow.Enabled = isConnect;
            btn_loadStatus.Enabled = isConnect;
            btn_start.Text = isConnect ? "Running" : "Start/Run";
            btn_start.BackColor = isConnect ? Color.Green : Color.Red;
            btn_autoload.BackColor = isConnect ? Color.Red : Color.LightGray;
            btn_plcstatus.BackColor = isConnect ? Color.Green : Color.LightGray;
            btn_loadStatus.BackColor = isConnect ? Color.Green : Color.LightGray;
        }

        private void SetTestStatus(bool isRun)
        {
            _isRun = isRun;
            btn_start.Enabled = !isRun;
            if (isRun)
            {
                switch (_iCurrStep)
                {
                    case 1:
                        btn_0.BackColor = Color.Green;
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
                lbl_adj_value.Text = "0.00";
                lbl_pcStep.Text = _iCurrStep.ToString();
                lbl_steadyT.Text = _iLoadTime.ToString();
                lbl_status_automanual.BackColor = Color.Green;
                lbl_status_automanual.Text = _isAuto ? "AutoLoad" : "Manual";
                lbl_rated_P.Text = _drStepData["ck_Steppower"]?.ToString();
                return;
            }
            _frmLoad.CheckBits("0000000000000000");
            btn_0.BackColor = Color.LightGray;
            btn_25.BackColor = Color.LightGray;
            btn_50.BackColor = Color.LightGray;
            btn_75.BackColor = Color.LightGray;
            btn_90.BackColor = Color.LightGray;
            btn_100.BackColor = Color.LightGray;
            lbl_status_automanual.Text = "Manual";
            lbl_status_automanual.BackColor = Color.LightGray;
            btn_autoload.BackColor = _isAuto ? Color.Green : Color.Red;
        }

        /// <summary>
        /// Kiểm tra đã chọn model hay chưa
        /// </summary>
        /// <returns></returns>
        private bool Checkinput()
        {
            if (cbm_model.SelectedItem == null || cbm_orderid.SelectedItem == null || txt_barcode.Text == "")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin Mã Hàng ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Bắt đầu step theo step
        /// </summary>
        /// <param name="step"></param>
        private void StartTest(int step)
        {
            try
            {
                if (Checkinput() == false || CheckPressure() == false) return;
                _drStepData = GetMasterStep(step);
                if (!int.TryParse(_drStepData["ck_LoadTime"]?.ToString(), out int loadTime))
                {
                    loadTime = 0;
                }
                _iLoadTime = loadTime;
                _iCounter = _iLoadTime;

                if (!float.TryParse(_drStepData["ck_Min_Noloadlimitspeed"]?.ToString(), out float minRPM))
                {
                    minRPM = 0;
                }

                _fLowerSpeed = minRPM;
                if (!float.TryParse(_drStepData["ck_Max_Noloadlimitspeed"]?.ToString(), out float maxRPM))
                {
                    maxRPM = 0;
                }
                _fUperSpeed = maxRPM;

                #region --- CURRENT LIMIT ---
                if (!float.TryParse(_drStepData["ck_Min_Generator"]?.ToString(), out float minCurr))
                {
                    minCurr = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_Generator"]?.ToString(), out float maxCurr))
                {
                    maxCurr = 9999;
                }
                _fUperCurrent = maxCurr;
                _fLowerCurrent = minCurr;
                avd_current.ValueLimitUpper = maxCurr;
                avd_current.ValueLimitLower = minCurr;
                #endregion
                #region --- VOLTAGE LIMIT ---
                if (!float.TryParse(_drStepData["ck_Min_VolGenerator"]?.ToString(), out float minVolt))
                {
                    minVolt = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_VolGenerator"]?.ToString(), out float maxVolt))
                {
                    maxVolt = 9999;
                }
                _fUperVolt = maxVolt;
                _fLowerVolt = minVolt;
                avd_voltage.ValueLimitUpper = maxVolt;
                avd_voltage.ValueLimitLower = minVolt;
                #endregion
                #region --- FREQUENCY LIMIT ---
                if (!float.TryParse(_drStepData["ck_Min_frequency"]?.ToString(), out float minFreq))
                {
                    minFreq = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_frequency"]?.ToString(), out float maxFreq))
                {
                    maxFreq = 9999;
                }
                _fUperFreq = maxFreq;
                _fLowerFreq = minFreq;
                avd_frequency.ValueLimitUpper = maxFreq;
                avd_frequency.ValueLimitLower = minFreq;
                #endregion
                #region --- SPEED MOD LIMIT ---
                if (!float.TryParse(_drStepData["ck_Min_fluctuationspeed"]?.ToString(), out float minFluc))
                {
                    minFluc = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_fluctuationspeed"]?.ToString(), out float maxFluc))
                {
                    maxFluc = 9999;
                }
                _fUperModlSpeed = maxFluc;
                _fLowerModSpeed = minFluc;
                avd_rotspdmod.ValueLimitUpper = maxFluc;
                avd_rotspdmod.ValueLimitLower = minFluc;
                #endregion

                _fSpeed = 0;
                _fMaxSpeed = 0;
                _fMinSpeed = 0;
                _iMaxNG = MAX_NG;
                _iCurrStep = step;
                _iTimeOut = TIME_OUT;
                _frmLoad.CheckBits(_drStepData["ck_load"]?.ToString());
                SetTestStatus(true);
            }
            catch (Exception ex)
            {
                SetTestStatus(false);
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        /// <summary>
        /// Kết thúc test
        /// </summary>
        /// <param name="isOk"></param>
        private void EndTest(bool isOk)
        {
            // Step đầu tiên thì set tốc độ không tải
            if (_iCurrStep == 1)
            {
                _fNoLoadSpeed = _fSpeed;
            }
            SetTestStatus(false);
            // Hiển thị dữ liệu lên grid
            if (_drStepData != null)
            {
                var test_time = DateTime.Now;
                var dr = _dtResult.NewRow();
                dr["ck_serial"] = _drStepData["ck_serial"];
                dr["ck_time"] = test_time.ToDtString();
                dr["ck_model"] = cbm_model.Text;
                dr["ck_number"] = txt_barcode.Text;
                dr["ck_order"] = cbm_orderid.Text;
                dr["ck_rack"] = "1-1";
                dr["ck_speed_noload"] = _fNoLoadSpeed;
                dr["ck_load_percent"] = _drStepData["ck_Steppercentage"];
                dr["ck_speed_output"] = lbl_speedrpm.Text;
                dr["ck_power"] = lbl_actualP.Text;
                dr["ck_torque"] = avd_torque.Value;
                dr["ck_speed_adj"] = avd_rotspdmod.Value;
                dr["ck_speed_flt"] = avd_rotspdwav.Value;
                dr["ck_speed_max"] = _fMaxSpeed;
                dr["ck_speed_min"] = _fMinSpeed;
                dr["ck_braking_time"] = _drStepData["ck_testbrakes"];
                dr["ck_result"] = isOk ? "合格" : "";
                dr["ck_tester"] = ClsVariables.User;
                dr["ck_upload"] = ClsVariables.User;
                dr["ck_test_type"] = "N/A";
                dr["ck_volt"] = avd_voltage.Text;
                dr["ck_current"] = avd_current.Text;
                dr["ck_frequency"] = avd_frequency.Text;
                dr["ck_pressure_neg"] = "N/A";
                dr["ck_reason"] = "N/A";
                dr["ck_volt_dc"] = avd_FWVolt.Value;
                dr["ck_current_dc"] = avd_FWcurr.Value;
                dr["ck_power_dc"] = avd_DCpower.Value;
                dr["linecd"] = ClsVariables.Line;
                dr["machinecd"] = ClsVariables.Machine;
                dr["datimeregister"] = test_time.ToDtString();
                dr["ck_pid_stop"] = lbl_adj_value.Text;
                _dtResult.Rows.Add(dr);
                _drStepData = null;
            }
            // Chuyển sang step kế khi chạy auto
            if (isOk && _isAuto && _iCurrStep < _iSteps)
            {
                _iCurrStep++;
                StartTest(_iCurrStep);
                _isRun = _iCurrStep <= _iSteps;
            }
            // Kết thúc kiểm tra
            if (!_isRun)
            {
                _isAuto = false;
                SetTestStatus(false);
                string result = isOk ? "OK" : "NG";
                if (MessageBox.Show($"Test complete!\nResult: {result}\nDo you want record data?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btn_record_Click(this, null);
                }
            }
        }
        #endregion
        #region --- XỬ LÝ DỮ LIỆU ---
        private void btn_clear_Click(object sender, EventArgs e)
        {
            _dtResult.Rows.Clear();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dtResult.Rows.Count < 1)
                {
                    return;
                }
                sqlite sqlite_ = new sqlite();
                string columns = string.Join(",", _dtResult.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                foreach (DataRow dr in _dtResult.Rows)
                {
                    string values = "'" + string.Join("','", dr.ItemArray.Select(x => x?.ToString())) + "'";
                    string sql = $"INSERT INTO m_history ({columns}) VALUES ({values})";
                    sqlite_.ExeNonQuery_auto(sql);
                }
                _dtResult.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_deleterow_Click(object sender, EventArgs e)
        {
            int[] rows = gv_main.GetSelectedRows();
            if (rows != null && rows.Length > 0)
            {
                foreach (var row in rows)
                {
                    _dtResult.Rows.RemoveAt(row);
                }
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
                sqlite_.GetComboBoxData(sqlorderid.ToString(), ref cbm_orderid);
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

        private int GetTestSteps()
        {
            string sql = "select max(ck_serial) as ck_serial from m_ck_point where ck_model = '" + cbm_model.Text + "'";
            sqlite sqlite_ = new sqlite();
            string strMaxStep = sqlite_.ExecuteScalarString(sql);
            if (!int.TryParse(strMaxStep, out int maxStep))
            {
                maxStep = STEPS;
            }
            return maxStep;
        }

        private DataRow GetMasterStep(int step)
        {
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_ck_point where ck_model = '" + cbm_model.Text + "' order by ck_model";
            sqlite sqlite_ = new sqlite();
            sqlite_.SelectData(sqlmodel, ref dt);
            return dt.AsEnumerable().FirstOrDefault(row => row["ck_serial"].ToString() == step.ToString());
        }
        #endregion
        #region --- SQL BACKUP ---
        private const string KEY = "keyofkey,notofnot";

        private bool ReadAndInsertData()
        {
            /*
             * S1: limited date for disconnect of network
             * S2: fillter this table
             * S3: check dulicate
             * S4: insert data rows
             */
            DataTable dt_result = new DataTable();
            StringBuilder sqlBuilder = new StringBuilder();
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlBuilder.Append("SELECT ID,ck_serial,ck_time,ck_model,ck_number,ck_order,ck_rack,");
                sqlBuilder.Append("ck_speed_noload,ck_load_percent,ck_speed_output,ck_power,");
                sqlBuilder.Append("ck_torque,ck_speed_adj,ck_speed_flt,ck_speed_max,ck_speed_min,");
                sqlBuilder.Append("ck_braking_time,ck_result,ck_tester,ck_upload,ck_test_type,");
                sqlBuilder.Append("ck_volt,ck_current,ck_frequency,ck_pressure_neg,ck_reason,");
                sqlBuilder.Append("ck_volt_dc,ck_current_dc,ck_power_dc,linecd,machinecd,datimeregister ");
                sqlBuilder.Append("FROM m_history WHERE ck_time > DATE('now') -300;");
                sqlite_.SelectData(sqlBuilder.ToString(), ref dt_result);
            }
            catch (Exception ex)
            {
                WriteSqlLog("Cannot Read Data from Data Access file", ex.ToString());
            }
            if (dt_result.Rows.Count > 0)
            {
                try
                {
                    foreach (DataRow dtRow in dt_result.Rows)
                    {
                        string srtcheck = dtRow[1].ToString() + dtRow[3].ToString() + dtRow[4].ToString() + dtRow[5].ToString();
                        DateTime datetimecheck = DateTime.Parse(dtRow[2].ToString());
                        string sqlcheck = @"select count(*) from 
                        (SELECT cast(v_twin_02 as varchar(256))   + v_twin_04 + v_twin_05 + v_twin_06 as checkcolumn
                        FROM m_v_twin_history where v_twin_03 > GETDATE() - 300" +
                        " and  cast(v_twin_02 as varchar(256)) + v_twin_04 + v_twin_05 + v_twin_06 = N'" + srtcheck + "' " +
                        " and v_twin_03 ='" + datetimecheck + "' )a";
                        SqlGetClass con = new SqlGetClass();
                        if (int.Parse(con.sqlExecuteScalarString_Autosystem(sqlcheck)) < 1) //insert
                        {
                            string values = "N'" + string.Join("',N'", dtRow.ItemArray.Select(x => x?.ToString())) + "'";
                            //insert here
                            StringBuilder sqlinsert = new StringBuilder();
                            sqlinsert.Append("insert into m_v_twin_history (");
                            sqlinsert.Append("v_twin_01,v_twin_02,v_twin_03,v_twin_04,v_twin_05,v_twin_06,v_twin_07,v_twin_08,v_twin_09,");
                            sqlinsert.Append("v_twin_10,v_twin_11,v_twin_12,v_twin_13,v_twin_14,v_twin_15,v_twin_16,v_twin_17,v_twin_18,");
                            sqlinsert.Append("v_twin_19,v_twin_20,v_twin_21,v_twin_22,v_twin_23,v_twin_24,v_twin_25,v_twin_26,v_twin_27,");
                            sqlinsert.Append("v_twin_28,v_twin_29,");
                            sqlinsert.AppendFormat("linecd, machinecd,datimeregister ) VALUES ({0});", values);
                            //foreach (DataColumn dtcolumn in dt_result.Columns)
                            //{
                            //    sqlinsert.Append("N'" + dtRow[dtcolumn].ToString() + "',");
                            //}
                            //sqlinsert.Append("'" + cbm_linecd.Text + "',");
                            //sqlinsert.Append("'" + cbm_machinecd.Text + "',");
                            //sqlinsert.Append("GETDATE())");
                            con.sqlExecuteScalarString_Autosystem(sqlinsert.ToString());
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    WriteSqlLog("Cannot insert data to the server", ex.ToString());
                }
            }
            return false;
        }

        private string Decrypt(string toDecrypt)
        {
            try
            {
                bool useHashing = true;
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(KEY));
                }
                else
                    keyArray = UTF8Encoding.UTF8.GetBytes(KEY);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                WriteSqlLog(" Rows Decrypt Demo Error", ex.ToString());
                return "122000";
            }

        }

        private void SetAutoBackup(bool isConnected)
        {
            if (isConnected)
            {
                btnSqlConnect.Text = "SQL Connected";
                btnSqlConnect.BackColor = Color.Green;
            }
            else
            {
                btnSqlConnect.Text = "SQL Connect";
                btnSqlConnect.BackColor = Color.Red;
            }
            timerSQL.Enabled = isConnected;
        }

        private void timerSQL_Tick(object sender, EventArgs e)
        {
            try
            {
                ReadAndInsertData();
            }
            catch (Exception ex)
            {
                SetAutoBackup(false);
                WriteSqlLog(ex.Message);
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btnSqlLogs_Click(object sender, EventArgs e)
        {
            try
            {
                btnSqlLogs.BackColor = Color.LightGray;
                if (string.IsNullOrWhiteSpace(_logFile) || !File.Exists(_logFile))
                {
                    MessageBox.Show("Not found log file!", "Error");
                    return;
                }
                Process.Start("notepad.exe", _logFile);
            }
            catch (Exception ex)
            {
                SetAutoBackup(false);
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btnSqlConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!timerSQL.Enabled)
                {
                    btnSqlConnect.Text = "SQL Connected";
                    btnSqlConnect.BackColor = Color.Green;
                    bool isBackup = ReadAndInsertData();
                    SetAutoBackup(isBackup);
                }
                else
                {
                    SetAutoBackup(false);
                }
            }
            catch (Exception ex)
            {
                SetAutoBackup(false);
                WriteSqlLog(ex.Message);
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void WriteSqlLog(string header, params string[] lines)
        {
            try
            {
                btnSqlLogs.BackColor = Color.Red;
                SetAutoBackup(false);
                if (!Directory.Exists(ClsVariables.FOLDER_LOGS))
                {
                    Directory.CreateDirectory(ClsVariables.FOLDER_LOGS);
                }
                _logFile = Path.Combine(ClsVariables.FOLDER_LOGS, $"{DateTime.Today:yyyyMMdd}.log");
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Error: " + header);
                sb.AppendLine("Detail: ");
                foreach (var line in lines)
                {
                    sb.AppendLine(line);
                }
                sb.AppendLine("DateTime: " + DateTime.Now.ToString("yyyyMMdd HHmmss"));
                sb.AppendLine("--------------------------------------------------------");
                File.AppendAllText(_logFile, sb.ToString());
                MessageBox.Show(header, "Error");
            }
            catch
            {

            }
        }
        #endregion

        #region --- 20230515 ---
        private bool CheckPressure()
        {
            try
            {
                if (!_isPlcConnected) _plc.Open();
                _plc.GetDevice2("D0", out short shortX17);
                var bytes = BitConverter.GetBytes(shortX17);
                var bits = new BitArray(bytes);
                if (bits[15])
                {
                    return true;
                }
            }
            finally
            {
                if (!_isPlcConnected) _plc.Close();
            }
            if (MessageBox.Show("Pressure not reached!", "Error",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
            {
                CheckPressure();
            }
            return false;
        }

        private void CalcValues()
        {
            try
            {
                #region --- Đọc giá trị DC voltage ---
                _fDcVolt = 0;
                if (_isPlcConnected)
                {
                    _plc.GetDevice2("D10", out short shortD10); // đọc lên giá trị từ miền nhớ
                    _fDcVolt = Convert.ToSingle(shortD10);
                }
                #endregion
                #region --- Đọc giá trị voltage ---
                _fVolt = 0;
                if (UInt32.TryParse(avd_voltage.Value, out UInt32 intVolt))
                {
                    _fVolt = intVolt.ToFloat();
                }
                #endregion
                #region --- Đọc giá trị current ---
                _fCurrent = 0;
                if (UInt32.TryParse(avd_current.Value, out UInt32 intCurrent))
                {
                    _fCurrent = intCurrent.ToFloat() * 20;
                }
                #endregion
                #region --- Đọc giá trị frequency ---
                _fFreq = 0;
                if (UInt32.TryParse(avd_frequency.Value, out UInt32 intFreq))
                {
                    _fFreq = intFreq.ToFloat();
                }
                #endregion
                #region --- Tính toán các giá trị còn lại ---
                _fDcPower = _fDcVolt * _fDcCurrent;
                _fSpeed = 60 * _fFreq / SO_CAP_CUC;
                _fDcCurrent = _fDcVolt / FIXED_RES;
                _fActualPower = (_fVolt * _fCurrent) / 1000;
                _fTorque = _fSpeed != 0 ? _fVolt * _fCurrent * 9.95f / _fSpeed : 0;
                #endregion
                #region --- Cập nhật giao diện ---
                avd_voltage.Text = $"{_fVolt:0.0}";
                avd_current.Text = $"{_fCurrent:0.00}";
                avd_electricP.Text = $"{_fActualPower:0.000}";
                avd_FWVolt.Text = $"{_fDcVolt:0.0}";

                avd_DCpower.Text = $"{_fDcPower:0}";
                avd_torque.Text = $"{_fTorque:0.00}";

                avd_rotspdmod.Text = $"{_fModSpeed:0.00}";
                avd_frequency.Text = $"{_fFreq:0.0}";
                avd_FWcurr.Text = $"{_fDcCurrent:0.0}";
                lbl_speedrpm.Text = $"{_fSpeed}";
                lbl_actualP.Text = avd_electricP.Text;
                #endregion
            }
            catch { }
        }
        #endregion
    }
}
