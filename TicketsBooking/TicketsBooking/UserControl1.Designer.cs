namespace TicketsBooking
{
    partial class ConcertCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConcertName = new System.Windows.Forms.Label();
            this.ConcertDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConcertName
            // 
            this.ConcertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcertName.Location = new System.Drawing.Point(752, 0);
            this.ConcertName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConcertName.Name = "ConcertName";
            this.ConcertName.Size = new System.Drawing.Size(267, 59);
            this.ConcertName.TabIndex = 1;
            this.ConcertName.Text = "Tamerr Ashour";
            // 
            // ConcertDate
            // 
            this.ConcertDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcertDate.Location = new System.Drawing.Point(752, 46);
            this.ConcertDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConcertDate.Name = "ConcertDate";
            this.ConcertDate.Size = new System.Drawing.Size(280, 34);
            this.ConcertDate.TabIndex = 2;
            this.ConcertDate.Text = "25,april,2025";
            this.ConcertDate.Click += new System.EventHandler(this.ConcertDate_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(752, 97);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(260, 44);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Prices From: 1500 EGP";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyTicket.ForeColor = System.Drawing.Color.Green;
            this.buttonBuyTicket.Location = new System.Drawing.Point(1084, 97);
            this.buttonBuyTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(122, 48);
            this.buttonBuyTicket.TabIndex = 4;
            this.buttonBuyTicket.Text = "Buy Ticket";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketsBooking.Properties.Resources.d351843d_4755_4145_8a50_15b6ae1e24f9;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ConcertCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.ConcertDate);
            this.Controls.Add(this.ConcertName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConcertCard";
            this.Size = new System.Drawing.Size(1261, 185);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ConcertName;
        public System.Windows.Forms.Label ConcertDate;
        public System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBuyTicket;
    }
}
