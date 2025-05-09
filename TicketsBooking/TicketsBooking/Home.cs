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
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void kryptonLabel25_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Profile_Form Open = new Profile_Form();
            Open.Show();
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            MatchesForm1 Open = new MatchesForm1();
            Open.Show();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            /* EventForm Open = new Event_Form();
            Open.Show();*/
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Recommend Open = new Recommend();
            Open.Show();
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            TicketsHistory Open= new TicketsHistory();
            Open.Show();

        }
    }
}
