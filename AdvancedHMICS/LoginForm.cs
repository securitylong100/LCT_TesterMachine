using AdvancedHMICS.Class;
using System;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Mật Khẩu không được bỏ trống", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // string pass_encryt = Class.De_Encrypt.Encrypt(txt_pass.Text);
            // Class.mysqlconnection con = new Class.mysqlconnection();
            //string sqllogin = "select user_name from m_user where  1=1 and user_pass= '" + pass_encryt + "' and user_cd ='" + txt_user.Text + "'";
            //string username = con.sqlExecuteScalarString(sqllogin);
            sqlite sqlite_ = new sqlite();
            string sql = "select  User  from m_user where User =  '" + txt_user.Text + "' and Pass = '" + txt_pass.Text + "'";
            string username =  sqlite_.ExecuteScalarString(sql);

            if (username.Length > 1)
            {
                ClsVariables.User = username;
                frmMain f = new frmMain();
                f.ShowDialog();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AcceptButton = btn_login;
        }
    }
}
