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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            myLoadDtaFromDB();
        }

        private void myLoadDtaFromDB()
        {
            myCommandClass.MyloadDataFromDB(loadData, "select * from driver");
        }

        private void loadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myRowNumber = e.RowIndex;
            selectedIdText.Text = loadData.Rows[myRowNumber].Cells[0].Value.ToString();
            driverNameBox.Text = loadData.Rows[myRowNumber].Cells[1].Value.ToString();
            driverTelenoBox.Text = loadData.Rows[myRowNumber].Cells[2].Value.ToString();
            driverAddressBox.Text = loadData.Rows[myRowNumber].Cells[3].Value.ToString();
            dreiverLicenceNoBox.Text = loadData.Rows[myRowNumber].Cells[4].Value.ToString();
            driverRentBox.Text = loadData.Rows[myRowNumber].Cells[5].Value.ToString();
            driverOverNightChargeBox.Text = loadData.Rows[myRowNumber].Cells[7].Value.ToString();
            driverWaitingChargeBox.Text= loadData.Rows[myRowNumber].Cells[6].Value.ToString();
        }

        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into driver (driver_Name,driver_address,driver_teleno,driver_licence_no,driver_rate,driver_overNightRate,driver_waitingCharge) values ('" + driverNameBox.Text + "' , '" + driverAddressBox.Text + "' , '" + driverTelenoBox.Text + "' , '" + dreiverLicenceNoBox.Text + "' , '" + driverRentBox.Text + "','" + driverOverNightChargeBox.Text + "', '" + driverWaitingChargeBox.Text + "')");
            myLoadDtaFromDB();
        }

       

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update driver set driver_Name ='" + driverNameBox.Text + "' , driver_teleno = '" + driverTelenoBox.Text + "' , driver_Address = '" + driverAddressBox.Text + "' , driver_Licence_No = '" + dreiverLicenceNoBox.Text + "' , driver_Rate = '" + driverRentBox.Text + "', driver_overNightRate ='" + driverOverNightChargeBox.Text + "',driver_waitingCharge ='" + driverWaitingChargeBox.Text + "'  where Driver_id = '" + selectedIdText.Text + "'");
            myLoadDtaFromDB();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from driver where driver_id = '" + selectedIdText.Text + "'");
            myLoadDtaFromDB();
        }

        private void loadData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}


