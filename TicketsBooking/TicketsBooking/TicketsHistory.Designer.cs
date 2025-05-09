using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketsBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.PaymentBottun = new System.Windows.Forms.Button();
            this.PaymentSubPanel = new System.Windows.Forms.Panel();
            this.SportsPanel = new System.Windows.Forms.Panel();
            this.Sportsbottun = new System.Windows.Forms.Button();
            this.SportsSubPanel = new System.Windows.Forms.Panel();
            this.EntertainmentPanel = new System.Windows.Forms.Panel();
            this.EntertainmentSubPanel = new System.Windows.Forms.Panel();
            this.Entertainmentbottun = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            this.PaymentPanel.SuspendLayout();
            this.SportsPanel.SuspendLayout();
            this.EntertainmentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 87);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.AutoSize = true;
            this.PaymentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PaymentPanel.Controls.Add(this.PaymentBottun);
            this.PaymentPanel.Controls.Add(this.PaymentSubPanel);
            this.PaymentPanel.Location = new System.Drawing.Point(34, 520);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1018, 120);
            this.PaymentPanel.TabIndex = 12;
            // 
            // PaymentBottun
            // 
            this.PaymentBottun.BackColor = System.Drawing.Color.LightGray;
            this.PaymentBottun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBottun.Location = new System.Drawing.Point(5, 0);
            this.PaymentBottun.Name = "PaymentBottun";
            this.PaymentBottun.Size = new System.Drawing.Size(1000, 40);
            this.PaymentBottun.TabIndex = 7;
            this.PaymentBottun.Text = "▶ Payments";
            this.PaymentBottun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentBottun.UseVisualStyleBackColor = false;
            this.PaymentBottun.Click += new System.EventHandler(this.PaymentBottun_Click_1);
            // 
            // PaymentSubPanel
            // 
            this.PaymentSubPanel.AutoScroll = true;
            this.PaymentSubPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PaymentSubPanel.Location = new System.Drawing.Point(15, 32);
            this.PaymentSubPanel.Name = "PaymentSubPanel";
            this.PaymentSubPanel.Size = new System.Drawing.Size(1000, 85);
            this.PaymentSubPanel.TabIndex = 4;
            // 
            // SportsPanel
            // 
            this.SportsPanel.AutoSize = true;
            this.SportsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SportsPanel.Controls.Add(this.Sportsbottun);
            this.SportsPanel.Controls.Add(this.SportsSubPanel);
            this.SportsPanel.Location = new System.Drawing.Point(34, 431);
            this.SportsPanel.Name = "SportsPanel";
            this.SportsPanel.Size = new System.Drawing.Size(1018, 120);
            this.SportsPanel.TabIndex = 11;
            // 
            // Sportsbottun
            // 
            this.Sportsbottun.BackColor = System.Drawing.Color.LightGray;
            this.Sportsbottun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sportsbottun.Location = new System.Drawing.Point(5, 0);
            this.Sportsbottun.Name = "Sportsbottun";
            this.Sportsbottun.Size = new System.Drawing.Size(1000, 40);
            this.Sportsbottun.TabIndex = 6;
            this.Sportsbottun.Text = "▶ Sports Tickets";
            this.Sportsbottun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sportsbottun.UseVisualStyleBackColor = false;
            this.Sportsbottun.Click += new System.EventHandler(this.Sportsbottun_Click_1);
            // 
            // SportsSubPanel
            // 
            this.SportsSubPanel.AutoScroll = true;
            this.SportsSubPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SportsSubPanel.Location = new System.Drawing.Point(15, 32);
            this.SportsSubPanel.Name = "SportsSubPanel";
            this.SportsSubPanel.Size = new System.Drawing.Size(1000, 85);
            this.SportsSubPanel.TabIndex = 4;
            // 
            // EntertainmentPanel
            // 
            this.EntertainmentPanel.AutoSize = true;
            this.EntertainmentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntertainmentPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.EntertainmentPanel.Controls.Add(this.EntertainmentSubPanel);
            this.EntertainmentPanel.Controls.Add(this.Entertainmentbottun);
            this.EntertainmentPanel.Location = new System.Drawing.Point(34, 327);
            this.EntertainmentPanel.Name = "EntertainmentPanel";
            this.EntertainmentPanel.Size = new System.Drawing.Size(1018, 119);
            this.EntertainmentPanel.TabIndex = 10;
            // 
            // EntertainmentSubPanel
            // 
            this.EntertainmentSubPanel.AutoScroll = true;
            this.EntertainmentSubPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EntertainmentSubPanel.Location = new System.Drawing.Point(15, 31);
            this.EntertainmentSubPanel.Name = "EntertainmentSubPanel";
            this.EntertainmentSubPanel.Size = new System.Drawing.Size(1000, 85);
            this.EntertainmentSubPanel.TabIndex = 6;
            // 
            // Entertainmentbottun
            // 
            this.Entertainmentbottun.BackColor = System.Drawing.Color.LightGray;
            this.Entertainmentbottun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entertainmentbottun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Entertainmentbottun.Location = new System.Drawing.Point(5, 0);
            this.Entertainmentbottun.Name = "Entertainmentbottun";
            this.Entertainmentbottun.Size = new System.Drawing.Size(1000, 40);
            this.Entertainmentbottun.TabIndex = 5;
            this.Entertainmentbottun.Text = "▶ Entertainment Tickets";
            this.Entertainmentbottun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entertainmentbottun.UseVisualStyleBackColor = false;
            this.Entertainmentbottun.Click += new System.EventHandler(this.Entertainmentbottun_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.kryptonButton6);
            this.panel2.Controls.Add(this.kryptonButton5);
            this.panel2.Controls.Add(this.kryptonButton4);
            this.panel2.Controls.Add(this.kryptonButton3);
            this.panel2.Controls.Add(this.kryptonButton2);
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Controls.Add(this.kryptonTextBox2);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.kryptonTextBox1);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 100);
            this.panel2.TabIndex = 13;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(162, 16);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(59, 16);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Welcome";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(162, 38);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(162, 74);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "User ID";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(227, 71);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox2.TabIndex = 3;
            this.kryptonTextBox2.Text = "kryptonTextBox2";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(34, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(110, 94);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(597, 26);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 14;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Profile";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(372, 26);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton3.TabIndex = 15;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Text = "Home";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(484, 26);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton4.TabIndex = 16;
            this.kryptonButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton4.Values.Text = "Matches";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(717, 26);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton5.TabIndex = 17;
            this.kryptonButton5.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton5.Values.Text = "Events";
            this.kryptonButton5.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(835, 26);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton6.TabIndex = 18;
            this.kryptonButton6.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton6.Values.Text = "Recommend";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // TicketsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.SportsPanel);
            this.Controls.Add(this.EntertainmentPanel);
            this.Controls.Add(this.panel1);
            this.Name = "TicketsHistory";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.TicketsHistory_Load);
            this.PaymentPanel.ResumeLayout(false);
            this.SportsPanel.ResumeLayout(false);
            this.EntertainmentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Panel PaymentPanel;
        private Button PaymentBottun;
        private Panel PaymentSubPanel;
        private Panel SportsPanel;
        private Button Sportsbottun;
        private Panel SportsSubPanel;
        private Panel EntertainmentPanel;
        private Panel EntertainmentSubPanel;
        private Button Entertainmentbottun;
        private Panel panel2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
