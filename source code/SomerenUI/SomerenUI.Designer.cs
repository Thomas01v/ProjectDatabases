using System;

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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            drankjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnlRevenueReport = new System.Windows.Forms.Panel();
            firstDate = new System.Windows.Forms.DateTimePicker();
            lastDate = new System.Windows.Forms.DateTimePicker();
            amountOfSales = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlDrankjes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRevenueReport.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, revenueReportToolStripMenuItem });
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
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            revenueReportToolStripMenuItem.Text = "Revenue report";
            revenueReportToolStripMenuItem.Click += revenueReportToolStripMenuItem_Click;
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
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(14, 36);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(938, 466);
            pnlTeachers.TabIndex = 2;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Location = new System.Drawing.Point(18, 56);
            listViewTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(875, 408);
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
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
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
            // pnlRevenueReport
            // 
            pnlRevenueReport.Controls.Add(amountOfSales);
            pnlRevenueReport.Controls.Add(firstDate);
            pnlRevenueReport.Controls.Add(lastDate);
            pnlRevenueReport.Location = new System.Drawing.Point(14, 36);
            pnlRevenueReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRevenueReport.Name = "pnlRevenueReport";
            pnlRevenueReport.Size = new System.Drawing.Size(1072, 621);
            pnlRevenueReport.TabIndex = 2;
            // 
            // firstDate
            // 
            firstDate.Location = new System.Drawing.Point(45, 67);
            firstDate.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            firstDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            firstDate.Name = "firstDate";
            firstDate.Size = new System.Drawing.Size(250, 27);
            firstDate.TabIndex = 2;
            firstDate.ValueChanged += onFirstDateValueChange;
            firstDate.MaxDate = DateTime.Today;
            // 
            // lastDate
            // 
            lastDate.Location = new System.Drawing.Point(45, 124);
            lastDate.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            lastDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            lastDate.Name = "lastDate";
            lastDate.Size = new System.Drawing.Size(250, 27);
            lastDate.TabIndex = 2;
            lastDate.MaxDate = DateTime.Today;
            // 
            // amountOfSales
            // drankjesToolStripMenuItem
            // 
            drankjesToolStripMenuItem.Name = "drankjesToolStripMenuItem";
            drankjesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            drankjesToolStripMenuItem.Text = "Drankjes";
            drankjesToolStripMenuItem.Click += drankjesToolStripMenuItem_Click;
            amountOfSales.AutoSize = true;
            amountOfSales.Location = new System.Drawing.Point(45, 154);
            amountOfSales.Name = "amountOfSales";
            amountOfSales.Size = new System.Drawing.Size(0, 20);
            amountOfSales.TabIndex = 3;
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
            Controls.Add(pnlRevenueReport);
            MainMenuStrip = menuStrip1;
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlDrankjes.ResumeLayout(false);
            pnlTeachers.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRevenueReport.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlRevenueReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listRevenueReport;
        private System.Windows.Forms.ListView listViewDrankjes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.DateTimePicker lastDate;
        private System.Windows.Forms.Label amountOfSales;
    }
}