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
    public partial class Rates : Form
    {
        public Rates()
        {
            InitializeComponent();
        }

        private void Rates_Load(object sender, EventArgs e)
        {
            myCommandClass.loadFKItems(vechicleTypeBox, "select * from vechicle_Type", "vt_id", "vt_Name");
            loadDataFun();
        }

        private void loadDataFun()
        {
            myCommandClass.MyloadDataFromDB(loadData, " select Rates.perday , perday * 7 as perweek , perday * 30 as permonth , vechicle_type.vt_name from  Rates join vechicle_type on Rates.vt_id = vechicle_type.vt_id ");
        }

        private void loadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = loadData.Rows[myIndex].Cells[0].Value.ToString();
            DataTable myDT = myCommandClass.GetData("select * from rates where rate_id = '" + selectedIdText.Text + "'");
            vechicleTypeBox.SelectedValue = myDT.Rows[0]["vt_Name"].ToString();
            perDayBox.Text = myDT.Rows[0]["perDay"].ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into rates (vt_id,perDay) values ('" + vechicleTypeBox.SelectedValue.ToString() + "', '" + perDayBox.Text + "')");
            loadDataFun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update Rates set vechicle_id ='" + vechicleTypeBox.SelectedValue.ToString() + "' , perday ='" + perDayBox.Text + "' , vt_Name = '" + vechicleTypeBox.SelectedValue.ToString() + "' where rate_id ='" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete(" delete from rates where rate_id = '" + selectedIdText.Text + "'");
            loadDataFun();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
