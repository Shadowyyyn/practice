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
    public partial class sign_up : Form
    {
        DataBase database = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text;
            var password = txtPassword.Text;

            string querystring = $"insert into register(login_user, password_user, is_admin) values ('{login}', '{password}', 0)";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in form_log_in = new log_in();
                this.Hide();
                form_log_in.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            database.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = txtLogin.Text;
            var passwordUser = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
