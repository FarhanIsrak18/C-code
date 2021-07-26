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
    public partial class ChangePassword : Form
    {
        private DataAccess Da { get; set; }

        public ChangePassword()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvUpdatePassword.AutoGenerateColumns = false;
                this.dgvUpdatePassword.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnNewPassSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string sql = @"update Information set Password='" + this.txtNewPassword + "'where ID ='" + this.txtTypeID + "';";

            //    int count = this.Da.ExecuteDML(sql);//DML=data manupulation Language.Needed for CRUD

            //    if (count == 1)
            //    {
            //        MessageBox.Show("Password Changed ");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Password Not Changed !!!");
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Exception is:"+exc.Message);
            //}

        }

       

        private void btnClearPass_Click_1(object sender, EventArgs e)
        {
            this.txtNewPassword.Clear();
            this.txtSearchName.Clear();
        }

     /*   private void panel1_DoubleClick(object sender, EventArgs e)
        {
          this.txtNewPassword.Text = this.dgvUpdatePassword.CurrentRow.Cells["Password"].Value.ToString();

        }*/

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Information where Role='stuff' and Name like '" + this.txtSearchName.Text + "%';";

            this.PopulateGridView(sql);
        }

       

        private void dgvUpdatePassword_DoubleClick(object sender, EventArgs e)
        {
            this.txtNewPassword.Text = this.dgvUpdatePassword.CurrentRow.Cells["Password"].Value.ToString();
            this.txtSearchName.Text = this.dgvUpdatePassword.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnNewPassSave_Click_1(object sender, EventArgs e)
        {
            string sql = @"update Information set Password='" + this.txtNewPassword.Text + "'where Name='" + this.txtSearchName.Text + "';";
            int count = this.Da.ExecuteDML(sql);

            if (count == 1)
            {
                MessageBox.Show("Password Updated");

            }
            else
            {
                MessageBox.Show("Sorry !!! Not Updated");
            }

        }

       

      
    }
}
