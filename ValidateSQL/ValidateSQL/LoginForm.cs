using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ValidateSQL
{
    public partial class LoginForm : Form
    {
        private string connStr = string.Empty;
        public LoginModel model = new LoginModel();
        public List<string> list = new List<string>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            model.ServerName = this.serverNameTxt.Text.Trim();
            model.Authentiocation = this.authentiocationCmb.Text.Trim();
            model.UserName = this.userNameTxt.Text.Trim();
            model.Password = this.passwordTxt.Text.Trim();
            if (this.authentiocationCmb.Text.Trim() == "Windows Authentiocation")
            {
                this.connStr = $"Data Source={model.ServerName};Initial Catalog=;Integrated Security=True";
            }
            else
            {
                if (model.UserName == string.Empty || model.Password == string.Empty)
                {
                    MessageBox.Show("用户名及密码不能为空！");
                    return;
                }
                this.connStr = $"Data Source ={model.ServerName}; Initial Catalog =; User ID={model.UserName}; Password={model.Password}";            
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", conn))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void authentiocationCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.authentiocationCmb.Text.Trim() == "Windows Authentiocation")
            {
                this.userNameTxt.Enabled = false;
                this.passwordTxt.Enabled = false;
            }
            else
            {
                this.userNameTxt.Enabled = true;
                this.passwordTxt.Enabled = true;
            }
        }
    }

    public class LoginModel
    {
        public string ServerName { get; set; }
        public string Authentiocation { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
