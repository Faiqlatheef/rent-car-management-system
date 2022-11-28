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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }


        private void vechicleTypeBtn_Click(object sender, EventArgs e)
        {
            loadform(new vechicleType());

        }

        private void vechicleBtn_Click(object sender, EventArgs e)
        {
            loadform(new vechicle());
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            loadform(new customer());
        }

        private void driverBtn_Click(object sender, EventArgs e)
        {
            loadform(new Driver());
        }

        private void campanyBtn_Click(object sender, EventArgs e)
        {
            loadform(new campany());
        }

        private void ratesBtn_Click(object sender, EventArgs e)
        {
            loadform(new Rates());
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            loadform(new Rent());
        }

        private void hireBtn_Click(object sender, EventArgs e)
        {
            loadform(new Hire());
        }

        private void hirePacakagesBtn_Click(object sender, EventArgs e)
        {
            loadform(new HirePacakges());
        }

        private void rentPaymentBtn_Click(object sender, EventArgs e)
        {
            loadform(new RentPayment());
        }

        private void hirePaymentBtn_Click(object sender, EventArgs e)
        {
            loadform(new HirePayment());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //private void mixBtn_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    maxBtn.Visible = false;
        //    maxBtn.Location = maxBtn.Location;
        //    maxBtn.Visible = true;
        //}

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void maxedBtn_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    maxBtn.Visible = false;
        //    maxtn.Visible = true;
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new hireOtherCharge());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Rent_Type());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Tour_Type());
        }
    }
}
