using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Ayubo_1
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            MyloadDataFromDB();
        }

        private void MyloadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(LoadData, "select * from customer");
        }

        private void LoadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int myRowNumber = e.RowIndex;
                selectedIdText.Text = LoadData.Rows[myRowNumber].Cells[0].Value.ToString();
                customerNameBox.Text = LoadData.Rows[myRowNumber].Cells[1].Value.ToString();
                customerAddressBox.Text = LoadData.Rows[myRowNumber].Cells[2].Value.ToString();
                customerTeleNoBox.Text = LoadData.Rows[myRowNumber].Cells[3].Value.ToString();

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into customer (customer_name,customer_address,customer_teleno) values ('" + customerNameBox.Text + "' , '" + customerAddressBox.Text + "' , '" + customerTeleNoBox.Text + "')");
            MyloadDataFromDB();
        }








        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update("update customer set customer_name ='" + customerNameBox.Text + "' , customer_Address = '" + customerAddressBox.Text + "' , customer_teleno = '" + customerTeleNoBox.Text + "' where customer_id = '" + selectedIdText.Text + "'");
            MyloadDataFromDB();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from customer where customer_id = '" + selectedIdText.Text + "'");
            MyloadDataFromDB();
        }

        private void LoadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
