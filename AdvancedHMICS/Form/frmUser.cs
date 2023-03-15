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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sqlite sqlc = new sqlite();
            sqlc.SelectData("select * from m_user", ref dt);
            gc_main.DataSource = dt;
        }
    }
}
