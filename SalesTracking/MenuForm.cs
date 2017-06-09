using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTracking
{
    public partial class MenuForm : Form
    {
        String customer;
        public MenuForm(String custID)
        {
            InitializeComponent();
            this.customer = custID;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm(customer);
            of.Show();
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm(customer);
            vf.Show();
        }

        private void account_Click(object sender, EventArgs e)
        {
            AccountForm ac = new AccountForm(customer);
            ac.Show();
        }
    }
}
