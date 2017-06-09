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
    public partial class AccountForm : Form
    {

        String customer;
        public AccountForm(String c)
        {
            InitializeComponent();
            this.customer = c;
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var name = context.Customers.Where(cus => cus.Username == customer).Select(cu => cu.FirstName + " " + cu.LastName).First();
                welcomeLabel.Text = "Hello, " + name.ToString();
                var ad = context.Customers.Where(cus => cus.Username == customer).Select(cu => cu.CustAddress.ToString()).First();
                address.Text = ad.ToString();
                var bal = context.Customers.Where(cus => cus.Username == customer).Select(cu => cu.Balance).First();
                balance.Text = "Balance: $" + bal.ToString();
                var cred = context.Customers.Where(cus => cus.Username == customer).Select(cu => cu.Credit).First();
                credit.Text = "Credit: $" + cred.ToString();
            }
        }

        private void submitPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm pf = new PaymentForm(customer);
            pf.Show();
        }

        private void applyCredit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                ApplyCreditForm ac = new ApplyCreditForm(customer);
                ac.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            
        }
    }
}
