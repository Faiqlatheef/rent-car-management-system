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

namespace project_Ayubo_1
{
    public partial class vechicleType : Form
    {
        public vechicleType()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save("insert into vechicle_type(vt_name) values ('" + vtNameBox.Text + "')");
            loadDataFromDB();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update("update vechicle_type set vt_name ='" + vtNameBox.Text + "' where vt_id = '" + selectedIdText.Text + "'");
            loadDataFromDB();
        }

        private void vechicleType_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
        }

        private void loadDataFromDB()
        {

            string sql = "select vt_id as id ,vt_name as name from vechicle_type ";

            myCommandClass.MyloadDataFromDB(myLoadTable, sql);
            

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from vechicle_type where vt_id = '" + selectedIdText.Text + "'");
            loadDataFromDB();
        }

        private void myLoadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myRowNumber = e.RowIndex;
            selectedIdText.Text = myLoadTable.Rows[myRowNumber].Cells[0].Value.ToString();
            vtNameBox.Text = myLoadTable.Rows[myRowNumber].Cells[1].Value.ToString();
        }

        private void openVechiclesBtn_Click(object sender, EventArgs e)
        {
            new vechicle().Show();
        }

        private void customerDetailsBtn_Click(object sender, EventArgs e)
        {
            new customer().Show();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            new Driver().Show();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            new Rent().Show();

        }

        private void RatesBtn_Click(object sender, EventArgs e)
        {
            new Rates().Show();
        }

        private void campanyBtn_Click(object sender, EventArgs e)
        {
            new campany().Show();
        }

        private void HireBtn_Click(object sender, EventArgs e)
        {
            new Hire().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HirePacakges().Show();
        }

        private void rentPaymentBox_Click(object sender, EventArgs e)
        {
            new RentPayment().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HirePayment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vtNameBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
