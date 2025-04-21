using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WindowsFormsApp8.Properties;


namespace WindowsFormsApp8
{
    public partial class Form1: Form
    {
        private List<(ConcertCard Card, string Name, string Category, DateTime Date)> allEventCards = new List<(ConcertCard, string, string, DateTime)>();


        public Form1()
        {
            InitializeComponent();
            


        }

        private void FilterAndDisplayCards()
        {
            string nameFilter = kryptonTextBox1.Text.Trim().ToLower();
            string categoryFilter = kryptonComboBox1.Text.Trim().ToLower();
            DateTime? selectedDate = kryptonDateTimePicker1.Checked ? kryptonDateTimePicker1.Value.Date : (DateTime?)null;

            flowLayoutPanel1.Controls.Clear();
            List<ConcertCard> matchingCards = new List<ConcertCard>();

            foreach (var (card, name, category, date) in allEventCards)
            {
                bool matchName = string.IsNullOrEmpty(nameFilter) || name.Contains(nameFilter);
                bool matchCategory = categoryFilter == "all" || string.IsNullOrEmpty(categoryFilter) || category.Contains(categoryFilter);
                bool matchDate = !selectedDate.HasValue || date.Date == selectedDate.Value;

                if (matchName && matchCategory && matchDate)
                {
                    matchingCards.Add(card);
                }
            }

            if (matchingCards.Count > 0)
            {
                foreach (var card in matchingCards)
                {
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            else
            {
                DisplayAllCards(); 
                MessageBox.Show("No events found matching your filters.");
            }
        }






        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            kryptonPanel1.BackColor = Color.Green;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }
        

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonComboBox1.Items.AddRange(new string[] { "All", "Concert", "Race", "Cars" });
            kryptonComboBox1.SelectedIndex = 0; 
            kryptonDateTimePicker1.ShowCheckBox = true; //shows the checkbox in the date 
            kryptonDateTimePicker1.Checked = false;
             

            MakePictureBoxCircular(pictureBox1);

           
            AddEventCard("Tamer Ahour", "Concert", new DateTime(2025, 4, 25, 18, 0, 0), "1500 EGP", "Resources\\d351843d-4755-4145-8a50-15b6ae1e24f9.jpeg");
            AddEventCard("Exotc Drag Race", "Race", new DateTime(2025, 4, 25, 23, 0, 0), "3000 EGP", "Resources\\1b2059d7-1d95-45b6-a3eb-16e62a416c3c.png");
            AddEventCard("Amr Diab", "Concert", new DateTime(2025, 5, 16, 13, 0, 0), "500 EGP", "Resources\\58996dc6-24a8-485b-8c39-93948dd81bcf.jpeg");
            AddEventCard("Elite Tuners", "Cars", new DateTime(2025, 5, 9, 20, 0, 0), "5000 EGP", "Resources\\faba0d30-1ee9-470a-a3e5-7fcee38bda74.jpeg");

            
            DisplayAllCards();

        }
        private void AddEventCard(string name, string category, DateTime date, string price, string imagePath)
        {
            ConcertCard card = new ConcertCard();
            Image image = Image.FromFile($"C:\\Users\\liong\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\{imagePath}");
            card.SetData(name, date.ToString("dddd, MMMM d, yyyy - h:mm tt"), price, image);
            
            allEventCards.Add((card, name.ToLower(), category.ToLower(), date));
        }


        private void DisplayAllCards()
        {
          
            foreach (var (card, _, _, _) in allEventCards)
            {
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void MakePictureBoxCircular(PictureBox picBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(gp);
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEventCat_Click(object sender, EventArgs e)
        {

        }

        private void labelEventName_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kryptonTextBox1.Clear();
            kryptonComboBox1.SelectedIndex = -1;
            kryptonDateTimePicker1.Checked = false; 

            DisplayAllCards();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            FilterAndDisplayCards();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButtonSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
