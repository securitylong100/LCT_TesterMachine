using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class frmLoadStatusTest : Form
    {
        //public const string ON_BITS = "1111 1111 1111 111";
        //public const string OFF_BITS = "0000 0000 0000 0000";
        public CheckBox[] RList { get; }
        public int RPower { get; private set; }
        public frmLoadStatusTest()
        {
            InitializeComponent();
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
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                RList[i].Checked = true;
            }
        }

        private void btnKills_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                RList[i].Checked = false;
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
                //string rBits = string.Join("", RBits);
                //sqlite sqlite_ = new sqlite();
                //string sql = $@"UPDATE m_loadstatus SET r_bits='{rBits}',l_power='{LPower}' WHERE l_bits='{lBits}';
                //                INSERT INTO m_loadstatus (l_bits, r_bits, l_power) SELECT '{lBits}','{rBits}','{LPower}'
                //                WHERE NOT EXISTS(SELECT 1 FROM m_loadstatus WHERE l_bits='{lBits}');";
                //sqlite_.ExeNonQuery_auto(sql);
                //MessageBox.Show($"Update load success!\nPOWER: {LPower}\nR: {rBits}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void RChanged(object sender, EventArgs e)
        {
            RPower = GetPower(RList).Sum();
            lblStatus.Text = $"POWER: {RPower} W";
        }

        public void CheckBits(string rbits)
        {
            try
            {
                rbits = rbits.Replace(" ", "");
                if (rbits.Length < 16 || string.IsNullOrWhiteSpace(rbits))
                {
                    rbits = "0000000000000000";
                }
                for (int i = 0; i < 16; i++)
                {
                    RList[i].Checked = rbits[i] == '1';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private IEnumerable<int> GetPower(params CheckBox[] cbList)
        {
            foreach (var cb in cbList)
            {
                if (cb.Checked && int.TryParse(cb.Tag?.ToString(), out int power))
                {
                    yield return power;
                }
            }
        }
    }
}
