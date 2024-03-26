﻿using System;

namespace SomerenUI {
    partial class SomerenUI {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drankjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            listViewStudents = new System.Windows.Forms.ListView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachers = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            pnlDrinkOrder = new System.Windows.Forms.Panel();
            listViewDrinkOrderStudents = new System.Windows.Forms.ListView();
            listViewDrinkOrderDrinks = new System.Windows.Forms.ListView();
            DrinkOrderAmountBox = new System.Windows.Forms.NumericUpDown();
            DrinkOrderPriceLabel = new System.Windows.Forms.Label();
            DrinkOrderSubmitButton = new System.Windows.Forms.Button();
            DrinkOrderResultLabel = new System.Windows.Forms.Label();
            pnlDrankjes = new System.Windows.Forms.Panel();
            listViewDrankjes = new System.Windows.Forms.ListView();
            pnlRevenueReport = new System.Windows.Forms.Panel();
            amountOfSales = new System.Windows.Forms.Label();
            firstDate = new System.Windows.Forms.DateTimePicker();
            lastDate = new System.Windows.Forms.DateTimePicker();
            button1 = new System.Windows.Forms.Button();
            turnoverLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTeachers.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlDrinkOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkOrderAmountBox).BeginInit();
            pnlRevenueReport.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, revenueReportToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1099, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            revenueReportToolStripMenuItem.Text = "Revenue report";
            revenueReportToolStripMenuItem.Click += revenueReportToolStripMenuItem_Click;
            // 
            // drinkOrderToolStripMenuItem
            // 
            drinkOrderToolStripMenuItem.Name = "drinkOrderToolStripMenuItem";
            drinkOrderToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            drinkOrderToolStripMenuItem.Text = "Drink order";
            drinkOrderToolStripMenuItem.Click += drinkOrderToolStripMenuItem_Click;
            // 
            // drankjesToolStripMenuItem
            // 
            drankjesToolStripMenuItem.Name = "drankjesToolStripMenuItem";
            drankjesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            drankjesToolStripMenuItem.Text = "Drankjes";
            drankjesToolStripMenuItem.Click += drankjesToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(21, 75);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(999, 543);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(16, 48);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1225, 828);
            pnlTeachers.TabIndex = 2;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Location = new System.Drawing.Point(21, 75);
            listViewTeachers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(999, 543);
            listViewTeachers.TabIndex = 1;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(16, 48);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1225, 828);
            pnlRooms.TabIndex = 2;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(21, 75);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(999, 543);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // pnlDrinkOrder
            // 
            pnlDrinkOrder.Controls.Add(listViewDrinkOrderStudents);
            pnlDrinkOrder.Controls.Add(listViewDrinkOrderDrinks);
            pnlDrinkOrder.Controls.Add(DrinkOrderAmountBox);
            pnlDrinkOrder.Controls.Add(DrinkOrderPriceLabel);
            pnlDrinkOrder.Controls.Add(DrinkOrderSubmitButton);
            pnlDrinkOrder.Controls.Add(DrinkOrderResultLabel);
            pnlDrinkOrder.Controls.Add(label1);
            pnlDrinkOrder.Location = new System.Drawing.Point(16, 48);
            pnlDrinkOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pnlDrinkOrder.Name = "pnlDrinkOrder";
            pnlDrinkOrder.Size = new System.Drawing.Size(1225, 828);
            pnlDrinkOrder.TabIndex = 2;
            // 
            // listViewDrinkOrderStudents
            // 
            listViewDrinkOrderStudents.FullRowSelect = true;
            listViewDrinkOrderStudents.Location = new System.Drawing.Point(21, 75);
            listViewDrinkOrderStudents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewDrinkOrderStudents.Name = "listViewDrinkOrderStudents";
            listViewDrinkOrderStudents.Size = new System.Drawing.Size(999, 135);
            listViewDrinkOrderStudents.TabIndex = 1;
            listViewDrinkOrderStudents.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderStudents.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderStudents.Click += drinkOrderStudentListViewItem_Click;
            // 
            // listViewDrinkOrderDrinks
            // 
            listViewDrinkOrderDrinks.FullRowSelect = true;
            listViewDrinkOrderDrinks.Location = new System.Drawing.Point(21, 227);
            listViewDrinkOrderDrinks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewDrinkOrderDrinks.Name = "listViewDrinkOrderDrinks";
            listViewDrinkOrderDrinks.Size = new System.Drawing.Size(999, 135);
            listViewDrinkOrderDrinks.TabIndex = 1;
            listViewDrinkOrderDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderDrinks.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderDrinks.Click += drinkOrderDrinkListViewItem_Click;
            // 
            // DrinkOrderAmountBox
            // 
            DrinkOrderAmountBox.Location = new System.Drawing.Point(21, 379);
            DrinkOrderAmountBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DrinkOrderAmountBox.Name = "DrinkOrderAmountBox";
            DrinkOrderAmountBox.Size = new System.Drawing.Size(143, 27);
            DrinkOrderAmountBox.TabIndex = 3;
            DrinkOrderAmountBox.ValueChanged += drinkOrderNumericUpDownValueChanged;
            // 
            // DrinkOrderPriceLabel
            // 
            DrinkOrderPriceLabel.AutoSize = true;
            DrinkOrderPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkOrderPriceLabel.Location = new System.Drawing.Point(21, 431);
            DrinkOrderPriceLabel.Name = "DrinkOrderPriceLabel";
            DrinkOrderPriceLabel.Size = new System.Drawing.Size(411, 28);
            DrinkOrderPriceLabel.TabIndex = 0;
            DrinkOrderPriceLabel.Text = "Selecteer een Student, drankje en hoeveelheid";
            // 
            // DrinkOrderSubmitButton
            // 
            DrinkOrderSubmitButton.Location = new System.Drawing.Point(21, 473);
            DrinkOrderSubmitButton.Name = "DrinkOrderSubmitButton";
            DrinkOrderSubmitButton.Size = new System.Drawing.Size(128, 32);
            DrinkOrderSubmitButton.TabIndex = 4;
            DrinkOrderSubmitButton.Text = "submit order";
            DrinkOrderSubmitButton.Click += drinkOrderSubmit_Click;
            // 
            // DrinkOrderResultLabel
            // 
            DrinkOrderResultLabel.AutoSize = true;
            DrinkOrderResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkOrderResultLabel.Location = new System.Drawing.Point(21, 519);
            DrinkOrderResultLabel.Name = "DrinkOrderResultLabel";
            DrinkOrderResultLabel.Size = new System.Drawing.Size(0, 28);
            DrinkOrderResultLabel.TabIndex = 0;
            // 
            // pnlDrankjes
            // 
            pnlDrankjes.Location = new System.Drawing.Point(0, 0);
            pnlDrankjes.Name = "pnlDrankjes";
            pnlDrankjes.Size = new System.Drawing.Size(200, 100);
            pnlDrankjes.TabIndex = 3;
            // 
            // listViewDrankjes
            // 
            listViewDrankjes.Location = new System.Drawing.Point(18, 56);
            listViewDrankjes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrankjes.Name = "listViewDrankjes";
            listViewDrankjes.Size = new System.Drawing.Size(875, 408);
            listViewDrankjes.TabIndex = 1;
            listViewDrankjes.UseCompatibleStateImageBehavior = false;
            listViewDrankjes.View = System.Windows.Forms.View.Details;
            // 
            // pnlRevenueReport
            // 
            pnlRevenueReport.Controls.Add(amountOfSales);
            pnlRevenueReport.Controls.Add(turnoverLabel);
            pnlRevenueReport.Controls.Add(firstDate);
            pnlRevenueReport.Controls.Add(lastDate);
            pnlRevenueReport.Controls.Add(button1);
            pnlRevenueReport.Location = new System.Drawing.Point(14, 36);
            pnlRevenueReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRevenueReport.Name = "pnlRevenueReport";
            pnlRevenueReport.Size = new System.Drawing.Size(1072, 621);
            pnlRevenueReport.TabIndex = 2;
            // 
            // amountOfSales
            // 
            amountOfSales.AutoSize = true;
            amountOfSales.Location = new System.Drawing.Point(45, 154);
            amountOfSales.Name = "amountOfSales";
            amountOfSales.Size = new System.Drawing.Size(0, 20);
            amountOfSales.TabIndex = 3;
            // 
            // firstDate
            // 
            firstDate.Location = new System.Drawing.Point(45, 67);
            firstDate.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            firstDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            firstDate.Name = "firstDate";
            firstDate.Size = new System.Drawing.Size(250, 27);
            firstDate.TabIndex = 2;
            firstDate.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            firstDate.ValueChanged += onFirstDateValueChange;
            // 
            // lastDate
            // 
            lastDate.Location = new System.Drawing.Point(45, 124);
            lastDate.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            lastDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            lastDate.Name = "lastDate";
            lastDate.Size = new System.Drawing.Size(250, 27);
            lastDate.TabIndex = 2;
            lastDate.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            lastDate.ValueChanged += onLastDateValueChange;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(777, 138);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // turnoverLabel
            // 
            turnoverLabel.AutoSize = true;
            turnoverLabel.Location = new System.Drawing.Point(45, 239);
            turnoverLabel.Name = "getTheTurnover";
            turnoverLabel.Size = new System.Drawing.Size(50, 20);
            turnoverLabel.TabIndex = 2;
            turnoverLabel.Text = $"";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDrankjes);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlDrinkOrder);
            Controls.Add(pictureBox1);
            Controls.Add(pnlRevenueReport);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTeachers.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlDrinkOrder.ResumeLayout(false);
            pnlDrinkOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkOrderAmountBox).EndInit();
            pnlRevenueReport.ResumeLayout(false);
            pnlRevenueReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drankjesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkOrderToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlDrinkOrder;
        private System.Windows.Forms.NumericUpDown DrinkOrderAmountBox;
        private System.Windows.Forms.Label DrinkOrderPriceLabel;
        private System.Windows.Forms.Label DrinkOrderResultLabel;
        private System.Windows.Forms.Button DrinkOrderSubmitButton;
        private System.Windows.Forms.Panel pnlDrankjes;
        private System.Windows.Forms.Panel pnlRevenueReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listRevenueReport;
        private System.Windows.Forms.ListView listViewDrinkOrderStudents;
        private System.Windows.Forms.ListView listViewDrinkOrderDrinks;
        private System.Windows.Forms.ListView listViewDrankjes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.DateTimePicker lastDate;
        private System.Windows.Forms.Label amountOfSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turnoverLabel;
    }
}