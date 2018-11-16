using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementApp.Models
{
    [Table("Student")]
    public class Student : Person, INotifyPropertyChanged
    {
        public int Id { get; set; }
        public virtual Group Group { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName]string prop = "") =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
