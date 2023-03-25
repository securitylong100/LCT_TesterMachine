using AdvancedHMICS.Class;
using System;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmLoadStatus : Form
    {
        public const string ON_BITS = "1111 1111 1111 111";
        public const string OFF_BITS = "0000 0000 0000 0000";
        public char[] RBits { get; }
        public char[] LBits { get; }

        public CheckBox[] RList { get; }
        public int RPower { get; private set; }

        public CheckBox[] LoadList { get; }
        public int LPower { get; private set; }

        public frmLoadStatus()
        {
            InitializeComponent();
            RBits = new char[16];
            LBits = new char[16];
            RList = new CheckBox[]
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LBits.Length; i++)
            {
                LBits[i] = '0';
            }
        }

        private void btnSelfTest_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RBits.Length; i++)
            {
                RBits[i] = '1';
            }
        }

        private void btnKills_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RBits.Length; i++)
            {
                RBits[i] = '0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string rBits = RBits.ToString();
                string lBits = LBits.ToString();
                sqlite sqlite_ = new sqlite();
                string sql = $@"UPDATE m_loadstatus SET r_bits='{rBits}',l_power='{LPower}' WHERE l_bits='{lBits}';
                                INSERT INTO m_loadstatus (l_bits, r_bits, l_power) SELECT '{lBits}','{rBits}','{LPower}'
                                WHERE NOT EXISTS(SELECT 1 FROM m_loadstatus WHERE l_bits='{lBits}');";
                sqlite_.exeNonQuery_auto(sql);
                MessageBox.Show($"Update load success!\nPOWER: {LPower}\nR: {rBits}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void LoadChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            LBits[cb.TabIndex] = cb.Checked ? '1' : '0';
        }

        private void RChanged(object sender, EventArgs e)
        {
            var cb = sender as AdvancedHMIControls.CheckBox;
            RBits[cb.TabIndex] = cb.Checked ? '1' : '0';
            cb.ComComponent.Write(cb.PLCAddressCheckChanged, RBits[cb.TabIndex].ToString());
        }

        public void CheckBits(string loadbits)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(loadbits))
                {
                    loadbits = OFF_BITS;
                }
                string sqlmodel = $"select r_bits from m_loadstatus where l_bits='{loadbits}' order by l_bits";
                sqlite sqlite_ = new sqlite();
                string data = sqlite_.ExecuteScalarString(sqlmodel);
                if (string.IsNullOrWhiteSpace(data))
                {
                    data = OFF_BITS;
                }
                data = data.Replace(" ", "");
                loadbits = loadbits.Replace(" ", "");
                RPower = 0;
                LPower = 0;
                for (int i = 0; i < 16; i++)
                {
                    RList[i].Checked = data.Length == 16 && data[i] == '1';
                    if (RList[i].Checked && int.TryParse(RList[i].Tag?.ToString(), out int power))
                    {
                        RPower += power;
                    }

                    LoadList[i].Checked = loadbits.Length == 16 && loadbits[i] == '1';
                    if (LoadList[i].Checked && int.TryParse(LoadList[i].Tag?.ToString(), out power))
                    {
                        LPower += power;
                    }
                }
                lblStatus.Text = $"L POWER: {LPower} W\nR POWER: {RPower} W";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
    }
}
