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
    public class sqlite
    {
        static string connectionname = "Data Source=Data.db";

        public void SelectData(string stringQuery, ref DataTable dt)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionname);
            try
            {
                // string stringQuery = "SELECT * FROM Staffs";
                conn.Open();
                var cmd = new SQLiteCommand(stringQuery, conn);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //public void InsertData( string staffId, string fullName, int age)
        //{
        //    SQLiteConnection conn = new SQLiteConnection(connectionname);
        //    try
        //    {
        //        conn.Open();
        //        var sql = "INSERT INTO test(StaffId, FullName, Age) " +
        //        "VALUES(@staffId, @fullName, @age)";
        //        var cmd = new SQLiteCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@staffId", staffId);
        //        cmd.Parameters.AddWithValue("@fullName", fullName);
        //        cmd.Parameters.AddWithValue("@age", age);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error :" + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        public void exeNonQuery(string stringQuery)
        {
            //stringQuery = "CREATE TABLE IF NOT EXISTS Staffs(" +
            //       "StaffId VARCHAR(20) PRIMARY KEY," +
            //       "FullName VARCHAR(50)," +
            //       "Age INT DEFAULT 0" +
            //       ")";
            SQLiteConnection conn = new SQLiteConnection(connectionname);
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(stringQuery, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Query Successful", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
