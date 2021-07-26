using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCLogin
{
    public partial class display : Form
    {
        //CLogin cl = new CLogin(this);

        AdminRegister ar = new AdminRegister();
        
        public display()
        {
            InitializeComponent();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            
            ar.Visible = true;
            //this.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CLogin cl = new CLogin(this);
            cl.Visible = true;
           // this.Visible = false;
        }
    





        //button coloring
        private void btnAdminRegister_MouseHover(object sender, EventArgs e)
        {
            this.btnAdminRegister.BackColor = Color.CadetBlue;
        }

        private void btnAdminRegister_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdminRegister.BackColor = SystemColors.Control;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit!", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }
}
