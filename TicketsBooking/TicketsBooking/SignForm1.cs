using TicketsBooking.Properties;
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
    public partial class SignForm1: Form
    {
        bool sidebarExpand;
        public SignForm1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;

            Rectangle shadowRect = new Rectangle(4, 4, box.Width - 8, box.Height - 8);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
            {
                g.FillRectangle(shadowBrush, shadowRect);
            }
        }

        private void kryptonGroupBox2_Panel_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;

            Rectangle shadowRect = new Rectangle(4, 4, box.Width - 8, box.Height - 8);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
            {
                g.FillRectangle(shadowBrush, shadowRect);
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            SignForm2 newForm = new SignForm2();  // استدعاء الفورم الجديدة
            newForm.Show();
            

        }

        private void SignForm1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            SignForm5 N_E_Wform = new SignForm5();
            N_E_Wform.Show();
           
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width==sidebar.MinimumSize.Width)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)  // sign in bottun
        {
            SignInForm Enter_home = new SignInForm();
            Enter_home.ShowDialog();
        }
    }
}
