using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing.Text;

namespace SomerenUI {
    public partial class SomerenUI : Form {
        public SomerenUI() {
            InitializeComponent();
        }

        private void hideAllPanels() {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrankjes.Hide();
            pnlDrinkOrder.Hide();
        }

        private void ShowDashboardPanel() {
            // hide all other panels
            hideAllPanels();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel() {
            // hide all other panels
            hideAllPanels();

            // show students
            pnlStudents.Show();

            try {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students, listViewStudents);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowTeachersPanel() {
            // hide all other panels
            hideAllPanels();

            // show teachers
            pnlTeachers.Show();

            try {
                // get and display all teachers
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private void ShowDrankjePanel() {
            // hide all other panels
            hideAllPanels();

            // show drankjes
            pnlDrankjes.Show();

            try {
                // get and display all drankjes
                List<Drankje> drankjes = GetDrankjes();
                DisplayDrankjes(drankjes, listViewDrankjes);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the drankjes: " + e.Message);
            }
        }
        private List<Student> GetStudents() {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Teacher> GetTeachers() {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private List<Drankje> GetDrankjes() {
            DrankjeService drankjeService = new DrankjeService();
            List<Drankje> drankjes = drankjeService.GetDrankjes();
            return drankjes;
        }

        private void DisplayDrankjes(List<Drankje> drankjes, ListView displayView) {
            // clear the listview before filling it

            displayView.Clear();

            displayView.Columns.Add("dranknaam", 256);
            displayView.Columns.Add("soort", 128);
            displayView.Columns.Add("verkoopprijs", 128);
            displayView.Columns.Add("voorraad", 128);

            foreach (Drankje drankje in drankjes) {

                ListViewItem li = new ListViewItem(new[] { drankje.dranknaam, drankje.type.ToString(), $"\u20AC {drankje.verkoopprijs:0.00}", drankje.voorraad.ToString() });

                li.Tag = drankje;   // link drankje object to listview item
                displayView.Items.Add(li);
            }
        }

        private void DisplayStudents(List<Student> students, ListView displayView) {
            // clear the listview before filling it
            displayView.Clear();

            displayView.Columns.Add("studentnummer", 128);
            displayView.Columns.Add("naam", 256);
            displayView.Columns.Add("telefoonnummer", 256);
            displayView.Columns.Add("klas", 128);

            foreach (Student student in students) {
                string telefoonnummer;
                if (student.telefoonnummer != 0) {
                    telefoonnummer = $"0{student.telefoonnummer}";
                }else {
                    telefoonnummer = "-";
                }
                ListViewItem li = new ListViewItem(new[] { student.studentnummer.ToString(), student.naam,telefoonnummer, student.klas.ToString() });
                li.Tag = student;   // link student object to listview item
                displayView.Items.Add(li);
            }
        }

        private void ShowRoomPanel() {
            // hide all other panels
            hideAllPanels();

            // show rooms
            pnlRooms.Show();

            try {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void ShowDrinkOrderPanel() {
            // hide all other panels
            hideAllPanels();

            // show drink order dialogue
            pnlDrinkOrder.Show();

            try {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students, listViewDrinkOrderStudents);
                // get and display all drinks
                List<Drankje> drankjes = GetDrankjes();
                DisplayDrankjes(drankjes, listViewDrinkOrderDrinks);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the drink order dialog: " + e.Message);
            }
        }

        private void UpdateOrderPrice() {
            //check if required data is selected
            if (listViewDrinkOrderDrinks.SelectedItems.Count > 0 && listViewDrinkOrderStudents.SelectedItems.Count > 0) {
                Drankje drankje = (Drankje)listViewDrinkOrderDrinks.SelectedItems[0].Tag;
                Student student = (Student)listViewDrinkOrderStudents.SelectedItems[0].Tag;
                int amount = (int)DrinkOrderAmountBox.Value;

                decimal price = drankje.verkoopprijs * amount;
                DrinkOrderPriceLabel.Text = $"Student {student.naam} besteld {amount} {drankje.dranknaam} voor � {price:0.00}";
            }

        }

        private void SubmitOrder() {
            int amount = (int)DrinkOrderAmountBox.Value;
            //check if required data is selected
            if (listViewDrinkOrderDrinks.SelectedItems.Count > 0 && listViewDrinkOrderStudents.SelectedItems.Count > 0 && amount > 0) {
                Drankje drankje = (Drankje)listViewDrinkOrderDrinks.SelectedItems[0].Tag;
                Student student = (Student)listViewDrinkOrderStudents.SelectedItems[0].Tag;

                Order newOrder = new Order() {
                    dranknummer = drankje.dranknummer,
                    studentnummer = student.studentnummer,
                    aantal = amount,
                    datum = DateTime.Now
                };

                OrderService orderService = new OrderService();
                string resultmessage;
                if (orderService.createOrder(newOrder)) {
                    resultmessage = $"{drankje.dranknaam} besteld. nieuwe voorraad: {drankje.voorraad - newOrder.aantal}";

                    //refresh the display
                    try {
                        // get and display all drinks
                        List<Drankje> drankjes = GetDrankjes();
                        DisplayDrankjes(drankjes, listViewDrinkOrderDrinks);
                    } catch (Exception e) {
                        MessageBox.Show("Something went wrong while reloading the drink amounts: " + e.Message);
                    }
                    DrinkOrderPriceLabel.Text = "Selecteer een Student, drankje en hoeveelheid";
                } else {
                    resultmessage = $"niet genoeg {drankje.dranknaam} op voorraad. ({drankje.voorraad})";
                }

                DrinkOrderResultLabel.Text = resultmessage;
            }
        }

        private List<Room> GetRooms() {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms) {
            // clear the listview before filling it
            listViewRooms.Clear();

            listViewRooms.Columns.Add("kamernummer", 256);
            listViewRooms.Columns.Add("kamersoort", 128);

            foreach (Room room in rooms) {
                ListViewItem li = new ListViewItem(new[] { room.kamernummer, room.roomType.ToString() });
                li.Tag = room;   // link rooms object to listview item
                listViewRooms.Items.Add(li);
            }
        }


        private void DisplayTeachers(List<Teacher> teachers) {
            // clear the listview before filling it
            listViewTeachers.Clear();

            listViewTeachers.Columns.Add("naam", 256);
            listViewTeachers.Columns.Add("telefoonnummer", 256);
            listViewTeachers.Columns.Add("leeftijd", 128);

            foreach (Teacher teacher in teachers) {
                int age = (int)(DateTime.Today.Subtract(teacher.geboortedatum).Days / 365.25);
                ListViewItem li = new ListViewItem(new[] { teacher.naam, $"0{teacher.telefoonnummer}", age.ToString()});
                li.Tag = teacher;   // link teacher object to listview item
                listViewTeachers.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e) {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e) {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowStudentsPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowRoomPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowTeachersPanel();
        }

        private void drankjesToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowDrankjePanel();
        }

        private void drankjesListView_Click(object sender, EventArgs e)
        {
            displayDrankjeInfo();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateDrankje();
        }

        public void CreateDrankje()
        {
            string naam = naamTb.Text;
            decimal prijs = decimal.Parse(prijsTb.Text);
            int inkoop = int.Parse(inkoopTb.Text);
            double btw = double.Parse(btwTb.Text);
            decimal inkoopPrijs = decimal.Parse(inkoopPrijsTb.Text);
            int voorraad = int.Parse(stockTb.Text);

            Drankje drankje = new Drankje() {dranknaam = naam, inkoop = inkoop, verkoopprijs = prijs, btw = btw, aankoopprijs = inkoopPrijs, voorraad = voorraad};
            DrankjeService drankjeService = new DrankjeService();
            drankjeService.AddDrankje(drankje);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            UpdateDrankje();
        }
        public void UpdateDrankje()
        {
            Object O = listViewDrankjes.SelectedItems[0].Tag;
            if (O.GetType() == typeof(Drankje))
            {
                Drankje drankje = (Drankje)O;
                drankje.dranknaam = naamTb.Text;
                drankje.inkoop = int.Parse(inkoopTb.Text);
                drankje.verkoopprijs = decimal.Parse(prijsTb.Text);
                drankje.btw = double.Parse(btwTb.Text);
                drankje.aankoopprijs = decimal.Parse(inkoopPrijsTb.Text);
                drankje.voorraad = int.Parse(stockTb.Text);

                DrankjeService drankjeService = new DrankjeService();
                drankjeService.updateDrankje(drankje);
            }
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteDrankje();
        }

        public void DeleteDrankje()
        {
            /* TODO exeption gooien als er niks verwijdert wordt*/
            DrankjeService drankjeService = new DrankjeService();
            drankjeService.DeleteDrankje((Drankje)listViewDrankjes.SelectedItems[0].Tag);
        }
        private void displayDrankjeInfo()
        {
            Object O = listViewDrankjes.SelectedItems[0].Tag;
            if (O.GetType() == typeof(Drankje))
            {
                Drankje drankje = (Drankje)O;
                naamTb.Text = drankje.dranknaam;
                inkoopTb.Text = $"{drankje.inkoop}";
                prijsTb.Text = $"{drankje.verkoopprijs:F2}";
                btwTb.Text = $"{drankje.btw:F0}";
                inkoopPrijsTb.Text = $"{drankje.aankoopprijs:F2}";
                stockTb.Text = $"{drankje.voorraad}";
            }

        }

        private void drinkOrderToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowDrinkOrderPanel();
        }

        private void drinkOrderNumericUpDownValueChanged(object sender, EventArgs e) {
            UpdateOrderPrice();
        }

        private void drinkOrderDrinkListViewItem_Click(object sender, EventArgs e) {
            UpdateOrderPrice();
        }

        private void drinkOrderStudentListViewItem_Click(object sender, EventArgs e) {
            UpdateOrderPrice();
        }

        private void drinkOrderSubmit_Click(object sender, EventArgs e) {
            SubmitOrder();
        }

    }
}