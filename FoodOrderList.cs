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
    public partial class FoodOrderList : Form
    {
        public FoodOrderList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private DataAccess Da { get; set; }

      
       private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "select * from OrderList";


            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, "Data Source=DESKTOP-HCC83D8;Initial Catalog=FoodOffer;Persist Security Info=True;User ID=sa;Password=sqllogin");
                DataSet ds = new DataSet();
                da.Fill(ds, "OderList");

                
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "OderList";



                //DataSet ds = new DataSet();
                //ds = this.Da.ExecuteQuery(sql);

                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "OderList";

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
