using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Subject
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string SubjectName { get; set; }
    }
}
