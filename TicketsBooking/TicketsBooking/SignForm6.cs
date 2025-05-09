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
    public partial class SignForm6: Form
    {
        bool sidebarExpand = false;
        public SignForm6()
        {
            InitializeComponent();
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

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            SignForm7 newform = new SignForm7();
            newform.Show();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            SignForm5 oldform = new SignForm5();
            oldform.Show();
        }
    }
}
