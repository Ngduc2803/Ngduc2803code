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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "server=DESKTOP-I2O9P5Q\\SQLEXPRESS;database=BeeCafeDatabase;uid=sa;pwd=123456";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from dbo.Drinks ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form2()
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
            tb_did.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_did.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_price.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cb_size.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cb_type.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_quantity.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void tb_add_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into dbo.Drinks values('" + tb_did.Text + "','" + tb_price.Text + "', '" + cb_size.Text + "', '" + cb_type.Text + "','" + tb_quantity.Text + "') ";
                cmd.ExecuteNonQuery();
                conn.Close();
                loaddata();
                MessageBox.Show("Add Successfully");
            }catch(Exception ex)
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
                cmd.CommandText = "delete from dbo.Drinks where DID = '" + tb_did.Text + "'";
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
                cmd.CommandText = "update dbo.Drinks set Dprice='" + tb_price.Text + "', Dsize = '" + cb_size.Text + "',Dtype = '" + cb_type.Text + "',Dquantity='" + tb_quantity.Text + "'where DID='" + id + "' ";// set DID = id of row where will update
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
                cmd.CommandText = "select * from dbo.Drinks where Dtype like @Dtype";
                cmd.Parameters.AddWithValue("Dtype", string.Format("%{0}%", txt_search.Text));
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
        
    }
}
