namespace Tazaker
{
    partial class TicketsHistory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SportsSubPanel = new Panel();
            PaymentSubPanel = new Panel();
            button2 = new Button();
            button3 = new Button();
            SportsPanel = new Panel();
            PaymentPanel = new Panel();
            EntertainmentPanel = new Panel();
            EntertainmentSubPanel = new Panel();
            button1 = new Button();
            SportsPanel.SuspendLayout();
            PaymentPanel.SuspendLayout();
            EntertainmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SportsSubPanel
            // 
            SportsSubPanel.AutoScroll = true;
            SportsSubPanel.BackColor = SystemColors.ButtonFace;
            SportsSubPanel.Location = new Point(17, 37);
            SportsSubPanel.Name = "SportsSubPanel";
            SportsSubPanel.Size = new Size(969, 60);
            SportsSubPanel.TabIndex = 4;
            // 
            // PaymentSubPanel
            // 
            PaymentSubPanel.AutoScroll = true;
            PaymentSubPanel.BackColor = SystemColors.ButtonFace;
            PaymentSubPanel.Location = new Point(17, 37);
            PaymentSubPanel.Name = "PaymentSubPanel";
            PaymentSubPanel.Size = new Size(969, 60);
            PaymentSubPanel.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(6, 0);
            button2.Name = "button2";
            button2.Size = new Size(980, 35);
            button2.TabIndex = 6;
            button2.Text = "▶ Sports Tickets";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(6, 0);
            button3.Name = "button3";
            button3.Size = new Size(980, 35);
            button3.TabIndex = 7;
            button3.Text = "▶ Payments";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SportsPanel
            // 
            SportsPanel.Controls.Add(button2);
            SportsPanel.Controls.Add(SportsSubPanel);
            SportsPanel.Location = new Point(35, 245);
            SportsPanel.Name = "SportsPanel";
            SportsPanel.Size = new Size(1000, 100);
            SportsPanel.TabIndex = 9;
            // 
            // PaymentPanel
            // 
            PaymentPanel.Controls.Add(button3);
            PaymentPanel.Controls.Add(PaymentSubPanel);
            PaymentPanel.Location = new Point(35, 347);
            PaymentPanel.Name = "PaymentPanel";
            PaymentPanel.Size = new Size(1000, 100);
            PaymentPanel.TabIndex = 9;
            // 
            // EntertainmentPanel
            // 
            EntertainmentPanel.BackColor = Color.Gainsboro;
            EntertainmentPanel.Controls.Add(EntertainmentSubPanel);
            EntertainmentPanel.Controls.Add(button1);
            EntertainmentPanel.Location = new Point(35, 143);
            EntertainmentPanel.Name = "EntertainmentPanel";
            EntertainmentPanel.Size = new Size(1000, 100);
            EntertainmentPanel.TabIndex = 8;
            // 
            // EntertainmentSubPanel
            // 
            EntertainmentSubPanel.AutoScroll = true;
            EntertainmentSubPanel.BackColor = SystemColors.ButtonFace;
            EntertainmentSubPanel.Location = new Point(17, 36);
            EntertainmentSubPanel.Name = "EntertainmentSubPanel";
            EntertainmentSubPanel.Size = new Size(969, 60);
            EntertainmentSubPanel.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(6, 0);
            button1.Name = "button1";
            button1.Size = new Size(980, 35);
            button1.TabIndex = 5;
            button1.Text = "▶ Entertainment Tickets";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(872, 458);
            Controls.Add(PaymentPanel);
            Controls.Add(SportsPanel);
            Controls.Add(EntertainmentPanel);
            Name = "Form1";
            Text = "Tickets";
            Load += Form1_Load;
            SportsPanel.ResumeLayout(false);
            PaymentPanel.ResumeLayout(false);
            EntertainmentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel SportsSubPanel;
        private Panel PaymentSubPanel;
        private Button button2;
        private Button button3;
        private Panel SportsPanel;
        private Panel PaymentPanel;
        private Panel EntertainmentPanel;
        private Button button1;
        private Panel EntertainmentSubPanel;
    }
}
