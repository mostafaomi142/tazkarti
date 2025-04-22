using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp12
{
    public partial class Form1: Form
    {
        public Form1()
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

        private void kryptonButton2_Click(object sender, EventArgs e)
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
            Form2 newForm = new Form2();  // استدعاء الفورم الجديدة
            newForm.Show();
            

        }

        private void Form1_Load(object sender, EventArgs e)
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
            Form5 N_E_Wform = new Form5();
            N_E_Wform.Show();
        }
    }
}
