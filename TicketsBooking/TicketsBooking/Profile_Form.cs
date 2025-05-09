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
    public partial class Profile_Form : Form
    {
        public Profile_Form()
        {
            InitializeComponent();
        }

        private void Profile_Form_Load(object sender, EventArgs e)
        {

        }

        private void Update_Btn1_Click(object sender, EventArgs e)
        {
            FanName_TxtBox.ReadOnly = false;
            Email_TxtBox.ReadOnly = false;
            MobileNumber_TxtBox.ReadOnly = false;
            Nationality_TxtBox.ReadOnly = false;
        }

        private void Update_Btn2_Click(object sender, EventArgs e)
        {
            Password_TxtBox.ReadOnly = false;
            ConfirmPassword_TxtBox.ReadOnly = false;
            LanguageOfCommunication_TxtBox.ReadOnly = false;
            CountryOfResidence_TxtBox.ReadOnly = false;
            City_TxtBox.ReadOnly = false;
            Region_TxtBox.ReadOnly = false;
            AddressOne_TxtBox.ReadOnly = false;
            AddressTwo_TxtBox.ReadOnly = false;
            PreferredTeam_TxtBox.ReadOnly = false;
        }
    }
}
