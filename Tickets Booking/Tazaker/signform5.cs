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

namespace WindowsFormsApp12
{
    public partial class signform5: Form
    {
        public signform5()
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
    }
}
