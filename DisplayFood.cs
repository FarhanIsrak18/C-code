using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsCLogin
{
    public partial class DisplayFood : Form
    {
         private DataAccess Da { get; set; }

        // private Main_display md;

         public DisplayFood()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

       /*  public DisplayFood(Main_display md)
         {
             InitializeComponent();
             this.md = md;
         }*/

        
        void PopulateGridView(string sql)
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                //this.dgvFood.AutoGenerateColumns = false;
                this.dgvFood.DataSource = ds.Tables[0];
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
           
        }
        private void btnShowFd_Click(object sender, EventArgs e)
        {
            string sql = "select*from FoodInfo;";
            this.PopulateGridView(sql);
                
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

                string sql = "select *from FoodInfo where Category='"+this.texsearch.Text+"';";
                this.PopulateGridView(sql);
              

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtFoodItem.Text) || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
                {
                    MessageBox.Show("Please Fill All Information!!");
                    return;
                }
                var sql = "select*from FoodInfo where [Food Items]='" + this.txtFoodItem + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    string query = @"update FoodInfo set food Items = '"+this.txtFoodItem.Text+"',Category = '"+this.cmbCategory.Text+"'where prices = '"+this.txtPrice.Text+"'; ";
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
                    string query = @"insert into FoodInfo values('" + this.txtFoodItem.Text + "', '" + this.cmbCategory.Text + "', '" + this.txtPrice.Text + "')";

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
            catch(Exception exc)
            {
                MessageBox.Show("");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        { 
            try
            {
                var FoodItems = this.dgvFood.CurrentRow.Cells[0].Value.ToString();
                string sql="delete from FoodInfo where[Food Items] = '"+FoodItems+"';";
                int count=this.Da.ExecuteDML(sql);
                if (count == 1)
                { 
                
                     MessageBox.Show("FoodInfo"+FoodItems+"has been deleted");
                }
                else
                {
                    MessageBox.Show("Delete Failed!!");
                }
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error :" + exc.Message);
            }
           
        }

        private void dgvFood_DoubleClick(object sender, EventArgs e)
        {
            this.txtFoodItem.Text = this.dgvFood.CurrentRow.Cells[0].Value.ToString();
            this.txtPrice.Text = this.dgvFood.CurrentRow.Cells[2].Value.ToString();
            this.cmbCategory.Text = this.dgvFood.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtFoodItem.Text = "";
            this.txtPrice.Text = "";
            this.cmbCategory.Text = "";
            this.texsearch.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Visible = false;
            this.md.Visible = true;*/
           
        }

       
        

       
    }
}

