using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsBooking
{
    public partial class ConcertCard: UserControl
    {
        public event EventHandler BuyTicketClicked;

        public ConcertCard()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string name, string date, string price, Image image)
        {
            ConcertName.Text = name;
            ConcertDate.Text = date;
            labelPrice.Text = price;
            pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void ConcertDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
