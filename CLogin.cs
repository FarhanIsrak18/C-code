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

namespace WindowsFormsCLogin
{
    public partial class CLogin : Form
    {
       private display dp;

        public CLogin()
        {
            InitializeComponent();
        }

        public CLogin(display dp)
        {
            InitializeComponent();
            this.dp= dp;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "select * from Information where ID='" + this.txtId.Text + "' and Password ='" + this.txtPassword.Text + "';";
                SqlConnection sqlCon = new SqlConnection("Data Source=desktop-mtjufcm;Initial Catalog=vspringdb;Persist Security Info=True;User ID=sa;Password=sqllogin");
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCom);
                DataSet ds = new DataSet();
                
                sqlAdapter.Fill(ds);

                Main_display ad = new Main_display();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                   /* this.Visible = false;
                    ad.Visible = true;*/

                    if (ds.Tables[0].Rows[0][2].ToString().Equals("admin"))
                    {
                        this.Visible = false;
                        ad.Visible = true;
                    }
                    else
                    {
                        StuffDisplay sd = new StuffDisplay();
                        this.Visible = false;
                        sd.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
                sqlCon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("error" + exc.Message);

            }

        /*    int index = 0;
           bool flag = false;
           while(index < ds.Tables[0].Rows.Count)
           {
               if (this.txtId.Text.ToLower().Equals(ds.Tables[0].Rows[index][1].ToString()) 
                   && this.txtPassword.Text.ToLower().Equals(ds.Tables[0].Rows[index][2].ToString()))
               {
                   MessageBox.Show("Login Successful");
                   flag = true;
                   index++;
               }
              if(!flag)
               {
                   MessageBox.Show("Login Failed!!! ");
               }
               // this.txtId.Text = ds.Tables[0].Rows[0][1].ToString();
           }*/
            
        }
            
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.dp.Visible = true;
        }

        //display dp = new display();

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dp.Visible = true;
        //        // this.Visible = false;
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show("Exception is"+exc.Message);
        //    }
        //}

      
    }
}
