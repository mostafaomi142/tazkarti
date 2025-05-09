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
    public partial class SignForm3: Form
    {
        bool sidebarExpand = false;
        public SignForm3()
        {
            InitializeComponent();
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            SignForm2 _Newform = new SignForm2();
            _Newform.Show();
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            Form NEWform = new SignForm4();
            NEWform.Show();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
