using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loginform
{
    public partial class Form1 : Form
    {
        string sqlconnect = "server=DESKTOP-I2O9P5Q\\SQLEXPRESS;database=BeeCafeDatabase;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;
                con = new SqlConnection(sqlconnect);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM dbo.Administrator where Aacc='" + txtUser.Text + "' AND Apass='" + txtPass.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login sucess Welcome to Homepage");
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Menu obj = new Menu();
            obj.Show();// hien thi form 2 ra
            this.Hide();// an form hien tai
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
