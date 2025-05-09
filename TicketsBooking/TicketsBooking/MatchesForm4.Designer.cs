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
    partial class MatchesForm4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label match_IDLabel;
            System.Windows.Forms.Label team1Label;
            System.Windows.Forms.Label team2Label;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label remaining_TicketsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesForm4));
            this.matchesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.matchesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.match_IDTextBox = new System.Windows.Forms.TextBox();
            this.team1TextBox = new System.Windows.Forms.TextBox();
            this.team2TextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.remaining_TicketsTextBox = new System.Windows.Forms.TextBox();
            this.ticket_Number = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new TicketsBooking.Database1DataSet();
            this.matchesTableAdapter = new TicketsBooking.Database1DataSetTableAdapters.matchesTableAdapter();
            this.tableAdapterManager = new TicketsBooking.Database1DataSetTableAdapters.TableAdapterManager();
            match_IDLabel = new System.Windows.Forms.Label();
            team1Label = new System.Windows.Forms.Label();
            team2Label = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            remaining_TicketsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingNavigator)).BeginInit();
            this.matchesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // match_IDLabel
            // 
            match_IDLabel.AutoSize = true;
            match_IDLabel.Location = new System.Drawing.Point(409, 176);
            match_IDLabel.Name = "match_IDLabel";
            match_IDLabel.Size = new System.Drawing.Size(54, 13);
            match_IDLabel.TabIndex = 2;
            match_IDLabel.Text = "Match ID:";
            // 
            // team1Label
            // 
            team1Label.AutoSize = true;
            team1Label.Location = new System.Drawing.Point(409, 202);
            team1Label.Name = "team1Label";
            team1Label.Size = new System.Drawing.Size(43, 13);
            team1Label.TabIndex = 4;
            team1Label.Text = "Team1:";
            // 
            // team2Label
            // 
            team2Label.AutoSize = true;
            team2Label.Location = new System.Drawing.Point(409, 228);
            team2Label.Name = "team2Label";
            team2Label.Size = new System.Drawing.Size(43, 13);
            team2Label.TabIndex = 6;
            team2Label.Text = "Team2:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(409, 254);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // remaining_TicketsLabel
            // 
            remaining_TicketsLabel.AutoSize = true;
            remaining_TicketsLabel.Location = new System.Drawing.Point(409, 280);
            remaining_TicketsLabel.Name = "remaining_TicketsLabel";
            remaining_TicketsLabel.Size = new System.Drawing.Size(98, 13);
            remaining_TicketsLabel.TabIndex = 10;
            remaining_TicketsLabel.Text = "Remaining Tickets:";
            // 
            // matchesBindingNavigator
            // 
            this.matchesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.matchesBindingNavigator.BindingSource = this.matchesBindingSource;
            this.matchesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.matchesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.matchesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.matchesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.matchesBindingNavigatorSaveItem});
            this.matchesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.matchesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.matchesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.matchesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.matchesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.matchesBindingNavigator.Name = "matchesBindingNavigator";
            this.matchesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.matchesBindingNavigator.Size = new System.Drawing.Size(1031, 25);
            this.matchesBindingNavigator.TabIndex = 0;
            this.matchesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // matchesBindingNavigatorSaveItem
            // 
            this.matchesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matchesBindingNavigatorSaveItem.Enabled = false;
            this.matchesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matchesBindingNavigatorSaveItem.Image")));
            this.matchesBindingNavigatorSaveItem.Name = "matchesBindingNavigatorSaveItem";
            this.matchesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.matchesBindingNavigatorSaveItem.Text = "Save Data";
            this.matchesBindingNavigatorSaveItem.Click += new System.EventHandler(this.matchesBindingNavigatorSaveItem_Click);
            // 
            // match_IDTextBox
            // 
            this.match_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchesBindingSource, "Match_ID", true));
            this.match_IDTextBox.Location = new System.Drawing.Point(513, 173);
            this.match_IDTextBox.Name = "match_IDTextBox";
            this.match_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.match_IDTextBox.TabIndex = 3;
            // 
            // team1TextBox
            // 
            this.team1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchesBindingSource, "Team1", true));
            this.team1TextBox.Location = new System.Drawing.Point(513, 199);
            this.team1TextBox.Name = "team1TextBox";
            this.team1TextBox.Size = new System.Drawing.Size(100, 20);
            this.team1TextBox.TabIndex = 5;
            // 
            // team2TextBox
            // 
            this.team2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchesBindingSource, "Team2", true));
            this.team2TextBox.Location = new System.Drawing.Point(513, 225);
            this.team2TextBox.Name = "team2TextBox";
            this.team2TextBox.Size = new System.Drawing.Size(100, 20);
            this.team2TextBox.TabIndex = 7;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchesBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(513, 251);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 9;
            // 
            // remaining_TicketsTextBox
            // 
            this.remaining_TicketsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchesBindingSource, "Remaining_Tickets", true));
            this.remaining_TicketsTextBox.Location = new System.Drawing.Point(513, 277);
            this.remaining_TicketsTextBox.Name = "remaining_TicketsTextBox";
            this.remaining_TicketsTextBox.Size = new System.Drawing.Size(100, 20);
            this.remaining_TicketsTextBox.TabIndex = 11;
            // 
            // ticket_Number
            // 
            this.ticket_Number.AutoSize = true;
            this.ticket_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_Number.Location = new System.Drawing.Point(406, 64);
            this.ticket_Number.Name = "ticket_Number";
            this.ticket_Number.Size = new System.Drawing.Size(93, 33);
            this.ticket_Number.TabIndex = 2;
            this.ticket_Number.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "matches";
            this.matchesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.matchesTableAdapter = this.matchesTableAdapter;
            this.tableAdapterManager.UpdateOrder = TicketsBooking.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MatchesForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(match_IDLabel);
            this.Controls.Add(this.match_IDTextBox);
            this.Controls.Add(team1Label);
            this.Controls.Add(this.team1TextBox);
            this.Controls.Add(team2Label);
            this.Controls.Add(this.team2TextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(remaining_TicketsLabel);
            this.Controls.Add(this.remaining_TicketsTextBox);
            this.Controls.Add(this.ticket_Number);
            this.Controls.Add(this.matchesBindingNavigator);
            this.Name = "MatchesForm4";
            this.Text = "MatchesForm4";
            this.Load += new System.EventHandler(this.MatchesForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingNavigator)).EndInit();
            this.matchesBindingNavigator.ResumeLayout(false);
            this.matchesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private Database1DataSetTableAdapters.matchesTableAdapter matchesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator matchesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton matchesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox match_IDTextBox;
        private System.Windows.Forms.TextBox team1TextBox;
        private System.Windows.Forms.TextBox team2TextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox remaining_TicketsTextBox;
        private System.Windows.Forms.Label ticket_Number;
        private System.Windows.Forms.Button button1;
    }
}
