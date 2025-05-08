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

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kryptonLabel14_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kryptonComboBox1.Items.Add("1");  
            kryptonComboBox1.Items.Add("2");
            kryptonComboBox1.Items.Add("3");
            kryptonComboBox1.Items.Add("4");  
            kryptonComboBox2.Items.Add("1");  
            kryptonComboBox2.Items.Add("2");
            kryptonComboBox2.Items.Add("3");
            kryptonComboBox2.Items.Add("4"); 
            kryptonComboBox3.Items.Add("1");  
            kryptonComboBox3.Items.Add("2");
            kryptonComboBox3.Items.Add("3");
            kryptonComboBox3.Items.Add("4");
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonLabel6.Text = "CAT1 - Left";
            kryptonLabel9.Text = "CAT2 - Left";
            kryptonLabel11.Text = "CAT3 - Left";
            kryptonLabel6.Visible = true;
            kryptonLabel7.Visible = true;
            kryptonLabel8.Visible = true; 
            kryptonLabel9.Visible = true;
            kryptonLabel10.Visible = true;
            kryptonLabel11.Visible = true;
            kryptonLabel12.Visible = true;
            kryptonLabel13.Visible = true;
            kryptonLabel14.Visible = true;
            kryptonComboBox1.Visible = true;
            kryptonComboBox2.Visible = true;
            kryptonComboBox3.Visible = true;
            kryptonButton3.Visible = true;

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonLabel6.Text = "CAT1 - Right";
            kryptonLabel9.Text = "CAT2 - Right";
            kryptonLabel11.Text = "CAT3 - Right";
            kryptonLabel6.Visible = true;
            kryptonLabel7.Visible = true;
            kryptonLabel8.Visible = true;
            kryptonLabel9.Visible = true;
            kryptonLabel10.Visible = true;
            kryptonLabel11.Visible = true;
            kryptonLabel12.Visible = true;
            kryptonLabel13.Visible = true;
            kryptonLabel14.Visible = true;
            kryptonComboBox1.Visible = true;
            kryptonComboBox2.Visible = true;
            kryptonComboBox3.Visible = true;
            kryptonButton3.Visible = true;

        }

        
    }
}
