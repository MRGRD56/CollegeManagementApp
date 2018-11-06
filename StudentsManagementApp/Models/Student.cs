using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementApp.Models
{
    [Table("Student")]
    public class Student : Person
    {
        public int Id { get; set; }
        public virtual Group Group { get; set; }
    }
}
