using Krypton;
namespace TicketsBooking
{
    partial class MatchesForm2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesForm2));
            this.talaButton = new Krypton.Toolkit.KryptonButton();
            this.enppiButton = new Krypton.Toolkit.KryptonButton();
            this.location = new Krypton.Toolkit.KryptonLabel();
            this.Stadium = new Krypton.Toolkit.KryptonLabel();
            this.date = new Krypton.Toolkit.KryptonLabel();
            this.time = new Krypton.Toolkit.KryptonLabel();
            this.warrningMessage = new Krypton.Toolkit.KryptonLabel();
            this.category1Label = new Krypton.Toolkit.KryptonLabel();
            this.priceCategory1Label = new Krypton.Toolkit.KryptonLabel();
            this.Category2ComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.priceCategory2Label = new Krypton.Toolkit.KryptonLabel();
            this.category2Label = new Krypton.Toolkit.KryptonLabel();
            this.Category3ComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.priceCategory3Label = new Krypton.Toolkit.KryptonLabel();
            this.category3Label = new Krypton.Toolkit.KryptonLabel();
            this.totalLabel = new Krypton.Toolkit.KryptonLabel();
            this.priceLabel = new Krypton.Toolkit.KryptonLabel();
            this.countTicket = new Krypton.Toolkit.KryptonLabel();
            this.proceedButton = new Krypton.Toolkit.KryptonButton();
            this.Category1ComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.favouriteTeam = new Krypton.Toolkit.KryptonLabel();
            this.closeButton = new Krypton.Toolkit.KryptonButton();
            this.resetButton = new Krypton.Toolkit.KryptonButton();
            this.calculateButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Category2ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category3ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category1ComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // talaButton
            // 
            this.talaButton.Location = new System.Drawing.Point(125, 62);
            this.talaButton.Name = "talaButton";
            this.talaButton.Size = new System.Drawing.Size(190, 190);
            this.talaButton.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("talaButton.StateNormal.Back.Image")));
            this.talaButton.StateNormal.Border.Rounding = 100F;
            this.talaButton.TabIndex = 0;
            this.talaButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.talaButton.Values.Text = "";
            this.talaButton.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // enppiButton
            // 
            this.enppiButton.Location = new System.Drawing.Point(713, 62);
            this.enppiButton.Name = "enppiButton";
            this.enppiButton.Size = new System.Drawing.Size(190, 190);
            this.enppiButton.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("enppiButton.StateNormal.Back.Image")));
            this.enppiButton.StateNormal.Border.Rounding = 100F;
            this.enppiButton.TabIndex = 1;
            this.enppiButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.enppiButton.Values.Text = "";
            this.enppiButton.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(458, 260);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(114, 28);
            this.location.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.location.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.location.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.location.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.TabIndex = 2;
            this.location.Values.Text = "City, Cairo";
            // 
            // Stadium
            // 
            this.Stadium.Location = new System.Drawing.Point(428, 206);
            this.Stadium.Name = "Stadium";
            this.Stadium.Size = new System.Drawing.Size(182, 28);
            this.Stadium.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.Stadium.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.Stadium.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.Stadium.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stadium.TabIndex = 3;
            this.Stadium.Values.Text = " Gezah El Reyada";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(428, 309);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(188, 28);
            this.date.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.date.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.date.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.date.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.TabIndex = 4;
            this.date.Values.Text = "Thu 17 April 2025";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(453, 343);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(157, 24);
            this.time.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.time.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.time.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.time.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.TabIndex = 5;
            this.time.Values.Text = "Time : 04 : 00 Pm";
            // 
            // warrningMessage
            // 
            this.warrningMessage.Location = new System.Drawing.Point(216, 403);
            this.warrningMessage.Name = "warrningMessage";
            this.warrningMessage.Size = new System.Drawing.Size(636, 22);
            this.warrningMessage.StateNormal.ShortText.Color1 = System.Drawing.Color.Green;
            this.warrningMessage.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.warrningMessage.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.warrningMessage.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warrningMessage.TabIndex = 6;
            this.warrningMessage.Values.Text = "This ticket can be used to attend all matches that will be played in this stadium" +
    " on this day.";
            // 
            // category1Label
            // 
            this.category1Label.Location = new System.Drawing.Point(201, 499);
            this.category1Label.Name = "category1Label";
            this.category1Label.Size = new System.Drawing.Size(122, 28);
            this.category1Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.category1Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.category1Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.category1Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category1Label.TabIndex = 7;
            this.category1Label.Values.Text = "CAT1 - Left";
            this.category1Label.Visible = false;
            // 
            // priceCategory1Label
            // 
            this.priceCategory1Label.Location = new System.Drawing.Point(484, 499);
            this.priceCategory1Label.Name = "priceCategory1Label";
            this.priceCategory1Label.Size = new System.Drawing.Size(126, 28);
            this.priceCategory1Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.priceCategory1Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.priceCategory1Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.priceCategory1Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCategory1Label.TabIndex = 8;
            this.priceCategory1Label.Values.Text = "EGP 150.00";
            this.priceCategory1Label.Visible = false;
            // 
            // Category2ComboBox
            // 
            this.Category2ComboBox.DropDownWidth = 47;
            this.Category2ComboBox.Location = new System.Drawing.Point(805, 533);
            this.Category2ComboBox.Name = "Category2ComboBox";
            this.Category2ComboBox.Size = new System.Drawing.Size(47, 22);
            this.Category2ComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Category2ComboBox.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category2ComboBox.TabIndex = 12;
            this.Category2ComboBox.Text = "0";
            this.Category2ComboBox.Visible = false;
            // 
            // priceCategory2Label
            // 
            this.priceCategory2Label.Location = new System.Drawing.Point(484, 533);
            this.priceCategory2Label.Name = "priceCategory2Label";
            this.priceCategory2Label.Size = new System.Drawing.Size(126, 28);
            this.priceCategory2Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.priceCategory2Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.priceCategory2Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.priceCategory2Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCategory2Label.TabIndex = 11;
            this.priceCategory2Label.Values.Text = "EGP 100.00";
            this.priceCategory2Label.Visible = false;
            // 
            // category2Label
            // 
            this.category2Label.Location = new System.Drawing.Point(201, 533);
            this.category2Label.Name = "category2Label";
            this.category2Label.Size = new System.Drawing.Size(128, 28);
            this.category2Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.category2Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.category2Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.category2Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category2Label.TabIndex = 10;
            this.category2Label.Values.Text = "CAT 2 - Left";
            this.category2Label.Visible = false;
            // 
            // Category3ComboBox
            // 
            this.Category3ComboBox.DropDownWidth = 47;
            this.Category3ComboBox.Location = new System.Drawing.Point(805, 573);
            this.Category3ComboBox.Name = "Category3ComboBox";
            this.Category3ComboBox.Size = new System.Drawing.Size(47, 22);
            this.Category3ComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Category3ComboBox.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category3ComboBox.TabIndex = 15;
            this.Category3ComboBox.Text = "0";
            this.Category3ComboBox.Visible = false;
            // 
            // priceCategory3Label
            // 
            this.priceCategory3Label.Location = new System.Drawing.Point(484, 567);
            this.priceCategory3Label.Name = "priceCategory3Label";
            this.priceCategory3Label.Size = new System.Drawing.Size(114, 28);
            this.priceCategory3Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.priceCategory3Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.priceCategory3Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.priceCategory3Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCategory3Label.TabIndex = 14;
            this.priceCategory3Label.Values.Text = "EGP 75.00";
            this.priceCategory3Label.Visible = false;
            // 
            // category3Label
            // 
            this.category3Label.Location = new System.Drawing.Point(201, 567);
            this.category3Label.Name = "category3Label";
            this.category3Label.Size = new System.Drawing.Size(128, 28);
            this.category3Label.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.category3Label.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.category3Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.category3Label.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category3Label.TabIndex = 13;
            this.category3Label.Values.Text = "CAT 3 - Left";
            this.category3Label.Visible = false;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(201, 629);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 28);
            this.totalLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.totalLabel.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.totalLabel.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.totalLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Values.Text = "Total";
            this.totalLabel.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(484, 629);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(114, 28);
            this.priceLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.priceLabel.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.priceLabel.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.priceLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Values.Text = "EGP 00.00";
            this.priceLabel.Visible = false;
            // 
            // countTicket
            // 
            this.countTicket.Location = new System.Drawing.Point(805, 629);
            this.countTicket.Name = "countTicket";
            this.countTicket.Size = new System.Drawing.Size(25, 28);
            this.countTicket.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.countTicket.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.countTicket.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.countTicket.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTicket.TabIndex = 18;
            this.countTicket.Values.Text = "0";
            this.countTicket.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(191, 698);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(132, 34);
            this.proceedButton.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.proceedButton.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.proceedButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.proceedButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.proceedButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.TabIndex = 19;
            this.proceedButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.proceedButton.Values.Text = "Proceed";
            this.proceedButton.Visible = false;
            this.proceedButton.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // Category1ComboBox
            // 
            this.Category1ComboBox.DropDownWidth = 47;
            this.Category1ComboBox.Location = new System.Drawing.Point(805, 499);
            this.Category1ComboBox.Name = "Category1ComboBox";
            this.Category1ComboBox.Size = new System.Drawing.Size(47, 22);
            this.Category1ComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Category1ComboBox.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category1ComboBox.TabIndex = 9;
            this.Category1ComboBox.Text = "0";
            this.Category1ComboBox.Visible = false;
            // 
            // favouriteTeam
            // 
            this.favouriteTeam.Location = new System.Drawing.Point(341, 62);
            this.favouriteTeam.Name = "favouriteTeam";
            this.favouriteTeam.Size = new System.Drawing.Size(386, 38);
            this.favouriteTeam.StateCommon.ShortText.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteTeam.StateNormal.ShortText.Color1 = System.Drawing.Color.Green;
            this.favouriteTeam.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.favouriteTeam.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.favouriteTeam.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteTeam.TabIndex = 20;
            this.favouriteTeam.Values.Text = "Select your favourite team ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(771, 698);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 34);
            this.closeButton.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.closeButton.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.closeButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.closeButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.closeButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.TabIndex = 21;
            this.closeButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.closeButton.Values.Text = "Close";
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(484, 698);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 34);
            this.resetButton.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.resetButton.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.resetButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.resetButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.resetButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.TabIndex = 22;
            this.resetButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.resetButton.Values.Text = "Reset";
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(874, 623);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(132, 34);
            this.calculateButton.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.calculateButton.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.calculateButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.calculateButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.calculateButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.TabIndex = 23;
            this.calculateButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.calculateButton.Values.Text = "calculate";
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 770);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.favouriteTeam);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.countTicket);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.Category3ComboBox);
            this.Controls.Add(this.priceCategory3Label);
            this.Controls.Add(this.category3Label);
            this.Controls.Add(this.Category2ComboBox);
            this.Controls.Add(this.priceCategory2Label);
            this.Controls.Add(this.category2Label);
            this.Controls.Add(this.Category1ComboBox);
            this.Controls.Add(this.priceCategory1Label);
            this.Controls.Add(this.category1Label);
            this.Controls.Add(this.warrningMessage);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Stadium);
            this.Controls.Add(this.location);
            this.Controls.Add(this.enppiButton);
            this.Controls.Add(this.talaButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Category2ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category3ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category1ComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton talaButton;
        private Krypton.Toolkit.KryptonButton enppiButton;
        private Krypton.Toolkit.KryptonLabel location;
        private Krypton.Toolkit.KryptonLabel Stadium;
        private Krypton.Toolkit.KryptonLabel date;
        private Krypton.Toolkit.KryptonLabel time;
        private Krypton.Toolkit.KryptonLabel warrningMessage;
        private Krypton.Toolkit.KryptonLabel category1Label;
        private Krypton.Toolkit.KryptonLabel priceCategory1Label;
        private Krypton.Toolkit.KryptonComboBox Category2ComboBox;
        private Krypton.Toolkit.KryptonLabel priceCategory2Label;
        private Krypton.Toolkit.KryptonLabel category2Label;
        private Krypton.Toolkit.KryptonComboBox Category3ComboBox;
        private Krypton.Toolkit.KryptonLabel priceCategory3Label;
        private Krypton.Toolkit.KryptonLabel category3Label;
        private Krypton.Toolkit.KryptonLabel totalLabel;
        private Krypton.Toolkit.KryptonLabel priceLabel;
        private Krypton.Toolkit.KryptonLabel countTicket;
        private Krypton.Toolkit.KryptonButton proceedButton;
        private Krypton.Toolkit.KryptonComboBox Category1ComboBox;
        private Krypton.Toolkit.KryptonLabel favouriteTeam;
        private Krypton.Toolkit.KryptonButton closeButton;
        private Krypton.Toolkit.KryptonButton resetButton;
        private Krypton.Toolkit.KryptonButton calculateButton;
    }
}