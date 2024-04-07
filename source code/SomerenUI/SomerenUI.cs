using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace SomerenUI {
    public partial class SomerenUI : Form
    {
        string drinkOrderDefaultMessage = "Selecteer een Student, drankje en hoeveelheid";

        public SomerenUI()
        {
            InitializeComponent();
            hideAllPanels();
            pnlDashboard.Show();
        }

        private void hideAllPanels()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrankjes.Hide();
            pnlDrinkOrder.Hide();
            pnlRevenueReport.Hide();
            pnlActivities.Hide();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            hideAllPanels();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            hideAllPanels();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students, listViewStudents);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowRevenueReportPanel()
        {
            // hide all other panels
            hideAllPanels();

            // Show revenue

            pnlRevenueReport.Show();
        }
        private void ShowActivitiesPanel()
        {

            // hide all other panels
            hideAllPanels();

            // Show activies

            pnlActivities.Show();

            List<Activiteit> activiteiten = GetActiviteiten();
            DisplayActiviteiten(activiteiten, listViewWhatActivities);
        }


        private void ShowTeachersPanel()
        {
            // hide all other panels
            hideAllPanels();

            // show teachers
            pnlTeachers.Show();

            try
            {
                // get and display all activiteiten.
                List<Activiteit> activiteiten = GetActiviteiten();
                DisplayActiviteiten(activiteiten, listViewTeachersActivities);

                //clear the two teacher lists (if data was still in them)
                listViewTeachersSupervisors.Clear();
                listViewTeachersNonSupervisors.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message + '\n' + e.StackTrace);
            }
        }

        private void ShowDrankjePanel()
        {
            // hide all other panels
            hideAllPanels();

            // show drankjes
            pnlDrankjes.Show();

            try
            {
                // get and display all drankjes
                List<Drankje> drankjes = GetDrankjes();
                DisplayDrankjes(drankjes, listViewDrankjes);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drankjes: " + e.Message);
            }
        }
        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Activiteit> GetActiviteiten() {
            ActiviteitService activiteitService = new ActiviteitService();
            List<Activiteit> activiteiten = activiteitService.GetActiviteiten();
            return activiteiten;
        }

        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private List<Drankje> GetDrankjes()
        {
            DrankjeService drankjeService = new DrankjeService();
            List<Drankje> drankjes = drankjeService.GetDrankjes();
            return drankjes;
        }

        private void DisplayDrankjes(List<Drankje> drankjes, ListView displayView)
        {
            // clear the listview before filling it

            displayView.Clear();

            displayView.Columns.Add("dranknaam", 256);
            displayView.Columns.Add("soort", 128);
            displayView.Columns.Add("verkoopprijs", 128);
            displayView.Columns.Add("voorraad", 128);

            foreach (Drankje drankje in drankjes)
            {

                ListViewItem li = new ListViewItem(new[] { drankje.dranknaam, drankje.type.ToString(), $"\u20AC {drankje.verkoopprijs:0.00}", drankje.voorraad.ToString() });

                li.Tag = drankje;   // link drankje object to listview item
                displayView.Items.Add(li);
            }
        }

        private void DisplayStudents(List<Student> students, ListView displayView)
        {
            // clear the listview before filling it
            displayView.Clear();

            displayView.Columns.Add("studentnummer", 128);
            displayView.Columns.Add("naam", 256);
            displayView.Columns.Add("telefoonnummer", 256);
            displayView.Columns.Add("klas", 128);

            foreach (Student student in students)
            {
                string telefoonnummer;
                if (student.telefoonnummer != 0)
                {
                    telefoonnummer = $"0{student.telefoonnummer}";
                }
                else
                {
                    telefoonnummer = "-";
                }
                ListViewItem li = new ListViewItem(new[] { student.studentnummer.ToString(), student.naam, telefoonnummer, student.klas.ToString() });
                li.Tag = student;   // link student object to listview item
                displayView.Items.Add(li);
            }
        }

        private void DisplayActiviteiten(List<Activiteit> activiteiten, ListView displayView) {
            // clear the listview before filling it
            displayView.Clear();

            displayView.Columns.Add("activiteitnaam", 256);
            displayView.Columns.Add("datum", 128);
            displayView.Columns.Add("tijd", 128);

            foreach (Activiteit activiteit in activiteiten) {
                ListViewItem li = new ListViewItem(new[] { activiteit.activiteitnaam, activiteit.datumtijd.ToString("dd-MMMM-yyyy"), activiteit.datumtijd.ToString("HH:mm") });
                li.Tag = activiteit;   // link student object to listview item
                displayView.Items.Add(li);
            }
        }

        private void ShowRoomPanel()
        {
            // hide all other panels
            hideAllPanels();

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

        private void ShowDrinkOrderPanel()
        {
            // hide all other panels
            hideAllPanels();

            // show drink order dialogue
            pnlDrinkOrder.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students, listViewDrinkOrderStudents);
                // get and display all drinks
                List<Drankje> drankjes = GetDrankjes();
                DisplayDrankjes(drankjes, listViewDrinkOrderDrinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drink order dialog: " + e.Message);
            }
        }

        private void UpdateOrderPrice()
        {
            int amount = (int)DrinkOrderAmountBox.Value;
            //check if required data is selected
            if (listViewDrinkOrderDrinks.SelectedItems.Count > 0 && listViewDrinkOrderStudents.SelectedItems.Count > 0 && amount > 0)
            {
                Drankje drankje = (Drankje)listViewDrinkOrderDrinks.SelectedItems[0].Tag;
                Student student = (Student)listViewDrinkOrderStudents.SelectedItems[0].Tag;

                decimal price = drankje.verkoopprijs * amount;
                DrinkOrderPriceLabel.Text = $"Student {student.naam} besteld {amount} {drankje.dranknaam} voor \u20AC {price:0.00}";
                DrinkOrderSubmitButton.Enabled = true;
                DrinkOrderAmountBox.Maximum = drankje.voorraad;
            } else {
                DrinkOrderSubmitButton.Enabled = false;
                DrinkOrderPriceLabel.Text = drinkOrderDefaultMessage;
            }

        }

        private void SubmitOrder()
        {
            int amount = (int)DrinkOrderAmountBox.Value;
            Drankje drankje = (Drankje)listViewDrinkOrderDrinks.SelectedItems[0].Tag;
            Student student = (Student)listViewDrinkOrderStudents.SelectedItems[0].Tag;

            OrderService orderService = new OrderService();
            string resultmessage;
            if (orderService.createOrder(drankje, student, amount)) {
                resultmessage = $"{drankje.dranknaam} besteld.";

                //refresh the display
                try
                {
                    // get and display all drinks
                    List<Drankje> drankjes = GetDrankjes();
                    DisplayDrankjes(drankjes, listViewDrinkOrderDrinks);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while reloading the drink amounts: " + e.Message);
                }

                UpdateOrderPrice();
            }
            else
            {
                resultmessage = $"niet genoeg {drankje.dranknaam} op voorraad. ({drankje.voorraad})";
            }

            DrinkOrderResultLabel.Text = resultmessage;
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

            listViewRooms.Columns.Add("kamernummer", 256);
            listViewRooms.Columns.Add("kamersoort", 128);

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(new[] { room.kamernummer, room.roomType.ToString() });
                li.Tag = room;   // link rooms object to listview item
                listViewRooms.Items.Add(li);
            }
        }


        private void DisplayTeachers(List<Teacher> teachers, ListView displayView)
        {
            // clear the listview before filling it
            displayView.Clear();

            displayView.Columns.Add("naam", 256);
            displayView.Columns.Add("telefoonnummer", 256);
            displayView.Columns.Add("leeftijd", 128);

            foreach (Teacher teacher in teachers)
            {
                int age = (int)(DateTime.Today.Subtract(teacher.geboortedatum).Days / 365.25);
                ListViewItem li = new ListViewItem(new[] { teacher.naam, $"0{teacher.telefoonnummer}", age.ToString() });
                li.Tag = teacher;   // link teacher object to listview item
                displayView.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void ActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void drankjesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            Drankje drankje = new Drankje(-1, naam, inkoop, voorraad, btw, inkoopPrijs, prijs);
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
                int dranknummer = ((Drankje)O).dranknummer;

                Drankje drankje = new Drankje(
                dranknummer,
                naamTb.Text,
                int.Parse(inkoopTb.Text),
                int.Parse(stockTb.Text),
                double.Parse(btwTb.Text),
                decimal.Parse(inkoopPrijsTb.Text),
                decimal.Parse(prijsTb.Text)
                );

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

        private void displayTeachersInActivity() {
            if (listViewTeachersActivities.SelectedItems.Count == 0) {
                return;
            }
            Activiteit activiteit = (Activiteit)listViewTeachersActivities.SelectedItems[0].Tag;
            //display teachers in this activity
            DisplayTeachers(activiteit.begeleiders, listViewTeachersSupervisors);


            //display teachers NOT in this activity
            TeacherService teacherService = new TeacherService();
            List<Teacher> nonBegeleiders = new List<Teacher>();

            List<Teacher> allTeachers = teacherService.GetTeachers();

            foreach (Teacher teacher in allTeachers) {
                if (!activiteit.begeleiders.Contains(teacher)) {
                    nonBegeleiders.Add(teacher);
                }
            }

            DisplayTeachers(nonBegeleiders, listViewTeachersNonSupervisors);
        }

        private void addBegeleider() {
            AddBegeleiderButton.Enabled = false;
            RemoveBegeleiderButton.Enabled = false;
            Activiteit activiteit = (Activiteit)listViewTeachersActivities.SelectedItems[0].Tag;
            Teacher teacher = (Teacher)listViewTeachersNonSupervisors.SelectedItems[0].Tag;

            ActiviteitService activiteitService = new ActiviteitService();
            activiteitService.addBegeleider(activiteit, teacher);

            //update the activiteit and reload the display
            activiteit.begeleiders.Add(teacher);
            displayTeachersInActivity();
        }

        private void removeBegeleider() {
            AddBegeleiderButton.Enabled = false;
            RemoveBegeleiderButton.Enabled = false;
            Activiteit activiteit = (Activiteit)listViewTeachersActivities.SelectedItems[0].Tag;
            Teacher teacher = (Teacher)listViewTeachersSupervisors.SelectedItems[0].Tag;

            ActiviteitService activiteitService = new ActiviteitService();
            activiteitService.removeBegeleider(activiteit, teacher);

            //update the activiteit and reload the display
            activiteit.begeleiders.Remove(teacher);
            displayTeachersInActivity();
        }

        private void drinkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinkOrderPanel();
        }

        private void drinkOrderNumericUpDownValueChanged(object sender, EventArgs e)
        {
            UpdateOrderPrice();
        }

        private void drinkOrderDrinkListViewItem_IndexChanged(object sender, EventArgs e)
        {
            UpdateOrderPrice();
        }

        private void drinkOrderStudentListViewItem_IndexChanged(object sender, EventArgs e)
        {
            UpdateOrderPrice();
        }

        private void drinkOrderSubmit_Click(object sender, EventArgs e)
        {
            SubmitOrder();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenueReportPanel();
        }


        private void onFirstDateValueChange(object sender, EventArgs e)
        {
            if (lastDate.Value < firstDate.Value)
            {
                lastDate.Value = firstDate.Value;
            }

            lastDate.MinDate = firstDate.Value;
        }

        private void onLastDateValueChange(object sender, EventArgs e)
        {
            if (lastDate.Value < firstDate.Value)
            {
                lastDate.Value = firstDate.Value;
            }
        }

        private OrderService orderService = new OrderService();

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            DateTime firstDateValue = firstDate.Value.Date;
            DateTime lastDateValue = lastDate.Value.Date;

            lastDateValue = lastDateValue.AddDays(1).AddSeconds(-1);

            int totalSales = orderService.amountOfOrders(firstDateValue, lastDateValue);

            amountOfSales.Text = $"Total Sales: {totalSales.ToString()} sales";

            decimal turnover = orderService.getTheTurnover(firstDateValue, lastDateValue);

            amountOfSales.Text += $"\nTurnover: €{turnover:0.00}";

            int amountOfConsumers = orderService.amountOfConsumers(firstDateValue, lastDateValue);

            amountOfSales.Text += "\nAmount of customers: " + amountOfConsumers.ToString();
        }






        private void createStudent_Click(object sender, EventArgs e)
        {

        }

        private void changeStudent_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void teacherActiviteit_IndexChanged(object sender, EventArgs e) {
            displayTeachersInActivity();
        }

        private void listViewTeachersSupervisors_IndexChanged(object sender, EventArgs e) {
            if (listViewTeachersActivities.SelectedItems.Count == 0) {
                RemoveBegeleiderButton.Enabled = false;
            } else {
                RemoveBegeleiderButton.Enabled = true;
            }
        }

        private void listViewTeachersNonSupervisors_IndexChanged(object sender, EventArgs e) {
            if (listViewTeachersActivities.SelectedItems.Count == 0) {
                AddBegeleiderButton.Enabled = false;
            } else {
                AddBegeleiderButton.Enabled = true;
            }
        }

        private void AddBegeleiderButton_Click(object sender, EventArgs e) {
            addBegeleider();
        }

        private void RemoveBegeleiderButton_Click(Object sender, EventArgs e) {
            Activiteit activiteit = (Activiteit)listViewTeachersActivities.SelectedItems[0].Tag;
            Teacher teacher = (Teacher)listViewTeachersSupervisors.SelectedItems[0].Tag;
            string message = $"Weet je zeker dat je {teacher.naam} uit {activiteit.activiteitnaam} wilt halen?";

            new DialogWindow(message, removeBegeleider);
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            if (sender.GetType() == typeof(ListView)) {
                ListView listView = (ListView)sender;
                ListViewColumnSorter sorter;

                if (listView.ListViewItemSorter != null) {
                    sorter = (ListViewColumnSorter)listView.ListViewItemSorter;
                } else {
                    sorter = new ListViewColumnSorter();
                    listView.ListViewItemSorter = sorter;
                }

                if (e.Column == sorter.SortColumn) {
                    if (sorter.Order == SortOrder.Ascending) {
                        sorter.Order = SortOrder.Descending;
                    } else {
                        sorter.Order = SortOrder.Ascending;
                    }
                } else {
                    sorter.SortColumn = e.Column;
                    sorter.Order = SortOrder.Ascending;
                }

                listView.Sort();
            }
        }
        private void listViewWhatActivities_IndexChanged(Object sender, EventArgs e)
        {
            if (listViewWhatActivities.SelectedItems.Count > 0)
            {
                Activiteit activiteit = (Activiteit)listViewWhatActivities.SelectedItems[0].Tag;
                DisplayStudents(activiteit.deelnemers, listViewPresentStudents);

                StudentService studentsService;
                studentsService = new StudentService();
                studentsService.GetStudents();
                List<Student> allStudents = studentsService.GetStudents();

                for (int i = 0; i < activiteit.deelnemers.Count; i++)
                {
                    allStudents.Remove(activiteit.deelnemers[i]);
                }

                DisplayStudents(allStudents, listViewNonPresentStudents);

            }
        }

        private void listViewPresentStudents_IndexChanged(object sender, EventArgs e)
        {
            if (listViewWhatActivities.SelectedItems.Count == 0)
            {
                RemoveStudentButton.Enabled = false;
            }
            else
            {
                RemoveStudentButton.Enabled = true;
            }
        }

        private void listViewNonPresentStudents_IndexChanged(object sender, EventArgs e)
        {
            if (listViewWhatActivities.SelectedItems.Count == 0)
            {
                AddStudentButton.Enabled = false;
            }
            else
            {
                AddStudentButton.Enabled = true;
            }
        }

        private void removeStudent()
        {
            AddStudentButton.Enabled = false;
            RemoveStudentButton.Enabled = false;
            Activiteit activiteit = (Activiteit)listViewWhatActivities.SelectedItems[0].Tag;
            Student student = (Student)listViewPresentStudents.SelectedItems[0].Tag;

            ActiviteitService activiteitService = new ActiviteitService();
            activiteitService.removeStudent(activiteit, student);

            activiteit.deelnemers.Remove(student);
            displayStudentsInActivity();
        }
        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            Activiteit activiteit = (Activiteit)listViewWhatActivities.SelectedItems[0].Tag;
            Student student = (Student)listViewPresentStudents.SelectedItems[0].Tag;
            string message = $"Weet je zeker dat je {student.naam} uit {activiteit.activiteitnaam} wilt halen?";

            new DialogWindow(message, removeStudent);
        }

  
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            addStudent();
        }
        private void addStudent()
        {
            AddStudentButton.Enabled = false;
            RemoveStudentButton.Enabled = false;

            Activiteit activiteit = (Activiteit)listViewWhatActivities.SelectedItems[0].Tag;
            Student student = (Student)listViewNonPresentStudents.SelectedItems[0].Tag;

            ActiviteitService activiteitService = new ActiviteitService();
            activiteitService.addStudent(activiteit, student);

            activiteit.deelnemers.Add(student);
            displayStudentsInActivity();
        }
        private void displayStudentsInActivity()
        {
            if (listViewWhatActivities.SelectedItems.Count == 0)
            {
                return;
            }

            Activiteit activiteit = (Activiteit)listViewWhatActivities.SelectedItems[0].Tag;
            
            DisplayStudents(activiteit.deelnemers, listViewPresentStudents);

            StudentService studentService = new StudentService();
            List<Student> notPresent = new List<Student>();

            List<Student> allStudents = studentService.GetStudents();

            foreach (Student student in allStudents)
            {
                if (!activiteit.deelnemers.Contains(student))
                {
                    notPresent.Add(student);
                }
            }

            DisplayStudents(notPresent, listViewNonPresentStudents);

        }
    }
}