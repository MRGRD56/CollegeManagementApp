using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentsManagementApp.Models;

namespace StudentsManagementApp.Pages.Students
{
    /// <summary>
    /// Логика взаимодействия для StudentsMgmtPage.xaml
    /// </summary>
    public partial class StudentsMgmtPage : Page
    {
        public ObservableCollection<Student> StudentsList { get; set; }
        public Student SelectedStudent { get; set; } = new Student() {LastName = "Empty"};

        public StudentsMgmtPage()
        {
            
            InitializeComponent();
            //StudentsList = App.DbModel.Students.Local;
            StudentsList = new ObservableCollection<Student>(App.DbModel.Students);
            
            
            DataContext = this;
            //App.DbModel.Students.Add(new Student()
            //    {Age = 18, Group = new Group(), FirstName = "FirstS", LastName = "LastS"});
            //App.DbModel.SaveChanges();
            //Binding binding = BindingOperations.GetBinding(StudentsListBox, ListBox.ItemsSourceProperty);

        }

        private void StudentsListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedStudent = (Student)StudentsListBox.SelectedItem;
        }
    }
}
