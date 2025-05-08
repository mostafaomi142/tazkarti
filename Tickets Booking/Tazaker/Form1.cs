using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        private List<MatchData> allMatches = new List<MatchData>();
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StadiumComboBox.Items.Add("cairo");
            StadiumComboBox.Items.Add("Suez");
            GroupComboBox.Items.Add("Group Two");
            GroupComboBox.Items.Add("Group Three");
            TeamComboBox.Items.Add("Tala'ea El Gaish SC");
            TeamComboBox.Items.Add("Farco FC");
            TeamComboBox.Items.Add("Al Ahly FC");
            TeamComboBox.Items.Add("Al-Masry SC");
            TeamComboBox.Items.Add("Ghazl El Mahala FC");
            TeamComboBox.Items.Add("ZED FC");
            TeamComboBox.Items.Add("Ceramica Cleopatra FC");
            allMatches.Add(new MatchData("Tala'ea El Gaish SC", "Enppi SC", "cairo", "Group Three", "Group Stage"));
            allMatches.Add(new MatchData("Al Ahly FC", "Farco FC", "cairo", "Group Three", "Group Stage"));
            allMatches.Add(new MatchData("Al-Masry SC", "Ghazl El Mahala FC", "Suez", "Group Two", "Group Stage"));
            allMatches.Add(new MatchData("ZED FC", "Ceramica Cleopatra FC", "cairo", "Group Two", "Group Stage"));
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel15_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            string teamSelected = "";
            if (TeamComboBox.SelectedItem != null)
            {
                teamSelected = TeamComboBox.SelectedItem.ToString();
            }

            string stadiumSelected = "";
            if (StadiumComboBox.SelectedItem != null)
            {
                stadiumSelected = StadiumComboBox.SelectedItem.ToString(); 
            }

            string groupSelected = "";
            if (GroupComboBox.SelectedItem != null)
            {
                groupSelected = GroupComboBox.SelectedItem.ToString(); 
            }
            if (string.IsNullOrEmpty(teamSelected) && string.IsNullOrEmpty(stadiumSelected) && string.IsNullOrEmpty(groupSelected))
            {
                MessageBox.Show("Please select at least one item.");
                return;
            }
            string output = "Matching Matches:\n--------------------\n";
            bool matchFound = false;

            foreach (var match in allMatches)
            {
                bool teamMatches = string.IsNullOrEmpty(teamSelected) ||
                                   match.Team1.Equals(teamSelected, StringComparison.OrdinalIgnoreCase) ||
                                   match.Team2.Equals(teamSelected, StringComparison.OrdinalIgnoreCase);
                bool stadiumMatches = string.IsNullOrEmpty(stadiumSelected) ||
                                     match.Stadium.Equals(stadiumSelected, StringComparison.OrdinalIgnoreCase);
                bool groupMatches = string.IsNullOrEmpty(groupSelected) ||
                                   match.Group.Equals(groupSelected, StringComparison.OrdinalIgnoreCase);

                if ((string.IsNullOrEmpty(teamSelected) || teamMatches) &&
                    (string.IsNullOrEmpty(stadiumSelected) || stadiumMatches) &&
                    (string.IsNullOrEmpty(groupSelected) || groupMatches))
                {
                    output += "Match: " + match.Team1 + " vs " + match.Team2 + "\n";
                    output += "Stadium: " + match.Stadium + "\n";
                    output += "Group: " + match.Group + "\n";
                    output += "--------------------\n";
                    matchFound = true;
                }
            }

            if (matchFound)
            {
                MessageBox.Show(output, "Matching Matches");
            }
            else
            {
                MessageBox.Show("No matches found matching your criteria.", "Matching Matches");
            }

        }

        private void kryptonButton15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This match is already booked");
        }

        private void kryptonButton17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This match is already booked");
        }

        private void kryptonButton19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This match is already booked");
        }

        private void kryptonButton20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new matches\n if there is we will make sure to update you :)");
        }

        private void PanelMatch1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
    public class MatchData
    {
        public string Team1;
        public string Team2;
        public string Stadium;
        public string Group;
        public string Stage;

        public MatchData(string team1, string team2, string stadium, string group, string stage)
        {
            Team1 = team1;
            Team2 = team2;
            Stadium = stadium;
            Group = group;
            Stage = stage;
        }
    }
}
