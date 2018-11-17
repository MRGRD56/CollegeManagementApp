using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementApp.Models
{
    public class Person
    {
        public int Id { get; set; }
<<<<<<< HEAD

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        //public string LastName
        //{
        //    get => lastName;
        //    set
        //    {   
        //        lastName = value;
        //        StudentsMgmtPageViewModel.OnPropertyChanged("LastName");
        //    }
        //}

        //public string FirstName
        //{
        //    get => firstName;
        //    set
        //    {
        //        firstName = value;
        //        OnPropertyChanged("FirstName");
        //    }
        //}

        //public int Age
        //{
        //    get => age;
        //    set
        //    {
        //        if (value < 14) throw new ArgumentException("Указан недопустимый возраст.");

        //        age = value;
        //        OnPropertyChanged("Age");
        //    }
        //}
=======
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
>>>>>>> parent of df23751... v1.31.1
    }
}
