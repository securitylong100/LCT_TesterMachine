using AdvancedHMICS.Class;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmLoadStatus : Form
    {
        private string _data = "0000000000000000";
        public string Data
        {
            get => _data;
            set
            {
                _data = value;
                lblStatus.Text = $"Buff: 0\nRec: {_data}";
                for (int i = 0; i < _data.Length; i++)
                {
                    LoadSelf[i].Checked = _data[i] == '1';
                }
            }
        }

        public CheckBox[] LoadList { get; }
        public CheckBox[] LoadSelf { get; }

        private DataTable _dtLoads;

        public frmLoadStatus()
        {
            InitializeComponent();
            LoadList = new CheckBox[]
            {
                // 0        // 1        // 2        // 3
                cbLoad1,    cbLoad2,    cbLoad3,    cbLoad4,
                // 4        // 5        // 6        // 7
                cbLoad5,    cbLoad6,    cbLoad7,    cbLoad8,
                // 8        // 9        // 10       // 11
                cbLoad9,    cbLoad10,   cbLoad11,   cbLoad12,
                // 12       // 13       // 14       // 15
                cbLoad13,   cbLoad14,   cbLoad15,   cbLoad16,
            };
            LoadSelf = new CheckBox[]
            {
                // 0    // 1    // 2    // 3
                cbR1,   cbR2,   cbR3,   cbR4,
                // 4    // 5    // 6    // 7
                cbR5,   cbR6,   cbR7,   cbR8,
                // 8    // 9    // 10   // 11
                cbR9,   cbR10,  cbR11,  cbR12,
                // 12   // 13   // 14   // 15
                cbR13,  cbR14,  cbR15,  cbR16,
            };
            _dtLoads = GetMasterLoads();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Data = "0000000000000000";
        }

        private void btnSelfTest_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Data = "1111111111111111";
        }

        private void btnKills_Click(object sender, EventArgs e)
        {
            Data = "0000000000000000";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _data = string.Join("", LoadSelf.Select(x => x.Checked ? "1" : "0"));
                string loadcd = LoadList.FirstOrDefault(x => x.Checked).Tag?.ToString();
                sqlite sqlite_ = new sqlite();
                string sql = $"UPDATE m_loads SET load_bits='{Data}' WHERE load_cd='{loadcd}'";
                sqlite_.exeNonQuery_auto(sql);
                MessageBox.Show($"Update load success!\nCode: {loadcd}\nValue: {_data}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            _dtLoads = GetMasterLoads();
        }

        private void LoadChanged(object sender, EventArgs e)
        {
            foreach (var load in LoadList)
            {
                if (load != sender)
                {
                    load.Checked = false;
                }
            }
            var drLoad = _dtLoads.AsEnumerable().FirstOrDefault(r => (sender as CheckBox).Tag?.ToString() == r["load_cd"]?.ToString());
            Data = drLoad["load_bits"]?.ToString();
        }

        private void RChanged(object sender, EventArgs e)
        {
        }

        private DataTable GetMasterLoads()
        {
            DataTable dt = new DataTable();
            string sqlmodel = "select * from m_loads order by load_cd";
            sqlite sqlite_ = new sqlite();
            sqlite_.SelectData(sqlmodel, ref dt);
            return dt;
        }

        public void SetLoad(string loadCd)
        {
            foreach (var item in LoadList)
            {
                item.Checked = loadCd == item.Tag?.ToString();
            }
        }
    }
}
