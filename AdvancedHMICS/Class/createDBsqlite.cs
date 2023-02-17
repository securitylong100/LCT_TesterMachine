using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;


namespace AdvancedHMICS.Class
{
    public class createDBsqlite
    {
        public void CreateDB(string dbFileName)
        {
            //chỉ khởi tạo 1 lân
            string connectionname = "Data Source=" + dbFileName + ".db";
            SQLiteConnection.CreateFile(connectionname);
            MessageBox.Show(connectionname+" Create Successful", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
