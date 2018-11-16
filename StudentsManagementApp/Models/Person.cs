using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentsManagementApp.Pages.Students;

namespace StudentsManagementApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        protected string lastName { get; set; }
        protected string firstName { get; set; }
        protected int age { get; set; }

        public string LastName
        {
            get => lastName;
            set
            {   
                lastName = value;
                StudentsMgmtPageViewModel.OnPropertyChanged("LastName");
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 14) throw new ArgumentException("Указан недопустимый возраст.");

                age = value;
                OnPropertyChanged("Age");
            }
        }
    }
}
