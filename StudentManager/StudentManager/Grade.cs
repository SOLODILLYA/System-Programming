using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Grade
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public Student Student { get; set; }
        [Required]
        public Subject Subject { get; set; }
        [Required]
        public int GradeValue { get; set; }
    }
}
