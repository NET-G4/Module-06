using Lesson01.Models;
using System.Windows;

namespace Lesson01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students;
        public MainWindow()
        {
            InitializeComponent();

            students = new List<Student>();
            students.Add(new Student(1, "Shoxbox", 2));
            students.Add(new Student(2, "Javlon", 1));
            students.Add(new Student(3, "Davlatshox", 4));

            StudentsDataGrid.ItemsSource = students;
        }

        private void Add_Student_Clicked(object sender, RoutedEventArgs e)
        {
            var addModal = new AddStudentModal(students);

            addModal.ShowDialog();

            StudentsDataGrid.ItemsSource = null;
            StudentsDataGrid.ItemsSource = students;
        }

        private void Edit_Student_Clicked(object sender, RoutedEventArgs e)
        {
            if (StudentsDataGrid.SelectedItem is not Student selectedStudent)
            {
                return;
            }

            var editModal = new EditStudentModal(selectedStudent);

            editModal.ShowDialog();

            StudentsDataGrid.ItemsSource = null;
            StudentsDataGrid.ItemsSource = students;
        }

        private void Delete_Student_Clicked(object sender, RoutedEventArgs e)
        {
            if (StudentsDataGrid.SelectedItem is not Student selectedStudent)
            {
                return;
            }

            students.Remove(selectedStudent);

            StudentsDataGrid.ItemsSource = null;
            StudentsDataGrid.ItemsSource = students;
        }
    }
}