using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using AdvancedHMICS.Class;

namespace AdvancedHMICS
{
    public partial class frmPLCValueRealtime : Form
    {
        public frmPLCValueRealtime(int[] D_)
        {
            InitializeComponent();
            output_ = D_;
        }
        public int[] output_ = new int[8];
        DataTable dt;

        private void frmPLCValueRealtime_Load(object sender, EventArgs e)
        {
            splitdata();
        }

        void splitdata()
        {
            try
            {
                //khởi tạo table header
                dt = new DataTable();
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData("select * from m_plcstatus", ref dt);
                //insert into gridcontroll
                Class.DataFuction data_ = new Class.DataFuction();
                string nvalue = "";// data_.ToBinary(output_[0]);
                for (int n = 0; n < 8; n++)
                {
                    nvalue = data_.ToBinary(output_[n]);
                    DataRow row = dt.NewRow();
                    row["address_"] = "D" + n;
                    int[] split = new int[16];
                    for (int i = 0; i < nvalue.Length; i++)
                    {
                        row["bit_" + (nvalue.Length - 1 - i).ToString()] = int.Parse(nvalue.Substring(i, 1));
                    }
                    dt.Rows.Add(row);
                }
                gc_main.DataSource = dt;
            }
            catch
            { }
        }
    }
}
