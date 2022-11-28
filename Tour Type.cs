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
    public partial class Tour_Type : Form
    {
        public Tour_Type()
        {
            InitializeComponent();
        }

        private void Tour_Type_Load(object sender, EventArgs e)
        {
            myLoadDataFromDB();
        }

        private void myLoadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(LoadData, " select * from Tour_Type ");
        }
    }
}
