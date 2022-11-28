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
    public partial class vechicle : Form
    {
        public vechicle()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.save("insert into vechicle ( vechicle_no , vt_id) values ('" + VechicleNoBox.Text + "','" + vechicleTypeBox.SelectedValue.ToString() + "')");
            loadDataFun();
            
        }

        private void vechicle_Load(object sender, EventArgs e)
        {
            myCommandClass.loadFKItems(vechicleTypeBox, "select * from vechicle_type", "vt_id", "vt_Name");
            loadDataFun();
        }

        private void loadDataFun()
        {
            myCommandClass.MyloadDataFromDB(loadTable, "select vechicle. vechicle_id as ID ,vechicle_no as Number,vechicle_type.vt_name from vechicle join vechicle_type on vechicle.vt_id = vechicle_type.vt_id");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            selectedIdText.Text = loadTable.Rows[myIndex].Cells[0].Value.ToString();
            DataTable myDT = myCommandClass.GetData ("select * from vechicle where vechicle_id = '" + selectedIdText.Text + "'");
            VechicleNoBox.Text = myDT.Rows[0]["vechicle_no"].ToString();
            vechicleTypeBox.SelectedValue = myDT.Rows[0]["vt_id"].ToString();
        }

        private void upDateBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.update(" update vechicle set vechicle_no ='" + VechicleNoBox.Text + "', vt_id ='" + vechicleTypeBox.SelectedValue.ToString() + "' where vechicle_id ='" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            myCommandClass.delete("delete from vechicle where vechicle_id = '" + selectedIdText.Text + "'");
            loadDataFun();
        }

        private void loadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void vechicleTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
