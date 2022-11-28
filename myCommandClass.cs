using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace project_Ayubo_1
{
    class myCommandClass
    {
        static SqlConnection SQLCon = new SqlConnection(@"Data Source=LAPTOP-OT3PFUD2\SQLEXPRESS;Initial Catalog=Hire2;Integrated Security=True");

        public static void MyloadDataFromDB(DataGridView _myloadTable, string _sql)
        {
            string sql = _sql;
            SqlDataAdapter da = new SqlDataAdapter(sql, SQLCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _myloadTable.DataSource = dt;
        }

        public static DataTable GetData(string _sql)
        {

            string sql = _sql;
            SqlDataAdapter da = new SqlDataAdapter(sql, SQLCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void loadFKItems(ComboBox _myBox, string _sql, string _idColumnName, string _nameColumnName)
        {

            string sql = _sql;
            SqlDataAdapter da = new SqlDataAdapter(sql, SQLCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            _myBox.DisplayMember = _nameColumnName;
            _myBox.ValueMember = _idColumnName;
            _myBox.DataSource = dt;
        }

        public static void save(string _sql)
        {

            SQLCon.Open();
            SqlCommand cmd = new SqlCommand(_sql, SQLCon);
            int count = cmd.ExecuteNonQuery();
            SQLCon.Close();

            if (count > 0)
            {
                MessageBox.Show("inserted successfully....!");
            }
            else
            {
                MessageBox.Show("contact with your It department....!");
            }
        }

        public static void update(string _sql)
        {

            SQLCon.Open();
            SqlCommand cmd = new SqlCommand(_sql, SQLCon);
            int count = cmd.ExecuteNonQuery();
            SQLCon.Close();

            if (count > 0)
            {
                MessageBox.Show("updated successfully....!");
            }
            else
            {
                MessageBox.Show("contact with your It department....!");
            }
        }

        public static void delete(string _sql)
        {

            SQLCon.Open();
            SqlCommand cmd = new SqlCommand(_sql, SQLCon);
            int count = cmd.ExecuteNonQuery();
            SQLCon.Close();

            if (count > 0)
            {
                MessageBox.Show("Deleted successfully....!");

            }
            else
            {
                MessageBox.Show("contact with your It department....!");
            }
        }
    }



}
