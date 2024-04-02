using System;
using System.Windows.Forms;

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
            kamernummer = new System.Windows.Forms.Label();
            klas = new System.Windows.Forms.Label();
            telefoonnummer = new System.Windows.Forms.Label();
            achternaam = new System.Windows.Forms.Label();
            voornaam = new System.Windows.Forms.Label();
            createStudent = new System.Windows.Forms.Button();
            changeStudent = new System.Windows.Forms.Button();
            deleteStudent = new System.Windows.Forms.Button();
            listViewStudents = new System.Windows.Forms.ListView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachersActivities = new System.Windows.Forms.ListView();
            listViewTeachersSupervisors = new System.Windows.Forms.ListView();
            listViewTeachersNonSupervisors = new System.Windows.Forms.ListView();
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
            listViewDrankjes = new System.Windows.Forms.ListView();
            voornaamTb = new System.Windows.Forms.TextBox();
            achternaamTb = new System.Windows.Forms.TextBox();
            telefoonnummerTb = new System.Windows.Forms.TextBox();
            klasTb = new System.Windows.Forms.TextBox();
            kamernummerTb = new System.Windows.Forms.TextBox();
            listViewDrankjes = new System.Windows.Forms.ListView();
            pnlRevenueReport = new System.Windows.Forms.Panel();
            amountOfSales = new System.Windows.Forms.Label();
            firstDate = new System.Windows.Forms.DateTimePicker();
            lastDate = new System.Windows.Forms.DateTimePicker();
            button1 = new System.Windows.Forms.Button();
            turnoverLabel = new System.Windows.Forms.Label();
            AddBegeleiderButton = new System.Windows.Forms.Button();
            RemoveBegeleiderButton = new System .Windows.Forms.Button();
            BegeleidersLabel = new System.Windows.Forms.Label();
            NonBegeleidersLabel = new System.Windows.Forms.Label();

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
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drankjesToolStripMenuItem, drinkOrderToolStripMenuItem, revenueReportToolStripMenuItem });
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
            pnlStudents.Controls.Add(kamernummerTb);
            pnlStudents.Controls.Add(klasTb);
            pnlStudents.Controls.Add(telefoonnummerTb);
            pnlStudents.Controls.Add(achternaamTb);
            pnlStudents.Controls.Add(voornaamTb);
            pnlStudents.Controls.Add(kamernummer);
            pnlStudents.Controls.Add(klas);
            pnlStudents.Controls.Add(telefoonnummer);
            pnlStudents.Controls.Add(achternaam);
            pnlStudents.Controls.Add(voornaam);
            pnlStudents.Controls.Add(createStudent);
            pnlStudents.Controls.Add(changeStudent);
            pnlStudents.Controls.Add(deleteStudent);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            // 
            // kamernummer
            // 
            kamernummer.AutoSize = true;
            kamernummer.Location = new System.Drawing.Point(88, 338);
            kamernummer.Name = "kamernummer";
            kamernummer.Size = new System.Drawing.Size(86, 15);
            kamernummer.TabIndex = 9;
            kamernummer.Text = "kamernummer";
            // 
            // klas
            // 
            klas.AutoSize = true;
            klas.Location = new System.Drawing.Point(88, 308);
            klas.Name = "klas";
            klas.Size = new System.Drawing.Size(27, 15);
            klas.TabIndex = 8;
            klas.Text = "klas";
            // 
            // telefoonnummer
            // 
            telefoonnummer.AutoSize = true;
            telefoonnummer.Location = new System.Drawing.Point(88, 278);
            telefoonnummer.Name = "telefoonnummer";
            telefoonnummer.Size = new System.Drawing.Size(97, 15);
            telefoonnummer.TabIndex = 7;
            telefoonnummer.Text = "telefoonnummer";
            // 
            // achternaam
            // 
            achternaam.AutoSize = true;
            achternaam.Location = new System.Drawing.Point(88, 248);
            achternaam.Name = "achternaam";
            achternaam.Size = new System.Drawing.Size(70, 15);
            achternaam.TabIndex = 6;
            achternaam.Text = "achternaam";
            // 
            // voornaam
            // 
            voornaam.AutoSize = true;
            voornaam.Location = new System.Drawing.Point(88, 218);
            voornaam.Name = "voornaam";
            voornaam.Size = new System.Drawing.Size(61, 15);
            voornaam.TabIndex = 5;
            voornaam.Text = "voornaam";
            // 
            // voornaamTb
            // 
            voornaamTb.Location = new System.Drawing.Point(200, 218);
            voornaamTb.Name = "voornaamTb";
            voornaamTb.Size = new System.Drawing.Size(100, 23);
            voornaamTb.TabIndex = 10;
            voornaamTb.TextChanged += valueIsChanged;
            // 
            // achternaamTb
            // 
            achternaamTb.Location = new System.Drawing.Point(200, 248);
            achternaamTb.Name = "achternaamTb";
            achternaamTb.Size = new System.Drawing.Size(100, 23);
            achternaamTb.TabIndex = 11;
            achternaamTb.TextChanged += valueIsChanged;
            // 
            // telefoonnummerTb
            // 
            telefoonnummerTb.Location = new System.Drawing.Point(200, 278);
            telefoonnummerTb.Name = "telefoonnummerTb";
            telefoonnummerTb.Size = new System.Drawing.Size(100, 23);
            telefoonnummerTb.TabIndex = 12;
            // 
            // klasTb
            // 
            klasTb.Location = new System.Drawing.Point(200, 308);
            klasTb.Name = "klasTb";
            klasTb.Size = new System.Drawing.Size(100, 23);
            klasTb.TabIndex = 13;
            klasTb.TextChanged += valueIsChanged;
            // 
            // kamernummerTb
            // 
            kamernummerTb.Location = new System.Drawing.Point(200, 338);
            kamernummerTb.Name = "kamernummerTb";
            kamernummerTb.Size = new System.Drawing.Size(100, 23);
            kamernummerTb.TabIndex = 14;
            kamernummerTb.TextChanged += valueIsChanged;
            // 
            // createStudent
            // 
            createStudent.Location = new System.Drawing.Point(80, 188);
            createStudent.Name = "createStudent";
            createStudent.Size = new System.Drawing.Size(100, 23);
            createStudent.TabIndex = 2;
            createStudent.Text = "create student";
            createStudent.UseVisualStyleBackColor = true;
            createStudent.Click += createStudent_Click;
            createStudent.Enabled = false;
            // 
            // changeStudent
            // 
            changeStudent.Location = new System.Drawing.Point(200, 188);
            changeStudent.Name = "changeStudent";
            changeStudent.Size = new System.Drawing.Size(100, 23);
            changeStudent.TabIndex = 3;
            changeStudent.Text = "change student";
            changeStudent.UseVisualStyleBackColor = true;
            changeStudent.Click += changeStudent_Click;
            changeStudent.Enabled = false;
            // 
            // deleteStudent
            // 
            deleteStudent.Location = new System.Drawing.Point(320, 188);
            deleteStudent.Name = "deleteStudent";
            deleteStudent.Size = new System.Drawing.Size(100, 23);
            deleteStudent.TabIndex = 4;
            deleteStudent.Text = "delete student";
            deleteStudent.UseVisualStyleBackColor = true;
            deleteStudent.Click += deleteStudent_Click;
            deleteStudent.Enabled = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 114);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            listViewStudents.FullRowSelect = true;
            listViewStudents.ColumnClick += ListView_ColumnClick;
            listViewStudents.SelectedIndexChanged += listViewStudent_indexChanged;

            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachersActivities);
            pnlTeachers.Controls.Add(listViewTeachersSupervisors);
            pnlTeachers.Controls.Add(listViewTeachersNonSupervisors);
            pnlTeachers.Controls.Add(AddBegeleiderButton);
            pnlTeachers.Controls.Add(RemoveBegeleiderButton);
            pnlTeachers.Controls.Add(BegeleidersLabel);
            pnlTeachers.Controls.Add(NonBegeleidersLabel);
            pnlTeachers.Location = new System.Drawing.Point(14, 36);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1072, 621);
            pnlTeachers.TabIndex = 2;
            // 
            // listViewTeachersActivities
            // 
            listViewTeachersActivities.Location = new System.Drawing.Point(18, 56);
            listViewTeachersActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachersActivities.Name = "listViewTeachersActivities";
            listViewTeachersActivities.Size = new System.Drawing.Size(875, 102);
            listViewTeachersActivities.TabIndex = 1;
            listViewTeachersActivities.UseCompatibleStateImageBehavior = false;
            listViewTeachersActivities.View = System.Windows.Forms.View.Details;
            listViewTeachersActivities.FullRowSelect = true;
            listViewTeachersActivities.SelectedIndexChanged += teacherActiviteit_IndexChanged;
            listViewTeachersActivities.ColumnClick += ListView_ColumnClick;
            // 
            // listViewTeachersSupervisors
            // 
            listViewTeachersSupervisors.Location = new System.Drawing.Point(593, 206);
            listViewTeachersSupervisors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachersSupervisors.Name = "listViewTeachersSupervisors";
            listViewTeachersSupervisors.Size = new System.Drawing.Size(300, 204);
            listViewTeachersSupervisors.TabIndex = 1;
            listViewTeachersSupervisors.UseCompatibleStateImageBehavior = false;
            listViewTeachersSupervisors.View = System.Windows.Forms.View.Details;
            listViewTeachersSupervisors.FullRowSelect = true;
            listViewTeachersSupervisors.SelectedIndexChanged += listViewTeachersSupervisors_IndexChanged;
            listViewTeachersSupervisors.ColumnClick += ListView_ColumnClick;
            // 
            // listViewTeachersNonSupervisors
            // 
            listViewTeachersNonSupervisors.Location = new System.Drawing.Point(18, 206);
            listViewTeachersNonSupervisors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachersNonSupervisors.Name = "listViewTeachersNonSupervisors";
            listViewTeachersNonSupervisors.Size = new System.Drawing.Size(300, 204);
            listViewTeachersNonSupervisors.TabIndex = 1;
            listViewTeachersNonSupervisors.UseCompatibleStateImageBehavior = false;
            listViewTeachersNonSupervisors.View = System.Windows.Forms.View.Details;
            listViewTeachersNonSupervisors.FullRowSelect = true;
            listViewTeachersNonSupervisors.SelectedIndexChanged += listViewTeachersNonSupervisors_IndexChanged;
            listViewTeachersNonSupervisors.ColumnClick += ListView_ColumnClick;
            // 
            // AddBegeleiderButton
            // 
            AddBegeleiderButton.Location = new System.Drawing.Point(18, 424);
            AddBegeleiderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AddBegeleiderButton.Name = "AddBegeleiderButton";
            AddBegeleiderButton.Size = new System.Drawing.Size(224, 24);
            AddBegeleiderButton.Text = "Voeg begeleider toe";
            AddBegeleiderButton.Click += AddBegeleiderButton_Click;
            AddBegeleiderButton.Enabled = false;
            // 
            // RemoveBegeleiderButton
            // 
            RemoveBegeleiderButton.Location = new System.Drawing.Point(593, 424);
            RemoveBegeleiderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            RemoveBegeleiderButton.Name = "RemoveBegeleiderButton";
            RemoveBegeleiderButton.Size = new System.Drawing.Size(224, 24);
            RemoveBegeleiderButton.Text = "Haal begeleider weg";
            RemoveBegeleiderButton.Click += RemoveBegeleiderButton_Click;
            RemoveBegeleiderButton.Enabled = false;
            // 
            // BegeleidersLabel
            // 
            BegeleidersLabel.AutoSize = true;
            BegeleidersLabel.Location = new System.Drawing.Point(593, 172);
            BegeleidersLabel.Name = "BegeleidersLabel";
            BegeleidersLabel.Size = new System.Drawing.Size(128, 20);
            BegeleidersLabel.Text = $"Begeleiders";
            // 
            // NonBegeleidersLabel
            // 
            NonBegeleidersLabel.AutoSize = true;
            NonBegeleidersLabel.Location = new System.Drawing.Point(18, 172);
            NonBegeleidersLabel.Name = "NonBegeleidersLabel";
            NonBegeleidersLabel.Size = new System.Drawing.Size(128, 20);
            NonBegeleidersLabel.Text = $"Geen Begeleiders";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(14, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 621);
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
            listViewRooms.View = System.Windows.Forms.View.Details;
            listViewRooms.ColumnClick += ListView_ColumnClick;
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
            pnlDrinkOrder.Location = new System.Drawing.Point(14, 36);
            pnlDrinkOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrinkOrder.Name = "pnlDrinkOrder";
            pnlDrinkOrder.Size = new System.Drawing.Size(1072, 621);
            pnlDrinkOrder.TabIndex = 2;
            // 
            // listViewDrinkOrderStudents
            // 
            listViewDrinkOrderStudents.FullRowSelect = true;
            listViewDrinkOrderStudents.Location = new System.Drawing.Point(18, 56);
            listViewDrinkOrderStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinkOrderStudents.Name = "listViewDrinkOrderStudents";
            listViewDrinkOrderStudents.Size = new System.Drawing.Size(875, 102);
            listViewDrinkOrderStudents.TabIndex = 1;
            listViewDrinkOrderStudents.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderStudents.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderStudents.SelectedIndexChanged += drinkOrderStudentListViewItem_IndexChanged;
            listViewDrinkOrderStudents.ColumnClick += ListView_ColumnClick;
            // 
            // listViewDrinkOrderDrinks
            // 
            listViewDrinkOrderDrinks.FullRowSelect = true;
            listViewDrinkOrderDrinks.Location = new System.Drawing.Point(21, 172);
            listViewDrinkOrderDrinks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listViewDrinkOrderDrinks.Name = "listViewDrinkOrderDrinks";
            listViewDrinkOrderDrinks.Size = new System.Drawing.Size(875, 102);
            listViewDrinkOrderDrinks.TabIndex = 1;
            listViewDrinkOrderDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrderDrinks.View = System.Windows.Forms.View.Details;
            listViewDrinkOrderDrinks.SelectedIndexChanged += drinkOrderDrinkListViewItem_IndexChanged;
            listViewDrinkOrderDrinks.ColumnClick += ListView_ColumnClick;
            // 
            // DrinkOrderAmountBox
            // 
            DrinkOrderAmountBox.Location = new System.Drawing.Point(18, 284);
            DrinkOrderAmountBox.Name = "DrinkOrderAmountBox";
            DrinkOrderAmountBox.Size = new System.Drawing.Size(125, 23);
            DrinkOrderAmountBox.TabIndex = 3;
            DrinkOrderAmountBox.ValueChanged += drinkOrderNumericUpDownValueChanged;
            // 
            // DrinkOrderPriceLabel
            // 
            DrinkOrderPriceLabel.AutoSize = true;
            DrinkOrderPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkOrderPriceLabel.Location = new System.Drawing.Point(18, 323);
            DrinkOrderPriceLabel.Name = "DrinkOrderPriceLabel";
            DrinkOrderPriceLabel.Size = new System.Drawing.Size(327, 21);
            DrinkOrderPriceLabel.TabIndex = 0;
            DrinkOrderPriceLabel.Text = drinkOrderDefaultMessage;
            // 
            // DrinkOrderSubmitButton
            // 
            DrinkOrderSubmitButton.Location = new System.Drawing.Point(18, 355);
            DrinkOrderSubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DrinkOrderSubmitButton.Name = "DrinkOrderSubmitButton";
            DrinkOrderSubmitButton.Size = new System.Drawing.Size(112, 24);
            DrinkOrderSubmitButton.TabIndex = 4;
            DrinkOrderSubmitButton.TabIndex = 4;
            DrinkOrderSubmitButton.Text = "submit order";
            DrinkOrderSubmitButton.Click += drinkOrderSubmit_Click;
            DrinkOrderSubmitButton.Enabled = false;
            // 
            // DrinkOrderResultLabel
            // 
            DrinkOrderResultLabel.AutoSize = true;
            DrinkOrderResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkOrderResultLabel.Location = new System.Drawing.Point(18, 389);
            DrinkOrderResultLabel.Name = "DrinkOrderResultLabel";
            DrinkOrderResultLabel.Size = new System.Drawing.Size(0, 21);
            DrinkOrderResultLabel.TabIndex = 0;
            // 
            // pnlDrankjes
            // 
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
            pnlDrankjes.Controls.Add(listViewDrankjes);
            pnlDrankjes.Location = new System.Drawing.Point(12, 27);
            pnlDrankjes.Name = "pnlDrankjes";
            pnlDrankjes.Size = new System.Drawing.Size(938, 466);
            pnlDrankjes.TabIndex = 2;
            // 
            // naamTb
            // 
            naamTb.Location = new System.Drawing.Point(175, 218);
            naamTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            naamTb.Name = "naamTb";
            naamTb.Size = new System.Drawing.Size(88, 23);
            naamTb.TabIndex = 4;
            // 
            // inkoopTb
            // 
            inkoopTb.Location = new System.Drawing.Point(175, 248);
            inkoopTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inkoopTb.Name = "inkoopTb";
            inkoopTb.Size = new System.Drawing.Size(88, 23);
            inkoopTb.TabIndex = 4;
            // 
            // prijsTb
            // 
            prijsTb.Location = new System.Drawing.Point(175, 278);
            prijsTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            prijsTb.Name = "prijsTb";
            prijsTb.Size = new System.Drawing.Size(88, 23);
            prijsTb.TabIndex = 4;
            // 
            // btwTb
            // 
            btwTb.Location = new System.Drawing.Point(175, 308);
            btwTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btwTb.Name = "btwTb";
            btwTb.Size = new System.Drawing.Size(88, 23);
            btwTb.TabIndex = 4;
            // 
            // inkoopPrijsTb
            // 
            inkoopPrijsTb.Location = new System.Drawing.Point(175, 338);
            inkoopPrijsTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inkoopPrijsTb.Name = "inkoopPrijsTb";
            inkoopPrijsTb.Size = new System.Drawing.Size(88, 23);
            inkoopPrijsTb.TabIndex = 4;
            // 
            // stockTb
            // 
            stockTb.Location = new System.Drawing.Point(175, 368);
            stockTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            stockTb.Name = "stockTb";
            stockTb.Size = new System.Drawing.Size(88, 23);
            stockTb.TabIndex = 4;
            // 
            // naam
            // 
            naam.AutoSize = true;
            naam.Location = new System.Drawing.Point(88, 218);
            naam.Name = "naam";
            naam.Size = new System.Drawing.Size(37, 15);
            naam.TabIndex = 3;
            naam.Text = "naam";
            // 
            // inkoop
            // 
            inkoop.AutoSize = true;
            inkoop.Location = new System.Drawing.Point(88, 248);
            inkoop.Name = "inkoop";
            inkoop.Size = new System.Drawing.Size(44, 15);
            inkoop.TabIndex = 3;
            inkoop.Text = "inkoop";
            // 
            // prijs
            // 
            prijs.AutoSize = true;
            prijs.Location = new System.Drawing.Point(88, 278);
            prijs.Name = "prijs";
            prijs.Size = new System.Drawing.Size(29, 15);
            prijs.TabIndex = 3;
            prijs.Text = "prijs";
            // 
            // btw
            // 
            btw.AutoSize = true;
            btw.Location = new System.Drawing.Point(88, 308);
            btw.Name = "btw";
            btw.Size = new System.Drawing.Size(27, 15);
            btw.TabIndex = 3;
            btw.Text = "btw";
            // 
            // inkoopPrijs
            // 
            inkoopPrijs.AutoSize = true;
            inkoopPrijs.Location = new System.Drawing.Point(88, 338);
            inkoopPrijs.Name = "inkoopPrijs";
            inkoopPrijs.Size = new System.Drawing.Size(66, 15);
            inkoopPrijs.TabIndex = 3;
            inkoopPrijs.Text = "inkoopPrijs";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new System.Drawing.Point(88, 368);
            stock.Name = "stock";
            stock.Size = new System.Drawing.Size(35, 15);
            stock.TabIndex = 3;
            stock.Text = "stock";
            // 
            // create
            // 
            create.Location = new System.Drawing.Point(88, 188);
            create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            create.Name = "create";
            create.Size = new System.Drawing.Size(66, 22);
            create.TabIndex = 2;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += createButton_Click;
            // 
            // change
            // 
            change.Location = new System.Drawing.Point(175, 188);
            change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            change.Name = "change";
            change.Size = new System.Drawing.Size(66, 22);
            change.TabIndex = 2;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            change.Click += changeButton_Click;
            // 
            // delete
            // 
            delete.Location = new System.Drawing.Point(262, 188);
            delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(66, 22);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += deleteButton_Click;
            // 
            // listViewDrankjes
            // 
            listViewDrankjes.Location = new System.Drawing.Point(16, 42);
            listViewDrankjes.Name = "listViewDrankjes";
            listViewDrankjes.Size = new System.Drawing.Size(766, 114);
            listViewDrankjes.TabIndex = 1;
            listViewDrankjes.UseCompatibleStateImageBehavior = false;
            listViewDrankjes.View = System.Windows.Forms.View.Details;
            listViewDrankjes.Click += drankjesListView_Click;
            listViewDrankjes.ColumnClick += ListView_ColumnClick;
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
            firstDate.MaxDate = DateTime.Today;
            firstDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            firstDate.Name = "firstDate";
            firstDate.Size = new System.Drawing.Size(250, 27);
            firstDate.TabIndex = 2;
            firstDate.Value = DateTime.Today;
            firstDate.ValueChanged += onFirstDateValueChange;
            // 
            // lastDate
            // 
            lastDate.Location = new System.Drawing.Point(45, 124);
            lastDate.MaxDate = DateTime.Today;
            lastDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            lastDate.Name = "lastDate";
            lastDate.Size = new System.Drawing.Size(250, 27);
            lastDate.TabIndex = 2;
            lastDate.Value = DateTime.Today;
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
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
            pnlDrankjes.ResumeLayout(false);
            pnlDrankjes.PerformLayout();
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
        private System.Windows.Forms.ListView listViewTeachersActivities;
        private System.Windows.Forms.ListView listViewTeachersSupervisors;
        private System.Windows.Forms.ListView listViewTeachersNonSupervisors;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listRevenueReport;
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
        private System.Windows.Forms.Button createStudent;
        private System.Windows.Forms.Button changeStudent;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Label kamernummer;
        private System.Windows.Forms.Label klas;
        private System.Windows.Forms.Label telefoonnummer;
        private System.Windows.Forms.Label achternaam;
        private System.Windows.Forms.Label voornaam;
        private System.Windows.Forms.TextBox kamernummerTb;
        private System.Windows.Forms.TextBox klasTb;
        private System.Windows.Forms.TextBox telefoonnummerTb;
        private System.Windows.Forms.TextBox achternaamTb;
        private System.Windows.Forms.TextBox voornaamTb;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.DateTimePicker lastDate;
        private System.Windows.Forms.Label amountOfSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turnoverLabel;
        private System.Windows.Forms.Button AddBegeleiderButton;
        private System.Windows.Forms.Button RemoveBegeleiderButton;
        private System.Windows.Forms.Label BegeleidersLabel;
        private System.Windows.Forms.Label NonBegeleidersLabel;
    }
}