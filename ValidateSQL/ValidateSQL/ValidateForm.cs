using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ValidateSQL
{
    public partial class ValidateForm : Form
    {
        private LoginForm loginForm = null;
        private LoginModel model = new LoginModel();
        private SqlConnection sqlConn = null;

        public ValidateForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            loginForm.FormClosing += this.LoginForm_FormClosing;
            loginForm.ShowDialog();
            this.databaseCmb.SelectedValue = string.Empty;
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            messageTxt.Text = string.Empty;
            try
            {
                if (ValidateSQLWithExecuteReader(sqlTxt.Text))
                {
                    messageTxt.Text = "SQL语句没有语法错误！";
                }
            }
            catch (Exception ex)
            {
                messageTxt.Text = ex.Message;
            }
        }

        private bool ValidateSQLwithExecuteNonQuery(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql.Trim()))
            {
                MessageBox.Show("请在下面输入待检查的SQL语句！");
                return false;
            }
            bool bResult;
            SqlCommand cmd = this.sqlConn.CreateCommand();
            cmd.CommandText = "SET NOEXEC ON";
            cmd.ExecuteNonQuery();
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                bResult = true;
            }
            catch (Exception ex)
            {
                bResult = false;
                throw;
            }
            finally
            {
                cmd.CommandText = "SET NOEXEC OFF";
                cmd.ExecuteNonQuery();
            }
            return bResult;
        }

        private bool ValidateSQLWithExecuteReader(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql.Trim()))
            {
                MessageBox.Show("请在下面输入待检查的SQL语句！");
                return false;
            }
            bool bResult;
            SqlCommand cmd = this.sqlConn.CreateCommand();
            try
            {
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly)) { }
                bResult = true;
            }
            catch (Exception ex)
            {
                bResult = false;
                throw;
            }
            return bResult;
        }

        private void ValidateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.sqlConn != null && this.sqlConn.State != ConnectionState.Closed)
            { 
                this.sqlConn.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.model = loginForm.model;
            this.databaseCmb.Items.Add(string.Empty);
            this.databaseCmb.Items.AddRange(loginForm.list.ToArray());
            this.databaseCmb.SelectedIndex = 0;
        }

        private void databaseCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.databaseCmb.SelectedIndex <= 0)
            {
                this.validateBtn.Enabled = false;
            }
            else
            {
                this.validateBtn.Enabled = true;
            }
            string connStr = string.Empty;
            if (this.model.Authentiocation.Trim() == "Windows Authentiocation")
            {
                connStr = $"Data Source={model.ServerName};Initial Catalog={this.databaseCmb.Text.Trim()};Integrated Security=True";
            }
            else
            {
                connStr = $"Data Source ={model.ServerName}; Initial Catalog ={this.databaseCmb.Text.Trim()}; User ID={model.UserName}; Password={model.Password}";
            }
            if (this.sqlConn != null && this.sqlConn.State != ConnectionState.Closed)
            {
                this.sqlConn.Close();
            }
            sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
        }
    }
}
