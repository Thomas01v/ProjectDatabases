using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

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

            foreach (Drankje drankje in drankjes) {

                ListViewItem li = new ListViewItem($"{drankje.dranknaam} {drankje.type} {drankje.verkoopprijs:0.00} {drankje.voorraad}");
                li.Tag = drankje;   // link drankje object to listview item
                displayView.Items.Add(li);
            }
        }

        private void DisplayStudents(List<Student> students, ListView displayView) {
            // clear the listview before filling it
            displayView.Clear();

            foreach (Student student in students) {
                ListViewItem li = new ListViewItem($"{student.studentnummer} {student.voornaam} {student.achternaam} {student.telefoonnummer} {student.klas}");
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
            if (listViewDrinkOrderDrinks.SelectedItems.Count > 0 && listViewDrinkOrderStudents.SelectedItems.Count > 0) {
                Drankje drankje = (Drankje)listViewDrinkOrderDrinks.SelectedItems[0].Tag;
                Student student = (Student)listViewDrinkOrderStudents.SelectedItems[0].Tag;
                int amount = (int)DrinkOrderAmountBox.Value;

                decimal price = drankje.verkoopprijs * amount;
                DrinkOrderPriceLabel.Text = $"Student {student.naam} orders {amount} {drankje.dranknaam} for € {price:0.00}";
            }

        }

        private void SubmitOrder() {
            int amount = (int)DrinkOrderAmountBox.Value;
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
                DrinkOrderResultLabel.Text = orderService.createOrder(newOrder);
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

            foreach (Room room in rooms) {
                ListViewItem li = new ListViewItem($"{room.kamernummer}, {room.roomType}");
                li.Tag = room;   // link rooms object to listview item
                listViewRooms.Items.Add(li);
            }
        }


        private void DisplayTeachers(List<Teacher> teachers) {
            // clear the listview before filling it
            listViewTeachers.Clear();
            int test = teachers.Count;

            foreach (Teacher teacher in teachers) {
                int age = (int)(DateTime.Today.Subtract(teacher.geboortedatum).Days / 365.25);
                ListViewItem li = new ListViewItem($"{teacher.naam}, 0{teacher.telefoonnummer}, {age}");
                li.Tag = teacher;   // link student object to listview item
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