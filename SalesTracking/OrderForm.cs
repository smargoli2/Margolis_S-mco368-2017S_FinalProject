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
    public partial class OrderForm : Form
    {

        String customer;
        public OrderForm(String custID)
        {
            InitializeComponent();
            this.customer = custID;

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = context.Items.Select(i => i.ItemDesc);
                itemList.DataSource = items;
                var p = context.Items.Where(it => it.ItemDesc == itemList.SelectedValue.ToString()).Select(i => i.ItemPrice).First();
                decimal pr = decimal.Parse(p.ToString());
                decimal format = Convert.ToDecimal(string.Format("{0:0.00}", pr));
                price.Text = format.ToString();
            }

        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var bal = context.Customers.Where(c => c.Username == customer).Select(c => c.Balance).First();
                decimal b = decimal.Parse(bal.ToString());
                if (b > 100.0M)
                {//hardcoded amount
                    orderPlaced.Text = "You have reached your credit limit"
                        + "and cannot placer any additional orders until you" +
                        "make a payment towards your balance. Contact your sales rep for help.";
                    this.Hide();
                }
                else
                {
                    var itemID = context.Items.Where(i => itemList.SelectedValue.ToString() == i.ItemDesc).Select(i => i.ItemID).First();
                    int id = Int32.Parse(itemID.ToString());
                    var pr = context.Items.Where(i => i.ItemID == itemID).Select(i => i.ItemPrice).First();
                    decimal pri = decimal.Parse(pr.ToString());
                    Order o = new Order
                    {
                        CustID = customer,
                        orderDate = DateTime.Today,
                        TotalPaid = 0.0M,
                        paid = false,
                        ItemID = id,
                        Quantity = Int32.Parse(quantity.Text),
                        OrderTotal = Int32.Parse(quantity.Text) * pri
                };
                context.Orders.InsertOnSubmit(o);
                context.SubmitChanges();
                var price = context.Items.Where(i => i.ItemID == itemID).Select(i => i.ItemPrice).First();
                decimal p = decimal.Parse(price.ToString());
                decimal total = Int32.Parse(quantity.Text) * p;

                var cust =
           (from c in context.Customers
            where c.Username == customer
            select c).First();
                cust.Balance += total;

                context.SubmitChanges();
                orderPlaced.Text = "Order #" + o.OrderID + " successfully placed!";
            }

        }
    }


    private void close_Click(object sender, EventArgs e)
    {
        this.Hide();//hide window
    }

    private void itemList_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (DataClasses1DataContext context = new DataClasses1DataContext())
        {

            var p = context.Items.Where(it => it.ItemDesc == itemList.SelectedValue.ToString()).Select(i => i.ItemPrice).First();
            decimal pr = decimal.Parse(p.ToString());
            decimal format = Convert.ToDecimal(string.Format("{0:0.00}", pr));
            price.Text = format.ToString();
        }
    }
}
}


