using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AdvancedHMICS.Class
{
    public class sqlite
    {
        static string connectionname = "Data Source=Data.db";
        public void getComboBoxData(string stringQuery, ref System.Windows.Forms.ComboBox cmb)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionname);          
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(stringQuery, conn);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                cmb.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
            }
        }
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

        public string ExecuteScalarString(string stringQuery)
        {
            string response;
            SQLiteConnection conn = new SQLiteConnection(connectionname);
            try
            {
               
                conn.Open();
                var cmd = new SQLiteCommand(stringQuery, conn);
                cmd.CommandType = CommandType.Text;
                response = Convert.ToString(cmd.ExecuteScalar());          
                return response;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite executeschalar method failed." + System.Environment.NewLine + ex.Message
                                , "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                return String.Empty;
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
        public void exeNonQuery_auto(string stringQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionname);
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(stringQuery, conn);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Query Successful", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
