using System;
using System.Collections;
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
    public partial class ViewForm : Form
    {

        String customer;
        public ViewForm(String custID)
        {
            InitializeComponent();
            this.customer = custID;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.salesDataSet.Orders);
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var orders = context.Orders.Where(c => c.CustID == customer);
                orderGridView1.DataSource = orders;
            }
            lowdate.Text = "yyyy-mm-dd";
            highdate.Text = "yyyy-mm-dd";

        }

        private void filterByDate_Click(object sender, EventArgs e)
        {
            if (highdate.Text != null && lowdate.Text != null)
            {
                //show filtered view
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var low = lowdate.Text.ToString();
                    System.DateTime l = DateTime.Parse(low);
                    System.DateTime high = DateTime.Parse(highdate.Text.ToString());
                    var orders = context.Orders.Where(c => c.CustID == customer && c.orderDate >= l && c.orderDate <= high);
                    orderGridView1.DataSource = orders;
                    orderGridView1.Refresh();
                }
            }

        }

        private void FilterByPrice_Click(object sender, EventArgs e)
        {
            if (highprice.Text != null && lowprice.Text != null)
            {
                //show filtered view
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    decimal low = decimal.Parse(lowprice.Text.ToString());
                    decimal high = decimal.Parse(highprice.Text.ToString());

                    var orders = context.Orders.Where(c => c.CustID == customer && c.OrderTotal >= low && c.OrderTotal <= high);
                    orderGridView1.DataSource = orders;
                    orderGridView1.Refresh();
                }
            }
        }
    }
}
