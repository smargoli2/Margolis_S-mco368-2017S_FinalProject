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
    public partial class ApplyCreditForm : Form
    {

        String customer;
        public ApplyCreditForm(String cust)
        {
            InitializeComponent();
            this.customer = cust;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                if (amount.Text != null && invoice.Text != null)
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
                        var less = compInv.Quantity * pr - compInv.TotalPaid >= amt;
                        bool l = bool.Parse(less.ToString());
                        if (!p && l)//not paid and invoice has balance
                        {//adjust cust bal
                            var cust =
                    (from c in context.Customers
                     where c.Username == customer
                     select c).First();
                            cust.Credit -= amt;
                            context.SubmitChanges();
                            //adjust invoice
                            var t = (from f in context.Orders
                                     where f.OrderID == inv
                                     select f).First();
                            t.TotalPaid += amt;
                            context.SubmitChanges();
                        }

                        var dif = compInv.Quantity * pr - compInv.TotalPaid;
                        decimal d = decimal.Parse(dif.ToString());
                        if (d == 0.0M)
                        {
                            var t = (from f in context.Orders
                                     where f.OrderID == inv
                                     select f).First();
                            t.paid = true;
                            context.SubmitChanges();
                        }
                        thanks.Text = "Credit of $" + amount.Text + " successfully submitted.";
                    }
                }
            }
        }
    }
}
