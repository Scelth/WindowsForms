﻿namespace DZ
{
    partial class Form1
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.adressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.skillTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 15;
            this.peopleListBox.Location = new System.Drawing.Point(572, 0);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(228, 450);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.peopleListBox_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.adressLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.skillLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adressTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.skillTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.20588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.79412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // adressLabel
            // 
            this.adressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(122, 139);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(42, 15);
            this.adressLabel.TabIndex = 3;
            this.adressLabel.Text = "Adress";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(112, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Full Name";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(127, 81);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 15);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // skillLabel
            // 
            this.skillLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(126, 198);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(33, 15);
            this.skillLabel.TabIndex = 4;
            this.skillLabel.Text = "Skills";
            // 
            // addButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.addButton, 2);
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 236);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(566, 33);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(289, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTextBox.Location = new System.Drawing.Point(289, 77);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(280, 23);
            this.dateTextBox.TabIndex = 7;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adressTextBox.Location = new System.Drawing.Point(289, 135);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(280, 23);
            this.adressTextBox.TabIndex = 8;
            // 
            // skillTextBox
            // 
            this.skillTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skillTextBox.Location = new System.Drawing.Point(289, 194);
            this.skillTextBox.Name = "skillTextBox";
            this.skillTextBox.Size = new System.Drawing.Size(280, 23);
            this.skillTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.peopleListBox);
            this.Name = "Form1";
            this.Text = "1.1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox peopleListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label adressLabel;
        private Label nameLabel;
        private Label dateLabel;
        private Label skillLabel;
        private Button addButton;
        private TextBox nameTextBox;
        private TextBox dateTextBox;
        private TextBox adressTextBox;
        private TextBox skillTextBox;
    }
}