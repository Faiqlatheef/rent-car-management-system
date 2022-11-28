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
    public partial class RentPayment : Form
    {
        public RentPayment()
        {
            InitializeComponent();
        }

        private void RentPayment_Load(object sender, EventArgs e)
        {
           myCommandClass.loadFKItems(customerNameBox, " select * from customer ", "customer_id", "customer_name");
           myCommandClass.loadFKItems(RentTypeBox, " select * from Rent_Type ", "Rent_Type_id ", "Rent_Type_Name");
           myCommandClass.loadFKItems(RentIdBox, "select * from Rent" , "Rent_id", "Rent_id");
            loadDataFun();
        }

        private void loadDataFun()
        {
            myCommandClass.MyloadDataFromDB(LoadDate, "  select Rent_payment.rp_id, customer.customer_name,  Rent_payment.rpDrivercharge, Rent.Rent_id, Rent_payment.rp_date, Rent_payment.rpBasecharge, Rent_payment.rp_Type , rpBasecharge + rpDrivercharge as  rp_Total_Charge from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id join Rent on Rent_payment.Rent_id = Rent.Rent_id; ");
        }

        private void LoadDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = LoadDate.Rows[myIndex].Cells[0].Value.ToString();

            DataTable myDT = myCommandClass.GetData("select * from rent_payment where rp_id = '" + selectedIdText.Text + "'");
            RentIdBox.SelectedValue = myDT.Rows[0]["Rent_id"].ToString();
            RPDriverChargeBox.Text = myDT.Rows[0]["rpDrivercharge"].ToString();
            rentPaymentDateBox.Text = myDT.Rows[0]["rp_date"].ToString();
            rpBasicChargeBox.Text = myDT.Rows[0]["rpBasecharge"].ToString();
            customerNameBox.SelectedValue = myDT.Rows[0]["customer_id"].ToString();
            RentTypeBox.SelectedValue = myDT.Rows[0]["rp_type"].ToString();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save("  insert into Rent_payment ( rpDrivercharge, customer_id ,Rent_id , rp_date, rpBasecharge, rp_Type ) values ('" + RPDriverChargeBox.Text + "' , '" + customerNameBox.SelectedValue.ToString() + "' , '" + RentIdBox.SelectedValue.ToString() + "' , '" + rentPaymentDateBox.Text + "' , '" + rpBasicChargeBox.Text + "' ,  '" + rpTypeBox.Text + "')");
            loadDataFun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update rent_payment set customer_id ='" + customerNameBox.SelectedValue.ToString() + "', rpBasecharge = '" + rpBasicChargeBox.Text + "' , rpDrivercharge ='" + RPDriverChargeBox + "' , rp_date = '" + rentPaymentDateBox.Text + "' , rent_id = '" + RentIdBox.SelectedValue.ToString() + "'  where rp_id ='" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("  delete from rent_payment where rp_id = '" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clossBtn_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void selectedIdText_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //double HPayment_StRead = 0;
            //if ( st_Reading != "")
            //{
            //   HPayment_StRead = Convert.ToDouble();
            //}

        }

        private void rentChargeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}


//int month =0, week = 0, day = 0;

//if (days >= 30)
//{
//     month = days / 30;
//     tempDay = thempDay - (month * 30);
//}

//if (days >= 7) 
//{
//    Week = days / 7;
//    tempDay = tempDay - (week * 7);

//}

//day = tempDay;

//double baseCharge = (month * perMonth) + (week * perweek) + (day * perDay);

//---------------------------------------------

//double HPayment_StRead = 0;
//if ( st_Reading != "")
//{
//    HPayment_StRead = Convert.ToDouble(StartReadingBox.Text);
//}

