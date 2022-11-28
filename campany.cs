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
    public partial class campany : Form
    {
        public campany()
        {
            InitializeComponent();
        }

        private void campany_Load(object sender, EventArgs e)
        {
            myloadDataFromDB();
        }

        private void myloadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(loadData, "select * from campany");
        }

        private void loadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myRowNumber = e.RowIndex;
            selectedIdText.Text = loadData.Rows[myRowNumber].Cells[0].Value.ToString();
            employeeNameBox.Text = loadData.Rows[myRowNumber].Cells[1].Value.ToString();
            employeeAddressBox.Text = loadData.Rows[myRowNumber].Cells[2].Value.ToString();
            employeeTeleNoBox.Text = loadData.Rows[myRowNumber].Cells[3].Value.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into campany (employee_Name,employee_address,employee_teleno) values ('" + employeeNameBox.Text + "' , '" + employeeAddressBox.Text + "' , '" + employeeTeleNoBox.Text + "')");
            myloadDataFromDB();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update campany set employee_Name ='" + employeeNameBox.Text + "' , employee_Address = '" + employeeAddressBox.Text + "' , employee_teleno = '" + employeeTeleNoBox.Text + "' where campany_id = '" + selectedIdText.Text + "'");
            myloadDataFromDB();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from campany where campany_id = '" + selectedIdText.Text + "'");
            myloadDataFromDB();
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

        private void loadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
