using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using AdvancedHMICS.Class;

namespace AdvancedHMICS
{
    public partial class frmQuerySQLite : Form
    {
        public frmQuerySQLite()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmQuerySQLite_Load(object sender, EventArgs e)
        {

        }

        private void btn_createnewDB_Click(object sender, EventArgs e)
        {
            createDBsqlite createData = new createDBsqlite();
            createData.CreateDB("Data");
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_query.Text = "";
            dt = new DataTable();
            gc_main.DataSource = dt;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            sqlite _SQLite = new sqlite();
            _SQLite.exeNonQuery(txt_query.Text.ToString().Trim());
        }
        private void btn_SelectData_Click(object sender, EventArgs e)
        {
             dt = new DataTable();
            sqlite _SQLite = new sqlite();
            _SQLite.SelectData(txt_query.Text.ToString().Trim(), ref dt);
            gc_main.DataSource = dt;
        }
    }
}
