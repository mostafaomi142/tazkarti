namespace Tazaker
{
    public partial class TicketsHistory : Form
    {
        public TicketsHistory()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EntertainmentSubPanel.Visible = false;
            SportsSubPanel.Visible = false;
            PaymentSubPanel.Visible = false;
            EntertainmentPanel.Top = 300;
            EntertainmentPanel.Height = button1.Height;
            SportsPanel.Height = button2.Height;
            PaymentPanel.Height = button3.Height;
            SportsPanel.Top = EntertainmentPanel.Bottom + 20;
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }

        // starting the program with hidden panels
        bool b1_visible = false;
        bool b2_visible = false;
        bool b3_visible = false;


        private void button1_Click(object sender, EventArgs e)
        {
            b1_visible = !b1_visible; // convert the state at each click

            if (b1_visible)
            {
                EntertainmentSubPanel.Visible = true;
                EntertainmentSubPanel.Top = button1.Bottom + 1;
                EntertainmentPanel.Height = EntertainmentSubPanel.Height + button1.Height;
                button1.Text = "▼ Entertainment Tickets";
                button1.BackColor = Color.ForestGreen;
                button1.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                button1.Text = "▶ Entertainment Tickets";
                EntertainmentPanel.Height = button1.Height;
                EntertainmentSubPanel.Visible = false;
                button1.BackColor = Color.LightGray;
                button1.ForeColor = Color.Black;
            }
            SportsPanel.Top = EntertainmentPanel.Bottom + 20;
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            b2_visible = !b2_visible;
            if (b2_visible)
            {
                SportsSubPanel.Visible = true;
                SportsSubPanel.Top = button2.Bottom + 1;
                SportsPanel.Height = SportsSubPanel.Height + button2.Height;
                button2.Text = "▼ Sports Tickets";
                button2.BackColor = Color.ForestGreen;
                button2.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                SportsSubPanel.Visible = false;
                SportsPanel.Height = button2.Height;
                button2.Text = "▶ Sports Tickets";
                button2.BackColor = Color.LightGray;
                button2.ForeColor = Color.Black;
            }
            PaymentPanel.Top = SportsPanel.Bottom + 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            b3_visible = !b3_visible;
            if (b3_visible)
            {
                PaymentSubPanel.Visible = true;
                PaymentSubPanel.Top = button3.Bottom + 1;
                PaymentPanel.Height = PaymentSubPanel.Height + button3.Height;
                button3.Text = "▼ Payment";
                button3.BackColor = Color.ForestGreen;
                button3.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                PaymentSubPanel.Visible = false;
                PaymentPanel.Height = button3.Height;
                button3.Text = "▶ Payment";
                button3.BackColor = Color.LightGray;
                button3.ForeColor = Color.Black;
            }
        }
    }
}
