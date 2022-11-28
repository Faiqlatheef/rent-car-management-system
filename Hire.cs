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
    public partial class Hire : Form
     {
        public Hire()
        {
            InitializeComponent();
        }

        private void Hire_Load(object sender, EventArgs e)
        {
            myCommandClass.loadFKItems(vechicleTypeBox, "select * from vechicle_type", "vt_id", "vt_Name");
           myCommandClass.loadFKItems(driverNameBox, "select * from Driver", "Driver_id", "Driver_Name");
           myCommandClass.loadFKItems(hpNameBox, "select * from Hire_Package", "hp_id", "hp_name");
           myCommandClass.loadFKItems(HOCNameBox, " select * from Hire_OtherCharge ", "HOC_id", "HOC_Name");
           myCommandClass.loadFKItems(TourTypeBox, " select * from Tour_Type ", "Tour_Type_id", "Tour_Type_Name");
           loadDataFun();
        }

        private void loadDataFun()
        {

            myCommandClass.MyloadDataFromDB(loadData, "  select hire.hire_id  , vechicle.vt_id ,Tour_Type.Tour_Type_Name , Hire_Package.HP_id ,Hire_OtherCharge.HOC_id,driver.driver_Name, hire.Hire_NoOfDays,hire.Hire_StartDate,hire.Hire_EndDate from Tour_Type join hire on Tour_Type.Tour_Type_id = hire.Tour_Type_id join Hire_Package on Hire_Package.HP_id = hire.HP_id join Hire_OtherCharge on hire.HOC_id = Hire_OtherCharge.HOC_id join driver on driver.driver_id = hire.Driver_id join vechicle on vechicle.vechicle_id = hire.vehicle_id");


        }

        private void loadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = loadData.Rows[myIndex].Cells[0].Value.ToString();

            DataTable myDT = myCommandClass.GetData("select * from hire where hire_id = '" + selectedIdText.Text + "'");

            hpNameBox.SelectedValue = myDT.Rows[0]["hp_id"].ToString();
            vechicleTypeBox.SelectedValue = myDT.Rows[0]["vechicle_id"].ToString();
            driverNameBox.SelectedValue = myDT.Rows[0]["driver_id"].ToString();
            hireStartBox.Text = myDT.Rows[0]["hireStartDate"].ToString();
            hireEndBox.Text = myDT.Rows[0]["hireEndDate"].ToString();
            noOfDaysBox.Text = myDT.Rows[0]["no_of_days"].ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save("  insert into hire ( hp_id  , vehicle_id ,Tour_Type_id, HOC_id, driver_id , Hire_StartDate , Hire_EndDate ,Hire_NoOfDays  ) values ( '" + hpNameBox.SelectedValue.ToString() + "' , '" + vechicleTypeBox.SelectedValue.ToString() + "' , '" + TourTypeBox.SelectedValue.ToString() + "' , '" + HOCNameBox.SelectedValue.ToString() + "' , '" + driverNameBox.SelectedValue.ToString() + "' , '" + hireStartBox.Text + "' , '" + hireEndBox.Text + "' , '" + noOfDaysBox.Text + "' ) ");
            loadDataFun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
           myCommandClass.update (" update hire set hp_id ='" + hpNameBox.SelectedValue.ToString() + "', vechicle_id ='" + vechicleTypeBox.SelectedValue.ToString() + "' , driver_id = '" + driverNameBox.SelectedValue.ToString() + "' , hireStartDate = '" + hireStartBox.Text + "' , hireEndDate = '" + hireEndBox.Text + "' , no_of_days = '"+ noOfDaysBox.Text +"'   where hire_id ='" + selectedIdText.Text + "'");
           loadDataFun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete(" delete from hire where hire_id = '" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void loadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixBtn_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void selectedIdText_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
