using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal AverageGrade { get; set; }
        public decimal Attendance { get; set; } 
    }
}
