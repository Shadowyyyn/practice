using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_DataBase.Pages
{
    public partial class log_in : Form
    {
        DataBase database = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginUser = txtLogin.Text;
            var passUser = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1(user);
                this.Hide();
                form1.ShowDialog();
            }
            else MessageBox.Show("Такого аккаунта не существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            sign_up form_sign_up = new sign_up();
            form_sign_up.Show();
            this.Hide();
        }
    }
}
