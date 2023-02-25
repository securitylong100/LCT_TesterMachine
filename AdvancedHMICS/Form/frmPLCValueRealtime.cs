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
        public frmPLCValueRealtime()
        {
            InitializeComponent();
        }
        public int[] output_ = new int[8];
        DataTable dt;
        public frmPLCValueRealtime(int[] D_)
        {
            output_ = D_;
          
        }
        private void frmPLCValueRealtime_Load(object sender, EventArgs e)
        {
            splitdata();
        }
        void selectdata()
        {
            sqlite sqlite_ = new sqlite();
            sqlite_.SelectData("select * from m_plcstatus", ref dt);
        }
        void splitdata()
        {
            dt = new DataTable();
            Class.DataFuction data_ = new Class.DataFuction();
            string a = data_.ToBinary(output_[0]);
            selectdata();
            DataRow row = dt.NewRow();
            row["address_"] = "D0";
            row["bit_01"] = 1;
            row["bit_02"] = 1;
            row["bit_03"] = 1;
            row["bit_04"] = 1;
            row["bit_05"] = 1;
            row["bit_06"] = 1;
            row["bit_07"] = 1;
            row["bit_10"] = 1;
            row["bit_11"] = 1;
            row["bit_12"] = 1;
            row["bit_13"] = 1;
            row["bit_14"] = 0;
            row["bit_15"] = 1;
            row["bit_16"] = 1;
            row["bit_17"] = 1;

            dt.Rows.Add(row);
            gc_main.DataSource = dt;
        }
    }
}
