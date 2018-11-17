using StudentsManagementApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace StudentsManagementApp.Pages.Students
{
    /// <summary>
    /// Логика взаимодействия для StudentsMgmtPage.xaml
    /// </summary>
    public partial class StudentsMgmtPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Student> StudentsList { get; set; }

        public Student SelectedStudent
        {
            get => StudentsMgmtPageViewModel.SelectedStudent;
            set
            {
                StudentsMgmtPageViewModel.SelectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }

        public StudentsMgmtPage()
        {
            InitializeComponent();
            StudentsList = new ObservableCollection<Student>(App.DbModel.Students);

            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            //var selectedStudent = SelectedStudent;
            //App.DbModel.Students.Remove(selectedStudent);
            //App.DbModel.Students.Add(selectedStudent);
            //App.DbModel.SaveChanges();
        }


        private void RemoveSelectedStudent(object sender, RoutedEventArgs e)
        {
            if (StudentsList.Contains(SelectedStudent))
            {
                App.DbModel.Students.Remove(SelectedStudent);
                App.DbModel.SaveChanges();

                StudentsList.Remove(SelectedStudent);
            }
        }


        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            var selectedStudent = SelectedStudent;
            App.DbModel.Students.Remove(selectedStudent);
            App.DbModel.Students.Add(selectedStudent);
            App.DbModel.SaveChanges();
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            var newStudent = new Student() { LastName = "Новый", FirstName = "студент" };
            StudentsList.Add(newStudent);
            App.DbModel.Students.Add(newStudent);
            StudentsListBox.SelectedItem = newStudent;
        }

        private void StudentsLBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //StudentsListBox.SelectedItem = StudentsMgmtPageViewModel.InitialStudent;
            //StudentsMgmtPageViewModel.InitialStudent = (Student)StudentsListBox.SelectedItem;
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
            {
                StudentsList = new ObservableCollection<Student>(App.DbModel.Students);
            }
            else
            {
                StudentsList = StudentsMgmtPageViewModel.GetFilteredStudentsList(SearchTextBox.Text);
            }
        }
    }
}
