using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TicketsBooking
{
    public partial class SignForm5: Form
    {
        bool sidebarExpand = false;
        public SignForm5()
        {
            InitializeComponent();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedItem = "Egypt";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Enabled = false;
        }

        private void kryptonButton18_Click(object sender, EventArgs e)
        {
            string accountSid = "Your_Account_SID";
            string authToken = "Your_Auth_Token";
            TwilioClient.Init(accountSid, authToken);

            string verificationCode = new Random().Next(100000, 999999).ToString();

            var message = MessageResource.Create(
                to: new PhoneNumber(textBox6.Text),  // رقم الموبايل بصيغة دولية
                from: new PhoneNumber(""),
                body: $"Your verification code is: {verificationCode}"
            );

        }

        private void kryptonGroupBox2_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton12_Click_1(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible = true;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            SignForm6 newform =new SignForm6();
            newform.Show();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            SignForm1 oldform = new SignForm1();
            oldform.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
