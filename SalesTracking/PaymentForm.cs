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
    public partial class PaymentForm : Form
    {

        String customer;
        public PaymentForm(String c)
        {
            InitializeComponent();
            this.customer = c;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                if (invoice.Text != null && invoice.Text != "0")
                {
                    int inv = Int32.Parse(invoice.Text.ToString());
                    decimal amt = decimal.Parse(amount.Text.ToString());
                    var compInv = context.Orders.Where(c => c.CustID == customer && c.OrderID == inv).First();
                    if (compInv != null)
                    {
                        var item = compInv.ItemID;
                        int a = Int32.Parse(item.ToString());
                        var price = context.Items.Where(it => it.ItemID == a).Select(it => it.ItemPrice).First();
                        decimal pr = decimal.Parse(price.ToString());
                        var paid = compInv.paid;
                        bool p = bool.Parse(paid.ToString());
                        bool less = amt <= compInv.OrderTotal -  compInv.TotalPaid;
                       // bool l = bool.Parse(less.ToString());
                        if (!p && less)//not paid and invoice has balance
                        {//adjust cust bal
                            var cust =
                    (from c in context.Customers
                     where c.Username == customer
                     select c).First();
                            cust.Balance -= amt;
                            context.SubmitChanges();
                            //adjust invoice
                            var t = (from f in context.Orders
                                     where f.OrderID == inv
                                     select f).First();
                            t.TotalPaid += amt;
                            context.SubmitChanges();
                        }

                        var dif = compInv.OrderTotal - compInv.TotalPaid;
                        decimal d = decimal.Parse(dif.ToString());
                        if (d == 0.0M)
                        {
                            var t = (from f in context.Orders
                                     where f.OrderID == inv
                                     select f).First();
                            t.paid = true;
                            context.SubmitChanges();
                        }
                        thanks.Text = "Payment of $" + amount.Text + " successfully submitted.";
                    }
                }
                else//make payment towards general balance
                {
                    decimal amt = decimal.Parse(amount.Text.ToString());
                    var cust =
                  (from c in context.Customers
                   where c.Username == customer
                   select c).First();
                    cust.Credit += amt;
                    context.SubmitChanges();
                }
            }
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
         }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void thanks_Click(object sender, EventArgs e)
        {

        }
    }
}
