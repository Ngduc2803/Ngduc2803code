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
    public partial class Menu : Form

    {
        
        public Menu()
        {
            InitializeComponent();
        }
        

        private void drinksManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formdrinks = new Form2();
            formdrinks.Show();
            
        }

        private void staffManagemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff formstaff = new staff();
            formstaff.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User formuser = new User();
            formuser.Show();
        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_logout_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure to log out beecafe?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
