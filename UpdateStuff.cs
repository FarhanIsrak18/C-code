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
    public partial class UpdateStuff : Form
    {
        private DataAccess Da { get; set; }

        public UpdateStuff()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.PopulateGridView();
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvInformation.AutoGenerateColumns = false;
                this.dgvInformation.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }



        private void PopulateGridView()//Without parameter 
        {
            string sql = "select * from Information where Role = 'STUFF';";
            this.PopulateGridView(sql);
            
        }
         
       private void btnStuffDetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from Information where Role = 'STUFF';";
            this.PopulateGridView(sql);
        }
        
       private void btnAddStuff_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(this.txtStuffName.Text) || string.IsNullOrEmpty(this.txtStuffId.Text) ||
                     string.IsNullOrEmpty(this.cmbStuffRole.Text) || string.IsNullOrEmpty(this.dtpStuffDoB.Text) ||
                 string.IsNullOrEmpty(this.txtStuffMobileNo.Text) || string.IsNullOrEmpty(this.txtStuffPassword.Text) ||
                     string.IsNullOrEmpty(this.cmbStuffGender.Text))//Checks if all the texts are fill or not.IF not it will return.
                {
                    MessageBox.Show("Ooops!!! Insert ALL Values  .");
                    return;

                }

 string sql = @"insert into Information values 
   ('" + this.txtStuffName.Text + "','" + this.txtStuffId.Text + "','" + this.cmbStuffRole.Text + "','" + this.dtpStuffDoB.Text + "','" +
       this.txtStuffMobileNo.Text + "','" + this.txtStuffPassword.Text + "','" + this.cmbStuffGender.Text + "');";

               int count = this.Da.ExecuteDML(sql);//DML=data manupulation Language.Needed for CRUD

               if (count == 1)
               {
                   MessageBox.Show("Data Inserted ");

               }
               else
               {
                   MessageBox.Show("Insertion failed !!!");
               }
               this.PopulateGridView();
               }

              
           

            catch (Exception exce)
            {
                MessageBox.Show("Exception is" + exce.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Information where Role='stuff' and Name like '" + this.txtAutoSearch.Text + "%';";
            
            this.PopulateGridView(sql);
        }

        private void btnRemoveStuff_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = this.dgvInformation.CurrentRow.Cells["ID"].Value.ToString();
                var Name = this.dgvInformation.CurrentRow.Cells["StuffName"].Value.ToString();
              //  var Password = this.dgvInformation.CurrentRow.Cells["Password"].Value.ToString();


                string sql = "delete from Information where ID='"+ID+"'";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Stuff"+Name+" Has been removed!!! ");

                }
                else
                {
                    MessageBox.Show("Did not remove !!!");
                }
                this.PopulateGridView();//calling the PopulateGridView() method
            }
            catch (Exception exc)
            {
                MessageBox.Show("Exception is :"+exc.Message);
            }
        }

        private void btnAddStuff_MouseHover(object sender, EventArgs e)
        {
              this.btnAddStuff.BackColor = Color.CadetBlue;                       
        }

        private void btnAddStuff_MouseLeave(object sender, EventArgs e)
        {
              this.btnAddStuff.BackColor = SystemColors.Control;
        }

        private void btnRemoveStuff_MouseHover(object sender, EventArgs e)
        {
            this.btnRemoveStuff.BackColor = Color.CadetBlue;
        }

        private void btnRemoveStuff_MouseLeave(object sender, EventArgs e)
        {
            this.btnRemoveStuff.BackColor = SystemColors.Control;
        }

        //private void dgvInformation_DoubleClick(object sender, EventArgs e)
        //{
        //    this.txtStuffName.Text = this.dgvInformation.CurrentRow.Cells["StuffName"].Value.ToString();
        //    this.txtStuffId.Text = this.dgvInformation.CurrentRow.Cells["ID"].Value.ToString();
        //    this.txtStuffPassword.Text = this.dgvInformation.CurrentRow.Cells["Password"].Value.ToString();
        //    this.dtpStuffDoB.Text = this.dgvInformation.CurrentRow.Cells["DoB"].Value.ToString();
        //    this.cmbStuffRole.Text = this.dgvInformation.CurrentRow.Cells["Role"].Value.ToString();
        //    this.txtStuffMobileNo.Text = this.dgvInformation.CurrentRow.Cells["MobileNo"].Value.ToString();
        //    this.cmbStuffGender.Text = this.dgvInformation.CurrentRow.Cells["Gender"].Value.ToString();


                
        //}

        

      
        
      
    }
}
