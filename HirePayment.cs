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
    public partial class HirePayment : Form
    {
        public HirePayment()
        {
            InitializeComponent();
        }
        private void HirePayment_Load(object sender, EventArgs e)
        {
           myCommandClass.loadFKItems(DriverNameBox, " select * from driver ", "driver_id", "driver_Name");
           myCommandClass.loadFKItems(CustomerNameBox, " select * from customer ", "customer_id", "customer_Name");
           myCommandClass.loadFKItems(HireIDBox, "select * from Hire", "Hire_id", "Hire_id");
           loadDataFun();
        }

        private void loadDataFun()
        {
            myCommandClass.MyloadDataFromDB(LoadData, " select Hire_Payment.HPayment_id, hire.hire_id , Hire_Payment.HPayment_base_charge , HPayment_Date, customer.Customer_Name , driver.driver_Name , Hire_Payment.HPayment_StRead , HPayment_EnRead , HPayment_EnRead - HPayment_StRead as HPayment_NoOfReading , HPayment_OtherCharge , HPayment_Type ,  HPayment_base_charge + HPayment_OtherCharge as  HPayment_Total from Hire_Payment join Hire on Hire.Hire_id = Hire_Payment.Hire_id join customer on Hire_Payment.Customer_id = Customer.Customer_id join Driver on Hire_Payment.Driver_id = Driver.Driver_id ");
        }

        private void LoadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = LoadData.Rows[myIndex].Cells[0].Value.ToString();

            DataTable myDT =myCommandClass.GetData("select * from hire_payment where HPayment_id = '" + selectedIdText.Text + "'");

            HireIDBox.SelectedValue = myDT.Rows[0]["Hire_id"].ToString();
            hirePaymentBasicCharge.Text = myDT.Rows[0]["HPayment_base_charge"].ToString();
            HirePaymentDateBox.Text = myDT.Rows[0]["HPayment_Date"].ToString();
            CustomerNameBox.SelectedValue = myDT.Rows[0]["Customer_id"].ToString();
            DriverNameBox.SelectedValue = myDT.Rows[0]["driver_id"].ToString();
            StartReadingBox.Text = myDT.Rows[0]["HPayment_StRead"].ToString();
            EndReadingBox.Text = myDT.Rows[0]["HPayment_EnRead"].ToString();
            extraKMBox.Text= myDT.Rows[0]["HPayment_NoOfReading"].ToString();
            //NoOfDaysBox.Text = myDT.Rows[0]["HPayment_NoOfDays"].ToString();
            hireOtherChargeBox.Text = myDT.Rows[0]["HPayment_OtherCharge"].ToString();
            PaymentTypeBox.Text = myDT.Rows[0]["HPayment_Type"].ToString();

            string HPayment_StRead = StartReadingBox.Text;
            string Hpayment_EnRead = endTimeBox.Text;

            string start_hour = tourTypeBox.Text;
            string End_hour = endTimeBox.Text;


            //double HPayment_StRead = 0;
            //if (StartReadingBox.Text != "")
            //{
            //    HPayment_StRead = Convert.ToDouble(StartReadingBox.Text);

            //}

            //double HPayment_EnReading = 0;
            //if (EndReadingBox.Text != "")
            //{
            //    HPayment_EnReading = Convert.ToDouble(EndReadingBox.Text);

            //}

            //double total = HPayment_StRead - HPayment_StRead;
            //NoOfKMBox.Text = (total).ToString();

            //double stTime = 0;
            //if( startTimeBox.Text != "" )
            //{
            //    stTime = Convert.ToDouble(startTimeBox.Text);
            //}
            
            //double entime = 0;
            //if (endTimeBox.Text != "")
            //{
            //    entime = Convert.ToDouble(endTimeBox.Text);
            //}

            //double totalHour = entime - stTime;
            //noOfHourBox.Text = (totalHour).ToString();



               if (Tour_Type != "long Tour")
            {
                tourTypeBox.Enabled = true;
                endTimeBox.Enabled = true;
                noOfHourBox.Enabled = true;

               if (totalHour > MixHour)
               {
                   double waitingCharge = Convert.ToDouble(waitingCharge_perHour * (totalHour - max_Hours));
                   hireOtherChargeBox.Text = ((extra_KM_Charge * extra_KM) + waitingCharge).ToString();

                   if (days >= 2)
                   {
                       double overNightCharge = (days - 1) * overNight;
                       double nightParking_Charge = (days - 1) * night_Parking;
                       hireOtherChargeBox.Text = "charge per Extra KM : '" + extraKM_Charge + "'\n over Night Charge : '" + overNight;
                   }
                   else
                   {
                       extraKMBox.Text = "charge per ExtraKM :'" + extra_KM_Charge + "' \n waithing charge per hour : '";
 
                   }

                }
            }
               ------------------------------------


            baseBox.text = basic_charge.Tostring();
            tourTypeBox.Text = Tour;
            daysBox.text = days.ToString();

            if (total > maxKM)
            {
                double extra_KM = total - maxKM;
                hireOtherChargeBox.Text = (extraKM_Charge * extra_KM).ToString();

                if (days >= 2)
                {
                    double overNightCharge = (days - 1) * overNight;
                    double nightParking_Charge = (days - 1) * night_Parking;
                    hireOtherChargeBox.Text = ((extraKM_Charge * extra_KM) + overNightCharge + nightParking_Charge).ToString();
                    extraKMBox.Text = "charge per Extra KM : '" + extraKM_Charge + "' \n over Night Charge : '" + overNightCharge
 
                }
                else
                {
                    extraKMBox.Text = "charge per Extra KM : '" + extraKM_Charge + "'";

                }

            }



            baseBox.text = basic_charge.Tostring();
            tourTypeBox.Text = Tour;
            daysBox.text = days.ToString();

            if (total > maxKM)
            {
                double extra_KM = total - maxKM;
                hireOtherChargeBox.Text = (extraKM_Charge * extra_KM).ToString();

                if (days >= 2)
                {
                    double overNightCharge = (days - 1) * overNight;
                    double nightParking_Charge = (days - 1) * night_Parking;
                    hireOtherChargeBox.Text = ((extraKM_Charge * extra_KM) + overNightCharge + nightParking_Charge).ToString();
                    extraKMBox.Text = "charge per Extra KM : '" + extraKM_Charge + "' \n over Night Charge : '" + overNightCharge
 
                }
                else
                {
                    extraKMBox.Text = "charge per Extra KM : '" + extraKM_Charge + "'";

                }

            }














               if (Tour_Type != "long Tour")
               {
                   tourTypeBox.Enabled = true;
                   endTimeBox.Enabled = true;
                   noOfHourBox.Enabled = true;

                   if (totalHour > MixHour)
                   {
                       double waitingCharge = Convert.ToDouble(waitingCharge_perHour * (totalHour - max_Hours));
                       hireOtherChargeBox.Text = ((extra_KM_Charge * extra_KM) + waitingCharge).ToString();

                       if (days >= 2)
                       {
                           double overNightCharge = (days - 1) * overNight;
                           double nightParking_Charge = (days - 1) * night_Parking;
                           hireOtherChargeBox.Text = "charge per Extra KM : '" + extraKM_Charge + "'\n over Night Charge : '" + overNight;
                       }
                       else
                       {
                           extraKMBox.Text = "charge per ExtraKM :'" + extra_KM_Charge + "' \n waithing charge per hour : '";

                       }

                   }
               }



        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save("insert into hire_payment (hire_id, HPayment_base_charge , HPayment_Date ,  Customer_id, Driver_id, HPayment_StRead, HPayment_EnRead ,HPayment_NoOfReading , HPayment_OtherCharge, HPayment_Type ) values ('" + HireIDBox.SelectedValue.ToString() + "', '" + hirePaymentBasicCharge.Text + "'  , '" + HirePaymentDateBox.Text + "' , '" + CustomerNameBox.SelectedValue.ToString() + "' , '" + DriverNameBox.SelectedValue.ToString() + "' , '" + StartReadingBox.Text + "' , '" + EndReadingBox.Text + "' , '" + hireOtherChargeBox.Text + "' , '" + PaymentTypeBox.Text + "' )");
            loadDataFun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update("  update hire_payment set hire_id ='" + HireIDBox.SelectedValue.ToString() + "',  HPayment_base_charge = '" + hirePaymentBasicCharge.Text + "'   , HPayment_Date ='" + HirePaymentDateBox.Text + "' , Customer_id = '" + CustomerNameBox.SelectedValue.ToString() + "' , Driver_id = '" + DriverNameBox.SelectedValue.ToString() + "' , HPayment_StRead = '" + StartReadingBox.Text + "' , HPayment_EnRead = '" + EndReadingBox.Text + "' , HPayment_OtherCharge = '" + hireOtherChargeBox.Text + "' , HPayment_Type = '" + PaymentTypeBox.Text + "'  where hire_payment_id ='" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("  delete from hire_payment where HPayment_id = '" + selectedIdText.Text + "'");
            loadDataFun();






        }

        private void hirePaymentDateBox_ValueChanged(object sender, EventArgs e)
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

        private void LoadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void extraKMBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void overNightStayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void hireIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedIdText_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
