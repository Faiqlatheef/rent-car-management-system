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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            myCommandClass.loadFKItems(vechicleNoBox, "select * from vechicle", "vechicle_id", "vechicle_no");
            myCommandClass.loadFKItems(driverNameBox, "select * from Driver", "Driver_id", "Driver_Name");
            myCommandClass.loadFKItems(RentIDTypeBox, "select * from Rent_Type", "Rent_Type_Id", "Rent_Type_Name");
            loadDataFun();
        }

        private void loadDataFun()
        {
            myCommandClass.MyloadDataFromDB(loadData, " select Rent.rent_id, vechicle_type.vt_name , driver.driver_name , RentStartDate , RentEndDate, rent_days from Rent join driver on driver.driver_id = Rent.driver_id join vechicle_type on vechicle_type.vt_id = Rent.vt_id ");
        }

        private void loadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = loadData.Rows[myIndex].Cells[0].Value.ToString();

            DataTable myDT = myCommandClass.GetData("select * from rent where rent_id = '" + selectedIdText.Text + "'");
            vechicleNoBox.SelectedValue = myDT.Rows[0]["vechicle_id"].ToString();
            driverNameBox.SelectedValue = myDT.Rows[0]["driver_id"].ToString();
            rentStartBox.Text = myDT.Rows[0]["RentStartDate"].ToString();
            rentEndBox.Text = myDT.Rows[0]["RentEndDate"].ToString();
            rentDayBox.Text = myDT.Rows[0]["rent_Days"].ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into rent ( vt_id , driver_id , RentStartDate , RentEndDate,Rent_Type_id,rent_days ) values ( '" + vechicleNoBox.SelectedValue.ToString() + "' , '" + driverNameBox.SelectedValue.ToString() + "' , '" + rentStartBox.Text + "' , '" + rentEndBox.Text + "' , '" + RentIDTypeBox.SelectedValue.ToString() + "' , '" + rentDayBox.Text + "')");
            loadDataFun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update rent set vechicle_id ='" + vechicleNoBox.SelectedValue.ToString() + "', driver_id = '" + driverNameBox.SelectedValue.ToString() + "' , RentStartDate ='" + rentStartBox.Text + "' , RentEndDate = '" + rentEndBox.Text + "' , rent_Days = '"+ rentDayBox.Text +"'  where rent_id ='" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from rent where rent_id = '" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void selectedIdText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
