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

        private void ShowDashboardPanel() {
            // hide all other panels
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel() {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            } catch (Exception e) {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowTeachersPanel() {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();

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

        private void DisplayStudents(List<Student> students) {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem($"{student.studentnummer} {student.voornaam} {student.achternaam} {student.telefoonnummer} {student.klas}");
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }

        private void ShowRoomPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlStudents.Hide();

            // show rooms
            pnlRooms.Show();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.kamernummer);
                li.Tag = room;   // link rooms object to listview item
                listViewRooms.Items.Add(li);
            }
        }

        
        private void DisplayTeachers(List<Teacher> teachers) {
            // clear the listview before filling it
            listViewTeachers.Clear(); 
            int test = teachers.Count;

            foreach (Teacher teacher in teachers) {
                ListViewItem li = new ListViewItem(teacher.naam);
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

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowTeachersPanel();
        }
    }
}