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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            String user = username.Text;
            String pw = password.Text;
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var p = context.Customers.Any(u => u.Username == user && u.password == pw);
                if (p)
                {
                    //show logout button, view orders button and submit orders button
                    //hide login tools
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    username.Hide();
                    password.Hide();
                    signIn.Hide();
                    MenuForm menu = new MenuForm(user);
                    menu.Show();

                }
                else
                {
                    label1.Text = "Username or password incorrect. Try again.";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
