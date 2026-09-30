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
    public partial class Add_Form : Form
    {
        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var type = txtProductType.Text;
            var count = txtQuantity.Text;
            var postav = txtSupplier.Text;
            int price;

            if(int.TryParse(txtPrice.Text, out price))
            {
                var addQuery = $"insert into test_db (type_of, count_of, postavka, price) values ('{type}', '{count}', '{postav}', '{price}')'";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }
    }
}
