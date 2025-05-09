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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TicketsBooking
{
    public partial class Recommend : Form
    {
        bool sidebarExpand;
        private EventRecommender eventRecommender = new EventRecommender();

        public Recommend()
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
                    kryptonGroupBox2.Visible = true;


                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    kryptonGroupBox2.Visible = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

  


        private void kryptonButton6_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                List<string> answers = CollectAnswers();
                if (answers.Count == 0)
                    return;

                string recommendedEvent = eventRecommender.GetRecommendedEvent(answers);
                //MessageBox.Show("Recommended Event: " + recommendedEvent);
            }
            catch
            {
                MessageBox.Show("An error occurred while collecting answers.");
            }
        }

        private List<string> CollectAnswers()
        {
            List<string> answers = new List<string>();
            try
            {

                string answer1 = GetSelectedKryptonRadioButton(kryptonGroupBox5);
                if (!string.IsNullOrEmpty(answer1))
                {
                    answers.Add(answer1);
                }
                else
                {
                    MessageBox.Show("Please select an answer for Question 1.");
                    return new List<string>();
                }

                string answer2 = GetSelectedKryptonRadioButton(kryptonGroupBox6);
                if (!string.IsNullOrEmpty(answer2))
                {
                    answers.Add(answer2);
                }
                else
                {
                    MessageBox.Show("Please select an answer for Question 2.");
                    return new List<string>();
                }

                string answer3 = GetSelectedKryptonRadioButton(kryptonGroupBox12);
                if (!string.IsNullOrEmpty(answer3))
                {
                    answers.Add(answer3);
                }
                else
                {
                    MessageBox.Show("Please select an answer for Question 3.");
                    return new List<string>();
                }

                string answer4 = GetSelectedKryptonRadioButton(kryptonGroupBox10);
                if (!string.IsNullOrEmpty(answer4))
                {
                    answers.Add(answer4);
                }
                else
                {
                    MessageBox.Show("Please select an answer for Question 4.");
                    return new List<string>();
                }


                string recommendedEvent = eventRecommender.GetRecommendedEvent(answers);

               
                if (!string.IsNullOrEmpty(recommendedEvent))
                {
                   
                    this.eventTableAdapter.InsertQuery(answer1, answer2, answer3, answer4, recommendedEvent);
                    this.eventTableAdapter.Fill(this.eventDatabase1DataSet.Event);


                    MessageBox.Show("Recommended Event: " + recommendedEvent);


                    MessageBox.Show("Answers and recommended event saved successfully!");
                }
                else
                {
                    MessageBox.Show("No recommended event found.");
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while saving the answers: ");
            }
            return answers;
        }

        private string GetSelectedKryptonRadioButton(KryptonGroupBox groupBox)
        {
            foreach (Control control in groupBox.Panel.Controls)
            {
                if (control is KryptonRadioButton radio && radio.Checked)
                {
                    return radio.Text; 
                }
            }
            return null; 
        }



        private void eventBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eventDatabase1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventDatabase1DataSet.Event' table. You can move, or remove it, as needed.
           // this.eventTableAdapter.Fill(this.eventDatabase1DataSet.Event);

        }

     
    }

    public class EventRecommender
    {
        private Random rand = new Random();

        public string GetRecommendedEvent(List<string> answers)
        {
            try
            {
                if (answers.Count == 0)
                    return null;

                string eventType = answers[0].Trim();

                if (string.IsNullOrEmpty(eventType))
                    return null;

                return GetEventForType(eventType);
            }
            catch
            {
                return null;
            }
        }

        private string GetEventForType(string eventType)
        {
            List<string> concerts = new List<string>
            {
                "Amr Diab Live at AUC",
                "Cairokee at ZED Park",
                "Angham Classical Night"
            };

            List<string> races = new List<string>
            {
                "Exotic Drag Race - Roads & Rides",
                "Desert Rally Challenge",
                "Red Bull Street Race"
            };

            List<string> festivals = new List<string>
            {
                "Downtown Music Festival",
                "Food & Fun Festival",
                "Cairo Lights Festival"
            };

            List<string> exhibitions = new List<string>
            {
                "Art & Tech Expo",
                "Startup Showcase 2025",
                "Book & Culture Exhibition"
            };

            switch (eventType)
            {
                case "Rocking concert":
                    return concerts[rand.Next(concerts.Count)];
                case "Adrenaline-packed race":
                    return races[rand.Next(races.Count)];
                case "Colorful festival":
                    return festivals[rand.Next(festivals.Count)];
                case "Thought-provoking exhibition":
                    return exhibitions[rand.Next(exhibitions.Count)];
                default:
                    return null;
            }
        }
    }
}