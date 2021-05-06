using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsraDurgun_StudentForm.Models
{
    public class Student
    {
        public Student()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        
        public string Department { get; set; }

        [Required]
        public DateTime BirtDate { get; set; }

        
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpDate { get; set; }
    }
}
