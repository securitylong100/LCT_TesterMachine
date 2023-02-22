using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMICS.Class;

namespace AdvancedHMICS
{
    public partial class frmSettingModel : Form
    {
        public frmSettingModel()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmSettingModel_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            string sql = "select * from m_ck_point";
            sqlite sqlite = new sqlite();
            sqlite.SelectData(sql, ref dt);
            gc_main.DataSource = dt;
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_createnewmodel_Click(object sender, EventArgs e)
        {

        }
    }
}
