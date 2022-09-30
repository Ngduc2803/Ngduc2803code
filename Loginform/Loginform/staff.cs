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
using Microsoft.SqlServer.Server;
using System.Xml.Linq;

namespace Loginform
{
    public partial class staff : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "server=DESKTOP-I2O9P5Q\\SQLEXPRESS;database=BeeCafeDatabase;uid=sa;pwd=123456";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from dbo.Staff ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public staff()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_sid.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_sid.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_salary.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cb_dob.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_phone.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_gmail.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_name.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void tb_add_Click(object sender, EventArgs e)
        {
            try
            {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into dbo.Staff values('" + tb_sid.Text + "','" + tb_salary.Text + "', '" + cb_dob.Text + "', '" + tb_phone.Text + "','" + tb_gmail.Text + "','"+tb_name.Text+"') ";
            cmd.ExecuteNonQuery();
            conn.Close();
            loaddata();
            
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from dbo.Staff where SID = '" + tb_sid.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                loaddata();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tb_edit_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                cmd = conn.CreateCommand();
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                cmd.CommandText = "update dbo.Staff set Ssalary=@Ssalary, Sdob = @Sdob,Sphone = @Sphone ,Sgmail=@Sgmail,Sname = @Sname where SID='" + id + "' ";
                cmd.Parameters.AddWithValue("@Ssalary", tb_salary.Text);
                cmd.Parameters.AddWithValue("@Sdob", cb_dob.Value);
                cmd.Parameters.AddWithValue("@Sphone", tb_phone.Text);
                cmd.Parameters.AddWithValue("@Sgmail", tb_gmail.Text);
                cmd.Parameters.AddWithValue("@Sname", tb_name.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                loaddata();
                MessageBox.Show("Edit Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void staff_Load(object sender, EventArgs e)
        {

        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_search_Click(object sender, EventArgs e)
        { 
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from dbo.Staff where Sname like @Sname";
                cmd.Parameters.AddWithValue("Sname", string.Format("%{0}%", txt_search.Text));
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM dbo.Staff";
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[index];
                tb_sid.Text = selectedRow.Cells[0].Value.ToString();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
