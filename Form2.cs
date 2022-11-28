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
    public partial class hireOtherCharge : Form
    {
        public hireOtherCharge()
        {
            InitializeComponent();
        }

        private void rentEndBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hireOtherCharge_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
        }

        private void loadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(loadData, " select * from Hire_OtherCharge ");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into Hire_OtherCharge ( HOC_Name, HOC_AmountPerKM, HOC_AmountPerHour ) values ( '" + HOCNameBox.Text + "', '" + HOCAmountPerKMBox.Text + "' , '" + HOCAmountPerHourBox.Text + "')");
            loadDataFromDB();
        }


    }
}
