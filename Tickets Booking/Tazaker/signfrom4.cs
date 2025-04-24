using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;



namespace Tazaker
{
    public partial class signfrom4: Form
    {
        public signfrom4()
        {
            InitializeComponent();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click_1(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible = true;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible = false;
        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();  
            NewForm.Show();
            
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            //    string verificationCode;
            //    string toEmail = textBox2.Text;

            //    // 2. إنشاء كود عشوائي من 6 أرقام
            //    Random rand = new Random();
            //    verificationCode = rand.Next(100000, 999999).ToString();

            //    try
            //    {
            //        // 3. تجهيز رسالة البريد
            //        MailMessage mail = new MailMessage();
            //        mail.From = new MailAddress("bdyab703@gmail.com"); // إيميل المرسل
            //        mail.To.Add(toEmail);                                // إيميل المستلم
            //        mail.Subject = "Email Verification Code";            // عنوان الرسالة
            //        mail.Body = $"Your verification code is: {verificationCode}"; // نص الرسالة

            //        // 4. إعداد SMTP لإرسال الرسالة عبر Gmail
            //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // سيرفر جيميل
            //        smtp.Credentials = new NetworkCredential("bdyab703@gmail.com", "Asiaa2019"); // بيانات تسجيل الدخول
            //        smtp.EnableSsl = true; // تشفير الاتصال

            //        // 5. إرسال الرسالة
            //        smtp.Send(mail);


            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("ERROR");
            //    }
        }


        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton4_Click_2(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible=true;
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();

        }
    }
}
