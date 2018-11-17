using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementApp.Models;

namespace StudentsManagementApp.Pages.Students
{
    public static class StudentsMgmtPageViewModel
    {
        public static Student SelectedStudent { get; set; } = new Student();
        public static Student InitialStudent { get; set; } = new Student();

        public static ObservableCollection<Student> GetFilteredStudentsList(string searchQuery)
        {
            var studentsList = new ObservableCollection<Student>(App.DbModel.Students);
            var filteredStudentsList = new ObservableCollection<Student>();
            foreach (var student in studentsList)
            {
                string studentName = $"{student.LastName} {student.LastName}".ToLower();
                if (studentName.Contains(searchQuery.ToLower()))
                    filteredStudentsList.Add(student);
            }

            return filteredStudentsList;
        }
    }
}
