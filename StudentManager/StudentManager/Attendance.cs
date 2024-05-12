using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Attendance
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Student Student { get; set; }
        [Required]
        public Subject Subject { get; set; }
        [Required]
        public bool IsPresent { get; set; }

    }
}
