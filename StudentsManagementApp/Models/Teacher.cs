using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementApp.Models
{
    [Table("Teacher")]
    public class Teacher : Person
    {
        public int Id { get; set; }
        public string Subject { get; set; }
    }
}
