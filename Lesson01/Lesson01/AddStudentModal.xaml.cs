using Lesson01.Models;
using System.Windows;

namespace Lesson01
{
    /// <summary>
    /// Interaction logic for AddStudentModal.xaml
    /// </summary>
    public partial class AddStudentModal : Window
    {
        private readonly List<Student> students;

        public AddStudentModal(List<Student> students)
        {
            InitializeComponent();

            this.students = students;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            string name = NameTextBox.Text;
            int grade = int.Parse(GradeTextBox.Text);

            var newStudent = new Student(id, name, grade);
            students.Add(newStudent);

            Close();
        }
    }
}
