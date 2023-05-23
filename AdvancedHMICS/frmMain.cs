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
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmMain : Form
    {
        #region --- Fields ---
        /// <summary>
        /// Số bước kiểm tra
        /// </summary>
        private const int STEPS = 5;
        /// <summary>
        /// Số lần NG trước khi xác nhận kết quả
        /// </summary>
        private const int MAX_NG = 3;
        /// <summary>
        /// Thời gian đợi trước 
        /// </summary>
        private const int TIME_OUT = 30;
        /// <summary>
        /// Số cặp cực
        /// </summary>
        private const int SO_CAP_CUC = 1;
        /// <summary>
        /// Điện trở dùng để tính dòng DC
        /// </summary>
        private const float FIXED_RES = 0.3f; //dơn vị là ôm.

        private int _intTimeOut = 0;
        private int _intCounter = 0;
        /// <summary>
        /// ck_LoadTime
        /// </summary>
        private int _intLoadTime = 0;
        private int _intCurrStep = 0;
        private int _intMaxNG = MAX_NG;
        private int _intMaxSteps = STEPS;

        private bool _isRun = false;
        private bool _isAuto = false;
        //private bool _isAdjusted = false;
        private bool _isPlcConnected = false;

        private string _logFile;

        private DataRow _drStepData;
        private DataTable _dtModel = new DataTable();
        private DataTable _dtRelays = new DataTable();
        private readonly DataTable _dtResult = new DataTable();

        private readonly frmLoadStatus _frmLoad = new frmLoadStatus();
        //private readonly frmLoadStatusTest _frmLoad = new frmLoadStatusTest();

        // Khai báo kết nối PLC
        private readonly ActUtlType _plc = new ActUtlType();

        private float _fFreq = 0;
        /// <summary>
        /// ck_Max_frequency
        /// </summary>
        private float _fUperFreq = 0;
        /// <summary>
        /// ck_Min_frequency
        /// </summary>
        private float _fLowerFreq = 0;

        private float _fVolt = 0;
        /// <summary>
        /// ck_Max_VolGenerator
        /// </summary>
        private float _fUperVolt = 0;
        /// <summary>
        /// ck_Min_VolGenerator
        /// </summary>
        private float _fLowerVolt = 0;

        private float _fCurrent = 0;
        /// <summary>
        /// ck_Max_Generator
        /// </summary>
        private float _fUperCurrent = 0;
        /// <summary>
        /// ck_Min_Generator
        /// </summary>
        private float _fLowerCurrent = 0;

        /// <summary>
        /// Công suất thực tế
        /// </summary>
        private float _fActualPower = 0;

        private float _fSpeed = 0;
        private float _fMaxSpeed = 0;
        private float _fMinSpeed = 0;
        /// <summary>
        /// ck_Max_Noloadlimitspeed
        /// </summary>
        private float _fUperSpeed = 0;
        /// <summary>
        /// ck_Min_Noloadlimitspeed
        /// </summary>
        private float _fLowerSpeed = 0;
        private float _fNoLoadSpeed = 0;
        private float _fModSpeed = 0;
        /// <summary>
        /// ck_Max_fluctuationspeed
        /// </summary>
        private float _fUperModlSpeed = 0;
        /// <summary>
        /// ck_Min_fluctuationspeed
        /// </summary>
        private float _fLowerModSpeed = 0;

        private float _fAdjust = 0;
        private float _fPidStop = 0;
        private float _fCkLoad = 0;
        private float _fLoadPower = 0;
        private float _fRatedPower = 0;
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
                MessageBox.Show($"Get list models fail.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
        #endregion
        #region --- BẢNG ĐIỀU KHIỂN ---
        private void btn_user_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            frmData frmData = new frmData();
            frmData.Show();
        }

        private void btn_plcstatus_Click(object sender, EventArgs e)
        {
            frmPLCValueRealtime frmPlc = new frmPLCValueRealtime();
            frmPlc.ShowDialog();
        }

        private void btn_querysqlite_Click(object sender, EventArgs e)
        {
            frmQuerySQLite frmSqlLite = new frmQuerySQLite();
            frmSqlLite.ShowDialog();
        }

        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel frmModels = new frmSettingModel();
            frmModels.ShowDialog();
        }

        private void btn_settingorder_Click(object sender, EventArgs e)
        {
            frmSettingOrder frmOrders = new frmSettingOrder();
            frmOrders.ShowDialog();
        }

        private void btn_loadStatus_Click(object sender, EventArgs e)
        {
            _frmLoad.Show();
        }
        #endregion
        #region --- DỮ LIỆU GRID ---
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
        #region --- GIÁ TRỊ ĐO ---
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

        private void UpdateValues()
        {
            float fTorque_ = 0;
            float fDcPower_ = 0;
            float fDcCurrent_ = 0;
            float fDcVolt_ = 0;
            #region --- 1. Đọc giá trị voltage ---
            try
            {
                _fVolt = 0;
                MyUnion u = new MyUnion();
                MyUnion w = new MyUnion();
                u.int32Value = (UInt32)int.Parse(avd_voltage.Value);
                w.byte1 = u.byte3;
                w.byte2 = u.byte4;
                w.byte3 = u.byte1;
                w.byte4 = u.byte2;
                _fVolt = (u.int32Value) == 0 ? 0 : w.floatValue;
                //if (UInt32.TryParse(avd_voltage.Value, out UInt32 intVolt))
                //{
                //    _fVolt = intVolt.ToFloat();
                //}
            }
            catch { }
            #endregion
            #region --- 2. Đọc giá trị current / actual power ---
            try
            {
                _fCurrent = 0;
                MyUnion u = new MyUnion();
                MyUnion w = new MyUnion();
                u.int32Value = (UInt32)int.Parse(avd_current.Value);
                w.byte1 = u.byte3;
                w.byte2 = u.byte4;
                w.byte3 = u.byte1;
                w.byte4 = u.byte2;
                _fCurrent = (u.int32Value) == 0 ? 0 : w.floatValue * 20;
                //command fixing
                //avd_current.Text = (u.int32Value) == 0 ? "0" : (w.floatValue * 22.464618).ToString();
                //if (UInt32.TryParse(avd_current.Value, out UInt32 intCurrent))
                //{
                //    _fCurrent = intCurrent.ToFloat() * 20;
                //}
            }
            catch { }
            _fActualPower = (_fVolt * _fCurrent) / 1000;
            #endregion
            #region --- 3. Đọc giá trị frequency / speed / torque ---
            try
            {
                _fFreq = 0;
                MyUnion u = new MyUnion();
                MyUnion w = new MyUnion();
                u.int32Value = (UInt32)int.Parse(avd_frequency.Value);
                w.byte1 = u.byte3;
                w.byte2 = u.byte4;
                w.byte3 = u.byte1;
                w.byte4 = u.byte2;
                _fFreq = (u.int32Value) == 0 ? 0 : w.floatValue;
                //if (UInt32.TryParse(avd_frequency.Value, out UInt32 intFreq))
                //{
                //    _fFreq = intFreq.ToFloat();
                //}
            }
            catch { }
            _fSpeed = SO_CAP_CUC == 0 ? 0 : 60 * _fFreq / SO_CAP_CUC;
            fTorque_ = _fSpeed == 0 ? 0 : _fVolt * _fCurrent * 9.95f / _fSpeed;
            #endregion
            #region --- 4. Đọc giá trị DC voltage / current / power ---
            try
            {
                if (_isPlcConnected)
                {
                    _plc.GetDevice2("D10", out short shortD10); // đọc lên giá trị từ miền nhớ
                    MyUnion u = new MyUnion();
                    MyUnion w = new MyUnion();
                    u.int32Value = (UInt32)shortD10;
                    w.byte1 = u.byte3;
                    w.byte2 = u.byte4;
                    w.byte3 = u.byte1;
                    w.byte4 = u.byte2;
                    fDcVolt_ = (u.int32Value) == 0 ? 0 : w.floatValue;
                    //fDcVolt_ = Convert.ToSingle(shortD10);
                }
            }
            catch { }
            fDcCurrent_ = FIXED_RES == 0 ? 0 : fDcVolt_ / FIXED_RES;
            fDcPower_ = fDcVolt_ * fDcCurrent_;
            #endregion
            #region --- 5. Tính tỉ lệ PID stop ---
            try
            {
                _fPidStop = _fRatedPower == _fActualPower
                    ? 100 : (_fRatedPower == 0 ? 0 : (_fActualPower / _fRatedPower) * 100);
            }
            catch { }
            #endregion
            #region --- 6. Tính tỉ lệ adjusting ---
            try
            {
                if (!float.TryParse(lbl_targetP.Text, out float targetPower))
                {
                    targetPower = 0;
                }
                _fAdjust = targetPower == 0 ? 0 : (_fActualPower / targetPower) * 100;
            }
            catch { }
            #endregion
            #region --- 7. Cập nhật giao diện ---
            avd_voltage.Text = $"{_fVolt:0.0}";
            avd_current.Text = $"{_fCurrent:0.00}";
            avd_electricP.Text = $"{_fActualPower:0.000}";
            lbl_actualP.Text = avd_electricP.Text;

            avd_frequency.Text = $"{_fFreq:0.0}";
            avd_torque.Text = $"{fTorque_:0.00}";
            lbl_speedrpm.Text = $"{_fSpeed}";

            avd_FWVolt.Text = $"{fDcVolt_:0.0}";
            avd_FWcurr.Text = $"{fDcCurrent_:0.0}";
            avd_DCpower.Text = $"{fDcPower_:0}";

            //lbl_adj_value.Text = _isRun ? $"{_fAdjust:0.##}" : $"{_fPidStop:0.##}";
            //lbl_adj.BackColor = _isRun && _isAdjusted ? Color.Green : Color.LightGray;
            //lbl_adj.Text = _isRun ? (_isAdjusted ? "Adjusted" : "Adjusting") : "PID Stop";
            #endregion
        }

        /// <summary>
        /// Kiểm tra áp suất (bit 15 của D0)
        /// </summary>
        /// <returns></returns>
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
                if (MessageBox.Show("Pressure not reached!", "Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    return CheckPressure();
                }
                return false;
            }
            finally
            {
                if (!_isPlcConnected) _plc.Close();
            }
        }

        private void avd_voltage_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void avd_current_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void avd_frequency_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
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
            string sqlmodel = $"select * from m_ck_point where ck_model = '{cbm_model.Text}' order by ck_model";
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
                MessageBox.Show($"Get max steps fail.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            _dtModel = dt;

            // Get max steps
            try
            {
                _intMaxSteps = STEPS;
                string sql = $"select max(ck_serial) as ck_serial from m_ck_point where ck_model = '{cbm_model.Text}'";
                sqlite sqlite_ = new sqlite();
                string strMaxStep = sqlite_.ExecuteScalarString(sql);
                if (int.TryParse(strMaxStep, out int maxStep))
                {
                    _intMaxSteps = maxStep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get max steps fail.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _plc.Close();
            _frmLoad.Dispose();
        }
        #endregion
        #region --- CHẾ ĐỘ TEST ---
        private void CheckValues()
        {
            try
            {
                // Nếu reset bộ đếm thì tính lại min speed / max speed
                if (_intCounter == _intLoadTime)
                {
                    _fMinSpeed = _fSpeed;
                    _fMaxSpeed = _fSpeed;
                }
                double minPower = _fRatedPower * 0.99;
                double maxPower = _fRatedPower * 1.01;
                double ngPower = _fRatedPower * 1.2;
                // Điều kiện kiểm tra (nếu không đạt điều kiện thì sẽ đợi)
                if (_intCurrStep > 0
                    && _fSpeed >= _fLowerSpeed
                    && _fSpeed <= _fUperSpeed
                    && _fModSpeed >= _fLowerModSpeed
                    && _fModSpeed <= _fUperModlSpeed
                    && _fVolt >= _fLowerVolt
                    && _fVolt <= _fUperVolt
                    && _fCurrent >= _fLowerCurrent
                    && _fCurrent <= _fUperCurrent
                    && _fFreq >= _fLowerFreq
                    && _fFreq <= _fUperFreq
                    && _fActualPower >= minPower
                    && _fActualPower <= maxPower)
                {
                    _intCounter--;
                    // Với các step > 1 thì tính mod speed
                    if (_intCurrStep > 1)
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
                        _fModSpeed = _fNoLoadSpeed == 0 ? 0 : _fModSpeed / _fNoLoadSpeed * 100;
                    }
                    //_isAdjusted = true;
                    lbl_adj.Text = "Adjusted";
                    lbl_adj.BackColor = Color.Green;
                    lbl_adj_value.Text = $"{_fAdjust:0.##}";
                    if (_intCounter < 1)
                    {
                        ChangeRunState(false, _intCurrStep, RunResults.OK);
                        _intCounter = _intLoadTime;
                        return;
                    }
                }
                else
                {
                    //_isAdjusted = false;
                    lbl_adj.Text = "Adjusting";
                    lbl_adj.BackColor = Color.White;
                    lbl_adj_value.Text = $"{_fAdjust:0.##}";
                    _intCounter = _intLoadTime;
                    string rbits = string.Empty;
                    if (_fActualPower < minPower)
                    {
                        for (int r = 0; r < _dtRelays.Rows.Count; r++)
                        {
                            if (float.TryParse(_dtRelays.Rows[r]["l_power"]?.ToString(), out float fPower)
                                && fPower != _fCkLoad && fPower > _fLoadPower)
                            {
                                _fLoadPower = fPower;
                                rbits = _dtRelays.Rows[r]["r_bits"]?.ToString();
                                break;
                            }
                        }
                    }
                    else if (_fActualPower > maxPower)
                    {
                        for (int r = _dtRelays.Rows.Count - 1; r > -1; r--)
                        {
                            if (float.TryParse(_dtRelays.Rows[r]["l_power"]?.ToString(), out float fPower)
                                    && fPower != _fCkLoad && fPower > _fLoadPower)
                            {
                                _fLoadPower = fPower;
                                rbits = _dtRelays.Rows[r]["r_bits"]?.ToString();
                                break;
                            }
                        }
                        if (_fActualPower > ngPower)
                        {
                            ChangeRunState(false, _intCurrStep, RunResults.NG);
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(rbits))
                    {
                        _frmLoad.CheckBits(rbits);
                    }
                    else
                    {
                        // Đếm 30s trước khi xác định lại số lần test
                        _intTimeOut--;
                        if (_intTimeOut < 1)
                        {
                            _intMaxNG--;
                        }
                        if (_intMaxNG < 0)
                        {
                            ChangeRunState(false, _intCurrStep, RunResults.NG);
                        }
                    }
                }
            }
            catch { }
            finally
            {
                lbl_steadyT.Text = _intCounter.ToString();
                avd_rotspdmod.Text = $"{_fModSpeed:0.00}";
            }
        }

        private void GetCheckValues()
        {
            if (int.TryParse(_drStepData["ck_LoadTime"]?.ToString(), out int loadTime))
            {
                _intLoadTime = loadTime;
            }
            _intCounter = _intLoadTime;
            #region --- SPEED LIMIT ---
            if (float.TryParse(_drStepData["ck_Min_Noloadlimitspeed"]?.ToString(), out float minRPM))
            {
                _fLowerSpeed = minRPM;
            }
            if (float.TryParse(_drStepData["ck_Max_Noloadlimitspeed"]?.ToString(), out float maxRPM))
            {
                _fUperSpeed = maxRPM;
            }
            #endregion
            #region --- VOLTAGE LIMIT ---
            if (float.TryParse(_drStepData["ck_Min_VolGenerator"]?.ToString(), out float minVolt))
            {
                _fLowerVolt = minVolt;
            }
            if (float.TryParse(_drStepData["ck_Max_VolGenerator"]?.ToString(), out float maxVolt))
            {
                _fUperVolt = maxVolt;
            }
            #endregion
            #region --- CURRENT LIMIT ---
            if (float.TryParse(_drStepData["ck_Min_Generator"]?.ToString(), out float minCurr))
            {
                _fLowerCurrent = minCurr;
            }
            if (float.TryParse(_drStepData["ck_Max_Generator"]?.ToString(), out float maxCurr))
            {
                _fUperCurrent = maxCurr;
            }
            #endregion
            #region --- FREQUENCY LIMIT ---
            if (float.TryParse(_drStepData["ck_Min_frequency"]?.ToString(), out float minFreq))
            {
                _fLowerFreq = minFreq;
            }
            if (float.TryParse(_drStepData["ck_Max_frequency"]?.ToString(), out float maxFreq))
            {
                _fUperFreq = maxFreq;
            }
            #endregion
            #region --- SPEED MOD LIMIT ---
            if (float.TryParse(_drStepData["ck_Min_fluctuationspeed"]?.ToString(), out float minFluc))
            {
                _fLowerModSpeed = minFluc;
            }
            if (float.TryParse(_drStepData["ck_Max_fluctuationspeed"]?.ToString(), out float maxFluc))
            {
                _fUperModlSpeed = maxFluc;
            }
            #endregion
        }

        private DataRow GetMasterStep(int step)
        {
            try
            {
                return _dtModel.AsEnumerable()
                               .FirstOrDefault(dr => !dr.IsNull("ck_serial")
                                                   && dr["ck_serial"].ToString() == step.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get master fail.\nStep: {step}.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return null;
            }
        }

        private DataTable GetRelays(string ckload)
        {
            try
            {
                string sqlmodel = $"select l_power,ck_load,r_bits from m_loadstatus where ck_load='{ckload}' order by l_power";
                DataTable dt = new DataTable();
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData(sqlmodel, ref dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get relays fail.\nLoad: {ckload}.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return null;
            }
        }

        private void ChangeRunState(bool isRun, int step = 0, RunResults result = RunResults.Cancel)
        {
            try
            {
                _isRun = isRun;
                if (_isRun)
                {
                    _fMaxSpeed = 0;
                    _fMinSpeed = 0;
                    _intLoadTime = 0;
                    _fLowerSpeed = 0;
                    _fUperSpeed = 9999;
                    _fLowerVolt = 0;
                    _fUperVolt = 360;
                    _fLowerCurrent = 0;
                    _fUperCurrent = 10;
                    _fLowerFreq = 0;
                    _fUperFreq = 240;
                    _fLowerModSpeed = 0;
                    _fUperModlSpeed = 9999;
                    _fLoadPower = 0;

                    _intMaxNG = MAX_NG;
                    _intCurrStep = step;
                    _intTimeOut = TIME_OUT;
                    //_isAdjusted = false;

                    if (Checkinput() == false || CheckPressure() == false) return;
                    // Tải thông số kiểm tra của step
                    _drStepData = GetMasterStep(step);
                    if (_drStepData != null)
                    {
                        #region --- Đọc giá trị rated power ---
                        try
                        {
                            _fRatedPower = 0;
                            if (_drStepData != null && !_drStepData.IsNull("ck_Steppower")
                                && float.TryParse(_drStepData["ck_Steppower"]?.ToString(), out float reatedPower))
                            {
                                _fRatedPower = reatedPower;
                            }
                        }
                        catch { }
                        #endregion
                        if (float.TryParse(_drStepData["ck_load"]?.ToString(), out float fckLoad))
                        {
                            _fCkLoad = fckLoad;
                            _fLoadPower = fckLoad;
                        }
                        _dtRelays = GetRelays(_fCkLoad.ToString());
                        if (_dtRelays != null)
                        {
                            GetCheckValues();
                            // Chạy bộ tải mặc định
                            foreach (DataRow dataRow in _dtRelays.Rows)
                            {
                                if (_fCkLoad.ToString() == dataRow["l_power"]?.ToString())
                                {
                                    string rbits = dataRow["r_bits"]?.ToString();
                                    _frmLoad.CheckBits(rbits);
                                }
                            }
                        }
                    }
                }
                else
                {
                    _frmLoad.CheckBits("0000000000000000");
                    if (result != RunResults.Cancel)
                    {
                        // Step đầu tiên thì set tốc độ không tải
                        if (_intCurrStep == 1)
                        {
                            _fNoLoadSpeed = _fSpeed;
                        }
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
                            dr["ck_result"] = result == RunResults.OK ? "合格" : "";
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
                            dr["ck_pid_stop"] = _fPidStop.ToString();
                            _dtResult.Rows.Add(dr);
                            _drStepData = null;
                        }
                        // Chuyển sang step kế khi chạy auto
                        if (result == RunResults.OK && _isAuto && _intCurrStep < _intMaxSteps)
                        {
                            _intCurrStep++;
                            _isRun = _intCurrStep <= _intMaxSteps;
                        }
                        // Kết thúc kiểm tra
                        if (!_isRun)
                        {
                            _isAuto = false;
                            _intCurrStep = 0;
                            timerLoad.Enabled = false;
                            if (MessageBox.Show($"Test complete!\nResult: {result}\nDo you want record data?",
                                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                btn_record_Click(this, null);
                            }
                        }
                        else
                        {
                            ChangeRunState(_isRun, _intCurrStep);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Reset loads fail.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            finally
            {
                avd_voltage.ValueLimitUpper = _fUperVolt;
                avd_voltage.ValueLimitLower = _fLowerVolt;
                avd_current.ValueLimitUpper = _fUperCurrent;
                avd_current.ValueLimitLower = _fLowerCurrent;
                avd_frequency.ValueLimitUpper = _fUperFreq;
                avd_frequency.ValueLimitLower = _fLowerFreq;
                avd_rotspdmod.ValueLimitUpper = _fUperModlSpeed;
                avd_rotspdmod.ValueLimitLower = _fLowerModSpeed;

                timerLoad.Enabled = _isRun;
                btn_start.Enabled = !_isRun;
                lbl_adj_value.Text = "0.00";
                lbl_rated_P.Text = _isRun ? $"{_fRatedPower}" : "0";
                lbl_steadyT.Text = _isRun ? _intLoadTime.ToString() : "0";
                lbl_pcStep.Text = _isRun ? _intCurrStep.ToString() : "1 - 5";
                lbl_status_automanual.Text = _isAuto ? "AutoLoad" : "Manual";
                lbl_status_automanual.BackColor = _isRun ? Color.Green : Color.White;
                //lbl_adj_value.Text = _isRun ? $"{_fAdjust:0.##}" : $"{_fPidStop:0.##}";
                //lbl_adj.BackColor = _isRun && _isAdjusted ? Color.Green : Color.LightGray;
                //lbl_adj.Text = _isRun ? (_isAdjusted ? "Adjusted" : "Adjusting") : "PID Stop";
                lbl_adj.Text = "PID Stop";
                lbl_adj.BackColor = Color.LightGray;
                lbl_adj_value.Text = $"{_fPidStop:0.##}";

                btn_autoload.BackColor = _isRun && _isAuto ? Color.Green : Color.Red;
                btn_0.BackColor = _isRun && _intCurrStep == 1 ? Color.Green : Color.LightGray;
                btn_25.BackColor = _isRun && _intCurrStep == 2 ? Color.Green : Color.LightGray;
                btn_50.BackColor = _isRun && _intCurrStep == 3 ? Color.Green : Color.LightGray;
                btn_75.BackColor = _isRun && _intCurrStep == 4 ? Color.Green : Color.LightGray;
                btn_90.BackColor = _isRun && _intCurrStep == 6 ? Color.Green : Color.LightGray;
                btn_100.BackColor = _isRun && _intCurrStep == 5 ? Color.Green : Color.LightGray;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                _dtResult.Rows.Clear();
                if (Checkinput() == false || CheckPressure() == false) return;
                if (_isPlcConnected)
                {
                    _isPlcConnected = false;
                    _plc.Close();
                    return;
                }
                _isPlcConnected = true;
                _plc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PLC start fail.\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                _isPlcConnected = false;
            }
            finally
            {
                btn_clear.Enabled = _isPlcConnected;
                btn_record.Enabled = _isPlcConnected;
                btn_export.Enabled = _isPlcConnected;
                cbm_model.Enabled = !_isPlcConnected;
                cbm_orderid.Enabled = !_isPlcConnected;
                txt_barcode.ReadOnly = _isPlcConnected;
                btn_autoload.Enabled = _isPlcConnected;
                btn_plcstatus.Enabled = _isPlcConnected;
                btn_deleterow.Enabled = _isPlcConnected;
                btn_loadStatus.Enabled = _isPlcConnected;
                btn_start.Text = _isPlcConnected ? "Running" : "Start/Run";
                btn_start.BackColor = _isPlcConnected ? Color.Green : Color.Red;
                btn_autoload.BackColor = _isPlcConnected ? Color.Red : Color.LightGray;
                btn_plcstatus.BackColor = _isPlcConnected ? Color.Green : Color.LightGray;
                btn_loadStatus.BackColor = _isPlcConnected ? Color.Green : Color.LightGray;
            }
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Tag?.ToString(), out int step))
            {
                if (_isAuto)
                {
                    MessageBox.Show("Processing in automatic mode.", "Information",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    if (_isRun)
                    {
                        // Nếu step đang chạy thì hủy test
                        if (step == _intCurrStep) ChangeRunState(false);
                        return;
                    }
                    // Nếu chưa chạy thì bắt đầu chạy
                    ChangeRunState(true, step);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Start manual-test fail.\nStep: {step}\n{ex.Message}", "Error",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
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
                        ChangeRunState(false);
                    }
                    return;
                }
                _isAuto = true;
                _dtResult.Rows.Clear();
                ChangeRunState(true, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Start auto-test fail.\nStep: {_intCurrStep}\n{ex.Message}", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            CheckValues();
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

        private enum RunResults
        {
            Cancel = 0,
            OK = 1,
            NG = 2
        }

        [StructLayout(LayoutKind.Explicit)]
        struct MyUnion
        {
            [FieldOffset(0)] public byte byte1;
            [FieldOffset(1)] public byte byte2;
            [FieldOffset(2)] public byte byte3;
            [FieldOffset(3)] public byte byte4;
            [FieldOffset(0)] public UInt32 int32Value;
            [FieldOffset(0)] public float floatValue;
        }
    }
}
