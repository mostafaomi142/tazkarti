using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsBooking
{
    public partial class MatchesForm4: Form
    {
        int numberOfTickets;
        int matchId = 20251;
        public MatchesForm4(int x)
        {
            numberOfTickets = x;
            InitializeComponent();
            updateTickets();
        }

        private void matchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void MatchesForm4_Load(object sender, EventArgs e)
        {
            this.matchesTableAdapter.Fill(this.database1DataSet.matches);
            
        }

        
        private void updateTickets()
        {
            if (numberOfTickets > 0)
            {
                string s = matchesTableAdapter.Get_NumberOf_RemainingTickets(matchId).ToString();
                int rem = int.Parse(s);
                if (numberOfTickets > rem)
                {
                    ticket_Number.Text = ("No enough tickets\n" + "there is only "+ s +" of tickets left ");
                }
                else
                {
                    matchesTableAdapter.Decrement_Remaining_Tickets(numberOfTickets, matchId);
                    this.matchesTableAdapter.Fill(this.database1DataSet.matches);
                    ticket_Number.Text = "You have booked successfully";
                }

            }
            else
            {
                MessageBox.Show("Please select at least one ticket.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
