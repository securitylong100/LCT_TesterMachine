using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMICS.Class;
using DevExpress.XtraEditors.Repository;

namespace AdvancedHMICS
{
    public partial class frmSettingOrder : Form
    {
        public frmSettingOrder()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmSettingOrder_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            GetCombox();
            LoadData();
        }
        void GetCombox()
        {
            string sqlmodel = "select distinct ck_model from m_ck_point order by ck_model";
            try
            {
                sqlite sqlite_ = new sqlite();
                sqlite_.getComboBoxData(sqlmodel, ref cbm_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        private void LoadData()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from m_orderid where 1=1 ");
            if (txt_orderid.Text != "")
            {
                sql.Append(" and orderid ='" + txt_orderid.Text + "'");
            }
            if (cbm_model.SelectedItem != null)
            {
                sql.Append(" and ck_model ='" + cbm_model.SelectedItem.ToString() + "'");
            }
            sqlite sqlite = new sqlite();
            sqlite.SelectData(sql.ToString(), ref dt);
            gc_main.DataSource = dt;
            GetComboxIntoGrid(cbm_model, "ck_model");

        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btn_deleteorderID_Click(object sender, EventArgs e)
        {
            dt.AcceptChanges();
            if (dt.Rows.Count == 0) return;
            if (txt_orderid.Text == "") return;
            sqlite sqlite_ = new sqlite();
            string sqldelte = "delete from m_orderid where orderid ='" + txt_orderid.Text + "'";
            sqlite_.exeNonQuery_auto(sqldelte);
            MessageBox.Show("OrderID : " + txt_orderid.Text + " deleted", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btn_createneworderID_Click(object sender, EventArgs e)
        {
            LoadData();
            try
            {
                if (checkcondition()&& checkmodelDB())
                {

                    DataRow row = dt.NewRow();
                    row["orderid"] = txt_orderid.Text;
                    row["ck_model"] = cbm_model.SelectedItem.ToString();         
                    dt.Rows.Add(row);
                }
                gc_main.DataSource = dt;
                savedb();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            LoadData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            savedb();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "output.xlsx";
                gc_main.ExportToXlsx(path);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
        void savedb()
        {
            dt.AcceptChanges();
            if (dt.Rows.Count == 0) return;
            sqlite sqlite_ = new sqlite();
            int id_current = int.Parse(sqlite_.ExecuteScalarString("select ifnull(max(id),0) as ID_current  from m_orderid"));
            foreach (DataRow rowdt in dt.Rows)
            {
                if (rowdt["ID"].ToString() == "")
                {
                    id_current = id_current + 1;
                    StringBuilder sqlinsert = new StringBuilder();
                    sqlinsert.Append(@"INSERT INTO m_orderid
                                    (ID, orderid,ck_model )
                                    VALUES("
                                    );
                    sqlinsert.Append("'" + id_current + "',");
                    sqlinsert.Append("'" + rowdt["orderid"].ToString() + "',");                 
                    sqlinsert.Append("'" + rowdt["ck_model"].ToString() + "'");
                    sqlinsert.Append(")");
                    sqlite_.exeNonQuery_auto(sqlinsert.ToString());

                }
                else
                {
                    StringBuilder sqlupdate = new StringBuilder();
                    sqlupdate.Append(@"UPDATE m_orderid set ");
                    sqlupdate.Append("orderid = '" + rowdt["orderid"].ToString() + "',");              
                    sqlupdate.Append("ck_model = '" + rowdt["ck_model"].ToString() + "'");
                    sqlupdate.Append(" where 1=1 and ID = " + rowdt["ID"].ToString() + "");
                    sqlite_.exeNonQuery_auto(sqlupdate.ToString());
                }
            }
            MessageBox.Show("Action Successful", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        bool checkcondition()
        {
            if (cbm_model.SelectedItem == null || txt_orderid.Text == "" || cbm_model.Text =="")
            {
                MessageBox.Show("Chưa chọn đầy đủ Thông Tin  ", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        bool c()
        {
            sqlite sqlite_ = new sqlite();
            string sql = "select  count(*)  from m_orderid where orderid =  '" + txt_orderid.Text + "'";
            int orderid_ = int.Parse(sqlite_.ExecuteScalarString(sql));
            if (orderid_> 0)
            {
                MessageBox.Show("Order ID  " + txt_orderid.Text + " Đã có trên hệ thống, hãy thực hiện chỉnh sữa, đừng thêm mới", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                return false;
            }
            return true;
        }
        void GetComboxIntoGrid(System.Windows.Forms.ComboBox cbm, string colHeader)
        {
            try
            {
                var arr = cbm.Items.Cast<Object>().Select(item => item.ToString()).ToArray();
                RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
                riComboBox.Items.AddRange(arr);
                gc_main.RepositoryItems.Add(riComboBox);
                gv_main.Columns[colHeader].ColumnEdit = riComboBox;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_orderid.Text = "";

        }
    }
}
