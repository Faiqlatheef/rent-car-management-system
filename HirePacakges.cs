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
    public partial class HirePacakges : Form
    {
        public HirePacakges()
        {
            InitializeComponent();
        }

        private void HirePacakges_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
        }

        private void loadDataFromDB()
        {
            myCommandClass.MyloadDataFromDB(LoadData, "  select * from  Hire_Package ");
        }

        private void LoadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myRowNumber = e.RowIndex;
            selectedIdText.Text = LoadData.Rows[myRowNumber].Cells[0].Value.ToString();
            HPNameBox.Text = LoadData.Rows[myRowNumber].Cells[1].Value.ToString();
            HPAmountBox.Text = LoadData.Rows[myRowNumber].Cells[2].Value.ToString();
            HPMinKMBox.Text = LoadData.Rows[myRowNumber].Cells[3].Value.ToString();
            HPMixKMBox.Text = LoadData.Rows[myRowNumber].Cells[4].Value.ToString();
            HPMixHourBox.Text = LoadData.Rows[myRowNumber].Cells[5].Value.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save(" insert into hire_package ( HP_Name, HP_Amount, HP_MinKM, HP_MixKM , HP_MixHour ) values ( '" + HPNameBox.Text + "', '" + HPAmountBox.Text + "' , '" + HPMinKMBox.Text + "' , '" + HPMixKMBox.Text + "' , '" + HPMixHourBox.Text + "')");
            loadDataFromDB();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update hire_package set hp_name ='" + HPNameBox.Text + "', hp_amount = '"+ HPAmountBox.Text +"'  where hp_id = '" + selectedIdText.Text + "'");
            loadDataFromDB();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from hire_packages where hp_id = '" + selectedIdText.Text + "'");
            loadDataFromDB();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
