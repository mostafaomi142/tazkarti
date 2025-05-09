using System;
using System.Drawing;
using System.Windows.Forms;


namespace TicketsBooking
{
    public partial class TicketsHistory : Form
    {
        public TicketsHistory()
        {
            InitializeComponent();
        }

        // starting the program with hidden panels
        bool b1_visible = false;
        bool b2_visible = false;
        bool b3_visible = false;

        private void TicketsHistory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EntertainmentSubPanel.Visible = false;
            SportsSubPanel.Visible = false;
            PaymentSubPanel.Visible = false;
            EntertainmentPanel.Top = 300;
            EntertainmentPanel.Height = Entertainmentbottun.Height;
            SportsPanel.Height = Sportsbottun.Height;
            PaymentPanel.Height = PaymentBottun.Height;
            SportsPanel.Top = EntertainmentPanel.Bottom + 20;
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }

  

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Home open = new Home();
            open.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            MatchesForm1 open = new MatchesForm1();
            open.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Profile_Form open = new Profile_Form();
            open.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            /*Event open = new Event();
            open.show();*/
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Recommend open = new Recommend();
            open.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Entertainmentbottun_Click_1(object sender, EventArgs e)
        {
            b1_visible = !b1_visible; // convert the state at each click

            if (b1_visible)
            {
                EntertainmentSubPanel.Visible = true;
                EntertainmentSubPanel.Top = Entertainmentbottun.Bottom + 1;
                EntertainmentPanel.Height = EntertainmentSubPanel.Height + Entertainmentbottun.Height;
                Entertainmentbottun.Text = "▼ Entertainment Tickets";
                Entertainmentbottun.BackColor = Color.ForestGreen;
                Entertainmentbottun.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                Entertainmentbottun.Text = "▶ Entertainment Tickets";
                EntertainmentPanel.Height = Entertainmentbottun.Height;
                EntertainmentSubPanel.Visible = false;
                Entertainmentbottun.BackColor = Color.LightGray;
                Entertainmentbottun.ForeColor = Color.Black;
            }
            SportsPanel.Top = EntertainmentPanel.Bottom + 20;
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }

        private void Sportsbottun_Click_1(object sender, EventArgs e)
        {
            b2_visible = !b2_visible;
            if (b2_visible)
            {
                SportsSubPanel.Visible = true;
                SportsSubPanel.Top = Sportsbottun.Bottom + 1;
                SportsPanel.Height = SportsSubPanel.Height + Sportsbottun.Height;
                Sportsbottun.Text = "▼ Sports Tickets";
                Sportsbottun.BackColor = Color.ForestGreen;
                Sportsbottun.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                SportsSubPanel.Visible = false;
                SportsPanel.Height = Sportsbottun.Height;
                Sportsbottun.Text = "▶ Sports Tickets";
                Sportsbottun.BackColor = Color.LightGray;
                Sportsbottun.ForeColor = Color.Black;
            }
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }

        private void PaymentBottun_Click_1(object sender, EventArgs e)
        {
            b3_visible = !b3_visible;
            if (b3_visible)
            {
                PaymentSubPanel.Visible = true;
                PaymentSubPanel.Top = PaymentBottun.Bottom + 1;
                PaymentPanel.Height = PaymentSubPanel.Height + PaymentBottun.Height;
                PaymentBottun.Text = "▼ Payment";
                PaymentBottun.BackColor = Color.ForestGreen;
                PaymentBottun.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                PaymentSubPanel.Visible = false;
                PaymentPanel.Height = PaymentBottun.Height;
                PaymentBottun.Text = "▶ Payment";
                PaymentBottun.BackColor = Color.LightGray;
                PaymentBottun.ForeColor = Color.Black;
            }
        }
    }
}
