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

namespace test_DataBase
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        private readonly checkUser _user;

        DataBase database = new DataBase();

        int selectedRow;

        public Form1(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void IsAdmin()
        {

        }

        private void CreateColumns()
        {
            dvgRecords.Columns.Add("id", "id");
            dvgRecords.Columns.Add("type_of", "Тип товара");
            dvgRecords.Columns.Add("count_of", "Количество");
            dvgRecords.Columns.Add("postavka", "Поставщик");
            dvgRecords.Columns.Add("price", "Цена");
            dvgRecords.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from test_db";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dvgRecords);
        }

        private void dvgRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgRecords.Rows[selectedRow];

                txtID.Text = row.Cells[0].Value.ToString();
                txtProductType.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                txtSupplier.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from test_db where concat (id, type_of, count_of, postavka, price) lile '%" + txtSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = dvgRecords.CurrentCell.RowIndex;

            dvgRecords.Rows[index].Visible = false;

            if (dvgRecords.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dvgRecords.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
        }

        private new void Update()
        {
            database.openConnection();

            for(int index = 0; index < dvgRecords.Rows.Count; index++)
            {
                var rowState = (RowState)dvgRecords.Rows[index].Cells[5].Value;

                if(rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dvgRecords.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test_db where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dvgRecords.Rows[index].Cells[0].Value.ToString();
                    var type = dvgRecords.Rows[index].Cells[1].Value.ToString();
                    var count = dvgRecords.Rows[index].Cells[2].Value.ToString();
                    var postav = dvgRecords.Rows[index].Cells[3].Value.ToString();
                    var price = dvgRecords.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update test_db set type_of = '{type}', count_of = '{count}', postavka = '{postav}', price = '{price}; where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dvgRecords.CurrentCell.RowIndex;

            var id = txtID.Text;
            var type = txtProductType.Text;
            var count = txtQuantity.Text;
            var postav = txtSupplier.Text;
            int price;

            if (dvgRecords.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(txtPrice.Text, out price))
                {
                    dvgRecords.Rows[selectedRowIndex].SetValues(id, type, count, postav, price);
                    dvgRecords.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void ClearFields()
        {
            txtID.Text = "";
            txtProductType.Text = "";
            txtQuantity.Text = "";
            txtSupplier.Text = "";
            txtPrice.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search(dvgRecords);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dvgRecords);
            ClearFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Pages.Add_Form addform = new Pages.Add_Form();
            addform.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }
    }
}
