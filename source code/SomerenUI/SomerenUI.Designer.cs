﻿namespace SomerenUI {
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
            drankjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachers = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            pnlDrankjes = new System.Windows.Forms.Panel();
            listViewDrankjes = new System.Windows.Forms.ListView();
            naamTb = new System.Windows.Forms.TextBox();
            prijsTb = new System.Windows.Forms.TextBox();
            btwTb = new System.Windows.Forms.TextBox();
            stockTb = new System.Windows.Forms.TextBox();
            naam = new System.Windows.Forms.Label();
            prijs = new System.Windows.Forms.Label();
            btw = new System.Windows.Forms.Label();
            stock = new System.Windows.Forms.Label();
            create = new System.Windows.Forms.Button();
            change = new System.Windows.Forms.Button();
            delete = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlDrankjes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drankjesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
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
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(13, 13);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(16, 42);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(766, 307);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(12, 27);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(938, 466);
            pnlTeachers.TabIndex = 2;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Location = new System.Drawing.Point(16, 42);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(766, 307);
            listViewTeachers.TabIndex = 1;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label1);
            pnlRooms.Location = new System.Drawing.Point(12, 27);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(938, 466);
            pnlRooms.TabIndex = 2;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(16, 42);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(766, 307);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // pnlDrankjes
            // 
            pnlDrankjes.Controls.Add(listViewDrankjes);
            pnlDrankjes.Controls.Add(naamTb);
            pnlDrankjes.Controls.Add(prijsTb);
            pnlDrankjes.Controls.Add(btwTb);
            pnlDrankjes.Controls.Add(stockTb);
            pnlDrankjes.Controls.Add(naam);
            pnlDrankjes.Controls.Add(prijs);
            pnlDrankjes.Controls.Add(btw);
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
            naamTb.Location = new System.Drawing.Point(200, 200);
            naamTb.Name = "naamTb";
            naamTb.Size = new System.Drawing.Size(100, 23);
            naamTb.TabIndex = 4;
            // 
            // prijsTb
            // 
            prijsTb.Location = new System.Drawing.Point(200, 240);
            prijsTb.Name = "prijsTb";
            prijsTb.Size = new System.Drawing.Size(100, 23);
            prijsTb.TabIndex = 4;
            // 
            // btwTb
            // 
            btwTb.Location = new System.Drawing.Point(200, 280);
            btwTb.Name = "btwTb";
            btwTb.Size = new System.Drawing.Size(100, 23);
            btwTb.TabIndex = 4;
            // 
            // stockTb
            // 
            stockTb.Location = new System.Drawing.Point(200, 320);
            stockTb.Name = "stockTb";
            stockTb.Size = new System.Drawing.Size(100, 23);
            stockTb.TabIndex = 4;
            // 
            // naam
            // 
            naam.AutoSize = true;
            naam.Location = new System.Drawing.Point(100, 200);
            naam.Name = "naam";
            naam.Size = new System.Drawing.Size(37, 15);
            naam.TabIndex = 3;
            naam.Text = "naam";
            // 
            // prijs
            // 
            prijs.AutoSize = true;
            prijs.Location = new System.Drawing.Point(100, 240);
            prijs.Name = "prijs";
            prijs.Size = new System.Drawing.Size(29, 15);
            prijs.TabIndex = 3;
            prijs.Text = "prijs";
            // 
            // btw
            // 
            btw.AutoSize = true;
            btw.Location = new System.Drawing.Point(100, 280);
            btw.Name = "btw";
            btw.Size = new System.Drawing.Size(27, 15);
            btw.TabIndex = 3;
            btw.Text = "btw";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new System.Drawing.Point(100, 320);
            stock.Name = "stock";
            stock.Size = new System.Drawing.Size(35, 15);
            stock.TabIndex = 3;
            stock.Text = "stock";
            // 
            // create
            // 
            create.Location = new System.Drawing.Point(100, 160);
            create.Name = "create";
            create.Size = new System.Drawing.Size(75, 23);
            create.TabIndex = 2;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += createButton_Click;
            // 
            // change
            // 
            change.Location = new System.Drawing.Point(200, 160);
            change.Name = "change";
            change.Size = new System.Drawing.Size(75, 23);
            change.TabIndex = 2;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            create.Click += changeButton_Click;
            // 
            // delete
            // 
            delete.Location = new System.Drawing.Point(300, 160);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            create.Click += deleteButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDrankjes);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
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
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlDrankjes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listViewDrankjes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Label prijs;
        private System.Windows.Forms.Label btw;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox naamTb;
        private System.Windows.Forms.TextBox prijsTb;
        private System.Windows.Forms.TextBox btwTb;
        private System.Windows.Forms.TextBox stockTb;
    }
}