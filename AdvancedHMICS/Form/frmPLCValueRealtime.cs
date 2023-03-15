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
using DevExpress.XtraGrid.Views.Grid;

namespace AdvancedHMICS
{
    public partial class frmPLCValueRealtime : Form
    {
        public frmPLCValueRealtime()
        {
            InitializeComponent();
            //  output_ = D_;
        }
        // public int[] output_ = new int[8];
        DataTable dt;
        public ActUtlType plc_sub1 = new ActUtlType();
        private void frmPLCValueRealtime_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;        
        }
        void splitdata()
        {
            try
            {
                plc_sub1.ActLogicalStationNumber = 1;
                plc_sub1.Open();

                int[] D_input = { 0, 1, 2, 3, 4, 5, 6, 7 };
                int[] D_output = new int[8];
                foreach (int i in D_input)
                {
                    {
                        plc_sub1.GetDevice("D" + i, out D_output[i]);
                    }
                }
                //khởi tạo table header
                dt = new DataTable();
                sqlite sqlite_ = new sqlite();
                sqlite_.SelectData("select * from m_plcstatus", ref dt);
                //insert into gridcontroll
                Class.DataFuction data_ = new Class.DataFuction();
                string nvalue = "";// data_.ToBinary(output_[0]);
                for (int n = 0; n < 8; n++)
                {
                    nvalue = data_.ToBinary(D_output[n]);
                    DataRow row = dt.NewRow();
                    row["address_"] = "D" + n;
                    int[] split = new int[16];
                    for (int i = 0; i < nvalue.Length; i++)
                    {
                        row["bit_" + (nvalue.Length - 1 - i).ToString()] = int.Parse(nvalue.Substring(i, 1)) == 1 ? "ON" : "OFF";
                    }
                    dt.Rows.Add(row);
                }
                gc_main.DataSource = dt;
            }
            catch
            { }
        }
        private void frmPLCValueRealtime_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            plc_sub1.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            splitdata();
        }

       
       

        private void gv_main_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {



        }

        private void gv_main_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView currentView = sender as GridView;
            //  if (e.Column.FieldName == "bit_1")
            string a = currentView.GetRowCellValue(e.RowHandle, "bit_1").ToString();
            //if (a == "OFF")
            // e.Appearance.BackColor = Color.Red;
        }
    }
}
