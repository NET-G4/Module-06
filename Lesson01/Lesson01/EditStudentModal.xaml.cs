using Lesson01.Models;
using System.Windows;

namespace Lesson01
{
    /// <summary>
    /// Interaction logic for EditStudentModal.xaml
    /// </summary>
    public partial class EditStudentModal : Window
    {
        private readonly Student student;
        public EditStudentModal(Student student)
        {
            InitializeComponent();

            this.student = student;

            IdTextBox.Text = student.Id.ToString();
            NameTextBox.Text = student.Name;
            GradeTextBox.Text = student.Grade.ToString();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            student.Id = int.Parse(IdTextBox.Text);
            student.Name = NameTextBox.Text;
            student.Grade = int.Parse(GradeTextBox.Text);

            Close();
        }
    }
}
