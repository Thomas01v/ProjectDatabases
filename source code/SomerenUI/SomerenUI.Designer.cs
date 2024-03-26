﻿using SomerenModel;

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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            pnlDrankjes = new System.Windows.Forms.Panel();
            listViewDrankjes = new System.Windows.Forms.ListView();
            naamTb = new System.Windows.Forms.TextBox();
            inkoopTb = new System.Windows.Forms.TextBox();
            prijsTb = new System.Windows.Forms.TextBox();
            btwTb = new System.Windows.Forms.TextBox();
            inkoopPrijsTb = new System.Windows.Forms.TextBox();
            stockTb = new System.Windows.Forms.TextBox();
            naam = new System.Windows.Forms.Label();
            inkoop = new System.Windows.Forms.Label();
            prijs = new System.Windows.Forms.Label();
            btw = new System.Windows.Forms.Label();
            inkoopPrijs = new System.Windows.Forms.Label();
            stock = new System.Windows.Forms.Label();
            create = new System.Windows.Forms.Button();
            change = new System.Windows.Forms.Button();
            delete = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            DrinkOrderSubmitButton = new System.Windows.Forms.Button();
            DrinkOrderResultLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTeachers.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlDrinkOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkOrderAmountBox).BeginInit();
            pnlDrankjes.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drankjesToolStripMenuItem, drinkOrderToolStripMenuItem });
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
            // drankjesToolStripMenuItem
            // 
            drankjesToolStripMenuItem.Name = "drankjesToolStripMenuItem";
            drankjesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
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
            drankjesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
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
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
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
            // pnlDrankjes
            // 
            pnlDrankjes.Controls.Add(listViewDrankjes);
            pnlDrankjes.Controls.Add(naamTb);
            pnlDrankjes.Controls.Add(inkoopTb);
            pnlDrankjes.Controls.Add(prijsTb);
            pnlDrankjes.Controls.Add(btwTb);
            pnlDrankjes.Controls.Add(inkoopPrijsTb);
            pnlDrankjes.Controls.Add(stockTb);
            pnlDrankjes.Controls.Add(naam);
            pnlDrankjes.Controls.Add(inkoop);
            pnlDrankjes.Controls.Add(prijs);
            pnlDrankjes.Controls.Add(btw);
            pnlDrankjes.Controls.Add(inkoopPrijs);
            pnlDrankjes.Controls.Add(stock);
            pnlDrankjes.Controls.Add(create);
            pnlDrankjes.Controls.Add(change);
            pnlDrankjes.Controls.Add(delete);
            pnlDrankjes.Location = new System.Drawing.Point(12, 27);
            pnlDrankjes.Name = "pnlDrankjes";
            pnlDrankjes.Size = new System.Drawing.Size(938, 466);
            pnlDrankjes.TabIndex = 2;
            // 
            // listViewDrankjes
            // 
            listViewDrankjes.Location = new System.Drawing.Point(16, 42);
            listViewDrankjes.Name = "listViewDrankjes";
            listViewDrankjes.Size = new System.Drawing.Size(766, 100);
            listViewDrankjes.TabIndex = 1;
            listViewDrankjes.UseCompatibleStateImageBehavior = false;
            listViewDrankjes.Click += drankjesListView_Click;
            // 
            // naamTb
            // 
            naamTb.Location = new System.Drawing.Point(200, 290);
            naamTb.Name = "naamTb";
            naamTb.Size = new System.Drawing.Size(100, 23);
            naamTb.TabIndex = 4;
            // 
            // naamTb
            // 
            inkoopTb.Location = new System.Drawing.Point(200, 330);
            inkoopTb.Name = "inkoopTb";
            inkoopTb.Size = new System.Drawing.Size(100, 23);
            inkoopTb.TabIndex = 4;
            // 
            // prijsTb
            // 
            prijsTb.Location = new System.Drawing.Point(200, 370);
            prijsTb.Name = "prijsTb";
            prijsTb.Size = new System.Drawing.Size(100, 23);
            prijsTb.TabIndex = 4;
            // 
            // inkoopprijsTb
            // 
            inkoopPrijsTb.Location = new System.Drawing.Point(200, 450);
            inkoopPrijsTb.Name = "inkoopPrijsTb";
            inkoopPrijsTb.Size = new System.Drawing.Size(100, 23);
            inkoopPrijsTb.TabIndex = 4;
            // 
            // btwTb
            // 
            btwTb.Location = new System.Drawing.Point(200, 410);
            btwTb.Name = "btwTb";
            btwTb.Size = new System.Drawing.Size(100, 23);
            btwTb.TabIndex = 4;
            // 
            // stockTb
            // 
            stockTb.Location = new System.Drawing.Point(200, 490);
            stockTb.Name = "stockTb";
            stockTb.Size = new System.Drawing.Size(100, 23);
            stockTb.TabIndex = 4;
            // 
            // naam
            // 
            naam.AutoSize = true;
            naam.Location = new System.Drawing.Point(100, 290);
            naam.Name = "naam";
            naam.Size = new System.Drawing.Size(37, 15);
            naam.TabIndex = 3;
            naam.Text = "naam";
            // 
            // inkoop
            // 
            inkoop.AutoSize = true;
            inkoop.Location = new System.Drawing.Point(100, 330);
            inkoop.Name = "inkoop";
            inkoop.Size = new System.Drawing.Size(37, 15);
            inkoop.TabIndex = 3;
            inkoop.Text = "inkoop";
            // 
            // prijs
            // 
            prijs.AutoSize = true;
            prijs.Location = new System.Drawing.Point(100, 370);
            prijs.Name = "prijs";
            prijs.Size = new System.Drawing.Size(29, 15);
            prijs.TabIndex = 3;
            prijs.Text = "prijs";
            // 
            // btw
            // 
            btw.AutoSize = true;
            btw.Location = new System.Drawing.Point(100, 410);
            btw.Name = "btw";
            btw.Size = new System.Drawing.Size(27, 15);
            btw.TabIndex = 3;
            btw.Text = "btw";
            // 
            // inkoopPrijs
            // 
            inkoopPrijs.AutoSize = true;
            inkoopPrijs.Location = new System.Drawing.Point(100, 450);
            inkoopPrijs.Name = "inkoopPrijs";
            inkoopPrijs.Size = new System.Drawing.Size(27, 15);
            inkoopPrijs.TabIndex = 3;
            inkoopPrijs.Text = "inkoopPrijs";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new System.Drawing.Point(100, 490);
            stock.Name = "stock";
            stock.Size = new System.Drawing.Size(35, 15);
            stock.TabIndex = 3;
            stock.Text = "stock";
            // 
            // create
            // 
            create.Location = new System.Drawing.Point(100, 250);
            create.Name = "create";
            create.Size = new System.Drawing.Size(75, 30);
            create.TabIndex = 2;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += createButton_Click;
            // 
            // change
            // 
            change.Location = new System.Drawing.Point(200, 250);
            change.Name = "change";
            change.Size = new System.Drawing.Size(75, 30);
            change.TabIndex = 2;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            change.Click += changeButton_Click;
            // 
            // delete
            // 
            delete.Location = new System.Drawing.Point(300, 250);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(75, 30);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += deleteButton_Click;
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
            listViewDrinkOrderStudents.Location = new System.Drawing.Point(21, 75);
            listViewDrinkOrderStudents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewDrinkOrderStudents.Name = "listViewDrinkOrderStudents";
            listViewDrinkOrderStudents.Size = new System.Drawing.Size(999, 135);
            listViewDrinkOrderStudents.TabIndex = 1;
            listViewDrinkOrderStudents.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderStudents.Click += drinkOrderStudentListViewItem_Click;
            listViewDrinkOrderStudents.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderStudents.FullRowSelect = true;
            // 
            // listViewDrinkOrderDrinks
            // 
            listViewDrinkOrderDrinks.Location = new System.Drawing.Point(21, 227);
            listViewDrinkOrderDrinks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewDrinkOrderDrinks.Name = "listViewDrinkOrderDrinks";
            listViewDrinkOrderDrinks.Size = new System.Drawing.Size(999, 135);
            listViewDrinkOrderDrinks.TabIndex = 1;
            listViewDrinkOrderDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderDrinks.Click += drinkOrderDrinkListViewItem_Click;
            listViewDrinkOrderDrinks.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderDrinks.FullRowSelect = true;
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
            DrinkOrderPriceLabel.Size = new System.Drawing.Size(44, 28);
            DrinkOrderPriceLabel.TabIndex = 0;
            DrinkOrderPriceLabel.Text = "Selecteer een Student, drankje en hoeveelheid";
            //
            // DrinkOrderSubmitButton
            //
            DrinkOrderSubmitButton.Location = new System.Drawing.Point(21, 473);
            DrinkOrderSubmitButton.Size = new System.Drawing.Size(128, 32);
            DrinkOrderSubmitButton.Text = "submit order";
            DrinkOrderSubmitButton.Click += drinkOrderSubmit_Click;
            //
            // DrinkOrderResultLabel
            //
            DrinkOrderResultLabel.AutoSize = true;
            DrinkOrderResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkOrderResultLabel.Location = new System.Drawing.Point(21, 519);
            DrinkOrderResultLabel.Name = "DrinkOrderPriceLabel";
            DrinkOrderResultLabel.Size = new System.Drawing.Size(44, 28);
            DrinkOrderResultLabel.TabIndex = 0;
            DrinkOrderResultLabel.Text = "";
            // 
            // pnlDrankjes
            // 
            pnlDrankjes.Controls.Add(listViewDrankjes);
            pnlDrankjes.Location = new System.Drawing.Point(14, 36);
            pnlDrankjes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrankjes.Name = "pnlDrankjes";
            pnlDrankjes.Size = new System.Drawing.Size(1072, 621);
            pnlDrankjes.TabIndex = 2;
            // 
            // listViewDrankjes
            // 
            listViewDrankjes.Location = new System.Drawing.Point(18, 56);
            listViewDrankjes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrankjes.Name = "listViewDrankjes";
            listViewDrankjes.Size = new System.Drawing.Size(875, 150);
            listViewDrankjes.TabIndex = 1;
            listViewDrankjes.UseCompatibleStateImageBehavior = false;
            listViewDrankjes.View = System.Windows.Forms.View.Details;
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
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);

            pnlTeachers.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            pnlDrankjes.ResumeLayout(false);
            pnlDrankjes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            pnlDrinkOrder.ResumeLayout(false);
            pnlDrinkOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkOrderAmountBox).EndInit();
            
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listViewDrinkOrderStudents;
        private System.Windows.Forms.ListView listViewDrinkOrderDrinks;
        private System.Windows.Forms.ListView listViewDrankjes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Label inkoop;
        private System.Windows.Forms.Label prijs;
        private System.Windows.Forms.Label btw;
        private System.Windows.Forms.Label inkoopPrijs;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox naamTb;
        private System.Windows.Forms.TextBox inkoopTb;
        private System.Windows.Forms.TextBox prijsTb;
        private System.Windows.Forms.TextBox btwTb;
        private System.Windows.Forms.TextBox inkoopPrijsTb;
        private System.Windows.Forms.TextBox stockTb;

    }
}