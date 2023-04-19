using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AdvancedHMICS.Class
{
    class SqlGetClass
    {
        //public string connetionString = null;
        public SqlConnection connection;// = new SqlConnection();
        //public string conStringIpqcDbP4 = "Data Source=localhost;Initial Catalog=LCT_DB;User ID=sa;Password=12345";
        public string conStringIpqcDbP4 = "";
        public string connectstring()
        {
            try
            {
                string cn = "";
                var fileName = Path.Combine(@"C:\LCT\", "connectsql_LCT_IFM.txt");
                bool exists = File.Exists(fileName);
                if (!exists) return string.Empty;
                string[] datarow = File.ReadAllLines(fileName);
                return cn = Decrypt(datarow[0]);
            }
            catch
            {
                return string.Empty;
            }
        }
        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            conStringIpqcDbP4 = connectstring();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new SqlConnection(conStringIpqcDbP4);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                cmb.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public string sqlExecuteScalarString(string sql)
        {
            conStringIpqcDbP4 = connectstring();
            string response;
            try
            {
                connection = new SqlConnection(conStringIpqcDbP4);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                response = Convert.ToString(command.ExecuteScalar());
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL executeschalar method failed." + Environment.NewLine + ex.Message
                                , "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }
        }
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            conStringIpqcDbP4 = connectstring();
            try
            {
                SqlConnection connection = new SqlConnection(conStringIpqcDbP4);
                SqlCommand command = new SqlCommand();

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    command.CommandText = sql;
                    command.Connection = connection;
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public static bool IsServerConnected(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public string sqlExecuteScalarString_Autosystem(string sql)
        {
            conStringIpqcDbP4 = connectstring();
            string response;

            connection = new SqlConnection(conStringIpqcDbP4);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            response = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return response;
        }
        public void sqlDataAdapterFillDatatableQuery(string sql, ref DataTable dt)
        {
            conStringIpqcDbP4 = connectstring();
            try
            {
                SqlConnection connection = new SqlConnection(conStringIpqcDbP4);
                SqlCommand command = new SqlCommand();

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    command.CommandText = sql;
                    command.Connection = connection;
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    MessageBox.Show("Đã Thực Thư", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        string Decrypt(string toDecrypt)
        {
            //string key = "InitializeComponent!!!!***";
            string key = "keyofkey,notofnot";
            try
            {
                bool useHashing = true;
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                }
                else
                    keyArray = Encoding.UTF8.GetBytes(key);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                return toDecrypt = "";
                MessageBox.Show(ex.ToString(), "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        } //ok
    }
}