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
    public partial class StuffDisplay : Form
    {
        public StuffDisplay()
        {
            InitializeComponent();
        }

        PlaceOrder po = new PlaceOrder();
        DisplayFood df = new DisplayFood();

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            po.Visible = true;
            this.Visible = false;
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            df.Visible = true;
            this.Visible = false;
        }
    }
}
