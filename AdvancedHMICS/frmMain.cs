using ActUtlTypeLib;
using AdvancedHMICS.Class;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
        private const int STEPS = 5;

        /// <summary>
        /// Số lần NG tối đa cho phép
        /// </summary>
        private const int MAX_NG = 3;

        private const int TIME_OUT = 20;
        private double FIXED_RES = 100; //dơn vị là ôm.

        private float _fSpeed = 0;
        private float _fModRPM = 0;
        private float _fminRPM = 0;
        private float _fmaxRPM = 0;
        private float _fNoloadRPM = 0;
        private float _fMinLimitRPM = 0;
        private float _fMaxLimitRPM = 0;
        private float _fMaxLimitCurr = 0;
        private float _fMaxLimitVolt = 0;
        private float _fMaxLimitFreq = 0;
        private float _fMaxLimitFluc = 0;

        private int _iTimeOut = 0;
        private int _iCounter = 0;
        private int _iLoadTime = 0;
        private int _iCurrStep = 0;
        private int _iSteps = STEPS;
        private int _iMaxNG = MAX_NG;

        private bool _bIsRun = false;
        private bool _bIsAuto = false;
        private bool _bIsPlcConnected = false;

        private DataRow _drStepData;
        private DataTable _dtResult;
        private frmLoadStatus _frmLoad;

        // Khai báo kết nối PLC
        public ActUtlType _plc = new ActUtlType();

        public frmMain()
        {
            InitializeComponent();
            gv_main.OptionsBehavior.ReadOnly = true;
            gv_main.OptionsBehavior.Editable = false;
            gv_main.OptionsSelection.MultiSelect = true;
            gv_main.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gv_main.CustomDrawCell += Gv_main_CustomDrawCell;
        }

        #region --- TRẠNG THÁI ---
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
                    avd_torque.Value = Math.Round(
                        float.Parse(avd_voltage.Text)
                        * float.Parse(avd_current.Text)
                        * 9.95
                        / float.Parse(lbl_speedrpm.Text),
                        3).ToString();
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
                avd_DCpower.Text = Math.Round(
                    float.Parse(avd_FWVolt.Text)
                    * float.Parse(avd_FWcurr.Text)
                    ).ToString();
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
            {
                avd_FWcurr.Value = Math.Round(
                    double.Parse(avd_FWVolt.Value) / (FIXED_RES), 2).ToString();
            }
            catch { }
        }
      
        private void avd_voltage_ValueChanged(object sender, EventArgs e)
        {
            avd_voltage.Text = Math.Round(double.Parse(avd_voltage.Value) / 10, 2).ToString();
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
                //dùng để test
                avd_current.Text = Math.Round(double.Parse(avd_current.Value) / 100, 2).ToString();
                avd_electricP.Text = Math.Round(
                    float.Parse(avd_voltage.Text)
                    * float.Parse(avd_current.Text) / 1000,
                    2).ToString();
                lbl_actualP.Text = avd_electricP.Text;
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
                //chi dung cho test
                avd_frequency.Text = Math.Round(double.Parse(avd_frequency.Value) / 10, 2).ToString();
                lbl_speedrpm.Text = Math.Round(60 * float.Parse(avd_frequency.Text) / 6, 0).ToString();
                //read vaule
                if (_bIsPlcConnected)
                {
                    _plc.GetDevice2("D10", out short shortvalue); // đọc lên giá trị từ miền nhớ
                    avd_FWVolt.Value = (shortvalue / 100).ToString();
                }
                else
                {
                    avd_FWVolt.Value = "0";
                }
            }
            catch { }
        }

        /// <summary>
        /// Xem trạng thái thanh ghi PLC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Xem trạng thái thanh ghi tải
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_loadStatus_Click(object sender, EventArgs e)
        {
            _frmLoad.Show();
        }
        #endregion
        #region --- GIAO DIỆN ---
        /// <summary>
        /// Cập nhật danh sách models
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                DefineResultTable();
                string sqlmodel = "select distinct(ck_model) from m_ck_point order by ck_model";
                sqlite sqlite_ = new sqlite();
                sqlite_.getComboBoxData(sqlmodel, ref cbm_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

            _frmLoad = new frmLoadStatus();
        }

        /// <summary>
        /// Đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _plc.Close();
        }
        #endregion
        #region --- CẤU HÌNH ---
        private void btn_user_Click(object sender, EventArgs e)
        {
            frmUser fd = new frmUser();
            fd.ShowDialog();
        }

        /// <summary>
        /// Mở cửa sổ setting model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modelSetting_Click(object sender, EventArgs e)
        {
            frmSettingModel fr = new frmSettingModel();
            fr.ShowDialog();
        }

        /// <summary>
        /// Mở cửa sổ setting order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_settingorder_Click(object sender, EventArgs e)
        {
            frmSettingOrder f = new frmSettingOrder();
            f.ShowDialog();
        }

        /// <summary>
        /// Vẽ cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gv_main_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string result = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ck_result"]);
                e.Appearance.BackColor = result == "1" ? Color.Green : Color.Red;
                e.Appearance.ForeColor = Color.Yellow;
            }
        }
        #endregion
        #region --- CHẾ ĐỘ TEST ---
        private void btn_data_Click(object sender, EventArgs e)
        {
            frmData frmData = new frmData();
            frmData.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                _dtResult.Rows.Clear();
                if (Checkinput() == false) return;
                SetPLCStatus(!_bIsPlcConnected);
                if (_bIsPlcConnected)
                {
                    _plc.ActLogicalStationNumber = 1;
                    _plc.Open();
                    return;
                }
                SetTestStatus(false);
                _plc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            if (!_bIsAuto)
            {
                var btn = (Button)sender;
                if (int.TryParse(btn.Tag?.ToString(), out int step))
                {
                    if (_bIsRun)
                    {
                        if (step == _iCurrStep) SetTestStatus(false);
                        return;
                    }
                    StartTest(step);
                }
            }
        }

        private void btn_autoload_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bIsRun)
                {
                    if (_bIsAuto)
                    {
                        _bIsAuto = false;
                        SetTestStatus(false);
                    }
                    return;
                }
                _bIsAuto = true;
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
                if (!float.TryParse(lbl_speedrpm.Text, out float speedrpm))
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
                if (!float.TryParse(avd_current.Text, out float current))
                {
                    current = 0;
                }
                if (!float.TryParse(avd_voltage.Text, out float volt))
                {
                    volt = 0;
                }
                if (!float.TryParse(avd_frequency.Text, out float freq))
                {
                    freq = 0;
                }
                double min = reatedP * 0.9;
                double max = reatedP * 1.1;
                double pidStop = reatedP == 0 ? 0 : (actualP / reatedP) * 100;
                if (actualP == reatedP)
                {
                    pidStop = 100;
                }

                lbl_pidStop.Text = $"{pidStop:0.##}";

                _fSpeed = speedrpm;
                // Điều kiện kiểm tra (nếu không đạt điều kiện thì sẽ đợi)
                if (_fMinLimitRPM <= _fSpeed && _fMaxLimitRPM >= _fSpeed
                    && (_iCurrStep > 1 && _fModRPM < _fMaxLimitFluc)
                    && volt < _fMaxLimitVolt && current < _fMaxLimitCurr && freq < _fMaxLimitFreq)
                {
                    _iCounter--;
                    // Với các step > 1 thì tính mod speed
                    if (_iCurrStep > 1)
                    {
                        if (_fSpeed < _fminRPM)
                        {
                            _fminRPM = _fSpeed;
                            _fModRPM = Math.Abs(_fminRPM - _fNoloadRPM);
                            _fModRPM = _fModRPM / _fNoloadRPM * 100;
                            avd_rotspdmod.Value = $"{_fModRPM:0.##}";
                        }
                        if (_fSpeed > _fmaxRPM)
                        {
                            _fmaxRPM = _fSpeed;
                        }
                    }
                    if (actualP < min)
                    {
                        // Đếm 20s trước khi xác định lại số lần test
                        _iTimeOut--;
                        _iCounter = _iLoadTime;
                        if (_iTimeOut < 1)
                        {
                            _iMaxNG--;
                        }
                    }
                    if (actualP > max || _iMaxNG < 0)
                    {
                        EndTest(false);
                        return;
                    }
                    if (_iCounter < 1)
                    {
                        EndTest(true);
                    }
                }
            }
            finally
            {
                lbl_steadyT.Text = _iCounter.ToString();
            }
        }

        private void SetPLCStatus(bool isConnect)
        {
            _bIsPlcConnected = isConnect;
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
            _bIsRun = isRun;
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
                timerLoad.Enabled = true;
                lbl_pcStep.Text = _iCurrStep.ToString();
                lbl_steadyT.Text = _iLoadTime.ToString();
                lbl_status_automanual.BackColor = Color.Green;
                lbl_status_automanual.Text = _bIsAuto ? "AutoLoad" : "Manual";
                lbl_rated_P.Text = _drStepData["ck_Steppower"]?.ToString();
                return;
            }
            _frmLoad.CheckBits("0000000000000000");
            timerLoad.Enabled = false;
            btn_0.BackColor = Color.LightGray;
            btn_25.BackColor = Color.LightGray;
            btn_50.BackColor = Color.LightGray;
            btn_75.BackColor = Color.LightGray;
            btn_90.BackColor = Color.LightGray;
            btn_100.BackColor = Color.LightGray;
            btn_autoload.BackColor = Color.Red;
            lbl_status_automanual.Text = "Manual";
            lbl_status_automanual.BackColor = Color.LightGray;
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
                if (Checkinput() == false) return;
                _drStepData = GetMasterStep(step);
                if (!int.TryParse(_drStepData["ck_LoadTime"]?.ToString(), out int loadTime))
                {
                    loadTime = 0;
                }
                if (!float.TryParse(_drStepData["ck_Min_Noloadlimitspeed"]?.ToString(), out float minRPM))
                {
                    minRPM = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_Noloadlimitspeed"]?.ToString(), out float maxRPM))
                {
                    maxRPM = 0;
                }

                #region --- CURRENT LIMIT ---
                if (!float.TryParse(_drStepData["ck_Min_Generator"]?.ToString(), out float minCurr))
                {
                    minCurr = 0;
                }
                if (!float.TryParse(_drStepData["ck_Max_Generator"]?.ToString(), out float maxCurr))
                {
                    maxCurr = 9999;
                }
                avd_current.ValueLimitUpper = maxCurr;
                avd_current.ValueLimitLower = minCurr;
                _fMaxLimitCurr = maxCurr;
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
                avd_voltage.ValueLimitUpper = maxVolt;
                avd_voltage.ValueLimitLower = minVolt;
                _fMaxLimitVolt = maxVolt;
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
                avd_frequency.ValueLimitUpper = maxFreq;
                avd_frequency.ValueLimitLower = minFreq;
                _fMaxLimitFreq = maxFreq;
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
                avd_rotspdmod.ValueLimitUpper = maxFluc;
                avd_rotspdmod.ValueLimitLower = minFluc;
                _fMaxLimitFluc = maxFluc;
                #endregion

                _fSpeed = 0;
                _fmaxRPM = 0;
                _fminRPM = 0;
                _fModRPM = 0;
                _iMaxNG = MAX_NG;
                _fMinLimitRPM = minRPM;
                _fMaxLimitRPM = maxRPM;
                _iCurrStep = step;
                _iTimeOut = TIME_OUT;
                _iLoadTime = loadTime;
                _iCounter = _iLoadTime;
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
                _fNoloadRPM = _fSpeed;
            }
            SetTestStatus(false);
            // Hiển thị dữ liệu lên grid
            if (_drStepData != null)
            {
                var dr = _dtResult.NewRow();
                foreach (DataColumn col in _dtResult.Columns)
                {
                    if (_drStepData.Table.Columns.Contains(col.ColumnName))
                    {
                        dr[col.ColumnName] = _drStepData[col.ColumnName];
                    }
                    dr["ck_time"] = DateTime.Now;
                    dr["ck_barcode"] = txt_barcode.Text;
                    dr["ck_actual_power"] = lbl_actualP.Text;
                    dr["ck_pid_stop"] = lbl_pidStop.Text;
                    dr["ck_rot_speed"] = lbl_speedrpm.Text;
                    dr["ck_noload_speed"] = _fNoloadRPM;
                    dr["ck_fw_volt"] = avd_FWVolt.Text;
                    dr["ck_volt"] = avd_voltage.Text;
                    dr["ck_current"] = avd_current.Text;
                    dr["ck_result"] = isOk ? 1 : 0;
                }
                _dtResult.Rows.Add(dr);
                _drStepData = null;
            }
            // Chuyển sang step kế khi chạy auto
            if (isOk && _bIsAuto && _iCurrStep < _iSteps)
            {
                _iCurrStep++;
                StartTest(_iCurrStep);
                _bIsRun = _iCurrStep <= _iSteps;
            }
            // Kết thúc kiểm tra
            if (!_bIsRun)
            {
                _bIsAuto = false;
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
                    string sql = $"INSERT INTO m_ck_point_data ({columns}) VALUES ({values})";
                    sqlite_.exeNonQuery_auto(sql);
                }
                _dtResult.Rows.Clear();
            }
            catch (Exception ex)
            {
                timerLoad.Enabled = false;
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

        /// <summary>
        /// Truy vấn SQL lite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_querysqlite_Click(object sender, EventArgs e)
        {
            frmQuerySQLite f = new frmQuerySQLite();
            f.ShowDialog();
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

        private void DefineResultTable()
        {
            _dtResult = new DataTable();
            _dtResult.Columns.Add("ck_serial");
            _dtResult.Columns.Add("ck_Max_Noloadlimitspeed");
            _dtResult.Columns.Add("ck_Min_Noloadlimitspeed");
            _dtResult.Columns.Add("ck_Steppower");
            _dtResult.Columns.Add("ck_power");
            _dtResult.Columns.Add("ck_Steppercentage");
            _dtResult.Columns.Add("ck_Max_Generator");
            _dtResult.Columns.Add("ck_Min_Generator");
            _dtResult.Columns.Add("ck_Max_VolGenerator");
            _dtResult.Columns.Add("ck_Min_VolGenerator");
            _dtResult.Columns.Add("ck_Max_frequency");
            _dtResult.Columns.Add("ck_Min_frequency");
            _dtResult.Columns.Add("ck_Max_braketime");
            _dtResult.Columns.Add("ck_Min_braketime");
            _dtResult.Columns.Add("ck_Max_regulationspeed");
            _dtResult.Columns.Add("ck_Min_regulationSpeed");
            _dtResult.Columns.Add("ck_Max_fluctuationspeed");
            _dtResult.Columns.Add("ck_Min_fluctuationspeed");
            _dtResult.Columns.Add("ck_LoadTime");
            _dtResult.Columns.Add("ck_speed");
            _dtResult.Columns.Add("ck_cycles");
            _dtResult.Columns.Add("ck_model");
            _dtResult.Columns.Add("ck_testbrakes");
            _dtResult.Columns.Add("ck_time");
            _dtResult.Columns.Add("ck_barcode");
            _dtResult.Columns.Add("ck_actual_power");
            _dtResult.Columns.Add("ck_pid_stop");
            _dtResult.Columns.Add("ck_rot_speed");
            _dtResult.Columns.Add("ck_noload_speed");
            _dtResult.Columns.Add("ck_fw_volt");
            _dtResult.Columns.Add("ck_volt");
            _dtResult.Columns.Add("ck_current");
            _dtResult.Columns.Add("ck_result");
            gc_main.DataSource = _dtResult;

            gv_main.Columns["ck_Max_Noloadlimitspeed"].Visible = false;
            gv_main.Columns["ck_Min_Noloadlimitspeed"].Visible = false;
            gv_main.Columns["ck_Max_Generator"].Visible = false;
            gv_main.Columns["ck_Min_Generator"].Visible = false;
            gv_main.Columns["ck_Max_VolGenerator"].Visible = false;
            gv_main.Columns["ck_Min_VolGenerator"].Visible = false;
            gv_main.Columns["ck_Max_frequency"].Visible = false;
            gv_main.Columns["ck_Min_frequency"].Visible = false;
            gv_main.Columns["ck_Max_braketime"].Visible = false;
            gv_main.Columns["ck_Min_braketime"].Visible = false;
            gv_main.Columns["ck_Max_regulationspeed"].Visible = false;
            gv_main.Columns["ck_Min_regulationSpeed"].Visible = false;
            gv_main.Columns["ck_Max_fluctuationspeed"].Visible = false;
            gv_main.Columns["ck_Min_fluctuationspeed"].Visible = false;
            gv_main.Columns["ck_LoadTime"].Visible = false;
            gv_main.Columns["ck_speed"].Visible = false;
            gv_main.Columns["ck_cycles"].Visible = false;
            gv_main.Columns["ck_model"].Visible = false;
            gv_main.Columns["ck_testbrakes"].Visible = false;

            gv_main.Columns["ck_serial"].Caption = "Step";
            gv_main.Columns["ck_Steppower"].Caption = "Step Power";
            gv_main.Columns["ck_power"].Caption = "Total Power";
            gv_main.Columns["ck_Steppercentage"].Caption = "Percentage";
            gv_main.Columns["ck_Steppercentage"].DisplayFormat.FormatString = "{0:P2}";
            gv_main.Columns["ck_time"].Caption = "Time";
            gv_main.Columns["ck_barcode"].Caption = "Barcode";
            gv_main.Columns["ck_actual_power"].Caption = "Actual Power";
            gv_main.Columns["ck_pid_stop"].Caption = "PID Stop";
            gv_main.Columns["ck_rot_speed"].Caption = "ROT Speed";
            gv_main.Columns["ck_noload_speed"].Caption = "NoLoad Speed";
            gv_main.Columns["ck_fw_volt"].Caption = "FW Voltage";
            gv_main.Columns["ck_volt"].Caption = "Voltage";
            gv_main.Columns["ck_current"].Caption = "Current";
            gv_main.Columns["ck_result"].Caption = "Result";
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

        #region --- OLD ---
        // Khai báo điện trở fix
        //private int R = 500;
        //private int minrpm = 0;
        //private int maxrpm = 0;
        //private int steadyT = 4;
        //private int counter = 0;

        // Kết quả test 
        //private bool result = false;
        //private bool _isTest = false;

        /// <summary>
        /// Chạy test
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="step"></param>
        //private void Steptest(Button btn, int step)
        //{
        //    try
        //    {
        //        if (Checkinput() == false) return;
        //        // Nếu đang chạy thì ngừng lại
        //        if (_isTest)
        //        {
        //            if (_iCurrStep == step)
        //            {
        //                _isTest = false;
        //                timerLoad.Enabled = false;
        //                btn.BackColor = Color.LightGray;
        //            }
        //            return;
        //        }
        //        _isTest = true;
        //        _iCurrStep = step;
        //        btn.BackColor = Color.Green;

        //        // step = 1;
        //        counter = steadyT;
        //        _iMaxNG = 3;
        //        _iTimeOut = TIME_OUT;
        //        lbl_pcStep.Text = step.ToString();
        //        DataTable dt = new DataTable();
        //        string sqlmodel = "select * from m_ck_point where ck_model = '" + cbm_model.Text + "' order by ck_model";
        //        sqlite sqlite_ = new sqlite();
        //        sqlite_.SelectData(sqlmodel, ref dt);
        //        _drStepData = dt.AsEnumerable().FirstOrDefault(row => row["ck_serial"].ToString() == step.ToString());
        //        //timerlable
        //        steadyT = int.Parse(_drStepData["ck_LoadTime"]?.ToString());
        //        lbl_steadyT.Text = steadyT.ToString();
        //        //ratedP step
        //        lbl_rated_P.Text = _drStepData["ck_Steppower"]?.ToString();
        //        //get min max
        //        minrpm = int.Parse(_drStepData["ck_Min_Noloadlimitspeed"]?.ToString());
        //        maxrpm = int.Parse(_drStepData["ck_Max_Noloadlimitspeed"]?.ToString());

        //        btn_90.Text = $"{_drStepData["ck_Steppercentage"]}%";

        //        //condtion function.,
        //        //if (btn.BackColor == Color.LightGray)
        //        //{
        //        //    btn.BackColor = Color.Green;
        //        //    timerLoad.Enabled = true;
        //        //}
        //        //else
        //        //{
        //        //    timerLoad.Enabled = false;
        //        //    btn.BackColor = Color.LightGray;
        //        //}
        //        //if (minrpm <= int.Parse(lbl_speedrpm.Text) && float.Parse(lbl_actualP.Text) >= float.Parse(lbl_rated_P.Text) * 0.85)
        //        //{
        //        //    timerLoad.Enabled = true;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        timerLoad.Enabled = false;
        //        MessageBox.Show("Error :" + ex.Message);
        //    }
        //    finally
        //    {
        //        timerLoad.Enabled = true;
        //    }
        //}
        #endregion
    }
}
