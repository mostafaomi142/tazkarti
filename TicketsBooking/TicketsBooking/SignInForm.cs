using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsBooking
{
    public partial class SignInForm: Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kryptonButton1_Click(object sender, EventArgs e) // sing in bottun
        {
           Home Enter_Home = new Home();
            Enter_Home.Show();
         }
    }
}
