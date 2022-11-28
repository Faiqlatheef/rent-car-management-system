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
    public partial class Hire_Other_Charge : Form
    {
        public Hire_Other_Charge()
        {
            InitializeComponent();
        }

        private void Hire_Other_Charge_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
        }

        private void loadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(LoadData, "  select * from  Hire_OtherCharge ");
        }


    }
}
