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
    public partial class Contacts : Form
    {
        private DataAccess Da { get; set; }

        public Contacts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        void PopulateGridView(string sql)
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                //this.dgvFood.AutoGenerateColumns = false;
                this.dgvContacts.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

            private void btnShowContacts_Click(object sender, EventArgs e)
        {
            string sql = "select * from ContactInfo;";
            this.PopulateGridView(sql);
        }

        private void txtAutoSuch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ContactInfo where Name like '"+this.txtAutoSuch.Text+"%';";
            this.PopulateGridView(sql);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show("Please Fill All Information!!");
                    return;
                }
                var sql = "select*from ContactInfo where Name='" + this.txtName + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    string query = @"update ContactInfo Name = ('" + this.txtName.Text + "',Number = '" + this.txtNumber.Text + "'where Email = '" + this.txtEmail.Text + "'); ";
                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data update successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data update Failed!!");
                    }

                }

                else
                {
                    //insert
                    string query = @"insert into ContactInfo values('" + this.txtName.Text + "', '" + this.txtNumber.Text + "', '" + this.txtEmail.Text + "')";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Inserted Failed!!");
                    }
                }
                //  this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Name = this.dgvContacts.CurrentRow.Cells[0].Value.ToString();
                string sql = "delete from ContactInfo where Name = '" + Name + "';";
                int count = this.Da.ExecuteDML(sql);
                if (count == 1)
                {

                    MessageBox.Show("ContactInfo:"+Name+"has been deleted");
                }
                else
                {
                    MessageBox.Show("Delete Failed!!");
                }
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error :" + exc.Message);
            }
        }

        private void dgvContacts_DoubleClick(object sender, EventArgs e)
        {

            this.txtName.Text = this.dgvContacts.CurrentRow.Cells[0].Value.ToString();
            this.txtNumber.Text = this.dgvContacts.CurrentRow.Cells[1].Value.ToString();
            this.txtEmail.Text = this.dgvContacts.CurrentRow.Cells[2].Value.ToString();
        }

        
        private void ClearContent()
        {
            this.txtName.Text = "";
            this.txtNumber.Text = "";
            this.txtEmail.Text = "";
            this.txtAutoSuch.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
    }
    
}

