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
    public partial class Rent_Type : Form
    {
        public Rent_Type()
        {
            InitializeComponent();
        }

        private void Rent_Type_Load(object sender, EventArgs e)
        {
            myLoadDataFromDB();
        }

        private void myLoadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(LoadData," select * from Rent_Type");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save( " insert into Rent_Type ( Rent_Type_Name ) values ( '" + RentTypeBox.Text + "')");
            myLoadDataFromDB();


        }

    }
}
