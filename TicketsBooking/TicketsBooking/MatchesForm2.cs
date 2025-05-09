using Krypton.Toolkit;
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
    public partial class MatchesForm2 : Form
    {
        public MatchesForm2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Category1ComboBox.Items.Add("0");
            Category1ComboBox.Items.Add("1");
            Category1ComboBox.Items.Add("2");
            Category1ComboBox.Items.Add("3");
            Category1ComboBox.Items.Add("4");
            Category2ComboBox.Items.Add("0");
            Category2ComboBox.Items.Add("1");
            Category2ComboBox.Items.Add("2");
            Category2ComboBox.Items.Add("3");
            Category2ComboBox.Items.Add("4");
            Category3ComboBox.Items.Add("0");
            Category3ComboBox.Items.Add("1");
            Category3ComboBox.Items.Add("2");
            Category3ComboBox.Items.Add("3");
            Category3ComboBox.Items.Add("4");

        }
        private void SetVisibility(bool isVisible)
        {
            category1Label.Visible = isVisible;
            priceCategory1Label.Visible = isVisible;
            priceCategory2Label.Visible = isVisible;
            category2Label.Visible = isVisible;
            priceCategory3Label.Visible = isVisible;
            category3Label.Visible = isVisible;
            totalLabel.Visible = isVisible;
            priceLabel.Visible = isVisible;
            countTicket.Visible = isVisible;
            Category1ComboBox.Visible = isVisible;
            Category2ComboBox.Visible = isVisible;
            Category3ComboBox.Visible = isVisible;
            proceedButton.Visible = isVisible;
            closeButton.Visible = isVisible;
            resetButton.Visible = isVisible;
            calculateButton.Visible = isVisible;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            category1Label.Text = "CAT1 - Left";
            category2Label.Text = "CAT2 - Left";
            category3Label.Text = "CAT3 - Left";
            SetVisibility(true);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            category1Label.Text = "CAT1 - Right";
            category2Label.Text = "CAT2 - Right";
            category3Label.Text = "CAT3 - Right";
            SetVisibility(true);

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            int numOfTickets = 0;
            if (Category1ComboBox.SelectedItem != null)
            {
                numOfTickets += int.Parse(Category1ComboBox.SelectedItem.ToString());
            }
            if (Category2ComboBox.SelectedItem != null)
            {
                numOfTickets += int.Parse(Category2ComboBox.SelectedItem.ToString());
            }
            if (Category3ComboBox.SelectedItem != null)
            {
                numOfTickets += int.Parse(Category3ComboBox.SelectedItem.ToString());
            }
            MatchesForm4 f5 = new MatchesForm4(numOfTickets);
            f5.ShowDialog();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Category1ComboBox.SelectedIndex = 0;
            Category2ComboBox.SelectedIndex = 0;
            Category3ComboBox.SelectedIndex = 0;
            priceLabel.Text = "EGP 00.00";
            countTicket.Text = "0";

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            int category1Selected = Convert.ToInt32(Category1ComboBox.SelectedItem);
            int category2Selected = Convert.ToInt32(Category2ComboBox.SelectedItem);
            int category3Selected = Convert.ToInt32(Category3ComboBox.SelectedItem);
            priceLabel.Text = "EGP " + Convert.ToString(category1Selected * 150 + category2Selected * 100 + category3Selected * 75);
            countTicket.Text = Convert.ToString(category1Selected + category2Selected + category3Selected);
        }

    }
}
