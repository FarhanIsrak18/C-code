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
    public partial class PlaceOrder : Form
    {

        private DataAccess Da { get; set; }
        private int globalItemId;
        private int globalPrice;
        private int totalAmount;
        private int globalQuantity;
        private DateTime localDate = DateTime.Now;


        List<category> categoryListObj = new List<category>();
        List<product> productListObj = new List<product>();


        public PlaceOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            string sql = "select * from category";
            DataTable dt = this.Da.ExecuteQueryTable(sql);


            comboBox1.DataSource = dt.DefaultView;//
            comboBox1.ValueMember = "catId";
            comboBox1.DisplayMember = "catName";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            comboBox4.DataSource = dt.DefaultView;
            comboBox4.ValueMember = "catId";
            comboBox4.DisplayMember = "catName";

            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            label10.Text = localDate.ToString("dd/MM/yyyy");


            //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-HCC83D8;Initial Catalog=FoodOffer;User ID=sa;Password=sqllogin");
            //sqlCon.Open();
            //SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
            //SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom);

            //DataSet ds = new DataSet();
            //sdAdapter.Fill(ds);

            //DataTable dt = new DataTable();
            //sdAdapter.Fill(dt);


            //DataTable catTable = ds.Tables[1];
            //IDictionary<int, string> catData = new Dictionary<int, string>();


            /*foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    //catData.Add(row[0], row[1]);
                    //Console.WriteLine(row.GetType().FullName);

                    foreach (DataColumn column in table.Columns)
                    {
                        //Console.WriteLine(row[column]);                      
                    }
                }
            }*/


            //Console.WriteLine("Hi, this is a console writeline");
            //Console.WriteLine(ds);

            /*categoryListObj = catTable.AsEnumerable().Select(m => new Category()
            {
                catId = m.Field<int>("catId"),
                catName = m.Field<string>("catName")

            }).ToList(); */

            /*foreach (string name in categoryListObj.Select(l => l.catName).ToArray())
            {
                this.comboBox1.Items.Add(name);
            }*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int catId = comboBox1.SelectedIndex + 1;


            string sql = @"select * from Menu where catId={catId}";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            comboBox2.DataSource = dt.DefaultView;
            comboBox2.ValueMember = "itemid";
            comboBox2.DisplayMember = "itemName";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = this.Da.ExecuteQueryTable(sql);

            //DataSet ds2 = this.Da.ExecuteQuery(sql);
            //DataTable firstTable = ds2.Tables[0];

            //DataRow row = firstTable.Rows[0];
            //string availability = row["availability"].ToString();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                //showing data based on selection
                string selectedItemId = Convert.ToString(comboBox2.SelectedValue);
                //Console.WriteLine(selectedItemId);

                string sql = "select * from Menu where itemid ='{selectedItemId}'";

                DataSet ds = this.Da.ExecuteQuery(sql);
                DataTable dt = new DataTable();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Console.WriteLine("More than one rows present");
                }
                else
                {
                    //Console.WriteLine("zero rows");
                }

                dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    //Console.WriteLine("at dt More than one rows present");                  
                    //Console.WriteLine(dt.Rows[0][2]);

                    int pr = dt.Rows[0].Field<int>("price");
                    string price = Convert.ToString(pr);
                    string avail = dt.Rows[0].Field<string>("availability");

                    //Console.WriteLine(price);
                    //Console.WriteLine(avail);
                    label2.Text = price;
                    label4.Text = avail;

                }
                else
                {
                    Console.WriteLine("at dt zero rows");

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int catId = comboBox4.SelectedIndex + 1;
            //Console.WriteLine(catId);

            string sql = "select * from Menu where catId={catId}";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            comboBox3.DataSource = dt.DefaultView;
            comboBox3.ValueMember = "itemid";
            comboBox3.DisplayMember = "itemName";
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectedItemId = Convert.ToString(comboBox3.SelectedValue);
                //Console.WriteLine(selectedItemId);

                string sql = "select * from Menu where itemid={selectedItemId}";

                DataSet ds = this.Da.ExecuteQuery(sql);
                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    int pr = dt.Rows[0].Field<int>("price");
                    int itemId = dt.Rows[0].Field<int>("itemid");

                    globalItemId = itemId;
                    globalPrice = pr;

                    //Console.WriteLine(pr);
                }
                else
                {
                  //  Console.WriteLine("at dt zero rows");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            int quantity = Convert.ToInt32(textBox1.Text);
            totalAmount = globalPrice * quantity;
            label5.Text = Convert.ToString(totalAmount);

            globalQuantity = quantity;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }

            int discount = Convert.ToInt32(textBox2.Text);
            totalAmount = totalAmount - discount;
            label5.Text = Convert.ToString(totalAmount);

            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "INSERT into OrderList (itemid,quantity,bill,date) values ('" + globalItemId + "'," + globalQuantity + "," + totalAmount + ",'" + localDate + "');";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Inserted.");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed.");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error: " + exe.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OrderList frm2 = new OrderList();
            frm2.Show();
        }
    }

    public class category
    {
        public int catId { get; set; }
        public string catName { get; set; }
    }
    //[Serializable]
    public class product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public float prod_price { get; set; }
        public float prod_unit { get; set; }
        public int cate_id { get; set; }
    }

}
